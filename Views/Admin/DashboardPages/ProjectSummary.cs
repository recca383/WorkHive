using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class ProjectSummary : UserControl
    {
        ProjectModel projectModel;
        public ProjectSummary(ProjectModel projectmodel)
        { 
            this.projectModel = projectmodel;
            InitializeComponent();
            InitializeElements();
            
        }

        private void InitializeElements()
        {
            if (projectModel.Tasks == null)
            {
                return;
            }
            
            List<TaskModel> taskModel = projectModel.Tasks;
            if(taskModel != null)
            {
                lblTotalTasks.Text = taskModel.Count.ToString();
                lblActiveTasks.Text = taskModel.Where(t => t.TaskStatus == Status.Ongoing).Count().ToString();
                lblFinishedTasks.Text = taskModel.Where(t => t.TaskStatus == Status.Finished).Count().ToString();
                lblArchivedTasks.Text = taskModel.Where(t => t.TaskStatus == Status.Archived).Count().ToString();
                AverageProgress.Value = ProjectModelAccess.GetProjectProgress(projectModel.Id);
            }
                
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Parent.Controls.Remove(this);
        }
    }
}
