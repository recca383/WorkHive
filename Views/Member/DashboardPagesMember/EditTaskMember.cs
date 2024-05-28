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
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class EditTaskMember : UserControl
    {
        TaskModel selectedtask;

        public static event Action OnUpdate;
        public static event Action<object, EventArgs> OnUpdate1;

        public EditTaskMember(TaskModel _selectedtask)
        {

            this.selectedtask = _selectedtask;
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            dropdownStatus.DataSource = Enum.GetNames(typeof(Status));
            dropdownStatus.SelectedIndex = (int)selectedtask.TaskStatus;
        }
        private void EditTaskSubmitbtn_Click(object sender, EventArgs e)
        {
            ProjectModel projectAssign = default;

            TaskModelAccess.EditTask(new TaskModel
            {
                TaskStatus = (Status)dropdownStatus.SelectedIndex,
                ProjectAssigned = projectAssign

            }, selectedtask.TaskID);
            new MessageBoxes("Edit Task Complete!!");
            TaskViewMember taskview = (TaskViewMember)Parent.Parent;
            taskview.OnProjectTasksOnclick(projectAssign);
            this.Parent.Controls.Remove(this);
            OnUpdate();

        }

        private void EditTaskExitbtn_Click(object sender, EventArgs e)
        {
            TaskViewMember taskview = (TaskViewMember)Parent.Parent;
            taskview.RefreshButton_Click(sender, e);
            this.Parent.Controls.Remove(this);
        }
    }
}
