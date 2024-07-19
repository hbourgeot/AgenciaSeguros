using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  /// <summary>
  /// Clase que representa un reclamo realizado por un cliente.
  /// </summary>
  public class Reclamo
  {
    /// <summary>
    /// Identificador único del reclamo.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Descripción del reclamo.
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Fecha en que se realizó el reclamo.
    /// </summary>
    public DateTime FechaReclamo { get; set; }

    /// <summary>
    /// Estado actual del reclamo.
    /// </summary>
    public string Estado { get; set; }

    /// <summary>
    /// Identificador del cliente que realizó el reclamo.
    /// </summary>
    public int ClienteId { get; set; }

    /// <summary>
    /// Identificador de la póliza asociada al reclamo.
    /// </summary>
    public int PolizaId { get; set; }

    /// <summary>
    /// Cliente que realizó el reclamo.
    /// </summary>
    public Cliente Cliente { get; set; }

    /// <summary>
    /// Póliza asociada al reclamo.
    /// </summary>
    public Poliza Poliza { get; set; }
  }
}
