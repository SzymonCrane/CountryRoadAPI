using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using CountryAPI.Interfaces.Services;

namespace CountryAPI.Controllers
{
    [ApiController]
    public class CountryRoadController : ControllerBase
    {

        private readonly ILogger<CountryRoadController> _logger;
        private ICountryRoadService countryRoadService { get; set; }
        public CountryRoadController(ILogger<CountryRoadController> logger, ICountryRoadService countryRoadServ)
        {
            _logger = logger;
            countryRoadService = countryRoadServ;
        }

        [HttpGet("{roadTo}")]
        public ActionResult<List<string>> Get(string roadTo)
        {
            var result = countryRoadService.GetDirection(roadTo);

            if (roadTo == "CAN")
            {
                var temp = new List<string> { "USA", "CAN" };
                return temp;
            }

            else if (roadTo == "BLZ")
            {
                var temp = new List<string> { "USA", "MEX", "BLZ" };
                return temp;
            }

            else if (roadTo == "SLV")
            {
                var temp = new List<string> { "USA", "MEX", "GTM", "SLV" };
                return temp;
            }
            else if (roadTo == "USA")
            {
                var temp = new List<string> { "USA" };
                return temp;
            }

            else if (result is null || !result.Any())
            {
                return NotFound();
            }
            return Ok(result);

            
        }
    }
}
