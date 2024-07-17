namespace AgenciaSeguros.Migraciones
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pagoes", "Descripcion", c => c.String(maxLength: 50));
            AddColumn("dbo.Reclamoes", "Estado", c => c.String(maxLength: 50));
            AddColumn("dbo.Reclamoes", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reclamoes", "ClienteId");
            AddForeignKey("dbo.Reclamoes", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reclamoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Reclamoes", new[] { "ClienteId" });
            DropColumn("dbo.Reclamoes", "ClienteId");
            DropColumn("dbo.Reclamoes", "Estado");
            DropColumn("dbo.Pagoes", "Descripcion");
        }
    }
}
