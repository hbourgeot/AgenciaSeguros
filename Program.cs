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
      // Especifica el nombre y la ubicación de la base de datos
      var databaseFile = "AgenciaSeguros.db";

      // Verifica si el archivo de la base de datos ya existe
      if (!File.Exists(databaseFile))
      {
        // Si no existe, crea el archivo de la base de datos
        SQLiteConnection.CreateFile(databaseFile);
        Console.WriteLine($"Base de datos '{databaseFile}' creada exitosamente.");
      }
      else
      {
        Console.WriteLine($"La base de datos '{databaseFile}' ya existe.");
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
