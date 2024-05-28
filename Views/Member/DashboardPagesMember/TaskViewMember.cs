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
            ProjectFilter.SelectedItem = null;
            StatusFilter.SelectedItem = null;
            var results = tasks.Where(a => a.TaskStatus != Status.Archived).ToList();
            AddProject.OnProjectAdded2 += OnProjectTasksOnclick;
            ProjectCard.OnProjectModelClick += OnProjectTasksOnclick;
            RefreshList(results);
            AddTask.OnTasksAdded1 += btnAll_Click;
            EditTaskInformation.OnUpdate += RefreshTaskViewLibraries;

            AddTaskPanel.Size = new Size(0, 0);
        }

        public void btnDetails_Click(object sender, EventArgs e, TaskModel task)
        {
            AddTaskPanel.Controls.Clear();
            AddTaskPanel.Controls.Add(new TaskDetailsCard(task));
            AddTaskPanel.Size = new Size(285, 385);

        }
        private void RefreshTaskViewLibraries()
        {
            tasks = TaskModelAccess.GetTaskModel();
            projects = ProjectModelAccess.GetProjects();
        }

        private void RefreshDataSources()
        {
            StatusFilter.DataSource = Enum.GetNames(typeof(Status));
            ProjectFilter.DataSource = projects.Select(s => s.ProjectName).ToList();
        }


        private void RefreshList(List<TaskModel> taskList)
        {

            TasksFlow.Controls.Clear();
            taskList = taskList.OrderBy(t => t.Deadline).ToList();
            foreach (TaskModel taskModel in taskList)
            {
                TasksFlow.Controls.Add(new MemberTaskCard(taskModel));
            }
        }


       
        private void AddTaskPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (AddTaskPanel.Controls.Count == 0)
            {
                AddTaskPanel.Size = new Size(0, 0);
            }
        }
        public void btnEdittasks_Click(object sender, EventArgs e, int id)
        {
            AddTaskPanel.Controls.Clear();
            AddTaskPanel.Controls.Add(new EditTaskMember(TaskModelAccess.GetTaskInfo(id)));
            AddTaskPanel.Size = new Size(417, 324);

        }
        private void RefreshTaskViewLibraries()
        {
            tasks = TaskModelAccess.GetTaskModel();
            projects = ProjectModelAccess.GetProjects();
        }

        public void OnProjectTasksOnclick(ProjectModel model)
        {
            RefreshTaskViewLibraries();
            RefreshDataSources();
            ProjectFilter.SelectedItem = ProjectModelAccess.GetProjectDetails(model.Id).ProjectName;

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

        public void RefreshButton_Click(object sender, EventArgs e)
        {
            
                ProjectFilter.SelectedItem = null;
                StatusFilter.SelectedItem = null;
                var results = tasks.Where(a => a.TaskStatus != Status.Archived).ToList();
                RefreshList(results);
            
        }
    }
}
