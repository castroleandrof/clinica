namespace WebAppVet.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppVet.Data.ClinicaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebAppVet.Data.ClinicaDbContext context)
        {
            context.Cliente.AddOrUpdate(x => x.id,
              new Cliente() { id = 1, DNI = 1000000, nombre = "Jose", telefono = "11111111", email = "jose@web.com" },
              new Cliente() { id = 2, DNI = 2000000, nombre = "Cristian", telefono = "22222222", email = "cristian@web.com" },
              new Cliente() { id = 3, DNI = 3000000, nombre = "Facundo", telefono = "33333333", email = "facundo@web.com" });

            context.Doctor.AddOrUpdate(x => x.id,
                new Doctor() { id = 1, nombre = "Gonzalo", idTipoDoctor = 1, email = "gonzalo@web.com" },
                new Doctor() { id = 2, nombre = "Alejandro", idTipoDoctor = 2, email = "alejandro@web.com" },
                new Doctor() { id = 3, nombre = "Fabricio", idTipoDoctor = 2, email = "fabricio@web.com" });

            context.Mascota.AddOrUpdate(x => x.id,
                new Mascota() { id = 1, edad = 1, nombre = "Sam", idTipoMascota = 1, idCliente = 1},
                new Mascota() { id = 2, edad = 3, nombre = "Negro", idTipoMascota = 2, idCliente = 2},
                new Mascota() { id = 3, edad = 4, nombre = "Junior", idTipoMascota = 3, idCliente = 3 });

            context.Pago.AddOrUpdate(x => x.id,
                new Pago() { id = 1, idCliente = 1, importe = 100, medioDePago = "efectivo", idMascota = 1 },
                new Pago() { id = 2, idCliente = 2, importe = 500, medioDePago = "tarjeta de credito", idMascota = 2 },
                new Pago() { id = 3, idCliente = 3, importe = 50, medioDePago = "cheque", idMascota = 3 });

            context.TipoDoctor.AddOrUpdate(x => x.id,
                new TipoDoctor() { id = 1, tipoDoctor = "cirujano" },
                new TipoDoctor() { id = 2, tipoDoctor = "general" });

            context.TipoMascota.AddOrUpdate(x => x.id,
                new TipoMascota() { id = 1, tipoMascota = "perro", raza = "labrador" },
                new TipoMascota() { id = 2, tipoMascota = "gato", raza = "persa" },
                new TipoMascota() { id = 3, tipoMascota = "conejo", raza = "europeo" });

            context.Turno.AddOrUpdate(x => x.id,
                new Turno() { id = 1, idDoctor = 1, idPago = 2, idMascota = 2, idSala = 1, idServicio = 1, fecha = 04052019 },
                new Turno() { id = 2, idDoctor = 1, idPago = 1, idMascota = 3, idSala = 1, idServicio = 1, fecha = 05052019 },
                new Turno() { id = 3, idDoctor = 2, idPago = 3, idMascota = 1, idSala = 2, idServicio = 2, fecha = 04052019 });

            context.TipoServicio.AddOrUpdate(x => x.id,
                new TipoServicio() { id = 1, nombreServicio = "vacunacion" },
                new TipoServicio() { id = 2, nombreServicio = "cirugia" },
                new TipoServicio() { id = 3, nombreServicio = "consulta" });

            context.Sala.AddOrUpdate(x => x.id,
                new Sala() { id = 1, nombre = "Sala 1", ubicacion = "A" },
                new Sala() { id = 2, nombre = "Sala 2", ubicacion = "A" },
                new Sala() { id = 3, nombre = "Sala 3", ubicacion = "A" });
        }
    }
}
