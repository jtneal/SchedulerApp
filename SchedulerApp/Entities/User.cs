namespace SchedulerApp.Entities
{
    public class User : Entity
    {
        public required int userId { get; set; }
        public required string userName { get; set; }
        public required string password { get; set; }
        public required int active { get; set; }
    }
}
