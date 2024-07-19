using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas.Componentes
{
  /// <summary>
  /// Formulario para agregar o editar usuarios.
  /// </summary>
  public partial class Usuarios : Form
  {
    private int? _usuarioId; // ID del usuario a editar, si es null se creará un nuevo usuario
    private bool showPassword = false; // Variable para mostrar u ocultar la contraseña

    /// <summary>
    /// Obtiene el estado de visibilidad de la contraseña.
    /// </summary>
    /// <returns>True si la contraseña está visible, False en caso contrario.</returns>
    private bool getShowPassword()
    {
      return showPassword;
    }

    /// <summary>
    /// Establece el estado de visibilidad de la contraseña.
    /// </summary>
    /// <param name="value">True para mostrar la contraseña, False para ocultarla.</param>
    private void setShowPassword(bool value)
    {
      showPassword = value;
    }

    /// <summary>
    /// Constructor del formulario Usuarios.
    /// </summary>
    /// <param name="clienteId">ID del usuario a editar, si es null se creará un nuevo usuario.</param>
    public Usuarios(int? clienteId)
    {
      InitializeComponent();
      _usuarioId = clienteId;
      if (_usuarioId.HasValue)
      {
        LoadClienteData();
        label1.Text = "Editar usuario";
        this.Text = $"Editar Usuario #{_usuarioId.Value}";
      }

      // Asignar eventos de validación a los campos del formulario.
      btnGuardar.Enabled = false;
      correoText.TextChanged += new EventHandler(ValidateForm);
      claveText.TextChanged += new EventHandler(ValidateForm);
      nombreText.TextChanged += new EventHandler(ValidateForm);
      telefonoText.TextChanged += new EventHandler(ValidateForm);
      comboRol.TextChanged += new EventHandler(ValidateForm);
      radioButton1.CheckedChanged += new EventHandler(ValidateForm);
      radioButton2.CheckedChanged += new EventHandler(ValidateForm);
    }

    /// <summary>
    /// Carga los datos del usuario desde la base de datos si se está editando.
    /// </summary>
    private void LoadClienteData()
    {
      using (var context = new AppDbContext())
      {
        var cliente = context.Usuarios.Find(_usuarioId.Value);
        if (cliente != null)
        {
          nombreText.Text = cliente.Nombre;
          correoText.Text = cliente.Correo;
          telefonoText.Text = cliente.Telefono;
          comboRol.Text = cliente.Rol;
          edadNum.Value = cliente.Edad;
          radioButton1.Checked = cliente.activo;
          radioButton2.Checked = !cliente.activo;
        }
      }
    }

    /// <summary>
    /// Valida los campos del formulario y habilita o deshabilita el botón de guardar.
    /// </summary>
    private void ValidateForm(object sender, EventArgs e)
    {
      bool isEmailValid = ValidateEmail(correoText.Text);
      bool isPasswordFilled = !string.IsNullOrWhiteSpace(claveText.Text) || _usuarioId.HasValue;
      bool nombreCompleto = !string.IsNullOrWhiteSpace(nombreText.Text);
      bool nombreMenorQue200 = nombreText.Text.Length <= 200;
      bool telefonoLlenado = !string.IsNullOrWhiteSpace(telefonoText.Text);
      bool rolSeleccionado = !string.IsNullOrWhiteSpace(comboRol.Text);
      bool activo = radioButton1.Checked;

      btnGuardar.Enabled = isEmailValid && isPasswordFilled && nombreCompleto && telefonoLlenado && rolSeleccionado && (radioButton1.Checked || radioButton2.Checked);

      // Asignar mensajes de error a los campos si no son válidos.
      if (!isEmailValid)
      {
        errorProvider1.SetError(correoText, "Correo electrónico no válido.");
      }
      else
      {
        errorProvider1.SetError(correoText, string.Empty);
      }

      if (!isPasswordFilled)
      {
        errorProvider1.SetError(claveText, "La contraseña no puede estar vacía.");
      }
      else
      {
        errorProvider1.SetError(claveText, string.Empty);
      }

      if (!nombreCompleto)
      {
        errorProvider1.SetError(nombreText, "El nombre no puede estar vacío.");
      }
      else if (!nombreMenorQue200)
      {
        errorProvider1.SetError(nombreText, "El nombre del usuario no puede tener más de 200 caracteres");
      }
      else
      {
        errorProvider1.SetError(nombreText, string.Empty);
      }

      if (!telefonoLlenado)
      {
        errorProvider1.SetError(telefonoText, "El teléfono debe ser llenado");
      }
      else
      {
        errorProvider1.SetError(telefonoText, string.Empty);
      }

      if (!rolSeleccionado)
      {
        errorProvider1.SetError(comboRol, "Debe seleccionar un rol");
      }
      else
      {
        errorProvider1.SetError(comboRol, string.Empty);
      }
    }

    /// <summary>
    /// Valida el formato del correo electrónico.
    /// </summary>
    /// <param name="email">Correo electrónico a validar.</param>
    /// <returns>True si el formato es válido, False en caso contrario.</returns>
    private bool ValidateEmail(string email)
    {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(email, pattern);
    }

    /// <summary>
    /// Evento al hacer clic en el botón de mostrar/ocultar contraseña.
    /// </summary>
    private void btnMostrar_Click(object sender, EventArgs e)
    {
      setShowPassword(!getShowPassword());
      if (getShowPassword())
      {
        btnMostrar.Text = "Ocultar";
        claveText.UseSystemPasswordChar = false;
      }
      else
      {
        btnMostrar.Text = "Mostrar";
        claveText.UseSystemPasswordChar = true;
      }
    }

    /// <summary>
    /// Evento al hacer clic en el botón de guardar. Guarda o actualiza los datos del usuario.
    /// </summary>
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      // Guardar el usuario en la base de datos, si el _usuarioId tiene valor, entonces se actualiza
      setShowPassword(false);
      string nombre = nombreText.Text;
      string correo = correoText.Text;
      string telefono = telefonoText.Text;
      string clave = claveText.Text;
      string rol = comboRol.Text;
      bool activo = radioButton1.Checked;
      decimal edad = edadNum.Value;
      int id = _usuarioId ?? 0;

      using (var context = new AppDbContext())
      {
        if (_usuarioId.HasValue)
        {
          // Actualizar usuario existente.
          var usuario = context.Usuarios.Find(_usuarioId.Value);
          usuario.Nombre = nombre;
          usuario.Correo = correo;
          usuario.Telefono = telefono;
          usuario.Rol = rol;
          usuario.activo = activo;
          usuario.Edad = ((int)edad);
          if (!string.IsNullOrWhiteSpace(clave))
          {
            usuario.Contraseña = BCrypt.Net.BCrypt.HashPassword(clave);
          }
        }
        else
        {
          // Crear un nuevo usuario.
          var usuario = new Usuario()
          {
            Nombre = nombre,
            Correo = correo,
            Telefono = telefono,
            Contraseña = BCrypt.Net.BCrypt.HashPassword(clave),
            Rol = rol,
            activo = activo,
            Edad = ((int)edad),
            FechaRegistro = DateTime.Now
          };
          context.Usuarios.Add(usuario);
        }
        context.SaveChanges();
      }

      this.Close();
    }

    /// <summary>
    /// Evento al hacer clic en el botón de cancelar. Cierra el formulario actual.
    /// </summary>
    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
