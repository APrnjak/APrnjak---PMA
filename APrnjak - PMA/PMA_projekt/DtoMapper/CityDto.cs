using Newtonsoft.Json.Linq;
using PMA_projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.DtoMapper
{
    public class CityDto
    {
        public static Grad FromJson(JObject json)
        {
            var id = json["id"].ToObject<int>();
            var naziv = json["naziv"].ToObject<string>();

            return new Models.Grad(id, naziv);
        }
    }
}
