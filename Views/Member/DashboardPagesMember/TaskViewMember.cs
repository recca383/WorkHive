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
        private List<TaskModel> tasks;
        private List<TaskCard> filteredlist = new List<TaskCard>();
        public TaskViewMember()
        {
            InitializeComponent();
            AddTaskElements();
        }
        private void AddTaskElements()
        {
            RefreshList();
        }

        private void RefreshList()
        {
            filteredlist.Clear();
            tasks = TaskModelAccess.GetTaskModel();

            if (tasks is null)
            {
                MessageBox.Show("Wala pang laman, palagyan ng design to HAHAHAHA");
            }
            else
            {
                foreach (TaskModel taskModel in tasks)
                {
                    TaskCard card = new TaskCard();
                    card.lblTask_Title.Text = taskModel.TaskName;
                    card.lblTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(taskModel.TaskStart.Month)} {taskModel.TaskStart.Day}");
                    card.Deadlinetxt.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(taskModel.Deadline.Month)} {taskModel.Deadline.Day}");
                    card.TaskProgress.Value = taskModel.TaskProgress;
                    card.Archived.Checked = !taskModel.Archived;
                    filteredlist.Add(card);
                }
            }

        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshList();
            SortAllTasks();
        }

        private void SortAllTasks()
        {
            RefreshList();
            TasksFlow.Controls.Clear();
            var results = filteredlist
                .Where(p => p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            RefreshList();
            TasksFlow.Controls.Clear();
            var results = filteredlist
                .Where(p => p.TaskProgress.Value < 100 && p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            RefreshList();
            TasksFlow.Controls.Clear();
            var results = filteredlist
                .Where(p => p.TaskProgress.Value == 100 && p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }

    }
}
