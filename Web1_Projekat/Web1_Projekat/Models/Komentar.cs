using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Komentar
    {
        public Korisnik Gost { get; set; }
        public Apartman Apartman { get; set; }
        public string Tekst { get; set; }
        public int Ocena { get; set; }

        public Komentar() { }

        public Komentar(Korisnik gost, Apartman apartman, string tekst, int ocena)
        {
            this.Gost = gost;
            this.Apartman = apartman;
            this.Tekst = tekst;
            this.Ocena = ocena;
        }
    }
}