using SchedulerApp.DAL;
using SchedulerApp.Entities;
using SchedulerApp.Utilities;
using System.Diagnostics;

namespace SchedulerApp
{
    public partial class MainScreen : Form
    {
        private readonly CompositeDAL dal;
        private readonly User user;
        private int year = DateTime.Now.Year;
        private int month = DateTime.Now.Month;

        public MainScreen(CompositeDAL dal, User user)
        {
            InitializeComponent();

            this.dal = dal;
            this.user = user;
        }

        public void AppointmentAlerts()
        {
            var upcoming = dal.appointment.GetUpcomingAppointment();

            if (upcoming.customerName != string.Empty)
            {
                MessageBox.Show(
                    $"You have an upcoming appointment:\n\nType: {upcoming.type}\nCustomer: {upcoming.customerName}\nTime: {upcoming.start:t} to {upcoming.end:t}",
                    "Upcoming Appointment"
                );
            }
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

            SetupCalendar();
        }

        public void SetupCalendar()
        {
            calendarTable.Visible = false;
            calendarTable.Controls.Clear();

            var firstOfMonth = new DateTime(year, month, 1);
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var row = 0;
            var col = ((int)firstOfMonth.DayOfWeek) - 1;
            var day = 1;

            if (firstOfMonth.DayOfWeek == DayOfWeek.Saturday)
            {
                col = 0;
                day += 2;
            }
            else if (firstOfMonth.DayOfWeek == DayOfWeek.Sunday)
            {
                col = 0;
                day++;
            }

            while (day <= daysInMonth)
            {
                var label = new Label
                {
                    Text = day.ToString(),
                    Height = 100,
                    Width = 200
                };

                label.MouseClick += new MouseEventHandler(calendarTable_Click!);
                calendarTable.Controls.Add(label, col, row);

                if (col < 4)
                {
                    col++;
                    day++;
                }
                else
                {
                    col = 0;
                    row++;
                    day += 3; // Skip the weekend
                }
            }

            monthYearLabel.Text = $"{firstOfMonth:MMMM} {firstOfMonth:yyyy}";
            calendarTable.Visible = true;
        }

        private void calendarTable_Click(object sender, EventArgs e)
        {
            var day = ((Control)sender).Text;
            var date = $"{year}-{month}-{day}";
            var dt = new DateTime(year, month, int.Parse(day));
            var appointments = dal.appointment.GetAppointmentsByDate(date);
            var dialog = new CalendarDateDialog($"{dt:M}, {dt:yyyy}", appointments.ToArray());

            dialog.ShowDialog();
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        private void MainScreen_Load(object sender, EventArgs e)
        {
            AppointmentAlerts();
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

        /***********************
         * Calendar Event Handlers *
         ***********************/

        private void prevYear_Click(object sender, EventArgs e)
        {
            year--;
            SetupCalendar();
        }

        private void prevMonth_Click(object sender, EventArgs e)
        {
            if (month > 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }

            SetupCalendar();
        }

        private void nextMonth_Click(object sender, EventArgs e)
        {
            if (month < 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }

            SetupCalendar();
        }

        private void nextYear_Click(object sender, EventArgs e)
        {
            year++;
            SetupCalendar();
        }

        private void report1Button_Click(object sender, EventArgs e)
        {
            var form = new ReportDialog(dal, 1);

            form.ShowDialog();
        }

        private void report2Button_Click(object sender, EventArgs e)
        {
            var form = new ReportDialog(dal, 2);

            form.ShowDialog();
        }

        private void report3Button_Click(object sender, EventArgs e)
        {
            var form = new ReportDialog(dal, 3);

            form.ShowDialog();
        }
    }
}
