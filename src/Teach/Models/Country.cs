using System.Collections.Generic;

namespace Teach.Models {
    public class Country {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Town> Towns { get; set; }
    }
}
