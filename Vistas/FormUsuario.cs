using AgenciaSeguros.Datos;
using AgenciaSeguros.Utilidades;
using AgenciaSeguros.Vistas.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas
{
  public partial class FormUsuario : Form
  {
    public FormUsuario()
    {
      InitializeComponent();
      LoadData();
      button11.Visible = false;
    }

    // own methods

    private void changeTab(TabPage page)
    {
      tabControl1.SelectedTab = page;
    }

    private void LoadData()
    {
      using (var context = new AppDbContext())
      {
        clientesData.DataSource = context.Clientes.Select(c => new
        {
          c.Id,
          c.Nombre,
          c.Email,
          c.Telefono,
          c.CodigoPostal,
          c.Direccion,
          c.Pais,
          c.Estado,
          c.Ciudad,
          c.Documento,
          Total = (c.Pagos.Count() > 0 ? c.Pagos.Sum(p => p.Monto) : 0),
          Polizas = (c.Polizas.Count() > 0 ? c.Polizas.Count() : 0)
        }).ToList();

        clientesData.Columns["Documento"].HeaderText = "Cédula de identidad";
        clientesData.Columns["Total"].HeaderText = "Total pagado";
        clientesData.Columns["Polizas"].HeaderText = "Cantidad de pólizas";
        clientesData.Columns["Id"].Visible = false;

        polizasData.DataSource = context.Polizas.Select(p => new
        {
          p.Id,
          p.Marca,
          p.Modelo,
          p.Anio,
          p.Placa,
          p.FechaEmision,
          p.FechaVencimiento,
          p.EstadoPoliza,
          p.Tipo,
          p.MontoCobertura,
          p.Prima,
          p.Cliente.Nombre,
          p.Cliente.Email,
          p.Cliente.Documento
        }).ToList();

        polizasData.Columns["Nombre"].HeaderText = "Nombre del cliente";
        polizasData.Columns["Documento"].HeaderText = "Cédula de identidad";
        polizasData.Columns["FechaEmision"].HeaderText = "Fecha de emisión";
        polizasData.Columns["FechaVencimiento"].HeaderText = "Fecha de vencimiento";
        polizasData.Columns["EstadoPoliza"].HeaderText = "Estado de la póliza";
        polizasData.Columns["MontoCobertura"].HeaderText = "Monto de cobertura";
        polizasData.Columns["Email"].HeaderText = "Correo electrónico";
        polizasData.Columns["Id"].Visible = false;

        pagosData.DataSource = context.Pagos.Select(p => new
        {
          p.Id,
          p.Monto,
          p.FechaPago,
          p.Descripcion,
          p.Cliente.Nombre,
          p.Cliente.Email,
          p.Cliente.Documento
        }).ToList();

        pagosData.Columns["Nombre"].HeaderText = "Nombre del cliente";
        pagosData.Columns["Documento"].HeaderText = "Cédula de identidad";
        pagosData.Columns["FechaPago"].HeaderText = "Fecha de pago";
        pagosData.Columns["Email"].HeaderText = "Correo electrónico";
        pagosData.Columns["Id"].Visible = false;

        reclamosData.DataSource = context.Reclamos.Select(r => new
        {
          r.Id,
          r.FechaReclamo,
          r.Estado,
          r.Cliente.Nombre,
          r.Cliente.Email,
          r.Cliente.Documento,
          r.Poliza.Marca,
          r.Poliza.Modelo,
          r.Poliza.Anio,
          r.Poliza.Placa
        }).ToList();
        reclamosData.Columns["Nombre"].HeaderText = "Nombre del cliente";
        reclamosData.Columns["Documento"].HeaderText = "Cédula de identidad";
        reclamosData.Columns["FechaReclamo"].HeaderText = "Fecha de reclamo";
        reclamosData.Columns["Email"].HeaderText = "Correo electrónico";
        reclamosData.Columns["Marca"].HeaderText = "Marca del vehículo";
        reclamosData.Columns["Modelo"].HeaderText = "Modelo del vehículo";
        reclamosData.Columns["Anio"].HeaderText = "Año del vehículo";
        reclamosData.Columns["Placa"].HeaderText = "Placa del vehículo";
        reclamosData.Columns["Id"].Visible = false;
      }
    }

    // c# events
    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      changeTab(tabPage7);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      Form registrarReclamo = new Reclamos(null);
      registrarReclamo.ShowDialog();
      LoadData();
      changeTab(reclamosPage);
    }

    private void button10_Click(object sender, EventArgs e)
    {
      changeTab(clientesPage);
    }


    private void button8_Click(object sender, EventArgs e)
    {
      changeTab(polizasPage);
    }

    private void dataGridView1_DoubleClick(object sender, EventArgs e)
    {

    }

    private void button11_Click(object sender, EventArgs e)
    {
      switch (tabControl1.SelectedIndex)
      {
        case 1:
          Form registrarPoliza = new Polizas(null);
          registrarPoliza.ShowDialog();
          LoadData();
          break;
        case 2:
          Form registrarCliente = new Cliente(null);
          registrarCliente.ShowDialog();
          LoadData();
          break;
        case 3:
          Form registrarPago = new Pagos(null);
          registrarPago.ShowDialog();
          LoadData();
          break;
        case 4:
          Form registrarReclamo = new Reclamos(null);
          registrarReclamo.ShowDialog();
          LoadData();
          break;
        default:
          break;
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      Form registrarCliente = new Cliente(null);
      registrarCliente.ShowDialog();
      changeTab(clientesPage);
      LoadData();
    }

    private void clientesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (clientesData.CurrentRow.Index != -1)
      {
        int clienteId = Convert.ToInt32(clientesData.CurrentRow.Cells["Id"].Value);
        Form registrarCliente = new Cliente(clienteId);
        registrarCliente.ShowDialog();
        LoadData();
      }
    }

    private void polizasData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (polizasData.CurrentRow.Index != -1)
      {
        int polizaId = Convert.ToInt32(polizasData.CurrentRow.Cells["Id"].Value);
        Form poliza = new Polizas(polizaId);
        poliza.ShowDialog();
        LoadData();
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Form registrarPoliza = new Polizas(null);
      registrarPoliza.ShowDialog();
      changeTab(polizasPage);
      LoadData();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Form registrarPago = new Pagos(null);
      registrarPago.ShowDialog();
      changeTab(pagosPage);
      LoadData();
    }

    private void pagosData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (pagosData.CurrentRow.Index != -1)
      {
        int pagoId = Convert.ToInt32(pagosData.CurrentRow.Cells["Id"].Value);
        Form pago = new Pagos(pagoId);
        pago.ShowDialog();
        LoadData();
      }
    }

    private void reclamosData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (reclamosData.CurrentRow.Index != -1)
      {
        int reclamoId = Convert.ToInt32(reclamosData.CurrentRow.Cells["Id"].Value);
        Form reclamo = new Reclamos(reclamoId);
        reclamo.ShowDialog();
        LoadData();
      }
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      button11.Visible = tabControl1.SelectedIndex != 0;
    }

    private void button12_Click(object sender, EventArgs e)
    {

    }

    private void button9_Click(object sender, EventArgs e)
    {
      // generar reporte de polizas, preguntando primero al usuario donde desea guardarlo en su sistema, como archivo PDF hay qu tener en cuenta
      // el reporte se encuentra en esta carpeta, especificamente, en Reportes.ReportePolizas.rdlc
      // recordar que el usuario debe escoger donde guardar el archivo
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "PDF|*.pdf";
      saveFileDialog.Title = "Guardar reporte de datos generales";
      saveFileDialog.FileName = "ReporteGeneral.pdf";
      saveFileDialog.ShowDialog();
      bool result = saveFileDialog.FileName != "";
      while (!result)
      {
        saveFileDialog.ShowDialog();
        result = saveFileDialog.FileName != "";
        if (result)
        {
          break;
        }
        else
        {
          MessageBox.Show("Debe seleccionar un archivo para guardar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }


      GeneradorDeReporte.ReporteGeneral(saveFileDialog.FileName);
      MessageBox.Show("Reporte guardado exitosamente como PDF en " + saveFileDialog.FileName, "Reporte guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
