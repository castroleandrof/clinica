using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Mascota : IEntity
    {
        public Mascota()
        {
        }

        public int id { get; set;}
        public Cliente cliente { get; set; }
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public int idTipoMascota { get; set; }
        public TipoMascota TipoMascota { get; set; }
        public int edad { get; set; }


       public ICollection<Pago> turno { get; set; }

    }

    [MetadataType(typeof(MascotaMetadata))]
    public partial class Mascota
    {
        public class MascotaMetadata
        {
            [Key]
            public int id { get; set; }
            [ForeignKey("idCliente")]
            public int cliente { get; set; }
            [Required]
            public string nombre { get; set; }
            [ForeignKey("idTipoMascota")]
            public TipoMascota TipoMascota { get; set; }
            [Required]
            public int edad { get; set; }
        }
    }
}