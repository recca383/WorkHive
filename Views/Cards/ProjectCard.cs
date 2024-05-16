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
        ProjectModel projectModel;
        public ProjectCard(ProjectModel projectModel)
        {
            this.projectModel = projectModel;
            InitializeComponent();
            lblProject_Title.Text = projectModel.Name;
            lblName.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(projectModel.StartDate.Month)} {projectModel.StartDate.Day}");

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            ProjectView parent = (ProjectView)this.Parent.Parent;
            parent.btnEdittasks_Click(sender, e, projectModel);
        }
    }
}
