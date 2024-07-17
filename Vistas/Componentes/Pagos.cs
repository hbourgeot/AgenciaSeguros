using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas.Componentes
{
  public partial class Pagos : Form
  {
    private int? _pagoId;
    public Pagos(int? pagoId)
    {
      InitializeComponent();
      _pagoId = pagoId;
      if (_pagoId.HasValue)
      {
        label1.Text = "Editar pago";
        this.Text = $"Editar Pago #{_pagoId.Value}";
      }
      else
      {
        this.Text = "Nuevo pago";
      }
      LoadPagoData();

      fechaRealizado.ValueChanged += (s, e) => ValidateForm();
      montoNum.ValueChanged += (s, e) => ValidateForm();
      clienteCombobox.SelectedValueChanged += (s, e) => ValidateForm();
      descripcionText.TextChanged += (s, e) => ValidateForm();

      btnGuardar.Enabled = false;
    }

    private void LoadPagoData()
    {
      using (var context = new AppDbContext())
      {
        // cargar el combobox con los clientes, mostrando el nombre y el id debe ser el valor
        clienteCombobox.DataSource = context.Clientes.Select(c => new
        {
          c.Id,
          c.Nombre
        }).ToList();
        clienteCombobox.DisplayMember = "Nombre";
        clienteCombobox.ValueMember = "Id";

        fechaRealizado.MinDate = new DateTime(DateTime.Now.Year - 10, 1, 1);
        fechaRealizado.MaxDate = DateTime.Now;

        if (!_pagoId.HasValue)
        {
          return;
        }

        var pago = context.Pagos.Find(_pagoId.Value);
        if (pago != null)
        {
          fechaRealizado.Value = pago.FechaPago;
          montoNum.Value = pago.Monto;
          clienteCombobox.SelectedValue = pago.ClienteId;
          descripcionText.Text = pago.Descripcion;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      using (var context = new AppDbContext())
      {
        if (_pagoId.HasValue)
        {
          var pago = context.Pagos.Find(_pagoId.Value);
          pago.Monto = montoNum.Value;
          pago.ClienteId = (int)clienteCombobox.SelectedValue;
          pago.FechaPago = fechaRealizado.Value;
          pago.Descripcion = descripcionText.Text;
        }
        else
        {
          var pago = new Pago()
          {
            Monto = montoNum.Value,
            ClienteId = (int)clienteCombobox.SelectedValue,
            FechaPago = fechaRealizado.Value,
            Descripcion = descripcionText.Text
          };
          context.Pagos.Add(pago);
        }
        context.SaveChanges();
      }

      this.Close();
    }

    private void ValidateForm()
    {
      bool descripcionValida = !string.IsNullOrEmpty(descripcionText.Text) && descripcionText.Text.Length <= 50;
      bool clienteValido = clienteCombobox.SelectedValue != null;
      bool montoValido = montoNum.Value > 0;

      btnGuardar.Enabled = descripcionValida && clienteValido && montoValido;

      if (!montoValido)
      {
        errorProvider1.SetError(montoNum, "El monto debe ser mayor a 0");
      }
      else
      {
        errorProvider1.SetError(montoNum, "");
      }

      if (!clienteValido)
      {
        errorProvider1.SetError(clienteCombobox, "El cliente es requerido");
      }
      else
      {
        errorProvider1.SetError(clienteCombobox, "");
      }

      if (!descripcionValida)
      {
        errorProvider1.SetError(descripcionText, "La descripción es requerida y debe tener menos de 50 caracteres");
      }
      else
      {
        errorProvider1.SetError(descripcionText, "");
      }
    }
  }
}
