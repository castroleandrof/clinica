using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Pago
    { 
        public Pago() { }

        public int id { get; set; }
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }
        public int importe { get; set; }
        public string medioDePago { get; set; }

        public ICollection<Turno> turno { get; set; }
        
    }

    [MetadataType(typeof(PagoMetadata))]
    public partial class Pago
    {
        public class PagoMetadata
        {
            [Key]
            public int id { get; set; }
            [ForeignKey("idCliente")]
            public Cliente cliente { get; set; }
            [Required]
            public int importe { get; set; }
            [Required]
            public int medioDePago { get; set; }
        }
    }
}