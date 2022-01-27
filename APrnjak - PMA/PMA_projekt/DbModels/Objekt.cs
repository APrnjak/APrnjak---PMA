using System;
using System.Collections.Generic;

namespace PMA_projekt.DbModels
{
    public partial class Objekt
    {
        public Objekt()
        {
            Objava = new HashSet<Objava>();
        }

        public int Id { get; set; }
        public string Vlasnik { get; set; }
        public string Objekt1 { get; set; }

        public virtual ICollection<Objava> Objava { get; set; }
    }
}
