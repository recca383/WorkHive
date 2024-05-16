using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;

namespace WorkHive.Views.Admin
{
    public partial class CalendarCurrentDays : UserControl
    {
        List<TaskModel> tasks = TaskModelAccess.GetTaskModel();
        private int currentMonth;
        private int currentYear;

        public int AspectRatio { get; internal set; }

        public CalendarCurrentDays(int currentYear, int currentMonth )
        {
            this.currentMonth = currentMonth;
            this.currentYear = currentYear;
            InitializeComponent();
        }

        private void CalendarCurrentDays_Load(object sender, EventArgs e)
        {
        }

        public void days(int numdays)
        {
            var taskdeadline = tasks.Where(d => d.Deadline.Month == currentMonth && d.Deadline.Year == currentYear && d.Deadline.Day == numdays);
            if (taskdeadline.Count() != 0)
            {
                foreach (var d in taskdeadline)
                {
                    lblTaskName.Text += d.TaskName + "\n";
                }
                
                lblTaskName.Visible = true;
            }

            lblDays.Text = numdays.ToString();
        }

        
    }
}
