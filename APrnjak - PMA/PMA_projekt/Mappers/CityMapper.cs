using PMA_projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Mappers
{
    public class CityMapper
    {
        public static Grad FromDatabase(DbModels.Grad grad)
        {
            return new Grad(
                grad.Id,
                grad.Naziv
                );
        }

        public static DbModels.Grad ToDatabase(Models.Grad grad)
        {
            return new DbModels.Grad
            {
                Id = grad.Id,
                Naziv = grad.Naziv
            };
        }
    }
}
