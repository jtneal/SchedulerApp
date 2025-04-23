using SchedulerApp.DAL;
using SchedulerApp.Entities;
using SchedulerApp.Utilities;

namespace SchedulerApp
{
    public partial class MainScreen : Form
    {
        private readonly CompositeDAL dal;
        private readonly User user;

        public MainScreen(CompositeDAL dal, User user)
        {
            InitializeComponent();

            this.dal = dal;
            this.user = user;
        }

        public void RefreshData()
        {
            customersDataGridView.DataSource = dal.customer.GetCustomers();
            appointmentsDataGridView.DataSource = dal.appointment.GetAppointments();
            appointmentsDataGridView.Columns["title"].Visible = false;
            appointmentsDataGridView.Columns["description"].Visible = false;
            appointmentsDataGridView.Columns["location"].Visible = false;
            appointmentsDataGridView.Columns["contact"].Visible = false;
            appointmentsDataGridView.Columns["url"].Visible = false;
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        private void MainScreen_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        /*************************
         * Button Event Handlers *
         *************************/

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(0, dal, this, user);

            form.ShowDialog();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(customersDataGridView);
            var customerId = accessor.GetSelectedInt("customerId");
            var form = new CustomerForm(customerId, dal, this, user);

            form.ShowDialog();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(customersDataGridView);
            var customerId = accessor.GetSelectedInt("customerId");
            var customerName = accessor.GetSelectedString("customerName");
            var confirm = MessageBox.Show($"Are you sure you want to delete {customerName}?", "Are you sure?", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.customer.DeleteCustomer(customerId);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Delete failed with exception", ex);
                    MessageBox.Show("Something went wrong, please try again!");
                }
            }
        }

        private void appointmentsAddButton_Click(object sender, EventArgs e)
        {
            var form = new AppointmentForm(0, dal, this, user);

            form.ShowDialog();
        }

        private void appointmentsUpdateButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(appointmentsDataGridView);
            var appointmentId = accessor.GetSelectedInt("appointmentId");
            var form = new AppointmentForm(appointmentId, dal, this, user);

            form.ShowDialog();
        }

        private void appointmentsDeleteButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(appointmentsDataGridView);
            var appointmentId = accessor.GetSelectedInt("appointmentId");
            var confirm = MessageBox.Show("Are you sure you want to delete this appointment?", "Are you sure?", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dal.appointment.DeleteAppointment(appointmentId);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Delete failed with exception", ex);
                    MessageBox.Show("Something went wrong, please try again!");
                }
            }
        }
    }
}
