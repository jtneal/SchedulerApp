namespace SchedulerApp.Entities
{
    public class Appointment : Entity
    {
        public int appointmentId { get; set; }
        public required int customerId { get; set; }
        public required int userId { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public string? location { get; set; }
        public string? contact { get; set; }
        public required string type { get; set; }
        public string? url { get; set; }
        public required DateTime start { get; set; }
        public required DateTime end { get; set; }
    }
}
