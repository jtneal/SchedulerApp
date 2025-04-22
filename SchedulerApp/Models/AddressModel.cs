using SchedulerApp.Entities;

namespace SchedulerApp.Models
{
    public class AddressModel : Address
    {
        public required CityModel city { get; set; }
    }
}
