using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Sala
    {
        public Sala() { }

        public int id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }

        public ICollection<Turno> turno { get; set; }
    }

    [MetadataType(typeof(SalaMetadata))]
    public partial class Sala
    {
        public class SalaMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string nombre { get; set; }
            [Required]
            public int ubicacion { get; set; }
        }
    }
}