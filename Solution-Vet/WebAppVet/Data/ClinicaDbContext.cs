using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppVet.Models;
namespace WebAppVet.Data
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext():base("ClinicaDbContext")
        {

        }
        
    public DbSet<Sala> Sala { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Mascota> Mascota { get; set; }
    public DbSet<Pago> Pago { get; set; }
    public DbSet<TipoDoctor> TipoDoctor { get; set; }
    public DbSet<TipoMascota> TipoMascota { get; set; }
    public DbSet<TipoServicio> TipoServicio { get; set; }
    public DbSet<Turno> Turno { get; set; }
    public DbSet<Venta> Venta{ get;  set; }
    public DbSet<VentaInsumos> VentaInsumos {get;set;}
    public DbSet<Insumos> Insumos { get; set; }
    }
}