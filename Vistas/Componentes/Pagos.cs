using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas.Componentes
{
  /// <summary>
  /// Formulario para agregar o editar un pago.
  /// </summary>
  public partial class Pagos : Form
  {
    private int? _pagoId;

    /// <summary>
    /// Constructor del formulario Pagos.
    /// </summary>
    /// <param name="pagoId">ID del pago a editar, si es null se creará un nuevo pago.</param>
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

      // Asignar eventos de validación a los campos del formulario.
      fechaRealizado.ValueChanged += (s, e) => ValidateForm();
      montoNum.ValueChanged += (s, e) => ValidateForm();
      clienteCombobox.SelectedValueChanged += (s, e) => ValidateForm();
      descripcionText.TextChanged += (s, e) => ValidateForm();

      btnGuardar.Enabled = false; // Deshabilitar el botón de guardar inicialmente
    }

    /// <summary>
    /// Carga los datos del pago desde la base de datos si se está editando, y los clientes para el ComboBox.
    /// </summary>
    private void LoadPagoData()
    {
      using (var context = new AppDbContext())
      {
        // Cargar el ComboBox con los clientes, mostrando el nombre y el ID debe ser el valor.
        clienteCombobox.DataSource = context.Clientes.Select(c => new
        {
          c.Id,
          c.Nombre
        }).ToList();
        clienteCombobox.DisplayMember = "Nombre";
        clienteCombobox.ValueMember = "Id";

        // Configurar el rango de fechas para el control de fecha.
        fechaRealizado.MinDate = new DateTime(DateTime.Now.Year - 10, 1, 1);
        fechaRealizado.MaxDate = DateTime.Now;

        if (!_pagoId.HasValue)
        {
          return;
        }

        // Cargar los datos del pago si se está editando.
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

    /// <summary>
    /// Evento al hacer clic en el botón de cancelar. Cierra el formulario actual.
    /// </summary>
    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    /// <summary>
    /// Evento al hacer clic en el botón de guardar. Guarda o actualiza los datos del pago.
    /// </summary>
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      using (var context = new AppDbContext())
      {
        if (_pagoId.HasValue)
        {
          // Actualizar pago existente
          var pago = context.Pagos.Find(_pagoId.Value);
          if (pago != null)
          {
            pago.Monto = montoNum.Value;
            pago.ClienteId = (int)clienteCombobox.SelectedValue;
            pago.FechaPago = fechaRealizado.Value;
            pago.Descripcion = descripcionText.Text;
          }
        }
        else
        {
          // Crear un nuevo pago
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

    /// <summary>
    /// Valida los campos del formulario y habilita o deshabilita el botón de guardar.
    /// </summary>
    private void ValidateForm()
    {
      // Validaciones de los campos del formulario.
      bool descripcionValida = !string.IsNullOrEmpty(descripcionText.Text) && descripcionText.Text.Length <= 50;
      bool clienteValido = clienteCombobox.SelectedValue != null;
      bool montoValido = montoNum.Value > 0;

      btnGuardar.Enabled = descripcionValida && clienteValido && montoValido;

      // Asignar mensajes de error a los campos si no son válidos.
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
