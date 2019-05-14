using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public class Patient : IEntity
    {
        public Patient()
        {
        }

        public int Id { get; set;}
        public Client Owner { get; private set; }
        public int ClientId { get; set; }
        public String Name { get; set; }

        public static implicit operator Patient(List<Patient> v)
        {
            throw new NotImplementedException();
        }
    }
}