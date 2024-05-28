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
using WorkHive.Views.Member.DashboardPagesMember;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            lblProject_Title.Text = projectModel.ProjectName;
            lblName.Text = projectModel.Instructor;
            this.BackgroundImage = projectModel.ColorImage;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is ProjectView)
            {
                ProjectView parent = (ProjectView)this.Parent.Parent;
                parent.LoadProjectSummary(sender,e, this.projectModel);
                parent.Summary_Click(sender, e);
            }
            else
            {
                ProjectViewMember parent1 = (ProjectViewMember)Parent.Parent;
                parent1.LoadProjectSummary(sender, e, this.projectModel);
                parent1.Summary_Click(sender, e);
            }
        }
        

        private void btnTasks_Click(object sender, EventArgs e)
        {
                OnProjectTasksClick(sender, e);
                OnProjectModelClick(projectModel);


            
        }
    }
}
