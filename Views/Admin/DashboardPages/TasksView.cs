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
        private List<TaskModel> tasks;
        private List<TaskCard> filteredlist = new List<TaskCard>();


        public TasksView()
        {
            InitializeComponent();
            AddTaskElements();
            SortAllTasks();
            this.Resize += TasksView_Resize;
            TaskViewOriginalSize = this.Size;
            recTasksName = new Rectangle(TasksName.Location, TasksName.Size);
            recTasksFlow = new Rectangle(TasksFlow.Location, TasksFlow.Size);
            recbtnAll = new Rectangle(btnAll.Location, btnAll.Size);
            recbtnOngoing = new Rectangle(btnOngoing.Location, btnOngoing.Size);
            recbtnCompleted = new Rectangle(btnCompleted.Location, btnCompleted.Size);
            recbtnArchived = new Rectangle(btnArchived.Location, btnArchived.Size);
            recbunifuVScrollBar1 = new Rectangle(bunifuVScrollBar1.Location, bunifuVScrollBar1.Size);
        }

        private void TasksView_Resize(object sender, EventArgs e)
        {
            resize_Control(TasksName, recTasksName);
            resize_Control(TasksFlow, recTasksFlow);
            resize_Control(btnAll, recbtnAll);
            resize_Control(btnOngoing, recbtnOngoing);
            resize_Control(btnCompleted, recbtnCompleted);
            resize_Control(btnArchived, recbtnArchived);
            resize_Control(bunifuVScrollBar1, recbunifuVScrollBar1);
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

        private void AddTaskElements()
        {
            RefreshList();
        }

        private void RefreshList()
        {
            filteredlist.Clear();
            tasks = TaskModelAccess.GetTaskModel();
            
            if(tasks is null)
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
            foreach ( var result in results )
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

        private void btnArchived_Click(object sender, EventArgs e)
        {
            RefreshList();
            TasksFlow.Controls.Clear();
            var results = filteredlist.Where(p => !p.Archived.Checked);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void TasksFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TasksView_Load(object sender, EventArgs e)
        {

        }
    }
}
