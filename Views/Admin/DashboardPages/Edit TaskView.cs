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
        private Size EditTaskViewOriginalSize;
        private Rectangle recEditTask;
        private Rectangle recbtnEditAll;
        private Rectangle recbtnEditOngoing;
        private Rectangle recbtnEditCompleted;
        private Rectangle recbtnEditArchived;
        private Rectangle recEditTasksFlow;
        private Rectangle recEditScrollBar1;
        private Rectangle recbtnAddtasks;
        private List<EditTasks> list = new List<EditTasks>();
        private List<TaskModel> tasks;
        public Edit_TaskView()
        {
            InitializeComponent();
            AddTaskElements();
            SortAllTasks();
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
                EditTasks card = new EditTasks(i);
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
        public void btnEdittasks_Click(object sender, EventArgs e, int id)
        {
            EditTaskInformation editTask = new EditTaskInformation(TaskModelAccess.GetTaskInfo(id));
            editTask.Dock = DockStyle.Fill;
            
            AddTaskPanel.Controls.Add(editTask);

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
