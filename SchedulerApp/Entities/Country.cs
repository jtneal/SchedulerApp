namespace SchedulerApp.Entities
{
    public class Country : Entity
    {
        public int countryId { get; set; }
        public required string country { get; set; }
    }
}
