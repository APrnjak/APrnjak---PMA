using System;
using System.Collections.Generic;

namespace PMA_projekt.DbModels
{
    public partial class Grad
    {
        public Grad()
        {
            Objava = new HashSet<Objava>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Objava> Objava { get; set; }
    }
}
