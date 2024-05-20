using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class ProjectProgress : UserControl
    {
      
        public ProjectProgress(int projectID)
        {
            InitializeComponent();
            InitializeElements(projectID);
        }



        private void InitializeElements(int projectID)
        {
            ProjectName.Text = ProjectModelAccess.GetProjectDetails(projectID).Name;
            AverageProgress.Value = ProjectModelAccess.GetProjectProgress(projectID);
        }
    }
}
