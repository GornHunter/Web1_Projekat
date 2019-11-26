using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web1_Projekat.Controllers
{
    public class ApartmanController : Controller
    {
        // GET: Apartman
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registracija()
        {
            return View();
        }
    }
}