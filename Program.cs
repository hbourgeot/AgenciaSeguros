using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using AgenciaSeguros.Vistas;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaSeguros
{
  /// Clase principal del programa que gestiona la inicialización y el arranque de la aplicación.
  internal static class Program
  {
    /// Punto de entrada principal para la aplicación.
    [STAThread]
    static void Main()
    {
      // Habilitar estilos visuales para la aplicación
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      // Cargar las ensambladuras nativas de SqlServerTypes
      SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
      
      // Asegurarse de que el directorio de datos existe
      string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory")?.ToString();
      if (dataDirectory == null)
      {
        dataDirectory = AppDomain.CurrentDomain.BaseDirectory;
        AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
      }

      // Ruta del archivo de la base de datos
      string databaseFile = Path.Combine(dataDirectory, "AgenciaSeguros.db");
      System.Console.WriteLine($"Database file: {databaseFile}");
      
      // Crear el archivo de base de datos si no existe
      if (!File.Exists(databaseFile))
      {
        SQLiteConnection.CreateFile(databaseFile);
      }

      using (var context = new AppDbContext())
      {
        // Asegurarse de que la base de datos esté creada
        context.Database.Initialize(force: false);

        // Verificar si hay usuarios registrados
        if (!context.Usuarios.Any())
        {
          MessageBox.Show("No hay usuarios registrados. Por favor, cargue un archivo Excel para registrar usuarios.", "Cargar Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

          OpenFileDialog openFileDialog = new OpenFileDialog
          {
            Filter = "Excel Files|*.xlsx",
            Title = "Seleccione el archivo Excel"
          };

          if (openFileDialog.ShowDialog() == DialogResult.OK)
          {
            var usuarios = ReadUsersFromFile(openFileDialog.FileName);
            RegisterUsers(usuarios, context);
          }
        }
      }

      // Ejecutar el formulario principal de la aplicación
      Application.Run(new AgenciaSeguros.Vistas.Form1());
    }

    /// Lee los usuarios desde un archivo Excel.
    /// <param name="filePath">Ruta del archivo Excel.</param>
    /// <returns>Lista de usuarios leídos del archivo Excel.</returns>
    static List<Usuario> ReadUsersFromFile(string filePath)
    {
      var usuarios = new List<Usuario>();

      if (filePath.EndsWith(".xlsx"))
      {
        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
          // Establecer el contexto de licencia a No Comercial
          ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

          var worksheet = package.Workbook.Worksheets[0];
          int rowCount = worksheet.Dimension.Rows;
          for (int row = 2; row <= rowCount; row++)
          {
            usuarios.Add(new Usuario
            {
              Nombre = worksheet.Cells[row, 1].Text,
              Correo = worksheet.Cells[row, 2].Text,
              Edad = int.Parse(worksheet.Cells[row, 3].Text),
              Telefono = worksheet.Cells[row, 4].Text,
              FechaRegistro = DateTime.Now, // Establecer la fecha de registro a la fecha y hora actuales
              Contraseña = worksheet.Cells[row, 5].Text,
              Rol = worksheet.Cells[row, 6].Text,
              activo = true
            });
          }
        }
      }

      return usuarios;
    }

    /// Registra usuarios en la base de datos.
    /// <param name="usuarios">Lista de usuarios a registrar.</param>
    /// <param name="context">Contexto de base de datos.</param>
    static void RegisterUsers(List<Usuario> usuarios, AppDbContext context)
    {
      foreach (var usuario in usuarios)
      {
        // Validar si el correo ya existe
        if (!context.Usuarios.Any(u => u.Correo == usuario.Correo))
        {
          // Hashear la contraseña antes de guardarla
          usuario.Contraseña = BCrypt.Net.BCrypt.HashPassword(usuario.Contraseña);
          context.Usuarios.Add(usuario); // Asegúrate de que 'Usuarios' es el DbSet para la entidad Usuario
        }
        else
        {
          MessageBox.Show($"El usuario con correo {usuario.Correo} ya existe y no será registrado.", "Cargar Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      context.SaveChanges();
    }
  }
}
