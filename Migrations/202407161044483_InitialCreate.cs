namespace AgenciaSeguros.Migraciones
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 2147483647),
                        Email = c.String(maxLength: 2147483647),
                        Telefono = c.String(maxLength: 2147483647),
                        Direccion = c.String(maxLength: 2147483647),
                        Ciudad = c.String(maxLength: 2147483647),
                        Estado = c.String(maxLength: 2147483647),
                        CodigoPostal = c.String(maxLength: 2147483647),
                        Pais = c.String(maxLength: 2147483647),
                        Documento = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pagoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaPago = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Polizas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaEmision = c.DateTime(nullable: false),
                        FechaVencimiento = c.DateTime(nullable: false),
                        Modelo = c.String(maxLength: 2147483647),
                        Marca = c.String(maxLength: 2147483647),
                        Anio = c.String(maxLength: 2147483647),
                        Placa = c.String(maxLength: 2147483647),
                        Color = c.String(maxLength: 2147483647),
                        ClienteId = c.Int(nullable: false),
                        Tipo = c.String(maxLength: 2147483647),
                        EstadoPoliza = c.String(maxLength: 2147483647),
                        MontoCobertura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Prima = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Reclamoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 2147483647),
                        FechaReclamo = c.DateTime(nullable: false),
                        PolizaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Polizas", t => t.PolizaId, cascadeDelete: true)
                .Index(t => t.PolizaId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 2147483647),
                        Correo = c.String(maxLength: 2147483647),
                        Edad = c.Int(nullable: false),
                        Telefono = c.String(maxLength: 2147483647),
                        FechaRegistro = c.DateTime(nullable: false),
                        Contraseña = c.String(maxLength: 2147483647),
                        activo = c.Boolean(nullable: false),
                        Rol = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reclamoes", "PolizaId", "dbo.Polizas");
            DropForeignKey("dbo.Polizas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Pagoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Reclamoes", new[] { "PolizaId" });
            DropIndex("dbo.Polizas", new[] { "ClienteId" });
            DropIndex("dbo.Pagoes", new[] { "ClienteId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Reclamoes");
            DropTable("dbo.Polizas");
            DropTable("dbo.Pagoes");
            DropTable("dbo.Clientes");
        }
    }
}
