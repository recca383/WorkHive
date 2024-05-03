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
    public partial class Edit_TaskView : UserControl
    {
        private List<EditTasks> list = new List<EditTasks>();
        private List<TaskModel> tasks;
        public Edit_TaskView()
        {
            InitializeComponent();
            AddTaskElements();
            SortAllTasks();

        }

        private void AddTaskElements()
        {
            RefreshList();

        }

        private void RefreshList()
        {
            list.Clear();
            for (int i = 0; i < TaskModelAccess.GetTaskCount(); i++)
            {
                TaskModel taskModel = TaskModelAccess.GetTaskInfo(i);
                EditTasks card = new EditTasks();
                card.lblEditTask_Title.Text = taskModel.TaskName;
                card.lblEditTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(taskModel.TaskStart.Month)} {taskModel.TaskStart.Day}");
                card.EditTaskProgress.Value = taskModel.TaskProgress;
                card.EditArchived.Checked = !taskModel.Archived;
                list.Add(card);

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
            EditTasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.EditArchived.Checked)
                .OrderBy(p => p.EditTaskProgress.Value);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            RefreshList();
            EditTasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.EditTaskProgress.Value < 100 && p.EditArchived.Checked)
                .OrderBy(p => p.EditTaskProgress.Value);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            RefreshList();
            EditTasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.EditTaskProgress.Value == 100 && p.EditArchived.Checked)
                .OrderBy(p => p.EditTaskProgress.Value);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            RefreshList();
            EditTasksFlow.Controls.Clear();
            var results = list.Where(p => !p.EditArchived.Checked);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnAddtasks_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Dock = DockStyle.Fill;
            AddTaskPanel.Controls.Add(addTask);
        }

        private void AddTaskPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            AddTaskPanel.Size = new System.Drawing.Size(500, 622);
        }

        private void AddTaskPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            AddTaskPanel.Size = new System.Drawing.Size(0, 0);
        }
    }
 
}
