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
        private static List<MemberModel> members = MemberModelAccess.GetMemberModel();
        private string SelectedName;
        public AddTask()
        {
            InitializeComponent();
            AddMembersToDropdown();
        }

        private void btnAddTaskSubmit_Click(object sender, EventArgs e)
        {
            int taskID = TaskModelAccess.GetTaskCount();
            MemberModel selectedMember = members.FirstOrDefault(i => i.FirstName == SelectedName);
            TaskModelAccess.AddTask(taskID,TaskNametxt.Text, TaskDescriptiontxt.Text, ArchivedCheckbox.Checked, DatePickerDeadline.Value);
        }
        private void AddMembersToDropdown()
        {
            var name = members.Select(n => n.FirstName).ToArray();
            Dropdownassigntask.DataSource = name; 
        }

        private void btnAddTaskExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Dropdownassigntask_onItemSelected(object sender, EventArgs e)
        {
            SelectedName = Dropdownassigntask.SelectedItem.ToString();
        }

       
    }
}
