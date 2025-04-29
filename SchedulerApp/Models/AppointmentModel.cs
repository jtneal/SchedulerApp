using SchedulerApp.Entities;

namespace SchedulerApp.Models
{
    public class AppointmentModel : Appointment
    {
        public required string userName { get; set; }
        public required string customerName { get; set; }
    }
}
