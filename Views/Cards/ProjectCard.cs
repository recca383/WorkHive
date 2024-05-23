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
using WorkHive.Model;
using WorkHive.Views.Admin.DashboardPages;

namespace WorkHive.Views.Cards
{
    public partial class ProjectCard : UserControl
    {
        public static event Action<object, EventArgs> OnProjectTasksClick;
        public static event Action<ProjectModel> OnProjectModelClick;
        private ProjectModel projectModel;

        public ProjectCard(ProjectModel projectModel)
        {
            this.projectModel = projectModel;
            InitializeComponent();
            lblProject_Title.Text = projectModel.Name;
            lblName.Text = projectModel.Instructor;

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            ProjectView parent = (ProjectView)this.Parent.Parent;
            parent.Summary_Click(sender, e, projectModel);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            OnProjectTasksClick(sender, e);
            OnProjectModelClick(projectModel);
        }
    }
}
