using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Cards;

namespace WorkHive
{
    public partial class AddTask : UserControl
    {

        public static event Action<object, EventArgs> OnTasksAdded1;
        public static event Action OnUpdate;
        List<ProjectModel > projects = ProjectModelAccess.GetProjects();
        
        public AddTask()
        {
            InitializeComponent();
            AddMembersToDropdown();
        }

        private void AddMembersToDropdown()
        {
            Dropdownassignproject.DataSource = projects.Select(n => n.ProjectName).ToArray(); 
        }

        private void btnAddTaskExit_Click(object sender, EventArgs e)
        {
            TasksView taskview = (TasksView)Parent.Parent;
            taskview.btnAll_Click(sender, e);
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
                TaskStatus = Status.Ongoing,
                ProjectAssigned = projects.FirstOrDefault(n => n.ProjectName == Dropdownassignproject.SelectedItem.ToString()),
                Deadline = DatePickerDeadline.Value,
                TaskStart = DateTime.Now
            }
            );
            TasksView taskview = (TasksView)Parent.Parent;
            taskview.OnProjectTasksOnclick(projects.FirstOrDefault(n => n.ProjectName == Dropdownassignproject.SelectedItem.ToString()));
            this.Parent.Controls.Remove(this);
            OnUpdate();
            OnTasksAdded1(sender,e);
        }

    }
}
