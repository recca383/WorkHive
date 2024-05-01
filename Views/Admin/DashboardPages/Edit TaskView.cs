﻿using System;
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
        private List<TaskCard> list = new List<TaskCard>();
        public Edit_TaskView()
        {
            InitializeComponent();
            AddTaskElements();
            SortAllTasks();

        }

        private void AddTaskElements()
        {

            for (int i = 0; i < TaskModelAccess.GetTaskCount(); i++)
            {
                TaskModel taskModel = TaskModelAccess.GetTaskInfo(i);
                TaskCard card = new TaskCard();
                card.lblTask_Title.Text = taskModel.TaskName;
                card.lblTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(taskModel.TaskStart.Month)} {taskModel.TaskStart.Day}");
                card.TaskProgress.Value = taskModel.TaskProgress;
                card.Archived.Checked = !taskModel.Archived;
                list.Add(card);

            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SortAllTasks();
        }

        private void SortAllTasks()
        {
            EditTasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            EditTasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.TaskProgress.Value < 100 && p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            EditTasksFlow.Controls.Clear();
            var results = list
                .Where(p => p.TaskProgress.Value == 100 && p.Archived.Checked)
                .OrderBy(p => p.TaskProgress.Value);
            foreach (var result in results)
            {
                EditTasksFlow.Controls.Add(result);
            }
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            EditTasksFlow.Controls.Clear();
            var results = list.Where(p => !p.Archived.Checked);
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
