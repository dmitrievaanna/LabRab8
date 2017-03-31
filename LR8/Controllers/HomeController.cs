using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LR8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult first()
        {
            return View();
        }

        public IActionResult second()
        {
            ViewData["Message"] = "This is second page";

            return View();
        }

        public IActionResult third()
        {
            ViewData["Message"] = "This is third page";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult contResTime()

        {
            return Content(DateTime.Now.ToString());
        }

    }
}
