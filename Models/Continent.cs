using System.Collections.Generic;

namespace Dropdowns.Models
{
    public class Continent
    {
        public int ContinentID { get; set; }
        public string ContinentName { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}