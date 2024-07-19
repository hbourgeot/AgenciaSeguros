using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  /// <summary>
  /// Clase que representa una póliza de seguro.
  /// </summary>
  public class Poliza
  {
    /// <summary>
    /// Identificador único de la póliza.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Fecha de emisión de la póliza.
    /// </summary>
    public DateTime FechaEmision { get; set; }

    /// <summary>
    /// Fecha de vencimiento de la póliza.
    /// </summary>
    public DateTime FechaVencimiento { get; set; }

    /// <summary>
    /// Modelo del vehículo asegurado.
    /// </summary>
    public string Modelo { get; set; }

    /// <summary>
    /// Marca del vehículo asegurado.
    /// </summary>
    public string Marca { get; set; }

    /// <summary>
    /// Año del vehículo asegurado.
    /// </summary>
    public string Anio { get; set; }

    /// <summary>
    /// Placa del vehículo asegurado.
    /// </summary>
    public string Placa { get; set; }

    /// <summary>
    /// Color del vehículo asegurado.
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Identificador del cliente que posee la póliza.
    /// </summary>
    public int ClienteId { get; set; }

    /// <summary>
    /// Tipo de la póliza.
    /// </summary>
    public string Tipo { get; set; }

    /// <summary>
    /// Estado actual de la póliza.
    /// </summary>
    public string EstadoPoliza { get; set; }

    /// <summary>
    /// Monto de la cobertura de la póliza.
    /// </summary>
    public decimal MontoCobertura { get; set; }

    /// <summary>
    /// Prima de la póliza.
    /// </summary>
    public decimal Prima { get; set; }

    /// <summary>
    /// Cliente que posee la póliza.
    /// </summary>
    public Cliente Cliente { get; set; }

    /// <summary>
    /// Colección de reclamos asociados a la póliza.
    /// </summary>
    public ICollection<Reclamo> Reclamos { get; set; }
  }
}
