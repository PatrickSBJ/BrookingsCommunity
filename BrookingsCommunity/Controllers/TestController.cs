using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BrookingsCommunity.Controllers
{
    public class TestController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public IActionResult PageOne()
        {
            return Content("Demo");
        }
        public String PageTwo()
        {
            return "Test string";
        }
        public StatusCodeResult PageThree()
        {
            return StatusCode(418);
        }
        public FileResult PageFour()
        {
            return File(@"wwwroot\test.txt", "test.txt");
        }
    }
}