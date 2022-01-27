using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PMA_projekt.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Post()   //sluze za prikaz nekog sadrzaja tj. Viewa
        {
            return View();
        }

        public IActionResult AddPost()
        {
            return View();
        }

        public IActionResult UpdatePost()
        {
            return View();
        }
    }
}
