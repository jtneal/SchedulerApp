namespace SchedulerApp.Entities
{
    public abstract class Entity
    {
        public required DateTime createDate { get; set; }
        public required string createdBy { get; set; }
        public required DateTime lastUpdate { get; set; }
        public required string lastUpdateBy { get; set; }
    }
}
