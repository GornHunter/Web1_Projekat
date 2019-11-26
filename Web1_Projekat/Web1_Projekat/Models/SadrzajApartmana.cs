using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1_Projekat.Models
{
    public class SadrzajApartmana
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public SadrzajApartmana() { }

        public SadrzajApartmana(int id, string naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }
    }
}