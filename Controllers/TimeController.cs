using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TimeDisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        [Route("/Example")]

        public IActionResult Example()
        {
            return View("/Example");
        }
    }
}