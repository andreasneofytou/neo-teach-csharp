namespace Teach.Models {
    public class Address {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public Town Town { get; set; }
    }
}
