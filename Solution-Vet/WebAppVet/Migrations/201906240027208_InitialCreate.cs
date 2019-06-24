namespace WebAppVet.Migrations
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
                        id = c.Int(nullable: false, identity: true),
                        DNI = c.Int(nullable: false),
                        nombre = c.String(nullable: false),
                        email = c.String(nullable: false),
                        telefono = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.TipoMascotas",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    raza = c.String(nullable: false),
                    tipoMascota = c.String(nullable: false),
                })
                .PrimaryKey(t => t.id);


            CreateTable(
                "dbo.Mascotas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idCliente = c.Int(nullable: false),
                        nombre = c.String(nullable: false),
                        idTipoMascota = c.Int(nullable: false),
                        edad = c.Int(nullable: false),
                        Mascota_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.idCliente, cascadeDelete: false)
                .ForeignKey("dbo.Mascotas", t => t.Mascota_id)
                .ForeignKey("dbo.TipoMascotas", t => t.idTipoMascota, cascadeDelete: false)
                .Index(t => t.idCliente)
                .Index(t => t.idTipoMascota)
                .Index(t => t.Mascota_id);
            
            
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
                .ForeignKey("dbo.TipoDoctors", t => t.idTipoDoctor, cascadeDelete: false)
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
                .ForeignKey("dbo.Doctors", t => t.idDoctor, cascadeDelete: false)
                .ForeignKey("dbo.Mascotas", t => t.idMascota, cascadeDelete: false)
                .ForeignKey("dbo.Pagoes", t => t.idPago, cascadeDelete: false)
                .ForeignKey("dbo.Salas", t => t.idSala, cascadeDelete: false)
                .ForeignKey("dbo.TipoServicios", t => t.idServicio, cascadeDelete: false)
                .Index(t => t.idServicio)
                .Index(t => t.idMascota)
                .Index(t => t.idDoctor)
                .Index(t => t.idSala)
                .Index(t => t.idPago);
            
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
                .ForeignKey("dbo.Clientes", t => t.idCliente, cascadeDelete: false)
                .ForeignKey("dbo.Mascotas", t => t.idMascota, cascadeDelete: false)
                .Index(t => t.idCliente)
                .Index(t => t.idMascota);
            
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
                "dbo.TipoServicios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombreServicio = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnoes", "idServicio", "dbo.TipoServicios");
            DropForeignKey("dbo.Turnoes", "idSala", "dbo.Salas");
            DropForeignKey("dbo.Turnoes", "idPago", "dbo.Pagoes");
            DropForeignKey("dbo.Pagoes", "idMascota", "dbo.Mascotas");
            DropForeignKey("dbo.Pagoes", "idCliente", "dbo.Clientes");
            DropForeignKey("dbo.Turnoes", "idMascota", "dbo.Mascotas");
            DropForeignKey("dbo.Turnoes", "idDoctor", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "idTipoDoctor", "dbo.TipoDoctors");
            DropForeignKey("dbo.Mascotas", "idTipoMascota", "dbo.TipoMascotas");
            DropForeignKey("dbo.Mascotas", "Mascota_id", "dbo.Mascotas");
            DropForeignKey("dbo.Mascotas", "idCliente", "dbo.Clientes");
            DropIndex("dbo.Pagoes", new[] { "idMascota" });
            DropIndex("dbo.Pagoes", new[] { "idCliente" });
            DropIndex("dbo.Turnoes", new[] { "idPago" });
            DropIndex("dbo.Turnoes", new[] { "idSala" });
            DropIndex("dbo.Turnoes", new[] { "idDoctor" });
            DropIndex("dbo.Turnoes", new[] { "idMascota" });
            DropIndex("dbo.Turnoes", new[] { "idServicio" });
            DropIndex("dbo.Doctors", new[] { "idTipoDoctor" });
            DropIndex("dbo.Mascotas", new[] { "Mascota_id" });
            DropIndex("dbo.Mascotas", new[] { "idTipoMascota" });
            DropIndex("dbo.Mascotas", new[] { "idCliente" });
            DropTable("dbo.TipoServicios");
            DropTable("dbo.Salas");
            DropTable("dbo.Pagoes");
            DropTable("dbo.Turnoes");
            DropTable("dbo.TipoDoctors");
            DropTable("dbo.Doctors");
            DropTable("dbo.TipoMascotas");
            DropTable("dbo.Mascotas");
            DropTable("dbo.Clientes");
        }
    }
}
