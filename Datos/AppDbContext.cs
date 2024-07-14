using AgenciaSeguros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Datos
{
  public class AppDbContext : DbContext
  {
    public AppDbContext() : base("name=DefaultConnection")
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Poliza> Polizas { get; set; }
    public DbSet<Reclamo> Reclamos { get; set; }
    public DbSet<Pago> Pagos { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}
