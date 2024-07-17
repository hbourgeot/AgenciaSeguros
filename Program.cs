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
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
      // Asegurarse de que el directorio de datos existe
      string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory")?.ToString();
      if (dataDirectory == null)
      {
        dataDirectory = AppDomain.CurrentDomain.BaseDirectory;
        AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
      }

      string databaseFile = Path.Combine(dataDirectory, "AgenciaSeguros.db");
      System.Console.WriteLine($"Database file: {databaseFile}");
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

      Application.Run(new AgenciaSeguros.Vistas.Form1());
    }

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

    static void RegisterUsers(List<Usuario> usuarios, AppDbContext context)
    {
      foreach (var usuario in usuarios)
      {
        // Validar si el correo ya existe
        if (!context.Usuarios.Any(u => u.Correo == usuario.Correo))
        {
          usuario.Contraseña = BCrypt.Net.BCrypt.HashPassword(usuario.Contraseña);
          context.Usuarios.Add(usuario); // Asegúrate de que 'Usuarios' es el DbSet para la entidad Usuario
        }
        else
        {
          Console.WriteLine($"El usuario con correo {usuario.Correo} ya existe y no será registrado.");
        }
      }
      context.SaveChanges();
    }
  }
}
