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
using WorkHive.Views.Member.DashboardPagesMember;
using WorkHive.Views.Pages;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class Edit_TaskView : UserControl
    {
        private Size EditTaskViewOriginalSize;
        private Rectangle recEditTask;
        private Rectangle recbtnEditAll;
        private Rectangle recbtnEditOngoing;
        private Rectangle recbtnEditCompleted;
        private Rectangle recbtnEditArchived;
        private Rectangle recEditTasksFlow;
        private Rectangle recEditScrollBar1;
        private Rectangle recbtnAddtasks;

        private List<TaskModel> tasks = TaskModelAccess.GetTaskModel();

        public Edit_TaskView()
        {
            InitializeComponent();
            SortAllTasks();
            AddTaskPanel.Size = new Size(0,0);
            this.Resize += Edit_TaskView_Resize; 
            EditTaskViewOriginalSize = this.Size;
            recEditTask = new Rectangle(EditTask.Location, EditTask.Size);
            recEditTasksFlow = new Rectangle(EditTasksFlow.Location, EditTasksFlow.Size);
            recbtnEditAll = new Rectangle(btnEditAll.Location, btnEditAll.Size);
            recbtnEditOngoing = new Rectangle(btnEditOngoing.Location, btnEditOngoing.Size);
            recbtnEditCompleted = new Rectangle(btnEditCompleted.Location, btnEditCompleted.Size);
            recbtnEditArchived = new Rectangle(btnEditArchived.Location, btnEditArchived.Size);
            recEditScrollBar1 = new Rectangle(EditScrollBar1.Location, EditScrollBar1.Size);
            recbtnAddtasks = new Rectangle(btnAddtasks.Location, btnAddtasks.Size);
            
        }
        private void Edit_TaskView_Resize(object sender, EventArgs e)
        {
            resize_Control(EditTask, recEditTask);
            resize_Control(EditTasksFlow, recEditTasksFlow);
            resize_Control(btnEditAll, recbtnEditAll);
            resize_Control(btnEditOngoing, recbtnEditOngoing);
            resize_Control(btnEditCompleted, recbtnEditCompleted);
            resize_Control(btnEditArchived, recbtnEditArchived);
            resize_Control(EditScrollBar1, recEditScrollBar1);
            resize_Control(btnAddtasks, recbtnAddtasks);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(EditTaskViewOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(EditTaskViewOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void RefreshList(List<TaskModel> taskList)
        {
            EditTasksFlow.Controls.Clear();
            foreach(var task in taskList)
            {
                EditTasksFlow.Controls.Add(new EditTasks(task.TaskID,task));
            }
        }

        private void SortAllTasks()
        {
            RefreshList(tasks);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshList(tasks);
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            var results = tasks.Where(p => p.TaskProgress < 100).ToList();
            RefreshList(results);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            var results = tasks.Where(p => p.TaskProgress == 100).ToList();
            RefreshList(results);
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            var results = tasks.Where(a => a.Archived).ToList();
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
            if(AddTaskPanel.Controls.Count == 0)
            {
                AddTaskPanel.Size = new Size(0, 0);
            }
        }
    }
 
}
