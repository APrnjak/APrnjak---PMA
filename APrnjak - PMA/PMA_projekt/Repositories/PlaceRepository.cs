using PMA_projekt.DbModels;
using PMA_projekt.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Repositories
{
    public class PlaceRepository
    {
        //mora primiti kontekst baze podataka
        private readonly pma_postContext _dbContext;
        public PlaceRepository(pma_postContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Objekt> GetAll()
        {
            return _dbContext.Objekt
                .Select(x => PlaceMapper.FromDatabase(x));
        }

        public void Save(Models.Objekt objekt)
        {
            var dbObjekt = PlaceMapper.ToDatabase(objekt); //podatak pogodan za bazu
            _dbContext.Objekt.Add(dbObjekt);
            _dbContext.SaveChanges();
        }
    }
}
