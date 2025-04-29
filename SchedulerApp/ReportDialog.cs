using SchedulerApp.DAL;
using System.Data;

namespace SchedulerApp
{
    public partial class ReportDialog: Form
    {
        private readonly CompositeDAL dal;

        public ReportDialog(CompositeDAL dal, int reportId)
        {
            InitializeComponent();

            this.dal = dal;

            switch (reportId)
            {
                case 1:
                    SetupReport1();
                    break;
                case 2:
                    SetupReport2();
                    break;
                case 3:
                    SetupReport3();
                    break;
            }
        }

        public void SetupReport1()
        {
            Text = "Number of Appointment Types by Month";
            reportLabel.Text = Text;

            reportGrid.Columns.Add("report_month", "Month");
            reportGrid.Columns.Add("type_count", "Number of Appointment Types");

            var appointments = dal.appointment.GetAppointments()
                .GroupBy(x => x.start.ToString("MMMM yyyy"))
                .Select(x => new {
                    report_month = x.Key,
                    type_count = x.Select(y => y.type).Distinct().Count(),
                })
                .ToList();

            foreach (var appointment in appointments)
            {
                var rowId = reportGrid.Rows.Add();
                var row = reportGrid.Rows[rowId];

                row.Cells[0].Value = appointment.report_month;
                row.Cells[1].Value = appointment.type_count;
            }
        }

        public void SetupReport2()
        {
            Text = "Schedule for Each User";
            reportLabel.Text = Text;

            reportGrid.Columns.Add("user", "User");
            reportGrid.Columns.Add("type", "Type");
            reportGrid.Columns.Add("start", "Start");
            reportGrid.Columns.Add("end", "End");

            var appointments = dal.appointment.GetAllAppointments()
                .Select(x => new {
                    user = x.userName,
                    x.type,
                    x.start,
                    x.end,
                })
                .ToList();

            foreach (var appointment in appointments)
            {
                var rowId = reportGrid.Rows.Add();
                var row = reportGrid.Rows[rowId];

                row.Cells[0].Value = appointment.user;
                row.Cells[1].Value = appointment.type;
                row.Cells[2].Value = appointment.start;
                row.Cells[3].Value = appointment.end;
            }
        }

        public void SetupReport3()
        {
            Text = "Time Consumed by Each Customer";
            reportLabel.Text = Text;

            reportGrid.Columns.Add("customer", "Customer");
            reportGrid.Columns.Add("consumed", "Time Consumed (in minutes)");

            var times = dal.appointment.GetAllAppointments()
                .GroupBy(x => new { x.customerId, x.customerName })
                .Select(x => new {
                    customer = x.Key.customerName,
                    consumed = x.Sum(y => y.end.Subtract(y.start).TotalMinutes),
                })
                .ToList();

            foreach (var time in times)
            {
                var rowId = reportGrid.Rows.Add();
                var row = reportGrid.Rows[rowId];

                row.Cells[0].Value = time.customer;
                row.Cells[1].Value = time.consumed;
            }
        }
    }
}
