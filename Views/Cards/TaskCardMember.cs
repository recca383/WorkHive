using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Cards
{
    public partial class TaskCardMember : UserControl
    {
        private Size TaskCardOriginalSize;
        private Rectangle recpanel2;
        private Rectangle recpanel3;
        private Rectangle recpictureBox1;

        int Id;
        
        public TaskCardMember(TaskModel task)
        {
            Id = task.TaskID;
            InitializeComponent();
            InitializeElements(task);
            this.Resize += TaskCard_Resize;
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            recpictureBox1 = new Rectangle(pictureboxFinished.Location, pictureboxFinished.Size);
        }

        private void InitializeElements(TaskModel task)
        {
            lblTask_Title.Text = task.TaskName;
            lblTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(task.TaskStart.Month)} {task.TaskStart.Day}");
            Deadlinetxt.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(task.Deadline.Month)} {task.Deadline.Day}");
            if (task.ProjectAssigned is null) lblProjectName.Text = "No Project";
            else lblProjectName.Text = task.ProjectAssigned.Name;
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                pictureboxFinished.Image = task.TaskImage;

            
        }

        private void TaskCard_Resize(object sender, EventArgs e)
        {
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
            resize_Control(pictureboxFinished, recpictureBox1);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(TaskCardOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(TaskCardOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void EditFlatButton_Click(object sender, EventArgs e)
        {
            TasksView editTask = (TasksView)this.Parent.Parent;

            editTask.btnEdittasks_Click(sender, e, Id);
        }
        public void TurnEditButtonVisible(EventArgs e)
        {
            if (EditFlatButton.Visible) EditFlatButton.Visible = false;
            else EditFlatButton.Visible = true;
        }
    }
}
