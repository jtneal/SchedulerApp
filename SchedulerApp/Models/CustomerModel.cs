using SchedulerApp.Entities;

namespace SchedulerApp.Models
{
    public class CustomerModel : Customer
    {
        public required AddressModel address { get; set; }
    }
}
