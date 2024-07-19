using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  /// <summary>
  /// Clase que representa un pago realizado por un cliente.
  /// </summary>
  public class Pago
  {
    /// <summary>
    /// Identificador único del pago.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Monto del pago.
    /// </summary>
    public decimal Monto { get; set; }

    /// <summary>
    /// Fecha en que se realizó el pago.
    /// </summary>
    public DateTime FechaPago { get; set; }

    /// <summary>
    /// Descripción del pago.
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Identificador del cliente que realizó el pago.
    /// </summary>
    public int ClienteId { get; set; }

    /// <summary>
    /// Cliente que realizó el pago.
    /// </summary>
    public Cliente Cliente { get; set; }
  }
}
