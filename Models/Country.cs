namespace Dropdowns.Models
{
    public class Country 
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int ContinentID { get; set; }
        public Continent Continent { get; set; }
    }
}