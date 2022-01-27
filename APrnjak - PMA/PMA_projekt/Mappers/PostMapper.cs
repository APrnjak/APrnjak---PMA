using PMA_projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Mappers
{
    public class PostMapper
    {
        public static Objava FromDatabase(DbModels.Objava objava)
        {
            return new Objava(
                objava.Id,
                objava.Sadrzaj,
                objava.Datum,
                CityMapper.FromDatabase(objava.Grad),  //mapper koji vraca podatke o gradu (id i naziv)
                PlaceMapper.FromDatabase(objava.Objekt)
                );
        }

        public static DbModels.Objava ToDatabase(Models.Objava objava)
        {
            return new DbModels.Objava
            {
                Id = objava.Id,
                Sadrzaj = objava.Sadrzaj,
                Datum = objava.Datum,
                ObjektId = objava.Objekt.Id,  //ovdje imamo upisan samo id, naziv smo stavili kako prazan string
                GradId = objava.Grad.Id
            };
        }
    }
}
