using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public class Client : IEntity
    {
        public Client()
        {
            Patient Patients = new List<Patient>();
        }

        public int Id { get; set; }
        public String FullName { get; set; }
        public String email { get; set; }

        public IList<Patient> Patients { get; private set; }
    }
}