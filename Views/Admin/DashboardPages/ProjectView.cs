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
using WorkHive.Views.Cards;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class ProjectView : UserControl
    {
        List<ProjectModel> projects;
        public ProjectView()
        {
            InitializeComponent();
            InitializeElements();
            ProjectSummary.Visible = false;
        }

        private void InitializeElements()
        {
            projects = ProjectModelAccess.GetProjects();
            foreach(var project in projects)
            {
                ProjectsFlow.Controls.Add(new ProjectCard(project));
            }
        }

        public void btnEdittasks_Click(object sender, EventArgs e, ProjectModel projectModel)
        {
            ProjectSummary.Controls.Clear();
            ProjectSummary.Controls.Add(new ProjectSummary(projectModel));
            ProjectSummary.Visible = true;

        }
        private void AddTaskPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ProjectSummary.Visible = false;
        }


    }
}
