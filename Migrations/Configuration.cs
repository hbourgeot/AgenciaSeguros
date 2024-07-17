using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace AgenciaSeguros.Migraciones
{
  internal sealed class Configuration : DbMigrationsConfiguration<AgenciaSeguros.Datos.AppDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
      SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
    }

    protected override void Seed(AgenciaSeguros.Datos.AppDbContext context)
    {
      // Seed method will be called after migrating to the latest version.
    }
  }
}
