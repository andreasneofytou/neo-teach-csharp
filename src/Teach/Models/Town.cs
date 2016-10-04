namespace Teach.Models {
    public class Town {
        public int TownId { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
