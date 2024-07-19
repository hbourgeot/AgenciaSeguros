using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AgenciaSeguros.Vistas.Componentes;

namespace AgenciaSeguros.Utilidades
{
  /// <summary>
  /// Clase para generar reportes en formato PDF a partir de datos de la aplicación.
  /// </summary>
  internal class GeneradorDeReporte
  {
    /// <summary>
    /// Genera un reporte de pólizas y lo guarda en formato PDF en la ruta especificada.
    /// </summary>
    /// <param name="outputPath">Ruta donde se guardará el archivo PDF.</param>
    public static void ReportePolizas(string outputPath)
    {
      string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

      // Construir la ruta relativa al archivo .rdlc
      string reportPath = Path.Combine(baseDirectory, @"..\..\Vistas\Reportes\ReportePolizas.rdlc");
      reportPath = Path.GetFullPath(reportPath);

      // Crear el reporte local
      LocalReport report = new LocalReport();
      report.ReportPath = reportPath;

      using (var context = new AppDbContext())
      {
        // Obtener los datos de las pólizas
        ReportDataSource rds = new ReportDataSource("PolizasDataSet", context.Polizas.Select(u => new
        {
          u.Marca,
          u.Modelo,
          u.Anio,
          u.Placa,
          u.Prima,
          u.MontoCobertura,
          u.FechaVencimiento,
          u.EstadoPoliza,
          u.Tipo,
          Cliente = u.Cliente.Nombre
        }).ToList());
        report.DataSources.Clear();
        report.DataSources.Add(rds);
      }

      // Renderizar el reporte en formato PDF
      string mimeType;
      string encoding;
      string fileNameExtension;
      string[] streams;
      Warning[] warnings;

      byte[] pdfContent = report.Render(
          "PDF", null, out mimeType, out encoding, out fileNameExtension,
          out streams, out warnings);

      // Guardar el archivo PDF
      File.WriteAllBytes(outputPath, pdfContent);
      Console.WriteLine("Reporte guardado exitosamente como PDF en " + outputPath);
    }

    /// <summary>
    /// Genera un reporte general que incluye datos de pólizas, clientes, pagos y reclamos, y lo guarda en formato PDF en la ruta especificada.
    /// </summary>
    /// <param name="outputPath">Ruta donde se guardará el archivo PDF.</param>
    public static void ReporteGeneral(string outputPath)
    {
      string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

      // Construir la ruta relativa al archivo .rdlc
      string reportPath = Path.Combine(baseDirectory, @"..\..\Vistas\Reportes\ReporteGeneral.rdlc");
      reportPath = Path.GetFullPath(reportPath);

      // Crear el reporte local
      LocalReport report = new LocalReport();
      report.ReportPath = reportPath;

      using (var context = new AppDbContext())
      {
        // Obtener los datos de las pólizas
        ReportDataSource rds = new ReportDataSource("PolizasData", context.Polizas.Select(u => new
        {
          u.Marca,
          u.Modelo,
          u.Anio,
          u.Placa,
          u.EstadoPoliza,
          Cliente = u.Cliente.Nombre
        }).ToList());
        report.DataSources.Clear();
        report.DataSources.Add(rds);

        // Obtener los datos de los clientes
        ReportDataSource rds2 = new ReportDataSource("ClientesData", context.Clientes.Select(c => new
        {
          c.Nombre,
          c.Documento,
          c.Telefono,
          c.Email
        }).ToList());
        report.DataSources.Add(rds2);

        // Obtener los datos de los pagos
        ReportDataSource rds3 = new ReportDataSource("PagosData", context.Pagos.Select(p => new
        {
          p.Monto,
          p.FechaPago,
          Cliente = p.Cliente.Nombre,
          p.Descripcion
        }).ToList());
        report.DataSources.Add(rds3);

        // Obtener los datos de los reclamos
        ReportDataSource rds4 = new ReportDataSource("ReclamosData", context.Reclamos.Select(r => new
        {
          r.FechaReclamo,
          r.Descripcion,
          r.Estado,
          Poliza = r.Poliza.Placa,
          Cliente = r.Cliente.Nombre
        }).ToList());
        report.DataSources.Add(rds4);
      }

      // Renderizar el reporte en formato PDF
      string mimeType;
      string encoding;
      string fileNameExtension;
      string[] streams;
      Warning[] warnings;

      byte[] pdfContent = report.Render(
          "PDF", null, out mimeType, out encoding, out fileNameExtension,
          out streams, out warnings);

      // Guardar el archivo PDF
      File.WriteAllBytes(outputPath, pdfContent);
      Console.WriteLine("Reporte guardado exitosamente como PDF en " + outputPath);
    }
  }
}
