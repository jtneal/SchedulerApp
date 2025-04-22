namespace SchedulerApp.Entities
{
    public class Customer : Entity
    {
        public int customerId { get; set; }
        public required string customerName { get; set; }
        public required int addressId { get; set; }
        public required int active { get; set; }
    }
}
