using PMA_projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Mappers
{
    public class PlaceMapper
    {
        public static Objekt FromDatabase(DbModels.Objekt objekt)
        {
            return new Objekt(
                objekt.Id,
                objekt.Vlasnik,
                objekt.Objekt1
                );
        }

        public static DbModels.Objekt ToDatabase(Models.Objekt objekt)
        {
            return new DbModels.Objekt
            {
                Id = objekt.Id,
                Vlasnik = objekt.Vlasnik,
                Objekt1 = objekt.Naziv
            };
        }
    }
}
