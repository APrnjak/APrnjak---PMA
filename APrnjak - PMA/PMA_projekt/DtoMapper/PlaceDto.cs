using Newtonsoft.Json.Linq;
using PMA_projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.DtoMapper
{
    public class PlaceDto
    {
        public static Objekt FromJson(JObject json)
        {
            var id = json["id"].ToObject<int>(); //uvijek saljemo i id
            var vlasnik = json["vlasnik"].ToObject<string>();
            var objekt = json["objekt"].ToObject<string>();

            return new Objekt(id, vlasnik, objekt);
        }
    }
}
