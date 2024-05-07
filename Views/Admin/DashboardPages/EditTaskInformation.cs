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

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class EditTaskInformation : UserControl
    {
        TaskModel selectedtask;
        public EditTaskInformation(TaskModel _selectedtask)
        {
            this.selectedtask = _selectedtask;
            InitializeComponent();
            SetDefaultValues();
            
        }

        private void SetDefaultValues()
        {
            EditTaskNametxt.PlaceholderText = selectedtask.TaskName;
            EditDatePickerDeadline.Value = selectedtask.Deadline;
            EditTaskDescriptiontxt.PlaceholderText = selectedtask.TaskDescription;

        }
        private void EditTaskSubmitbtn_Click(object sender, EventArgs e)
        {
            
            TaskModelAccess.EditTask(new TaskModel
            {
                TaskName = EditTaskNametxt.Text,
                Deadline = EditDatePickerDeadline.Value,
                TaskDescription = EditTaskDescriptiontxt.Text

            }, selectedtask.TaskID);
            MessageBox.Show("Edit Task Complete!!");
            this.Parent.Controls.Remove(this);
        }

        private void EditTaskExitbtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
