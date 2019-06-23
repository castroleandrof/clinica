using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Turno : IEntity
    {

        public Turno()
        {

        }
        
        public int id { get; set; }
        public TipoServicio tipoServicio { get; set; }
        public int idServicio { get; set; }
        public int fecha { get; set; }
        public Mascota mascota { get; set; }
        public int idMascota { get; set; }
        public Doctor doctor { get; set; }
        public int idDoctor { get; set; }
        public int idSala { get; set; }
        public Sala sala { get; set; }
        public int idPago { get; set; }
        public Pago pago { get; set; }
    }

    [MetadataType(typeof(TurnoMetadata))]
    public partial class Turno
    {
        public class TurnoMetadata
        {
            [Key]
            public int id { get; set; }
            [ForeignKey("idServicio")]
            public TipoServicio tipoServicio { get; set; }
            [Required]
            public int fecha { get; set; }
            [ForeignKey("idMascota")]
            public Mascota mascota { get; set; }
            [ForeignKey("idDoctor")]
            public Doctor doctor { get;set; }
            [ForeignKey("idSala")]
            public Sala sala { get; set; }
            [ForeignKey("idPago")]
            public Pago pago { get; set; }
        }
    }
}