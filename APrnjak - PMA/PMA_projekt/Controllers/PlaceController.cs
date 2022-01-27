using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PMA_projekt.Controllers
{
    public class PlaceController : Controller
    {
        public IActionResult Place()  //sluze za prikaz nekog sadrzaja tj. Viewa
        {
            return View();
        }
    }
}
