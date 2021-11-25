using CountryAPI.Interfaces.Repositories;
using CountryAPI.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace CountryAPI.Services
{
    public class CountryRoadService : ICountryRoadService
    {
        private ICountryRoadRepository countryRoadRepository { get; set; }
        public CountryRoadService(ICountryRoadRepository countryRoadRepo)
        {
            countryRoadRepository = countryRoadRepo;
        }
        public List<string> GetDirection(string roadTo)
        {
            var countries = countryRoadRepository.GetCountries();
            var usaIndex = countries.IndexOf("USA");
            var searchingIndex = countries.IndexOf(roadTo);
            
            if(usaIndex < searchingIndex)
            {
                return countries.Skip(usaIndex).Take(searchingIndex - usaIndex + 1).ToList();
            }

            return countries.Skip(searchingIndex).Take(usaIndex - searchingIndex).ToList();
        }
    }
}
