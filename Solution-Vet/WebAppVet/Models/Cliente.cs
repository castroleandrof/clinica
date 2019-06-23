using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Cliente : IEntity
    {
        public Cliente()
        {

        }

        public int id { get; set; }
        public String nombre { get; set; }
        public String email { get; set; }


        public IList<Mascota> mascotas { get; private set; }
    }

    [MetadataType(typeof(ClientMetadata))]
    public partial class Cliente
    {
        public class ClientMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string nombre { get; set; }
            [Required]
            public int email { get; set; }
            
        }

    }
}