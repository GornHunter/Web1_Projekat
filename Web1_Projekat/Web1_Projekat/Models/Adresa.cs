using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Adresa
    {
        public string Ulica { get; set; }
        public string Broj { get; set; }
        public string NaseljenoMesto { get; set; }
        public string PostanskiBrojMesta { get; set; }

        public Adresa() { }

        public Adresa(string ulica, string broj, string naseljenoMesto, string postanskiBrojMesta)
        {
            this.Ulica = ulica;
            this.Broj = broj;
            this.NaseljenoMesto = naseljenoMesto;
            this.PostanskiBrojMesta = postanskiBrojMesta;
        }
    }
}