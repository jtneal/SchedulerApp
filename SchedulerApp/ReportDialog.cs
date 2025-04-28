using SchedulerApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            reportPanel.Height = 26;

            var i = 1;
            var rows = dal.appointment.GetAppointments()
                .GroupBy(x => x.start.ToString("MMMM yyyy"))
                .Select(x => new {
                    report_month = x.Key,
                    type_count = x.Select(y => y.type).Distinct().Count(),
                })
                .ToList();

            foreach (var row in rows)
            {
                reportPanel.Controls.Add(new Label() { Height = 20, TextAlign = ContentAlignment.MiddleLeft, Text = row.report_month, Width = 200 }, 0, i);
                reportPanel.Controls.Add(new Label() { Height = 20, TextAlign = ContentAlignment.MiddleLeft, Text = row.type_count.ToString(), Width = 200 }, 1, i);
                reportPanel.Height += 21;
                i++;
            }
        }

        public void SetupReport2()
        {
            Text = "Schedule for Each User";
            reportLabel.Text = Text;
        }

        public void SetupReport3()
        {
            Text = "Time Consumed by Each Customer";
            reportLabel.Text = Text;
        }
    }
}
