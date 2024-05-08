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

        private List<TaskModel> tasks = TaskModelAccess.GetTaskModel();



        public TasksView()
        {
            InitializeComponent();
            RefreshList(tasks);
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

        private void RefreshList(List<TaskModel> taskList)
        {
            TasksFlow.Controls.Clear();
            tasks = TaskModelAccess.GetTaskModel();
            
            foreach (TaskModel taskModel in tasks)
            {
                TasksFlow.Controls.Add(new TaskCard     (taskModel));
            }

            
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

    }
}
