using System.Collections.Generic;
using System.Linq;

namespace Roads.TW {
    public class City {
        public string Name { get; set; }
        public List<District> Districts { get; set; }

        public District AddDistrict(string districtName) {
            Districts ??= new List<District>();

            districtName = districtName.Replace(Name, string.Empty);

            if (Districts.Any(d => d.Name.Equals(districtName)))
                return Districts.First(d => d.Name.Equals(districtName));

            var district = new District() {Name = districtName};
            Districts.Add(district);

            return Districts.First(d => d.Name.Equals(districtName));;
        }
    }
}
