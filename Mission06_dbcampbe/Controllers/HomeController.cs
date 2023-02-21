using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_dbcampbe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dbcampbe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Set it as variable to live outside of just the Home Controller Constructor
        private MovieContext _context { get; set; }

        //Contstructor
        public HomeController(ILogger<HomeController> logger, MovieContext x )
        {
            _logger = logger;
            _context = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(Movie m)
        {
            //Add the movie object and save it to store it in the database
            _context.Add(m);
            _context.SaveChanges();

            //Didn't feel the need to reroute to a confirmation page
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
    }
}
