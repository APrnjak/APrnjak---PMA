using Newtonsoft.Json.Linq;
using PMA_projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.DtoMapper
{
    public class PostDto
    {
        public static Objava FromJson(JObject json)
        {
            var id = json["id"].ToObject<int>(); //uvijek saljemo i id
            var sadrzaj = json["sadrzaj"].ToObject<string>();
            var datum = json["datum"].ToObject<string>();
            var gradId = json["grad"].ToObject<int>();
            var objektId = json["objekt"].ToObject<int>();

            var grad = new Grad(gradId, "");    //treba nam samo ID;ostali podaci nam nisu bitni pa stavljamo "" ili 0 u slucaju int vrijednosti
            var objekt = new Objekt(objektId, "", "");

            return new Objava(id, sadrzaj, datum, grad, objekt);
        }
    }
}
