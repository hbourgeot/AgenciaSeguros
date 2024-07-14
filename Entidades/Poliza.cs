using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  public class Poliza
  {
    public int Id { get; set; }
    public string NumeroPoliza { get; set; }
    public DateTime FechaEmision { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public ICollection<Reclamo> Reclamos { get; set; }
  }
}
