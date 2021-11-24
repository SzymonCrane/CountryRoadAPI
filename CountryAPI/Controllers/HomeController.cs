using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryAPI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("10.5");
        }
    }
}
