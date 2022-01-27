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
    [Route("api/city")]
    [ApiController]
    public class CityApiController : ControllerBase
    {
        private CityService _cityService;
        public CityApiController(CityService cityService) //konstruktor naseg API-a
        {
            _cityService = cityService;
        }

        [HttpGet]
        public ActionResult<List<Grad>> Get()
        {
            return _cityService.GetAll().ToList();
        }

        [HttpPost("save")]
        public ActionResult Save([FromBody] JObject json)
        {
            var city = CityDto.FromJson(json);
            _cityService.Save(city);
            return Ok();
        }
    }
}
