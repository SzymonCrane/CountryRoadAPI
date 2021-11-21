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
        public ActionResult<CountryRoad> GetJson(string roadTo)
        {
            if (roadTo == "CAN")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string> {
                    "USA",
                    "CAN"
                }
                };
                //Console.Write(destination);
                //var destinationJson = JsonDocument.Parse(JsonSerializer.Serialize(destination));
                return destination;
            }
            else if (roadTo == "MEX")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX"
                    }
                };
                return destination;
            }
            else if (roadTo == "BLZ")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "BLZ"
                    }
                };
                return destination;
            }
            else if (roadTo == "GTM")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "GTM"
                    }
                };
                return destination;
            }
            else if (roadTo == "SLV")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "GTM",
                        "SLV"
                    }
                };
                return destination;
            }
            else if (roadTo == "HND")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "GTM",
                        "HND"
                    }
                };
                return destination;
            }
            else if (roadTo == "NIC")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "GTM",
                        "HND",
                        "NIC"
                    }
                };
                return destination;
            }
            else if (roadTo == "CRI")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "GTM",
                        "HND",
                        "NIC",
                        "CRI"
                    }
                };
                return destination;
            }
            else if (roadTo == "PAN")
            {
                var destination = new CountryRoad
                {
                    Destination = roadTo,
                    Countries = new List<string>
                    {
                        "USA",
                        "MEX",
                        "GTM",
                        "HND",
                        "NIC",
                        "CRI",
                        "PAN"
                    }
                };
                return destination;
            }
            else
            {
                return NotFound();
            }
        }
    }
}
