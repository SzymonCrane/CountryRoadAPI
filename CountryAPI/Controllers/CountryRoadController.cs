using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace CountryAPI.Controllers
{
    [ApiController]
    public class CountryRoadController : ControllerBase
    {
        private static readonly string[] ListOfCountries = new[]
        {
            "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN"
        };

        private readonly ILogger<CountryRoadController> _logger;

        public CountryRoadController(ILogger<CountryRoadController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{roadTo}")]
        public JsonDocument GetJson(string roadTo)
        {
            var destination = new CountryRoad();
            if (roadTo == "CAN")
            {
            destination = new CountryRoad{
                Destination = roadTo,
                Countries = { ListOfCountries[1], ListOfCountries[0] }
            };
            }
            var destinationJson = JsonDocument.Parse(JsonSerializer.Serialize(destination));
            return destinationJson;
        }
    }
}
