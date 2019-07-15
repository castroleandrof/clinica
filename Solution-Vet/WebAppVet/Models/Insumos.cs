using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Insumos
    {
        public Insumos() { }

        public int id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }

        public ICollection<VentaInsumos> VentaInsumos { get; set; }

    }

    [MetadataType(typeof(InsumosMetadata))]
    public partial class Insumos
    {
        public class InsumosMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string nombre { get; set; }
            [Required]
            public int precio { get; set; }
        }
    }

}