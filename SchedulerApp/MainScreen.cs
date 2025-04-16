using SchedulerApp.Entities;
using SchedulerApp.Utilities;

namespace SchedulerApp
{
    public partial class MainScreen : Form
    {
        private readonly DAL dal;
        private readonly User user;

        public MainScreen(DAL dal, User user)
        {
            InitializeComponent();
            this.dal = dal;
            this.user = user;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = dal.GetCustomers();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(dal, user);

            form.ShowDialog();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(dal, user);

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
                dal.DeleteCustomer(customerId);
                customersDataGridView.DataSource = dal.GetCustomers();
            }
        }
    }
}
