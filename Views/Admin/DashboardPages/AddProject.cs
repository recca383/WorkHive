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
using Color = WorkHive.Model.Color;

namespace WorkHive
{
    public partial class AddProject : UserControl
    {
        List<ProjectModel> projects = ProjectModelAccess.GetProjects();
        public static event Action<object, EventArgs> OnProjectAdded1;
        public static event Action<ProjectModel> OnProjectAdded2;
        public AddProject()
        {
            InitializeComponent();
            DesignFilter.DataSource = Enum.GetNames(typeof(Color));
        }

        private void btnAddProjectExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnAddProjectProceed_Click(object sender, EventArgs e)
        {
            ProjectModel project = new ProjectModel
            {
                Id = projects.Count(),
                Name = ProjectTaskNametxt.Text,
                Instructor = Instructortxt.Text,
                ColorStatus = (Color)DesignFilter.SelectedIndex
            };

            ProjectModelAccess.AddProject(project);
            OnProjectAdded1?.Invoke(sender, e);
            OnProjectAdded2?.Invoke(project);
            this.Parent.Controls.Remove(this);
        }
    }
}
