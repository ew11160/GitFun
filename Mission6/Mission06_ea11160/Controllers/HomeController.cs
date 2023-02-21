using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_ea11160.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ea11160.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryContext _context { get; set; }

        public HomeController(MovieEntryContext someName)
        {
            _context = someName;
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
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieEntryModel newMovie)
        {
            if (ModelState.IsValid) // verify the model is valid b4 we put in db
            {
                _context.Add(newMovie);
                _context.SaveChanges();
                return View("Confirmation", newMovie);
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = _context.MovieEntries
                .Include(x => x.Category)
                //.Where()
                //.OrderBy()
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var movie = _context.MovieEntries.Single(x => x.MovieID == movieid);
            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntryModel movieentry)
        {
            _context.Update(movieentry);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = _context.MovieEntries.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntryModel movieentry)
        {
            _context.MovieEntries.Remove(movieentry);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
