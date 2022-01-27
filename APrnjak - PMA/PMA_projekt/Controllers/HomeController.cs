using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PMA_projekt.Models;

namespace PMA_projekt.Controllers
{
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
            private readonly UserManager<IdentityUser> _userManager;  //trba nam za logiranje i registraciju
            private readonly SignInManager<IdentityUser> _signInManager;  //trba nam za logiranje i registraciju

        public HomeController(ILogger<HomeController> logger,
                UserManager<IdentityUser> userManager,
                SignInManager<IdentityUser> signInManager)
            {
                _logger = logger;
                this._userManager = userManager;
                this._signInManager = signInManager;
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }





            //kada pristupino sadrzaju kojem ne smijemo prikazat ce nam se ovo
            public IActionResult AccessDenied()
            {
                return View();
            }

            public IActionResult Login()  //prikaz samo stranice
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Login(string email, string password)  //kada kliknemo dugne saljemo podatke pa ovisno o uspijehu/neuspijehu logiranja prikaz ce se sadrzaj
            {
                //login funkcionalnost
                //pronadi korisnika 
                var user = await _userManager.FindByEmailAsync(email);

                if (user != null)
                {
                    //sign in
                    var SignInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
                    if (SignInResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }

                //ako ne postoji taj korisnik onda ga odvedi na page za registraciju
                return RedirectToAction("Register");
            }

            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Register(string email, string username, string password)  //ovi podaci stizu kroz http post metodu u viewu; podaci moraju odgovarati atributu name
            {
                //registracija funkcionalnost
                //create a user
                var user = new IdentityUser
                {
                    UserName = username,
                    Email = email,
                };

                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    //sign user in
                    var SignInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
                    if (SignInResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }

                return RedirectToAction("Register");
            }

            [HttpPost]
            public async Task<IActionResult> LogOut()
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            }
        }
    }
