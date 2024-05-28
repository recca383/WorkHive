using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;
using WorkHive.Views.Member.DashboardPagesMember;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class TaskDetailsCard : UserControl
    {
        TaskModel task;
        public TaskDetailsCard(TaskModel task)
        {
            this.task = task;
            InitializeComponent();
            InitializeElements();
        }

        private void InitializeElements()
        {
            if (task.ProjectAssigned != null)
            {
                lblProjectName.Text = task.ProjectAssigned.ProjectName;
            }
            else
            {
                lblProjectName.Text = "No Project Assigned";
            }
            
            lblTaskName.Text = task.TaskName;
            lblDateStarted.Text = task.TaskStart.ToString("MMMM dd, yyyy");
            lblDeadline.Text = task.Deadline.ToString("MMMM dd, yyyy");
            lblDescription.Text = task.TaskDescription;
            lblStatus.Text = task.TaskStatus.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is TasksView)
            {
                //TasksView taskview = (TasksView)Parent.Parent;
                //taskview.btnAll_Click(sender, e);
                this.Parent.Controls.Remove(this);
                this.Visible = false;
            }
            else {
                //TaskViewMember taskview1 = (TaskViewMember)Parent.Parent;
                //taskview1.btnAll_Click(sender, e);
                this.Parent.Controls.Remove(this);
                this.Visible = false;
            }
            
        }
    }
}
