using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Entidades
{
  public class Pago
  {
    public int Id { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaPago { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
  }
}
