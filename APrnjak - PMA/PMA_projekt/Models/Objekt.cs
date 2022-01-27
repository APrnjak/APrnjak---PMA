using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Models
{
    public class Objekt
    {
        public int Id { get; set; }
        public string Vlasnik { get; set; }
        public string Naziv { get; set; }

        public Objekt(int id, string vlasnik, string naziv)
        {
            this.Id = id;
            this.Vlasnik = vlasnik;
            this.Naziv = naziv;
        }
    }
}
