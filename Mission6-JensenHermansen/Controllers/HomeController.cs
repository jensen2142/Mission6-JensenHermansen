using Microsoft.AspNetCore.Mvc;
using Mission6_JensenHermansen.Models;
using System.Diagnostics;

namespace Mission6_JensenHermansen.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KnowJoel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCollection()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCollection(Application response)
        {
            _context.Applications.Add(response); //add record to the database
            _context.SaveChanges();
            
            return View("return" ,response);
        }

    }
}
