using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private DateApplicationContext daContext { get; set; }
        // Constructor
        public HomeController(DateApplicationContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        //// example of returning a view with a different name
        [HttpGet]
        public IActionResult DatingApplication()
        {
            ViewBag.Majors = daContext.Majors.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else // if invalid
            {
                ViewBag.Majors = daContext.Majors.ToList();
                return View(ar);
            }
        }
        [HttpGet]
        public IActionResult WaitList()
        {
            // pulling from responses table, send to list format
            var applications = daContext.Responses
                .Include(x => x.Major)
                // filtering data
                //.Where(blah => blah.CreeperStalker == false)
                .OrderBy( x=> x.LastName)
                .ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Majors = daContext.Majors.ToList();
            var application = daContext.Responses.Single(x => x.ApplicationID == applicationid);
            // pass the model we just made to the view
            return View("DatingApplication", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse appRes)
        {
            daContext.Update(appRes);
            daContext.SaveChanges();
            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = daContext.Responses.Single(x => x.ApplicationID == applicationid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("WaitList");
        }
    }
}
