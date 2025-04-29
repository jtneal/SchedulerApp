namespace SchedulerApp.DAL
{
    public class CompositeDAL
    {
        public readonly AddressDAL address;
        public readonly AppointmentDAL appointment;
        public readonly CustomerDAL customer;
        public readonly UserDAL user;

        public CompositeDAL()
        {
            //var connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";
            var connectionString = "server=localhost;user=root;database=client_schedule;port=3306;password=root";

            address = new AddressDAL(connectionString);
            appointment = new AppointmentDAL(connectionString);
            customer = new CustomerDAL(connectionString);
            user = new UserDAL(connectionString);
        }
    }
}
