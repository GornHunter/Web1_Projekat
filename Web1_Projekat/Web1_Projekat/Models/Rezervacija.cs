using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Rezervacija
    {
        public Apartman Apartman { get; set; }
        public string PocetniDatumRezervacije { get; set; }
        public int BrojNocenja { get; set; }
        public double UkupnaCena { get; set; }
        public Korisnik Gost { get; set; }
        public StatusRezervacije StatusRezervacije { get; set; }

        public Rezervacija()
        {
            this.BrojNocenja = 1;
        }

        public Rezervacija(Apartman apartman, string pocetniDatumRezervacije, int brojNocenja, double ukupnaCena, Korisnik gost,StatusRezervacije statusRezervacije)
        {
            this.Apartman = apartman;
            this.PocetniDatumRezervacije = pocetniDatumRezervacije;
            this.BrojNocenja = brojNocenja;
            this.UkupnaCena = ukupnaCena;
            this.Gost = gost;
            this.StatusRezervacije = statusRezervacije;
        }
    }
}