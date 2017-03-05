using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class ExtraController : Controller
    {
        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Extra/Welcome/ 
        // GET: /Extra/Welcome?name=Peter => Hello Peter
        // GET: /Extra/Welcome?name=Peter&numtimes=2 => Hello Peter Hellow Peter

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
        //public string Welcome(string name, int numTimes=1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}
        public IActionResult Hello(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        /// <summary>
        /// Konventionen ger i underförstådd mening i bakgrunden att return View() visar Partners.cshtml sidan. 
        /// Det går fint att skriva return View("Partners") också (enligt samtalet med Oscar).
        /// </summary>
        /// <returns>View("Partners")</returns>
        public IActionResult Partners()
        {
            return View();
        }

        public IActionResult Numbers(int min = 1, int max = 1)
        {
            ViewData["Min"] = min;
            ViewData["Max"] = max;

            return View();
        }
    }
}
