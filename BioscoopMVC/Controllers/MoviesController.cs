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

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        }
    }
}
