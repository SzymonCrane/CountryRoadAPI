using CountryAPI.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryAPI.Repositories
{
    public class CountryRoadRepository : ICountryRoadRepository
    {
        private static readonly string[] ListOfCountries = new[]
        {
            "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN"
        };
        public List<string> GetCountries(){
            return ListOfCountries.ToList();
        }
    }
}
