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
  public partial class Cliente : Form
  {
    private int? _clienteId;

    public Cliente(int? clienteId)
    {
      InitializeComponent();

      _clienteId = clienteId;
      if (_clienteId.HasValue)
      {
        LoadClientemData();
        label11.Text = "Editar cliente";
        this.Text = $"Editar Cliente #{_clienteId.Value}";
      }
      else
      {
        label11.Text = "Nuevo cliente";
        this.Text = "Nuevo Cliente";
      }

      btnGuardar.Enabled = false;
      correoText.TextChanged += new EventHandler(ValidateForm);
      nombreText.TextChanged += new EventHandler(ValidateForm);
      telefonoText.TextChanged += new EventHandler(ValidateForm);
      codPostalText.TextChanged += new EventHandler(ValidateForm);
      documentoText.TextChanged += new EventHandler(ValidateForm);
      paisText.TextChanged += new EventHandler(ValidateForm);
      estadoText.TextChanged += new EventHandler(ValidateForm);
      ciudadText.TextChanged += new EventHandler(ValidateForm);
      direccionText.TextChanged += new EventHandler(ValidateForm);
    }


    private void LoadClientemData()
    {
      using (var context = new AppDbContext())
      {
        var cliente = context.Clientes.Find(_clienteId.Value);
        if (cliente != null)
        {
          nombreText.Text = cliente.Nombre;
          correoText.Text = cliente.Email;
          telefonoText.Text = cliente.Telefono;
          codPostalText.Text = cliente.CodigoPostal;
          documentoText.Text = cliente.Documento;
          paisText.Text = cliente.Pais;
          estadoText.Text = cliente.Estado;
          ciudadText.Text = cliente.Ciudad;
          direccionText.Text = cliente.Direccion;
        }
      }
    }

    private void ValidateForm(object sender, EventArgs e)
    {
      bool isEmailValid = ValidateEmail(correoText.Text);
      bool nombreCompleto = !string.IsNullOrWhiteSpace(nombreText.Text) && nombreText.Text.Length < 200;
      bool telefonoLlenado = !string.IsNullOrWhiteSpace(telefonoText.Text) && telefonoText.Text.Length < 21;
      bool codPostaLleno = !string.IsNullOrWhiteSpace(codPostalText.Text) && codPostalText.Text.Length == 4;
      bool documentoLleno = !string.IsNullOrWhiteSpace(documentoText.Text) && documentoText.Text.Length >= 8;
      bool paisLleno = !string.IsNullOrWhiteSpace(paisText.Text) && paisText.Text.Length < 100;
      bool estadoLleno = !string.IsNullOrWhiteSpace(estadoText.Text) && estadoText.Text.Length < 100;
      bool ciudadLleno = !string.IsNullOrWhiteSpace(ciudadText.Text) && ciudadText.Text.Length < 100;
      bool direccionLleno = !string.IsNullOrWhiteSpace(direccionText.Text) && direccionText.Text.Length < 300;

      btnGuardar.Enabled = isEmailValid && nombreCompleto && telefonoLlenado && codPostaLleno && documentoLleno && paisLleno && estadoLleno && ciudadLleno && direccionLleno;

      if (!isEmailValid)
      {
        errorProvider1.SetError(correoText, "Correo electrónico no válido.");
      }
      else
      {
        errorProvider1.SetError(correoText, string.Empty);
      }

      if (!nombreCompleto)
      {
        errorProvider1.SetError(nombreText, "El nombre no puede estar vacío y debe tener menos de 200 caracteres");
      }
      else
      {
        errorProvider1.SetError(nombreText, string.Empty);
      }

      if (!telefonoLlenado)
      {
        errorProvider1.SetError(telefonoText, "El teléfono no puede estar vacío y debe tener menos de 21 caracteres");
      }
      else
      {
        errorProvider1.SetError(telefonoText, string.Empty);
      }

      if (!codPostaLleno)
      {
        errorProvider1.SetError(codPostalText, "El código postal no puede estar vacío y debe tener 4 caracteres");
      }
      else
      {
        errorProvider1.SetError(codPostalText, string.Empty);
      }

      if (!documentoLleno)
      {
        errorProvider1.SetError(documentoText, "El documento no puede estar vacío y debe tener al menos 8 caracteres");
      }
      else
      {
        errorProvider1.SetError(documentoText, string.Empty);
      }

      if (!paisLleno)
      {
        errorProvider1.SetError(paisText, "El país no puede estar vacío y debe tener menos de 100 caracteres");
      }
      else
      {
        errorProvider1.SetError(paisText, string.Empty);
      }

      if (!estadoLleno)
      {
        errorProvider1.SetError(estadoText, "El estado no puede estar vacío y debe tener menos de 100 caracteres");
      }
      else
      {
        errorProvider1.SetError(estadoText, string.Empty);
      }

      if (!ciudadLleno)
      {
        errorProvider1.SetError(ciudadText, "La ciudad no puede estar vacía y debe tener menos de 100 caracteres");
      }
      else
      {
        errorProvider1.SetError(ciudadText, string.Empty);
      }

      if (!direccionLleno)
      {
        errorProvider1.SetError(direccionText, "La dirección no puede estar vacía y debe tener menos de 300 caracteres");
      }
      else
      {
        errorProvider1.SetError(direccionText, string.Empty);
      }
    }

    private bool ValidateEmail(string email)
    {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
      return Regex.IsMatch(email, pattern);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      string nombre = nombreText.Text;
      string email = correoText.Text;
      string telefono = telefonoText.Text;
      string codPostal = codPostalText.Text;
      string documento = documentoText.Text;
      string pais = paisText.Text;
      string estado = estadoText.Text;
      string ciudad = ciudadText.Text;
      string direccion = direccionText.Text;

      using (var context = new AppDbContext())
      {
        if (_clienteId.HasValue)
        {
          var cliente = context.Clientes.Find(_clienteId.Value);
          if (cliente != null)
          {
            cliente.Nombre = nombre;
            cliente.Email = email;
            cliente.Telefono = telefono;
            cliente.CodigoPostal = codPostal;
            cliente.Documento = documento;
            cliente.Pais = pais;
            cliente.Estado = estado;
            cliente.Ciudad = ciudad;
            cliente.Direccion = direccion;
          }
        }
        else
        {
          var cliente = new Entidades.Cliente()
          {
            Nombre = nombre,
            Email = email,
            Telefono = telefono,
            CodigoPostal = codPostal,
            Documento = documento,
            Pais = pais,
            Estado = estado,
            Ciudad = ciudad,
            Direccion = direccion
          };
          context.Clientes.Add(cliente);
        }
        context.SaveChanges();
      }

      this.Close();
    }
  }
}
