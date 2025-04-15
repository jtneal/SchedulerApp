namespace SchedulerApp.Models
{
    public class User
    {
        public required int userId { get; set; }
        public required string userName { get; set; }
        public required string password { get; set; }
        public required int active { get; set; }
        public required DateTime createDate { get; set; }
        public required string createdBy { get; set; }
        public required DateTime lastUpdate { get; set; }
        public required string lastUpdateBy { get; set; }
    }
}
