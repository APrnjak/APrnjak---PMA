using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Models
{
    public class Grad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Grad(int id, string naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
        }
    }
}
