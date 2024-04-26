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
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Cards;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class TasksView : UserControl
    {
        private List<TaskCard> list = new List<TaskCard>();
        public TasksView()
        {
            InitializeComponent();
            AddTaskElements();
            SortAllTasks();
        }

        private void AddTaskElements()
        {
            
            for (int i = 0; i < TaskModelAccess.GetTaskCount(); i++)
            {
                TaskModel TaskModel = TaskModelAccess.GetTaskInfo(i);
                TaskCard card = new TaskCard();
                card.lblTask_Title.Text = TaskModel.TaskName;
                card.lblTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(TaskModel.TaskStart.Month)} {TaskModel.TaskStart.Day}");
                card.TaskProgress.Value = TaskModel.TaskProgress;
                card.Archived.Checked = !TaskModel.Archived;
                list.Add( card );
                
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SortAllTasks();
        }

        private void SortAllTasks()
        {
            TasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            TasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.TaskProgress.Value < 100 && p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach ( var result in results )
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            TasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.TaskProgress.Value == 100 && p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            TasksFlow.Controls.Clear();
            var results = list.Where(p => !p.Archived.Checked);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }
    }
}
