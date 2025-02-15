using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieContext _context;
        public HomeController(AddMovieContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        // Display the form (GET)
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // Handle form submission (POST)
        [HttpPost]
        public IActionResult AddMovie(Application model)
        {
            if (ModelState.IsValid)
            {
                //_context.Movies.Add(model);  // Save movie to database
                //_context.SaveChanges(); //commit changes
                //return RedirectToAction("Index"); // Redirect to movie list page
            }

            return View("AddMovie", model);  // Re-render the form with validation errors
        }


    }
}
