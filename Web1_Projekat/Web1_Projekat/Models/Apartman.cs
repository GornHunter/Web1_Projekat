using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Apartman
    {
        public TipApartmana TipApartmana { get; set; }
        public int BrojSoba { get; set; }
        public int BrojGostiju { get; set; }
        public Lokacija Lokacija { get; set; }
        public List<DateTime> DatumiZaIzdavanje { get; set; }
        public List<DateTime> Dostupnost { get; set; }
        public Domacin Domacin { get; set; }
        public List<Komentar> Komentari { get; set; }
        public List<string> Slike { get; set; }
        public double Cena { get; set; }
        public string VremeZaPrijavu { get; set; }
        public string VremeZaOdjavu { get; set; }
        public StatusApartmana StatusApartmana { get; set; }
        public List<SadrzajApartmana> SadrzajApartmana { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }

        public Apartman()
        {
            this.DatumiZaIzdavanje = new List<DateTime>();
            this.Dostupnost = new List<DateTime>();
            this.Komentari = new List<Komentar>();
            this.Slike = new List<string>();
            this.VremeZaPrijavu = "2PM";
            this.VremeZaOdjavu = "10AM";
            this.StatusApartmana = StatusApartmana.NEAKTIVNO;
            this.SadrzajApartmana = new List<SadrzajApartmana>();
            this.Rezervacije = new List<Rezervacija>();
        }
    }
}