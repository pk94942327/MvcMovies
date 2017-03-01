using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Konventionen ger i underförstådd mening i bakgrunden att return View() visar Index.cshtml sidan. Det går fint att skriva return View("Index") också.
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View(); //Konventionen ger i underförstådd mening i bakgrunden att return View() visar Abaout.cshtml sidan. Det går fint att skriva return View("Abaout") också.
            
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(); //Konventionen ger i underförstådd mening i bakgrunden att return View() visar Contact.cshtml sidan. Det går fint att skriva return View("Contact") också.
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
