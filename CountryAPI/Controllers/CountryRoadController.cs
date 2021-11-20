using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryRoadController : ControllerBase
    {
        private static readonly string[] Countries = new[]
        {
            "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN"
        };

        private readonly ILogger<CountryRoadController> _logger;

        public CountryRoadController(ILogger<CountryRoadController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "CAN";
        }
    }
}
