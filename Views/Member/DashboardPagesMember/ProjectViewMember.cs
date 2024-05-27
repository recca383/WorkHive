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
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Cards;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class ProjectViewMember : UserControl
    {
        private List<ProjectModel> project = ProjectModelAccess.GetProjects();

        List<ProjectModel> projects;
        public ProjectViewMember()
        {
            InitializeComponent();
            InitializeElements();
            ProjectSummaryMember.Visible = false;
            AddProject.OnProjectAdded1 += RefreshButton_Click;
        }

        private void InitializeElements()
        {
            projects = ProjectModelAccess.GetProjects();
            foreach (var project in projects)
            {
                ProjectsFlowMember.Controls.Add(new ProjectCard(project));
            }
        }

        public void Summary_Click(object sender, EventArgs e, ProjectModel projectModel)
        {
            ProjectSummaryMember.Controls.Clear();
            ProjectSummaryMember.Location = new Point(148, 158);
            ProjectSummaryMember.Size = new Size(640, 301);
            ProjectSummaryMember.Controls.Add(new ProjectSummary(projectModel));
            ProjectSummaryMember.Visible = true;

        }
        private void AddTaskPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ProjectSummaryMember.Visible = false;
        }

        private void RefreshList(List<ProjectModel> projectList)
        {

            ProjectsFlowMember.Controls.Clear();
            foreach (ProjectModel projectModel in projectList)
            {
                ProjectsFlowMember.Controls.Add(new ProjectCard(projectModel));
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var results = project.ToList();
            RefreshList(results);
        }
    
    }
}
