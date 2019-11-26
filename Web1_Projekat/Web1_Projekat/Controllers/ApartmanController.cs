using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1_Projekat.Models;

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

        [HttpPost]
        public ActionResult Registracija(Korisnik k)
        {
            UpisiKorisnikaTxt(k);

            return RedirectToAction("Index", "Apartman");
        }

        public void UpisiKorisnikaTxt(Korisnik k)
        {
            string text = $"{k.KorisnickoIme}-{k.Lozinka}-{k.Ime}-{k.Prezime}-{k.Pol}-{k.Uloga}";

            using (StreamWriter sw = new StreamWriter("../gosti.txt", true))
            {
                sw.WriteLine(text);
            }
        }
    }
}