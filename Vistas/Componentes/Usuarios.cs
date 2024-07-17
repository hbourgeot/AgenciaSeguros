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
  public partial class Usuarios : Form
  {
    private int? _usuarioId;

    private bool showPassword = false;

    private bool getShowPassword()
    {
      return showPassword;
    }

    private void setShowPassword(bool value)
    {
      showPassword = value;
    }

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

      btnGuardar.Enabled = false;
      correoText.TextChanged += new EventHandler(ValidateForm);
      claveText.TextChanged += new EventHandler(ValidateForm);
      nombreText.TextChanged += new EventHandler(ValidateForm);
      telefonoText.TextChanged += new EventHandler(ValidateForm);
      comboRol.TextChanged += new EventHandler(ValidateForm);
      radioButton1.CheckedChanged += new EventHandler(ValidateForm);
      radioButton2.CheckedChanged += new EventHandler(ValidateForm);
    }

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
      } else       {
        errorProvider1.SetError(telefonoText, string.Empty);
      }

      if (!rolSeleccionado)
      {
        errorProvider1.SetError(comboRol, "Debe seleccionar un rol");
      } else
      {
        errorProvider1.SetError(comboRol, string.Empty);
      }
    }

    private bool ValidateEmail(string email)
    {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(email, pattern);
    }

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

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      // guarda el usuario en base de datos, si el _usuarioId tiene valor, entonces se actualiza
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

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
