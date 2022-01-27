using PMA_projekt.DbModels;
using PMA_projekt.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Repositories
{
    public class CityRepository
    {
        //mora primiti kontekst baze podataka
        private readonly pma_postContext _dbContext;
        public CityRepository(pma_postContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Grad> GetAll()
        {
            return _dbContext.Grad
                .Select(x => CityMapper.FromDatabase(x));
        }

        public void Save(Models.Grad grad)
        {
            var dbGrad = CityMapper.ToDatabase(grad);
            _dbContext.Grad.Add(dbGrad);
            _dbContext.SaveChanges();
        }
    }
}
