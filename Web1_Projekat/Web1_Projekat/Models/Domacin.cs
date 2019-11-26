using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Domacin : Korisnik
    {
        public List<Apartman> ApartmaniZaIzdavanje { get; set; }

        public Domacin()
        {
            this.ApartmaniZaIzdavanje = new List<Apartman>();
        }
    }
}