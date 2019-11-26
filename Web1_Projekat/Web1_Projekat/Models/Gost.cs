using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class Gost : Korisnik
    {
        public List<Apartman> IznajmljeniApartmani { get; set; }

        public Gost()
        {
            this.IznajmljeniApartmani = new List<Apartman>();
        }
    }
}