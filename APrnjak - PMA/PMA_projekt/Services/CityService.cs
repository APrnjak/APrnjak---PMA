using PMA_projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Services
{
    public class CityService
    {
        private readonly CityRepository _cityRepository;
        public CityService(CityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IEnumerable<Models.Grad> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public void Save(Models.Grad grad)
        {
            _cityRepository.Save(grad);
        }
    }
}
