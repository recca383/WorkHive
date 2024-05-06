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

namespace WorkHive.Views.Pages
{
    public partial class DashboardView : UserControl
    {
        List<TaskModel> tasks;
        List<MemberModel> members;
        MemberModel currentUser;
        public DashboardView(MemberModel CurrentUser)
        {
            currentUser = CurrentUser;
            InitializeComponent();
            RefreshElements();
        }
        private void RefreshElements()
        {
            TasksSummary.Controls.Clear();
            tasks = TaskModelAccess.GetTaskModel();
            members = MemberModelAccess.GetMemberModel();

            //Tasks
            float totalprogress = 0;
            
            foreach (var task in tasks)
            {
                totalprogress += task.TaskProgress;
                TasksSummary.Controls.Add(new TaskSummaryCard(task.TaskName,task.Deadline,task.TaskID));
            }
            float averageprogress = totalprogress / tasks.Count();
            AverageProgress.Value = (int)averageprogress;

            lblTotalMembers.Text = members
                .Count()
                .ToString();
            lblActiveTasks.Text = tasks
                .Where(t => !t.Archived && t.TaskProgress != 100)
                .Count()
                .ToString();
            lblFinishedTasks.Text = tasks
                .Where(t => t.TaskProgress == 100)
                .Count()
                .ToString();



        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshElements();
        }
    }
}
