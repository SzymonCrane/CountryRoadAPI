using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryAPI.Interfaces.Repositories
{
    public interface ICountryRoadRepository
    {
        List<string> GetCountries();
    }
}
