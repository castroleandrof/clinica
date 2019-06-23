using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class TipoMascota : IEntity
    {
        public TipoMascota() { }

        public int id { get; set; }
        public string raza { get; set; }
        public string tipoMascota { get; set; }

        public ICollection<Mascota> mascota { get; set; }
    }

    [MetadataType(typeof(TipoMascotaMetadata))]
    public partial class TipoMascota
    {
        public class TipoMascotaMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string raza { get; set; }
            [Required]
            public string tipoMascota { get; set; }
        }
    }
}