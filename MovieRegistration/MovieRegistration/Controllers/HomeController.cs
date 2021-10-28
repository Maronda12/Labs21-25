using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View(new Movie());
        }
        public IActionResult MovieDisplay(Movie film)
        {
            if (ModelState.IsValid)
            {
                return View(film);
            }
            else
            {
                return View("Registration", film);
            }
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
    }
}
