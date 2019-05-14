using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public class Doctor : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
    }
}