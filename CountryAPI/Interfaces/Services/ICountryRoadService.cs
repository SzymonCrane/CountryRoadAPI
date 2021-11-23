using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryAPI.Interfaces.Services
{
    public interface ICountryRoadService
    {
        List<string> GetDirection(string roadTo);
    }
}
