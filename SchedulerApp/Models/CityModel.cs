using SchedulerApp.Entities;

namespace SchedulerApp.Models
{
    public class CityModel : City
    {
        public required Country country { get; set; }
    }
}
