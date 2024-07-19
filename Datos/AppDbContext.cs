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
  /// <summary>
  /// Clase que representa el contexto de la base de datos de la aplicación.
  /// </summary>
  public class AppDbContext : DbContext
  {
    static AppDbContext()
    {
      // Registrar el proveedor SQLite
      DbConfiguration.SetConfiguration(new SQLiteConfiguration());
    }

    /// <summary>
    /// Constructor que inicializa el contexto de la base de datos con la conexión por defecto.
    /// </summary>
    public AppDbContext() : base("name=DefaultConnection")
    {
    }

    /// <summary>
    /// Conjunto de entidades de usuarios.
    /// </summary>
    public DbSet<Usuario> Usuarios { get; set; }
    
    /// <summary>
    /// Conjunto de entidades de clientes.
    /// </summary>
    public DbSet<Cliente> Clientes { get; set; }

    /// <summary>
    /// Conjunto de entidades de pólizas.
    /// </summary>
    public DbSet<Poliza> Polizas { get; set; }

    /// <summary>
    /// Conjunto de entidades de reclamos.
    /// </summary>
    public DbSet<Reclamo> Reclamos { get; set; }

    /// <summary>
    /// Conjunto de entidades de pagos.
    /// </summary>
    public DbSet<Pago> Pagos { get; set; }

    /// <summary>
    /// Configuración del modelo de la base de datos.
    /// </summary>
    /// <param name="modelBuilder">Constructor de modelos de entidad.</param>
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }

  /// <summary>
  /// Configuración para el proveedor SQLite.
  /// </summary>
  public class SQLiteConfiguration : DbConfiguration
  {
    public SQLiteConfiguration()
    {
      // Configurar el proveedor SQLite
      SetProviderFactory("System.Data.SQLite", System.Data.SQLite.SQLiteFactory.Instance);
      SetProviderFactory("System.Data.SQLite.EF6", System.Data.SQLite.EF6.SQLiteProviderFactory.Instance);
      SetProviderServices("System.Data.SQLite", (DbProviderServices)System.Data.SQLite.EF6.SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
    }
  }
}
