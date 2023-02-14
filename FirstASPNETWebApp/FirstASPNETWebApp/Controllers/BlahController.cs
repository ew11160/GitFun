using FirstASPNETWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNETWebApp.Controllers
{
    public class BlahController : Controller // inherits from general controller class
    {
        public IActionResult Index() // index action, with particular view (default is the name at top : Index())
        {
            return View();
        }

        [HttpGet] // attribute attached to our method to distinguish the two types, differentiating between the two
        public IActionResult FanMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FanMail(FanMailModel model)
        {
            return View();
        }
    }
}
