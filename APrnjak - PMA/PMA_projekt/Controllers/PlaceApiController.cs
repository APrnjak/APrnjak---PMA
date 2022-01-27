using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PMA_projekt.DtoMapper;
using PMA_projekt.Models;
using PMA_projekt.Services;

namespace PMA_projekt.Controllers
{
    [Route("api/place")]
    [ApiController]
    public class PlaceApiController : ControllerBase
    {
        private PlaceService _placeService;
        public PlaceApiController(PlaceService placeService) //konstruktor naseg API-a
        {
            _placeService =placeService;
        }

        [HttpGet]
        public ActionResult<List<Objekt>> Get()
        {
            return _placeService.GetAll().ToList();
        }

        [HttpPost("save")]
        public ActionResult Save([FromBody] JObject json)
        {
            var objekt = PlaceDto.FromJson(json);
            _placeService.Save(objekt);
            return Ok();
        }
    }
}
