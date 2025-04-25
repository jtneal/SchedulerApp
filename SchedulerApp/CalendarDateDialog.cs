using SchedulerApp.Models;

namespace SchedulerApp
{
    public partial class CalendarDateDialog: Form
    {
        public CalendarDateDialog(string day, AppointmentModel[] appointments)
        {
            InitializeComponent();

            Text = day;
            monthDayYearLabel.Text = day;
            
            var row = 1;

            foreach (var appointment in appointments)
            {
                dateTable.Height = dateTable.Height + 24;
                dateTable.Controls.Add(new Label { Height = 23, Text = $"{appointment.start:t}", TextAlign = ContentAlignment.MiddleLeft }, 0, row);
                dateTable.Controls.Add(new Label { Height = 23, Text = $"{appointment.end:t}", TextAlign = ContentAlignment.MiddleLeft }, 1, row);
                dateTable.Controls.Add(new Label { Height = 23, Text = appointment.type, TextAlign = ContentAlignment.MiddleLeft }, 2, row);
                dateTable.Controls.Add(new Label { Height = 23, Text = appointment.customerName, TextAlign = ContentAlignment.MiddleLeft }, 3, row);
                row++;
            }
        }
    }
}
