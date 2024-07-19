using AgenciaSeguros.Datos;
using AgenciaSeguros.Utilidades;
using AgenciaSeguros.Vistas.Componentes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas
{
  /// <summary>
  /// Formulario principal para el usuario.
  /// </summary>
  public partial class FormUsuario : Form
  {
    public FormUsuario()
    {
      InitializeComponent();
      LoadData();
      button11.Visible = false; // Oculta el botón inicialmente
    }

    // Métodos propios

    /// <summary>
    /// Cambia la pestaña activa del TabControl.
    /// </summary>
    /// <param name="page">Página del TabControl a la que se quiere cambiar.</param>
    private void changeTab(TabPage page)
    {
      tabControl1.SelectedTab = page;
    }

    /// <summary>
    /// Carga los datos en los DataGridView correspondientes desde la base de datos.
    /// </summary>
    private void LoadData()
    {
      using (var context = new AppDbContext())
      {
        // Cargar datos de clientes y mapearlos a una lista anónima.
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

        // Configurar los encabezados y visibilidad de columnas en el DataGridView de clientes.
        clientesData.Columns["Documento"].HeaderText = "Cédula de identidad";
        clientesData.Columns["Total"].HeaderText = "Total pagado";
        clientesData.Columns["Polizas"].HeaderText = "Cantidad de pólizas";
        clientesData.Columns["Id"].Visible = false;

        // Cargar datos de pólizas y mapearlos a una lista anónima.
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

        // Configurar los encabezados y visibilidad de columnas en el DataGridView de pólizas.
        polizasData.Columns["Nombre"].HeaderText = "Nombre del cliente";
        polizasData.Columns["Documento"].HeaderText = "Cédula de identidad";
        polizasData.Columns["FechaEmision"].HeaderText = "Fecha de emisión";
        polizasData.Columns["FechaVencimiento"].HeaderText = "Fecha de vencimiento";
        polizasData.Columns["EstadoPoliza"].HeaderText = "Estado de la póliza";
        polizasData.Columns["MontoCobertura"].HeaderText = "Monto de cobertura";
        polizasData.Columns["Email"].HeaderText = "Correo electrónico";
        polizasData.Columns["Id"].Visible = false;

        // Cargar datos de pagos y mapearlos a una lista anónima.
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

        // Configurar los encabezados y visibilidad de columnas en el DataGridView de pagos.
        pagosData.Columns["Nombre"].HeaderText = "Nombre del cliente";
        pagosData.Columns["Documento"].HeaderText = "Cédula de identidad";
        pagosData.Columns["FechaPago"].HeaderText = "Fecha de pago";
        pagosData.Columns["Email"].HeaderText = "Correo electrónico";
        pagosData.Columns["Id"].Visible = false;

        // Cargar datos de reclamos y mapearlos a una lista anónima.
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

        // Configurar los encabezados y visibilidad de columnas en el DataGridView de reclamos.
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

    // Eventos de C#

    /// <summary>
    /// Evento al hacer clic en el botón de ocultar. Cierra el formulario actual.
    /// </summary>
    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    /// <summary>
    /// Evento al hacer clic en el botón para cambiar a la pestaña de administración.
    /// </summary>
    private void button2_Click(object sender, EventArgs e)
    {
      changeTab(tabPage7);
    }

    /// <summary>
    /// Evento al hacer clic en el botón para registrar un nuevo reclamo.
    /// Abre el formulario para registrar reclamos y recarga los datos después de cerrar el formulario.
    /// </summary>
    private void button6_Click(object sender, EventArgs e)
    {
      Form registrarReclamo = new Reclamos(null);
      registrarReclamo.ShowDialog();
      LoadData();
      changeTab(reclamosPage);
    }

    /// <summary>
    /// Evento al hacer clic en el botón para cambiar a la pestaña de clientes.
    /// </summary>
    private void button10_Click(object sender, EventArgs e)
    {
      changeTab(clientesPage);
    }

    /// <summary>
    /// Evento al hacer clic en el botón para cambiar a la pestaña de pólizas.
    /// </summary>
    private void button8_Click(object sender, EventArgs e)
    {
      changeTab(polizasPage);
    }

    /// <summary>
    /// Evento al hacer doble clic en una celda del DataGridView.
    /// </summary>
    private void dataGridView1_DoubleClick(object sender, EventArgs e)
    {
      // Lógica a implementar en caso de necesitar una acción al hacer doble clic en una celda del DataGridView.
    }

    /// <summary>
    /// Evento al hacer clic en el botón para registrar un nuevo usuario, póliza, cliente, pago o reclamo según la pestaña seleccionada.
    /// </summary>
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

    /// <summary>
    /// Evento al hacer clic en el botón para registrar un nuevo cliente.
    /// Abre el formulario para registrar clientes y recarga los datos después de cerrar el formulario.
    /// </summary>
    private void button7_Click(object sender, EventArgs e)
    {
      Form registrarCliente = new Cliente(null);
      registrarCliente.ShowDialog();
      changeTab(clientesPage);
      LoadData();
    }

    /// <summary>
    /// Evento al hacer clic en una celda del DataGridView de clientes.
    /// Abre el formulario para editar el cliente seleccionado y recarga los datos después de cerrar el formulario.
    /// </summary>
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

    /// <summary>
    /// Evento al hacer clic en una celda del DataGridView de pólizas.
    /// Abre el formulario para editar la póliza seleccionada y recarga los datos después de cerrar el formulario.
    /// </summary>
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

    /// <summary>
    /// Evento al hacer clic en el botón para registrar una nueva póliza.
    /// Abre el formulario para registrar pólizas y recarga los datos después de cerrar el formulario.
    /// </summary>
    private void button4_Click(object sender, EventArgs e)
    {
      Form registrarPoliza = new Polizas(null);
      registrarPoliza.ShowDialog();
      changeTab(polizasPage);
      LoadData();
    }

    /// <summary>
    /// Evento al hacer clic en el botón para registrar un nuevo pago.
    /// Abre el formulario para registrar pagos y recarga los datos después de cerrar el formulario.
    /// </summary>
    private void button5_Click(object sender, EventArgs e)
    {
      Form registrarPago = new Pagos(null);
      registrarPago.ShowDialog();
      changeTab(pagosPage);
      LoadData();
    }

    /// <summary>
    /// Evento al hacer doble clic en una celda del DataGridView de pagos.
    /// Abre el formulario para editar el pago seleccionado y recarga los datos después de cerrar el formulario.
    /// </summary>
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

    /// <summary>
    /// Evento al hacer doble clic en una celda del DataGridView de reclamos.
    /// Abre el formulario para editar el reclamo seleccionado y recarga los datos después de cerrar el formulario.
    /// </summary>
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

    /// <summary>
    /// Evento al cambiar la pestaña seleccionada en el TabControl.
    /// Muestra u oculta el botón 11 según la pestaña seleccionada.
    /// </summary>
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      button11.Visible = tabControl1.SelectedIndex != 0;
    }

    /// <summary>
    /// Evento al hacer clic en el botón 12. No implementado.
    /// </summary>
    private void button12_Click(object sender, EventArgs e)
    {
      // Lógica a implementar en caso de necesitar una acción para el botón 12.
    }

    /// <summary>
    /// Evento al hacer clic en el botón para generar un reporte de datos generales.
    /// Permite al usuario seleccionar la ubicación para guardar el reporte como PDF.
    /// </summary>
    private void button9_Click(object sender, EventArgs e)
    {
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
    
    // Eventos no utilizados actualmente

    private void toolTip_Popup(object sender, PopupEventArgs e)
    {
      // Evento para el tooltip.
    }

    private void clientesPage_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la página de clientes.
    }

    private void tabPage7_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la página de administración.
    }

    private void label2_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 2.
    }

    private void label1_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 1.
    }

    private void usuariosTab_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la pestaña de usuarios.
    }

    private void label3_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 3.
    }

    private void usuariosData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      // Evento al hacer clic en una celda del DataGridView de usuarios.
    }

    private void polizasPage_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la página de pólizas.
    }

    private void label5_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 5.
    }

    private void label4_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 4.
    }

    private void pagosPage_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la página de pagos.
    }

    private void label6_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 6.
    }

    private void pagosData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      // Evento al hacer clic en una celda del DataGridView de pagos.
    }

    private void reclamosPage_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la página de reclamos.
    }

    private void label7_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en la etiqueta 7.
    }

    private void reclamosData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      // Evento al hacer clic en una celda del DataGridView de reclamos.
    }

    private void button13_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en el botón 13.
    }

    private void button14_Click(object sender, EventArgs e)
    {
      // Evento al hacer clic en el botón 14.
    }
  }
}
