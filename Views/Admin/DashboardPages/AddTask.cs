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
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Cards;

namespace WorkHive
{
    public partial class AddTask : UserControl
    {
        List<ProjectModel > projects = ProjectModelAccess.GetProjects();
        private string SelectedName;
        public AddTask()
        {
            InitializeComponent();
            AddMembersToDropdown();
        }


        private void AddMembersToDropdown()
        {
            Dropdownassignproject.DataSource = projects.Select(n => n.Name).ToArray(); 
        }

        private void btnAddTaskExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        private void btnAddTaskSubmit_Click(object sender, EventArgs e)
        {
            int taskID = TaskModelAccess.GetTaskCount();
            TaskModelAccess.AddTask( new TaskModel
            {
                TaskID = taskID, 
                TaskName = TaskNametxt.Text, 
                TaskDescription = TaskDescriptiontxt.Text, 
                Archived = ArchivedCheckbox.Checked,
                ProjectAssigned = (ProjectModel)Dropdownassignproject.SelectedItem,
                Deadline = DatePickerDeadline.Value
            }

            );
        }

    }
}
