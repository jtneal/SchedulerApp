namespace SchedulerApp.Models
{
    public class AppointmentModel
    {
        public required string customerName { get; set; }
        public required string type { get; set; }
        public required DateTime start { get; set; }
        public required DateTime end { get; set; }
    }
}
