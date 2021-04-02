using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BioscoopMVC.Controllers
{
    public class MoviesController : Controller
    {
        // 
        // GET: /Movie/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Movie/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
