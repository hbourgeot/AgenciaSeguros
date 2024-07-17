using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgenciaSeguros.Entidades
{
  public class Cliente
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public string Estado { get; set; }
    public string CodigoPostal { get; set; }
    public string Pais { get; set; }
    public string Documento { get; set; }
    public ICollection<Poliza> Polizas { get; set; }
    public ICollection<Pago> Pagos { get; set; }
  }
}
