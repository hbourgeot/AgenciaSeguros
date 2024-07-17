using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  public class Reclamo
  {
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaReclamo { get; set; }
    public string Estado { get; set; }
    public int ClienteId { get; set; }
    public int PolizaId { get; set; }
    public Cliente Cliente { get; set; }
    public Poliza Poliza { get; set; }
  }
}
