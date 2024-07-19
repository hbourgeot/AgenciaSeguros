using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgenciaSeguros.Entidades
{
  /// <summary>
  /// Clase que representa a un cliente de la agencia de seguros.
  /// </summary>
  public class Cliente
  {
    /// <summary>
    /// Identificador único del cliente.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre del cliente.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Email del cliente.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Teléfono del cliente.
    /// </summary>
    public string Telefono { get; set; }

    /// <summary>
    /// Dirección del cliente.
    /// </summary>
    public string Direccion { get; set; }

    /// <summary>
    /// Ciudad del cliente.
    /// </summary>
    public string Ciudad { get; set; }

    /// <summary>
    /// Estado o provincia del cliente.
    /// </summary>
    public string Estado { get; set; }

    /// <summary>
    /// Código postal del cliente.
    /// </summary>
    public string CodigoPostal { get; set; }

    /// <summary>
    /// País del cliente.
    /// </summary>
    public string Pais { get; set; }

    /// <summary>
    /// Documento de identificación del cliente.
    /// </summary>
    public string Documento { get; set; }

    /// <summary>
    /// Colección de pólizas asociadas al cliente.
    /// </summary>
    public ICollection<Poliza> Polizas { get; set; }

    /// <summary>
    /// Colección de pagos realizados por el cliente.
    /// </summary>
    public ICollection<Pago> Pagos { get; set; }
  }
}
