namespace SchedulerApp.Entities
{
    public class Address : Entity
    {
        public required int addressId { get; set; }
        public required string address { get; set; }
        public required string address2 { get; set; }
        public required int cityId { get; set; }
        public required string postalCode { get; set; }
        public required string phone { get; set; }
    }
}
