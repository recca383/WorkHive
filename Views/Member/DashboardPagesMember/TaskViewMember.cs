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
using WorkHive.Views.Admin.DashboardPages;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    
    public partial class TaskViewMember : UserControl
    {
        private List<TaskModel> tasks = TaskModelAccess.GetTaskModel();
        private List<ProjectModel> projects = ProjectModelAccess.GetProjects();
        public TaskViewMember()
        {
            InitializeComponent();
            RefreshDataSources();
            var results = tasks.Where(p => p.TaskStatus != Status.Archived).ToList();
            RefreshList(results);
            ProjectFilter.SelectedItem = null;
            StatusFilter.SelectedItem = null;

           
            ProjectCard.OnProjectModelClick += OnProjectTasksOnclick;
            RefreshList(results);
            AddTask.OnTasksAdded1 += btnAll_Click;

            AddTaskPanel.Size = new Size(0, 0);
        }

        private void RefreshList(List<TaskModel> tasks)
        {
           
            TasksFlow.Controls.Clear();
            tasks = tasks.OrderBy(t => t.Deadline).ToList();
            foreach (TaskModel taskModel in tasks)
            {
                TasksFlow.Controls.Add(new MemberTaskCard(taskModel));
            }
        }
        private void RefreshDataSources()
        {
            StatusFilter.DataSource = Enum.GetNames(typeof(Status));
            ProjectFilter.DataSource = projects.Select(s => s.Name).ToList();
        }
        public void btnDetails_Click(object sender, EventArgs e, TaskModel task)
        {
            AddTaskPanel.Controls.Clear();
            AddTaskPanel.Controls.Add(new TaskDetailsCard(task));
            AddTaskPanel.Size = new Size(285, 385);

        }
        public void btnAll_Click(object sender, EventArgs e)
        {
            ProjectFilter.SelectedItem = null;
            StatusFilter.SelectedItem = null;
            var results = tasks.Where(a => a.TaskStatus != Status.Archived).ToList();
            RefreshList(results);
        }

        private void btnAddtasks_Click(object sender, EventArgs e)
        {
            AddTaskPanel.Controls.Clear();
            AddTaskPanel.Controls.Add(new AddTask());
            AddTaskPanel.Size = new Size(500, 622);
        }
        public void btnEdittasks_Click(object sender, EventArgs e, int id)
        {
            AddTaskPanel.Controls.Clear();
            AddTaskPanel.Controls.Add(new EditTaskInformation(TaskModelAccess.GetTaskInfo(id)));
            AddTaskPanel.Size = new Size(500, 622);

        }
       

        public void OnProjectTasksOnclick(ProjectModel model)
        {
            RefreshDataSources();
            ProjectFilter.SelectedIndex = model.Id;

        }
        private void StatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectFilter.SelectedItem is null)
            {
                var results = tasks

                    .Where(a => a.TaskStatus == (Status)StatusFilter.SelectedIndex)
                    .ToList();
                RefreshList(results);
            }
            else if (StatusFilter.SelectedItem is null)
            {
                var results = tasks
                    .Where(a => a.ProjectAssigned.Id == ProjectFilter.SelectedIndex && a.TaskStatus != (Status)2)
                    .ToList();
                RefreshList(results);
            }
            else
            {
                var results = tasks
                    .Where(a => a.ProjectAssigned.Id == ProjectFilter.SelectedIndex)
                    .Where(a => a.TaskStatus == (Status)StatusFilter.SelectedIndex)
                    .ToList();
                RefreshList(results);
            }
        }
    }
}
