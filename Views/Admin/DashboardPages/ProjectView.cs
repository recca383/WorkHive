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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class ProjectView : UserControl
    {
        private List<ProjectModel> project = ProjectModelAccess.GetProjects();

        List<ProjectModel> projects;
        public ProjectView()
        {
            InitializeComponent();
            InitializeElements();
            ProjectSummary.Visible = false;
            AddProject.OnProjectAdded1 += RefreshButton_Click;
        }

        private void InitializeElements()
        {
            projects = ProjectModelAccess.GetProjects();
            foreach(var project in projects)
            {
                ProjectsFlow.Controls.Add(new ProjectCard(project));
            }
        }

        public void Summary_Click(object sender, EventArgs e, ProjectModel projectModel)
        {
            ProjectSummary.Controls.Clear();
            ProjectSummary.Location = new Point(148, 158);
            ProjectSummary.Size = new Size(640, 301);
            ProjectSummary.Controls.Add(new ProjectSummary(projectModel));
            ProjectSummary.Visible = true;

        }
        private void AddTaskPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ProjectSummary.Visible = false;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            ProjectSummary.Controls.Clear();
            ProjectSummary.Location = new Point(276, 46);
            ProjectSummary.Size = new Size(446, 523);
            ProjectSummary.Controls.Add(new AddProject());
            ProjectSummary.Visible = true;
        }

        private void RefreshList(List<ProjectModel> projectList)
        {

            ProjectsFlow.Controls.Clear();
            foreach (ProjectModel projectModel in projectList)
            {
                ProjectsFlow.Controls.Add(new ProjectCard(projectModel));
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var results = project.ToList();
            RefreshList(results);
        }
    }
}
