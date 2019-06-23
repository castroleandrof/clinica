using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class TipoServicio : IEntity
    {
        public TipoServicio() { }

        public int id { get; set; } 
        public int nombreServicio { get; set; }
        public ICollection<Turno> Turno { get; set; }

    }


    [MetadataType(typeof(TipoServicioMetadata))]
    public partial class TipoServicio
    {
        public class TipoServicioMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public int nombreServicio { get; set; }
        }
    }
}