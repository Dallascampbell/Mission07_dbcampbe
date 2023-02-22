using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //Set it as variable to live outside of just the Home Controller Constructor
        private MovieContext _context { get; set; }

        //Contstructor
        public HomeController(MovieContext x)
        {
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
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(Movie m)
        {

            if (ModelState.IsValid) //if Vlaid
            {
                //Add the movie object and save it to store it in the database
                _context.Add(m);
                _context.SaveChanges();

                //Didn't feel the need to reroute to a confirmation page
                return View("Confirmation");
            }
            else //If invalid
            {
                ViewBag.Categories = _context.Categories.ToList();

                return View(m);
            }

        }

        public IActionResult MovieList()
        {
            var movielist = _context.Movies
                .Include(x => x.Category)
                .ToList();

            return View(movielist);
        }
        [HttpGet]
        public IActionResult Edit(int movieId)
        {
            ViewBag.Categories = _context.Categories.ToList();

            var movie = _context.Movies.Single(x => x.MovieId == movieId);

            return View("MovieEntry", movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            _context.Update(m);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieId)
        {
            var movie = _context.Movies.Single(x => x.MovieId == movieId);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie m)
        {
            _context.Movies.Remove(m);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
