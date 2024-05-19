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
        private Size TaskViewOriginalSize;
        private Rectangle recTasksName;
        private Rectangle recbtnAll;
        private Rectangle recbtnOngoing;
        private Rectangle recbtnCompleted;
        private Rectangle recbtnArchived;
        private Rectangle recTasksFlow;
        private Rectangle recbunifuVScrollBar1;
        private Rectangle recRefreshButton;
        private Rectangle recEditFlatButton;
        private Rectangle recbtnAddtasks;

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


            this.Resize += TasksView_Resize;
            TaskViewOriginalSize = this.Size;
            recTasksName = new Rectangle(TasksName.Location, TasksName.Size);
            recTasksFlow = new Rectangle(TasksFlow.Location, TasksFlow.Size);
            recbtnAll = new Rectangle(btnAll.Location, btnAll.Size);
            recbunifuVScrollBar1 = new Rectangle(bunifuVScrollBar1.Location, bunifuVScrollBar1.Size);
            recRefreshButton = new Rectangle(RefreshButton.Location, RefreshButton.Size);
            recbtnAddtasks = new Rectangle(btnAddtasks.Location, btnAddtasks.Size);
        }

        private void RefreshDataSources()
        {
            StatusFilter.DataSource = Enum.GetNames(typeof(Status));
            ProjectFilter.DataSource = projects.Select(s => s.Name).ToList();
        }

        private void TasksView_Resize(object sender, EventArgs e)
        {
            resize_Control(TasksName, recTasksName);
            resize_Control(TasksFlow, recTasksFlow);
            resize_Control(btnAll, recbtnAll);
            resize_Control(bunifuVScrollBar1, recbunifuVScrollBar1);
            resize_Control(RefreshButton, recRefreshButton);
            resize_Control(btnAddtasks, recbtnAddtasks);

        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(TaskViewOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(TaskViewOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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
            RefreshDataSources();
            ProjectFilter.SelectedIndex = model.Id;

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
