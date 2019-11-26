using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Lokacija
    {
        public string GeografskaSirina { get; set; }
        public string GeografskaDuzina { get; set; }
        public Adresa Adresa { get; set; }

        public Lokacija() { }

        public Lokacija(string sirina, string duzina, Adresa adresa)
        {
            this.GeografskaSirina = sirina;
            this.GeografskaDuzina = duzina;
            this.Adresa = adresa;
        }
    }
}