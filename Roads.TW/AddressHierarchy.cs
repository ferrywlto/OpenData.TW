using System.Collections.Generic;
using System.Linq;

namespace Roads.TW {
    public class AddressHierarchy {
        public List<City> Cities { get; set; }

        public City AddCity(string cityName) {
            Cities ??= new List<City>();

            if (Cities.Any(c => c.Name.Equals(cityName)))
                return Cities.First(c => c.Name.Equals(cityName));

            var city = new City() { Name = cityName};
            Cities.Add(city);

            return Cities.First(c => c.Name.Equals(cityName));;
        }
    }
}
