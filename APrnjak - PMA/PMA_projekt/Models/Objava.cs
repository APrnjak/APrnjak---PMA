using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Models
{
    public class Objava
    {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public string Datum { get; set; }  //string formata 02.05.2020
        public Grad Grad { get; set; }
        public Objekt Objekt { get; set; }

        public Objava(int id, string sadrzaj, string datum, Grad grad, Objekt objekt)
        {
            Id = id;
            Sadrzaj = sadrzaj;
            Datum = datum;
            Grad = grad;
            Objekt = objekt;
        }
    }
}
