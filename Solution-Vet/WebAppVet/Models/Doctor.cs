using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Doctor : IEntity
    {
        public Doctor()
        {
            
        }

        public int id { get; set; }
        public String nombre { get; set; }
        public string email { get; set; }
        public int idTipoDoctor { get; set; }
        public TipoDoctor tipoDoctor { get; set; }

        public ICollection<Turno> turno { get; set; }


        
    }

    [MetadataType(typeof(DoctorMetadata))]
    public partial class Doctor
    {
        public class DoctorMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string nombre { get; set; }
            [Required]
            public string email { get; set; }
            [ForeignKey("idTipoDoctor")]
            public TipoDoctor tipoDoctor { get; set; }
        }
    }
}