using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppVet.Data;

namespace WebAppVet.Controllers
{
    public class SalaController : Controller
    {
        private ClinicaDbContext db = new ClinicaDbContext();
        // GET: Sala
        public ActionResult Index()
        {
            var Salas = db.Sala.ToList();
            return View(Salas);
        }
    }
}