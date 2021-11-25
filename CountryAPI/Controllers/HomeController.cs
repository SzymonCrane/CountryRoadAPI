using Microsoft.AspNetCore.Mvc;

namespace CountryAPI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok("10.5");
        }
    }
}
