using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class TipoDoctor : IEntity
    {
        public TipoDoctor()
        {
            //Patient Patients = new List<Patient>();
        }

        public int id { get; set; }
        public string tipoDoctor { get; set; }

        public IList<Doctor> doctor { get; private set; }
    }

    [MetadataType(typeof(TipoDoctor))]
    public partial class TipoDoctor
    {
        public class EspecieMetadata
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string tipoDoctor { get; set; }
        }
    }


}