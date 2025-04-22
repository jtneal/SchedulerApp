namespace SchedulerApp.Entities
{
    public abstract class Entity
    {
        public DateTime createDate { get; set; }
        public string createdBy { get; set; } = string.Empty;
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; } = string.Empty;
    }
}
