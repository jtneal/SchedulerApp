using SchedulerApp.Entities;

namespace SchedulerApp
{
    public partial class CustomerForm: Form
    {
        private readonly DAL dal;
        private readonly User user;

        public CustomerForm(DAL dal, User user)
        {
            InitializeComponent();
            this.dal = dal;
            this.user = user;
        }
    }
}
