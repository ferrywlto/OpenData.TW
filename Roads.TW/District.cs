using System.Collections.Generic;

namespace Roads.TW {
    public class District {
        public string Name { get; set; }
        public List<string> Roads { get; set; }

        public void AddRoad(string roadName) {
            Roads ??= new List<string>();
            Roads.Add(roadName);
        }
    }
}
