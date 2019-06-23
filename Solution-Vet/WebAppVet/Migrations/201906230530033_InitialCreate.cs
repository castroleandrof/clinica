namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        ubicacion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idServicio = c.Int(nullable: false),
                        fecha = c.Int(nullable: false),
                        idMascota = c.Int(nullable: false),
                        idDoctor = c.Int(nullable: false),
                        idSala = c.Int(nullable: false),
                        idPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Doctors", t => t.idDoctor, cascadeDelete: true)
                .ForeignKey("dbo.Mascotas", t => t.idMascota, cascadeDelete: true)
                .ForeignKey("dbo.Pagoes", t => t.idPago, cascadeDelete: true)
                .ForeignKey("dbo.Salas", t => t.idSala, cascadeDelete: true)
                .ForeignKey("dbo.TipoServicios", t => t.idServicio, cascadeDelete: true)
                .Index(t => t.idServicio)
                .Index(t => t.idMascota)
                .Index(t => t.idDoctor)
                .Index(t => t.idSala)
                .Index(t => t.idPago);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        email = c.String(nullable: false),
                        idTipoDoctor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TipoDoctors", t => t.idTipoDoctor, cascadeDelete: true)
                .Index(t => t.idTipoDoctor);
            
            CreateTable(
                "dbo.TipoDoctors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipoDoctor = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Mascotas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        nombre = c.String(nullable: false),
                        idTipoMascota = c.Int(nullable: false),
                        edad = c.Int(nullable: false),
                        Cliente_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_id)
                .Index(t => t.Cliente_id);
            
            CreateTable(
                "dbo.Pagoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idCliente = c.Int(nullable: false),
                        importe = c.Int(nullable: false),
                        idMascota = c.Int(nullable: false),
                        medioDePago = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.idCliente, cascadeDelete: true)
                .ForeignKey("dbo.Mascotas", t => t.idMascota, cascadeDelete: true)
                .Index(t => t.idCliente)
                .Index(t => t.idMascota);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TipoServicios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombreServicio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Rooms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Turnoes", "idServicio", "dbo.TipoServicios");
            DropForeignKey("dbo.Turnoes", "idSala", "dbo.Salas");
            DropForeignKey("dbo.Turnoes", "idPago", "dbo.Pagoes");
            DropForeignKey("dbo.Pagoes", "idMascota", "dbo.Mascotas");
            DropForeignKey("dbo.Pagoes", "idCliente", "dbo.Clientes");
            DropForeignKey("dbo.Mascotas", "Cliente_id", "dbo.Clientes");
            DropForeignKey("dbo.Turnoes", "idMascota", "dbo.Mascotas");
            DropForeignKey("dbo.Turnoes", "idDoctor", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "idTipoDoctor", "dbo.TipoDoctors");
            DropIndex("dbo.Pagoes", new[] { "idMascota" });
            DropIndex("dbo.Pagoes", new[] { "idCliente" });
            DropIndex("dbo.Mascotas", new[] { "Cliente_id" });
            DropIndex("dbo.Doctors", new[] { "idTipoDoctor" });
            DropIndex("dbo.Turnoes", new[] { "idPago" });
            DropIndex("dbo.Turnoes", new[] { "idSala" });
            DropIndex("dbo.Turnoes", new[] { "idDoctor" });
            DropIndex("dbo.Turnoes", new[] { "idMascota" });
            DropIndex("dbo.Turnoes", new[] { "idServicio" });
            DropTable("dbo.TipoServicios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Pagoes");
            DropTable("dbo.Mascotas");
            DropTable("dbo.TipoDoctors");
            DropTable("dbo.Doctors");
            DropTable("dbo.Turnoes");
            DropTable("dbo.Salas");
        }
    }
}
