using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas.Componentes
{
  /// <summary>
  /// Formulario para agregar o editar una póliza.
  /// </summary>
  public partial class Polizas : Form
  {
    private int? _polizaId;

    /// <summary>
    /// Constructor del formulario Polizas.
    /// </summary>
    /// <param name="polizaId">ID de la póliza a editar, si es null se creará una nueva póliza.</param>
    public Polizas(int? polizaId)
    {
      InitializeComponent();
      _polizaId = polizaId;
      if (_polizaId.HasValue)
      {
        label1.Text = "Editar poliza";
        this.Text = $"Editar Poliza #{_polizaId.Value}";
      }
      else
      {
        label1.Text = "Nueva poliza";
        this.Text = "Nueva Poliza";
      }
      LoadPolizaData();

      // Asignar eventos de validación a los campos del formulario.
      fechaVencimiento.ValueChanged += (s, e) => ValidateForm();
      fechaEmision.ValueChanged += (s, e) => ValidateForm();
      marcaText.TextChanged += (s, e) => ValidateForm();
      modeloText.TextChanged += (s, e) => ValidateForm();
      anioText.TextChanged += (s, e) => ValidateForm();
      placaText.TextChanged += (s, e) => ValidateForm();
      colorAutoText.TextChanged += (s, e) => ValidateForm();
      primaNum.ValueChanged += (s, e) => ValidateForm();
      clienteCombobox.SelectedValueChanged += (s, e) => ValidateForm();
      tipoPolizaText.TextChanged += (s, e) => ValidateForm();
      estadoText.TextChanged += (s, e) => ValidateForm();
      montoCoberturaNum.ValueChanged += (s, e) => ValidateForm();

      btnGuardar.Enabled = false; // Deshabilitar el botón de guardar inicialmente
    }

    /// <summary>
    /// Carga los datos de la póliza desde la base de datos si se está editando, y los clientes para el ComboBox.
    /// </summary>
    private void LoadPolizaData()
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

        // Configurar el rango de fechas para los controles de fecha.
        fechaEmision.MinDate = new DateTime(DateTime.Now.Year - 10, 1, 1);
        fechaEmision.MaxDate = DateTime.Now;

        fechaVencimiento.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
        fechaVencimiento.MaxDate = new DateTime(DateTime.Now.Year + 10, 12, 31);

        if (!_polizaId.HasValue)
        {
          return;
        }

        // Cargar los datos de la póliza si se está editando.
        var poliza = context.Polizas.Find(_polizaId.Value);
        if (poliza != null)
        {
          fechaEmision.Value = poliza.FechaEmision;
          fechaVencimiento.Value = poliza.FechaVencimiento;
          marcaText.Text = poliza.Marca;
          modeloText.Text = poliza.Modelo;
          anioText.Text = poliza.Anio;
          placaText.Text = poliza.Placa;
          colorAutoText.Text = poliza.Color;
          primaNum.Value = poliza.Prima;
          clienteCombobox.SelectedValue = poliza.ClienteId;
          tipoPolizaText.Text = poliza.Tipo;
          estadoText.Text = poliza.EstadoPoliza;
          montoCoberturaNum.Value = poliza.MontoCobertura;
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
    /// Evento al hacer clic en el botón de guardar. Guarda o actualiza los datos de la póliza.
    /// </summary>
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      using (var context = new AppDbContext())
      {
        if (_polizaId.HasValue)
        {
          // Actualizar póliza existente
          var poliza = context.Polizas.Find(_polizaId.Value);
          if (poliza != null)
          {
            poliza.Marca = marcaText.Text;
            poliza.Modelo = modeloText.Text;
            poliza.Anio = anioText.Text;
            poliza.Placa = placaText.Text;
            poliza.Color = colorAutoText.Text;
            poliza.Prima = primaNum.Value;
            poliza.ClienteId = (int)clienteCombobox.SelectedValue;
            poliza.Tipo = tipoPolizaText.Text;
            poliza.EstadoPoliza = estadoText.Text;
            poliza.MontoCobertura = montoCoberturaNum.Value;
            poliza.FechaEmision = fechaEmision.Value;
            poliza.FechaVencimiento = fechaVencimiento.Value;
          }
        }
        else
        {
          // Crear una nueva póliza
          var poliza = new Poliza()
          {
            Marca = marcaText.Text,
            Modelo = modeloText.Text,
            Anio = anioText.Text,
            Placa = placaText.Text,
            Color = colorAutoText.Text,
            Prima = primaNum.Value,
            ClienteId = (int)clienteCombobox.SelectedValue,
            Tipo = tipoPolizaText.Text,
            EstadoPoliza = estadoText.Text,
            MontoCobertura = montoCoberturaNum.Value,
            FechaEmision = fechaEmision.Value,
            FechaVencimiento = fechaVencimiento.Value
          };
          context.Polizas.Add(poliza);
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
      bool fechaValida = fechaEmision.Value <= fechaVencimiento.Value;
      bool marcaValida = !string.IsNullOrEmpty(marcaText.Text) && marcaText.Text.Length <= 50;
      bool modeloValido = !string.IsNullOrEmpty(modeloText.Text) && modeloText.Text.Length <= 50;
      bool anioValido = !string.IsNullOrEmpty(anioText.Text) && anioText.Text.Length == 4;
      bool placaValida = !string.IsNullOrEmpty(placaText.Text) && placaText.Text.Length <= 7;
      bool colorValido = !string.IsNullOrEmpty(colorAutoText.Text) && colorAutoText.Text.Length <= 50 && colorAutoText.Text.Length >= 3;
      bool primaValida = primaNum.Value > 0;
      bool clienteValido = clienteCombobox.SelectedValue != null;
      bool tipoValido = !string.IsNullOrEmpty(tipoPolizaText.Text) && tipoPolizaText.Text.Length <= 50;
      bool estadoValido = !string.IsNullOrEmpty(estadoText.Text) && estadoText.Text.Length <= 50;
      bool montoValido = montoCoberturaNum.Value > 0;

      btnGuardar.Enabled = fechaValida && marcaValida && modeloValido && anioValido && placaValida && colorValido && primaValida && clienteValido && tipoValido && estadoValido && montoValido;

      // Asignar mensajes de error a los campos si no son válidos.
      if (!fechaValida)
      {
        errorProvider1.SetError(fechaEmision, "La fecha de emisión debe ser menor o igual a la fecha de vencimiento");
        errorProvider1.SetError(fechaVencimiento, "La fecha de vencimiento debe ser mayor o igual a la fecha de emisión");
      }
      else
      {
        errorProvider1.SetError(fechaEmision, "");
        errorProvider1.SetError(fechaVencimiento, "");
      }

      if (!marcaValida)
      {
        errorProvider1.SetError(marcaText, "La marca es requerida y debe tener menos de 50 caracteres");
      }
      else
      {
        errorProvider1.SetError(marcaText, "");
      }

      if (!modeloValido)
      {
        errorProvider1.SetError(modeloText, "El modelo es requerido y debe tener menos de 50 caracteres");
      }
      else
      {
        errorProvider1.SetError(modeloText, "");
      }

      if (!anioValido)
      {
        errorProvider1.SetError(anioText, "El año es requerido y debe tener 4 caracteres");
      }
      else
      {
        errorProvider1.SetError(anioText, "");
      }

      if (!placaValida)
      {
        errorProvider1.SetError(placaText, "La placa es requerida y debe tener menos de 7 caracteres");
      }
      else
      {
        errorProvider1.SetError(placaText, "");
      }

      if (!colorValido)
      {
        errorProvider1.SetError(colorAutoText, "El color es requerido y debe tener entre 3 y 50 caracteres");
      }
      else
      {
        errorProvider1.SetError(colorAutoText, "");
      }

      if (!primaValida)
      {
        errorProvider1.SetError(primaNum, "La prima debe ser mayor a 0");
      }
      else
      {
        errorProvider1.SetError(primaNum, "");
      }

      if (!clienteValido)
      {
        errorProvider1.SetError(clienteCombobox, "El cliente es requerido");
      }
      else
      {
        errorProvider1.SetError(clienteCombobox, "");
      }

      if (!tipoValido)
      {
        errorProvider1.SetError(tipoPolizaText, "El tipo de poliza es requerido y debe tener menos de 50 caracteres");
      }
      else
      {
        errorProvider1.SetError(tipoPolizaText, "");
      }

      if (!estadoValido)
      {
        errorProvider1.SetError(estadoText, "El estado de la poliza es requerido y debe tener menos de 50 caracteres");
      }
      else
      {
        errorProvider1.SetError(estadoText, "");
      }

      if (!montoValido)
      {
        errorProvider1.SetError(montoCoberturaNum, "El monto de cobertura debe ser mayor a 0");
      }
      else
      {
        errorProvider1.SetError(montoCoberturaNum, "");
      }
    }
  }
}
