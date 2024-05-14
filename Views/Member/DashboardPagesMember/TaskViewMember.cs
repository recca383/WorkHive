using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Cards;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class TaskViewMember : UserControl
    {
        private List<TaskModel> tasks = TaskModelAccess.GetTaskModel();

        public TaskViewMember()
        {
            InitializeComponent();
            var results = tasks.Where(p => !p.Archived).ToList();
            RefreshList(results);
        }

        private void RefreshList(List<TaskModel> tasks)
        {
            TasksFlow.Controls.Clear();

            foreach (TaskModel taskModel in tasks)
            {
                TasksFlow.Controls.Add(new TaskCard(taskModel));
            }
        }
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            var results = tasks.Where(p => !p.Archived).ToList();
            RefreshList(results);
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            var results = tasks.Where(p => !p.TaskFinished && !p.Archived).ToList();
            RefreshList(results);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            var results = tasks.Where(p => p.TaskFinished && !p.Archived).ToList();
            RefreshList(results);
        }

    }
}
