using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class VentaInsumos
    {
        public VentaInsumos() { }

        public int id { get; set; }
        public Venta Venta { get; set; }
        public int idVenta { get; set; }
        public Insumos insumo { get; set; }
        public int idInsumo { get; set; }
        public int cantidad { get; set; }
    }

    [MetadataType(typeof(VentaInsumosMetadata))]
    public partial class VentaInsumos
    {
        public class VentaInsumosMetadata
        {
            [Key]
            public int id { get; set; }
            [ForeignKey("idVenta")]
            public Venta Venta { get; set; }
            [ForeignKey("idInsumo")]
            public Insumos insumo { get; set; }
            [Required]
            public int cantidad { get; set; }

        }
    }
}