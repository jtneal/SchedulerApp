using SchedulerApp.DAL;
using SchedulerApp.Entities;
using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchedulerApp
{
    public partial class AppointmentForm : Form
    {
        private Appointment? appointment;
        private readonly int appointmentId;
        private readonly CompositeDAL dal;
        private readonly MainScreen mainScreen;
        private readonly User user;

        public AppointmentForm(int appointmentId, CompositeDAL dal, MainScreen mainScreen, User user)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.dal = dal;
            this.mainScreen = mainScreen;
            this.user = user;
        }

        private bool IsFormValid()
        {
            var valid = true;

            if (customerComboBox.SelectedValue is null)
            {
                customerLabel.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                customerLabel.ForeColor = Color.Black;
            }

            if (typeTextBox.Text.Trim() == string.Empty)
            {
                typeLabel.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                typeLabel.ForeColor = Color.Black;
            }

            if (!IsBusinessDay(startDateTimePicker.Value) || !IsBusinessHours(startDateTimePicker.Value))
            {
                startLabel.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                startLabel.ForeColor = Color.Black;
            }

            if (!IsBusinessDay(endDateTimePicker.Value) || !IsBusinessHours(endDateTimePicker.Value) || startDateTimePicker.Value.Date != endDateTimePicker.Value.Date || startDateTimePicker.Value >= endDateTimePicker.Value)
            {
                endLabel.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                endLabel.ForeColor = Color.Black;
            }

            return valid;
        }

        protected static bool IsBusinessDay(DateTime dateTime)
        {
            return dateTime.DayOfWeek != DayOfWeek.Saturday && dateTime.DayOfWeek != DayOfWeek.Sunday;
        }

        protected static bool IsBusinessHours(DateTime dateTime)
        {
            return true;
            return dateTime.Hour >= 9 && (dateTime.Hour <= 16 || (dateTime.Hour == 17 && dateTime.Minute == 0 && dateTime.Second == 0));
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            customerComboBox.DataSource = dal.customer.GetCustomers();
            customerComboBox.DisplayMember = "customerName";
            customerComboBox.ValueMember = "customerId";
            customerComboBox.SelectedIndex = -1;

            if (appointmentId > 0)
            {
                appointment = dal.appointment.GetAppointment(appointmentId);

                if (appointment.appointmentId > 0)
                {
                    customerComboBox.SelectedValue = appointment.customerId;
                    typeTextBox.Text = appointment.type;
                    startDateTimePicker.Value = appointment.start;
                    endDateTimePicker.Value = appointment.end;
                }
            }
        }

        protected void Control_Changed(object sender, EventArgs e)
        {
            saveButton.Enabled = IsFormValid();
        }

        /*************************
         * Button Event Handlers *
         *************************/

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check for conflicting appointments
                // Search for start dates that exist any time before our end date
                // and end times that exist any time after our start date
                if (dal.appointment.HasConflict(appointmentId, startDateTimePicker.Value, endDateTimePicker.Value))
                {
                    MessageBox.Show("You have another appointment that conflicts with this one. Please adjust your appointment time and try again.", "Error");
                }
                else
                {
                    if (appointmentId > 0)
                    {
                        dal.appointment.UpdateAppointment(new Appointment()
                        {
                            appointmentId = appointment!.appointmentId,
                            customerId = (int)customerComboBox.SelectedValue!,
                            userId = user.userId,
                            type = typeTextBox.Text,
                            start = startDateTimePicker.Value.ToUniversalTime(),
                            end = endDateTimePicker.Value.ToUniversalTime(),
                            lastUpdate = DateTime.Now,
                            lastUpdateBy = user.userName,
                        });
                    }
                    else
                    {
                        dal.appointment.CreateAppointment(new Appointment()
                        {
                            customerId = (int)customerComboBox.SelectedValue!,
                            userId = user.userId,
                            type = typeTextBox.Text,
                            start = startDateTimePicker.Value.ToUniversalTime(),
                            end = endDateTimePicker.Value.ToUniversalTime(),
                            createDate = DateTime.Now.Date,
                            createdBy = user.userName,
                            lastUpdate = DateTime.Now,
                            lastUpdateBy = user.userName,
                        });
                    }

                    mainScreen.RefreshData();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save failed with exception", ex);
                MessageBox.Show("Something went wrong, please try again!");
            }

        }
    }
}
