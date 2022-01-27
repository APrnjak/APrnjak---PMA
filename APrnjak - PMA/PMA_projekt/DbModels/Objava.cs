using System;
using System.Collections.Generic;

namespace PMA_projekt.DbModels
{
    public partial class Objava
    {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public string Datum { get; set; }
        public int ObjektId { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Objekt Objekt { get; set; }
    }
}
