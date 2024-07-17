using AgenciaSeguros.Datos;
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

namespace AgenciaSeguros.Vistas
{
  public partial class Form1 : Form
  {
    private bool showPassword = false;

    private bool getShowPassword()
    {
      return showPassword;
    }

    private void setShowPassword(bool value)
    {
      showPassword = value;
    }

    public Form1()
    {
      InitializeComponent();
      maskedTextBox1.TextChanged += new EventHandler(ValidateForm);
      maskedTextBox2.TextChanged += new EventHandler(ValidateForm);
      button3.Enabled = false; // Deshabilitar el botón de enviar inicialmente
    }

    private void button1_Click(object sender, EventArgs e)
    {
      setShowPassword(!getShowPassword());
      if (getShowPassword())
      {
        button1.Text = "Ocultar";
        maskedTextBox1.UseSystemPasswordChar = false;
      }
      else
      {
        button1.Text = "Mostrar";
        maskedTextBox1.UseSystemPasswordChar = true;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    // login
    private void button3_Click(object sender, EventArgs e)
    {
      string correo = maskedTextBox2.Text;
      string contraseña = maskedTextBox1.Text;

      using (var context = new AppDbContext())
      {
        // Buscar el usuario por correo electrónico
        var usuario = context.Usuarios.SingleOrDefault(u => u.Correo == correo);

        if (usuario != null)
        {
          // Validar la contraseña
          bool contraseñaValida = BCrypt.Net.BCrypt.Verify(contraseña, usuario.Contraseña);
          if (usuario.activo == false)
          {
            MessageBox.Show("Usuario inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          else if (contraseñaValida)
          {
            // Obtener el rol del usuario
            string rol = usuario.Rol;

            // Redirigir al formulario correspondiente según el rol
            Form formToOpen = null;
            if (rol == "Administrador")
            {
              formToOpen = new FormAdmin(); // Asegúrate de tener un formulario FormAdmin
            }
            else if (rol == "Usuario")
            {
              formToOpen = new FormUsuario(); // Asegúrate de tener un formulario FormUsuario
            }

            if (formToOpen != null)
            {
              this.Hide();
              formToOpen.ShowDialog();
              this.Show();
            }
            else
            {
              MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          else
          {
            MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          MessageBox.Show("Correo electrónico no registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void ValidateForm(object sender, EventArgs e)
    {
      bool isEmailValid = ValidateEmail(maskedTextBox2.Text);
      bool isPasswordFilled = !string.IsNullOrWhiteSpace(maskedTextBox1.Text);

      button3.Enabled = isEmailValid && isPasswordFilled;

      if (!isEmailValid)
      {
        errorProvider1.SetError(maskedTextBox2, "Correo electrónico no válido.");
      }
      else
      {
        errorProvider1.SetError(maskedTextBox2, string.Empty);
      }

      if (!isPasswordFilled)
      {
        errorProvider1.SetError(maskedTextBox1, "La contraseña no puede estar vacía.");
      }
      else
      {
        errorProvider1.SetError(maskedTextBox1, string.Empty);
      }
    }

    private bool ValidateEmail(string email)
    {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(email, pattern);
    }
  }
}
