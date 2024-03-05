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
            if(ModelState.IsValid)
            {
                _context.Applications.Add(response); //add record to the database
                _context.SaveChanges();
            
                return View("return" ,response);
            }
            else
            {
                return View(response);
            }

        }
        public IActionResult MovieList()
        {
            var applications =_context.Applications
                .OrderBy(x => x.Title).ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Applications
                .Single(x => x.ApplicationId == id);

            return View("AddCollection", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Applications
                .Single(x => x.ApplicationId==id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Application app)
        {
            _context.Applications.Remove(app);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
