using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Venta
    {
        public Venta() { }

        public int id { get; set; }
        public Cliente cliente { get; set; }
        public int idCliente { get; set; }
        public Pago pago { get; set; }
        public int idPago { get; set; }

    }

    [MetadataType(typeof(VentaMetadata))]
    public partial class Venta
    {
        public class VentaMetadata
        {
            [Key]
            public int id { get; set; }
            [ForeignKey("idCliente")]
            public Cliente cliente { get; set; }
            [ForeignKey("idPago")]
            public Pago pago { get; set; }
        }
    }
}