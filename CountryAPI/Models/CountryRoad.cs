using System.Collections.Generic;

namespace CountryAPI
{
    public class CountryRoad
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public List<string> Countries { get; set; }        
    }
    
}
