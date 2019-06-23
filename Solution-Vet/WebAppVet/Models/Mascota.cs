using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int ClientId { get; set; }
        public string nombre { get; set; }
        public int idTipoMascota { get; set; }
        public int edad { get; set; }


        public static implicit operator Mascota(List<Mascota> v)
        {
            throw new NotImplementedException();
        }


    }

    [MetadataType(typeof(MascotaMetadata))]
    public partial class Mascota
    {
        public class MascotaMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string ClientId { get; set; }
            [Required]
            public string nombre { get; set; }
            [Required]
            public int idTipoMascota { get; set; }
            [Required]
            public int edad { get; set; }
        }
    }
}