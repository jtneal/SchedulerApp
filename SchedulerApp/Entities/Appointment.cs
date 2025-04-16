namespace SchedulerApp.Entities
{
    public class Appointment : Entity
    {
        public required int appointmentId { get; set; }
        public required int customerId { get; set; }
        public required int userId { get; set; }
        public required string title { get; set; }
        public required string description { get; set; }
        public required string location { get; set; }
        public required string contact { get; set; }
        public required string type { get; set; }
        public required string url { get; set; }
        public required DateTime start { get; set; }
        public required DateTime end { get; set; }
    }
}
