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
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class EditTaskInformation : UserControl
    {
        TaskModel selectedtask;
        List<ProjectModel> projectModels = ProjectModelAccess.GetProjects();
        public EditTaskInformation(TaskModel _selectedtask)
        {
            this.selectedtask = _selectedtask;
            InitializeComponent();
            SetDefaultValues();
            
        }

        private void SetDefaultValues()
        {
            EditTaskNametxt.PlaceholderText = selectedtask.TaskName;
            EditDatePickerDeadline.Value = selectedtask.Deadline; // masyado daw maliit
            EditTaskDescriptiontxt.PlaceholderText = selectedtask.TaskDescription;
            EditDropdownAssignProject.DataSource = projectModels.Select(n => n.Name).ToArray();
            EditDropdownAssignProject.SelectedItem = selectedtask.ProjectAssigned;

        }
        private void EditTaskSubmitbtn_Click(object sender, EventArgs e)
        {
            ProjectModel projectAssign = default;
            if (EditDropdownAssignProject.SelectedItem != null)
            {
                ProjectModel selectedproject = projectModels.FirstOrDefault(n => n.Name == EditDropdownAssignProject.SelectedItem.ToString());
                if (selectedproject != null) projectAssign = selectedproject;
            }
            
            
            TaskModelAccess.EditTask(new TaskModel
            {
                TaskName = EditTaskNametxt.Text,
                Deadline = EditDatePickerDeadline.Value,
                TaskDescription = EditTaskDescriptiontxt.Text,
                ProjectAssigned = projectAssign

            }, selectedtask.TaskID);
            new MessageBoxes("Edit Task Complete!!");
            this.Parent.Controls.Remove(this);
        }

        private void EditTaskExitbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
