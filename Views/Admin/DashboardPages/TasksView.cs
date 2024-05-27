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
        private List<TaskModel> tasks = TaskModelAccess.GetTaskModel();
        private List<ProjectModel> projects = ProjectModelAccess.GetProjects();
       

        public TasksView()
        {
            InitializeComponent();
            RefreshDataSources();
            ProjectFilter.SelectedItem = null;
            StatusFilter.SelectedItem = null;
            var results = tasks.Where(a => a.TaskStatus != Status.Archived).ToList();
            AddProject.OnProjectAdded2 += OnProjectTasksOnclick;
            ProjectCard.OnProjectModelClick += OnProjectTasksOnclick;
            RefreshList(results);

            AddTaskPanel.Size = new Size(0, 0);
            TaskDetails.Visible = false;
        }

        public void btnDetails_Click(object sender, EventArgs e, TaskModel task)
        {
            TaskDetails.Controls.Clear();
            TaskDetails.Size = new Size(285, 385);
            TaskDetails.Controls.Add(new TaskDetailsCard(task));
            TaskDetails.Visible = true;
        }

        private void RefreshTaskViewLibraries()
        {
            tasks = TaskModelAccess.GetTaskModel();
            projects = ProjectModelAccess.GetProjects();
        }
        private void RefreshDataSources()
        {
            StatusFilter.DataSource = Enum.GetNames(typeof(Status));
            ProjectFilter.DataSource = projects.Select(s => s.Name).ToList();
        }


        private void RefreshList(List<TaskModel> taskList)
        {

            TasksFlow.Controls.Clear();
            taskList = taskList.OrderBy(t => t.Deadline).ToList();
            foreach (TaskModel taskModel in taskList)
            {
                TasksFlow.Controls.Add(new AdminTaskCard(taskModel));
            }
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
        private void AddTaskPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (AddTaskPanel.Controls.Count == 0)
            {
                AddTaskPanel.Size = new Size(0, 0);
            }
        }

        public void OnProjectTasksOnclick(ProjectModel model)
        {
            RefreshTaskViewLibraries();
            RefreshDataSources();
            ProjectFilter.SelectedItem = ProjectModelAccess.GetProjectDetails(model.Id).Name;

        }
        private void StatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var results = tasks
                .Where(a => a.ProjectAssigned.Id == ProjectFilter.SelectedIndex)
                .Where(a => a.TaskStatus == (Status)StatusFilter.SelectedIndex)
                .ToList();
            RefreshList(results);
        }
    }
}
