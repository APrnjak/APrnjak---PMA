using PMA_projekt.Models;
using PMA_projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Services
{
    public class PlaceService
    {
        private readonly PlaceRepository _placeRepository;
        public PlaceService(PlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public IEnumerable<Models.Objekt> GetAll()
        {
            return _placeRepository.GetAll();
        }
        public void Save(Objekt objekt)
        {
            _placeRepository.Save(objekt);
        }
    }
}
