using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  /// <summary>
  /// Clase que representa un usuario del sistema.
  /// </summary>
  public class Usuario
  {
    /// <summary>
    /// Identificador único del usuario.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre del usuario.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Correo electrónico del usuario.
    /// </summary>
    public string Correo { get; set; }

    /// <summary>
    /// Edad del usuario.
    /// </summary>
    public int Edad { get; set; }

    /// <summary>
    /// Teléfono del usuario.
    /// </summary>
    public string Telefono { get; set; }

    /// <summary>
    /// Fecha de registro del usuario en el sistema.
    /// </summary>
    public DateTime FechaRegistro { get; set; }

    /// <summary>
    /// Contraseña del usuario.
    /// </summary>
    public string Contraseña { get; set; }

    /// <summary>
    /// Indicador de si el usuario está activo.
    /// </summary>
    public bool Activo { get; set; } = false;

    /// <summary>
    /// Rol del usuario (Administrador o Usuario Regular).
    /// </summary>
    public string Rol { get; set; }
  }
}
