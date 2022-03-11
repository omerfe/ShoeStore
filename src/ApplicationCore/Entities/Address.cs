namespace ApplicationCore.Entities
{
    public class Address
    {
        public Address()
        {
        }
        public Address(string street, string state, string zipCode, string city, string country)
        {
            Street = street;
            State = state;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}