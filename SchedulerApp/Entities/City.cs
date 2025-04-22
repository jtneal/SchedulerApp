namespace SchedulerApp.Entities
{
    public class City : Entity
    {
        public int cityId { get; set; }
        public required string city { get; set; }
        public required int countryId { get; set; }
    }
}
