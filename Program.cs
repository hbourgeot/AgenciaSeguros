using AgenciaSeguros.Datos;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
