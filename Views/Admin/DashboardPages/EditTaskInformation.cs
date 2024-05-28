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
using WorkHive.Views.LandingPage.LandingPagePages;
using WorkHive.Views.Pages;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class EditTaskInformation : UserControl
    {
        TaskModel selectedtask;
        List<ProjectModel> projectModels = ProjectModelAccess.GetProjects();

        public static event Action OnUpdate;
        public static event Action<object, EventArgs> OnUpdate1;

        public EditTaskInformation(TaskModel _selectedtask)
        {
            
            this.selectedtask = _selectedtask;
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            ProjectModel project = projectModels.FirstOrDefault(p => p.Tasks.Contains(selectedtask));
            dropdownStatus.DataSource = Enum.GetNames(typeof(Status));
            dropdownStatus.SelectedIndex = (int)selectedtask.TaskStatus;

            EditTaskNametxt.PlaceholderText = selectedtask.TaskName;
            EditDatePickerDeadline.Value = selectedtask.Deadline; // masyado daw maliit
            EditTaskDescriptiontxt.PlaceholderText = selectedtask.TaskDescription;
            EditDropdownAssignProject.DataSource = projectModels.Select(p => p.ProjectName).ToArray();
            EditDropdownAssignProject.SelectedIndex = projectModels.IndexOf(project);

        }
        private void EditTaskSubmitbtn_Click(object sender, EventArgs e)
        {
            ProjectModel projectAssign = default;
            if (EditDropdownAssignProject.SelectedItem != null)
            {
                ProjectModel selectedproject = projectModels.FirstOrDefault(n => n.ProjectName == EditDropdownAssignProject.SelectedItem.ToString());
                if (selectedproject != null) projectAssign = selectedproject;
            }


            TaskModelAccess.EditTask(new TaskModel
            {
                TaskName = EditTaskNametxt.Text,
                Deadline = EditDatePickerDeadline.Value,
                TaskDescription = EditTaskDescriptiontxt.Text,
                TaskStatus = (Status)dropdownStatus.SelectedIndex,
                ProjectAssigned = projectAssign

            }, selectedtask.TaskID) ;
            new MessageBoxes("Edit Task Complete!!");
            TasksView taskview = (TasksView)Parent.Parent;
            taskview.OnProjectTasksOnclick(projectAssign);
            this.Parent.Controls.Remove(this);
            OnUpdate();
            
        }

        private void EditTaskExitbtn_Click(object sender, EventArgs e)
        {
            TasksView taskview = (TasksView)Parent.Parent;
            taskview.btnAll_Click(sender, e);
            this.Parent.Controls.Remove(this);
        }
    }
}
