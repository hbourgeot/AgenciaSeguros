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
    public DateTime FechaEmision { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public String Modelo { get; set; }
    public String Marca { get; set; }
    public String Anio { get; set; }
    public String Placa { get; set; }
    public String Color { get; set; }
    public int ClienteId { get; set; }
    public string Tipo { get; set; }
    public string EstadoPoliza { get; set; }
    public decimal MontoCobertura { get; set; }
    public decimal Prima { get; set; }
    public Cliente Cliente { get; set; }
    public ICollection<Reclamo> Reclamos { get; set; }
  }
}
