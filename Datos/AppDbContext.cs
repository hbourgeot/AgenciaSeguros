using AgenciaSeguros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaSeguros.Datos
{
  public class AppDbContext : DbContext
  {
    static AppDbContext()
    {
      // Register the SQLite provider
      DbConfiguration.SetConfiguration(new SQLiteConfiguration());
    }

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

  public class SQLiteConfiguration : DbConfiguration
  {
    public SQLiteConfiguration()
    {
      SetProviderFactory("System.Data.SQLite", System.Data.SQLite.SQLiteFactory.Instance);
      SetProviderFactory("System.Data.SQLite.EF6", System.Data.SQLite.EF6.SQLiteProviderFactory.Instance);
      SetProviderServices("System.Data.SQLite", (DbProviderServices)System.Data.SQLite.EF6.SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
    }
  }
}
