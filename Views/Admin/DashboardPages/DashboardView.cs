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
using WorkHive.Views.Admin;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Cards;
using WorkHive.Views.Member.DashboardPagesMember;

namespace WorkHive.Views.Pages
{
    public partial class DashboardView : UserControl
    {       
        List<TaskModel> tasks;
        List<MemberModel> members;
        List<ProjectModel> projects;
        MemberModel currentUser;
        int projectID = 0;


        public DashboardView(MemberModel CurrentUser)
        {
            currentUser = CurrentUser;
            InitializeComponent();
            RefreshElements();

            EditTaskInformation.OnUpdate  += RefreshElements;
            AddTask.OnUpdate += RefreshElements;
            MemberTaskCard.OnUpdate += RefreshElements;
            ProfileEditMember.OnUpdate += RefreshElements;
            ProfileEdit.OnUpdate += RefreshElements;
        }
     
        public void RefreshElements()
        {
            TasksSummary.Controls.Clear();
            EventsPanel.Controls.Clear();
            ProjectProgressPanel.Controls.Clear();
            

            projects = ProjectModelAccess.GetProjects();
            tasks = TaskModelAccess.GetTaskModel();
            members = MemberModelAccess.GetMemberModel();

            ProjectProgressPanel.Controls.Add(new ProjectProgress(projectID));
            ProjectProgressPanel.Dock = DockStyle.Fill;

            var dateofmembers = members
                .Where(d => d.Birthday.Month <= DateTime.Now.Month +2)
                .OrderBy(d => d.Birthday);
            

            foreach(MemberModel member in dateofmembers)
            {
                EventsPanel.Controls.Add(new BirthdayCard(member));

            }
            foreach(TaskModel task in tasks)
            {
                TasksSummary.Controls.Add(new TaskSummaryCard(task.ProjectName, task.TaskName, task.Deadline, task.TaskID));
            }
            int finishedtasks = tasks
                .Where(t => t.TaskStatus == Status.Finished)
                .Count();
            int activetasks = tasks
                .Where(t => t.TaskStatus == Status.Ongoing)
                .Count();
            int finishedprojects = projects
                .Where (t => t.ProjectStatus == StatusProject.Finished)
                .Count();
            int totaltasks = activetasks + finishedtasks;

            lblTotalMembers.Text = members
                .Count()
                .ToString();
            lblActiveTasks.Text = activetasks
                .ToString();
            lblFinishedTasks.Text = finishedtasks
                .ToString();
            lblFinishedProj.Text = finishedprojects
                .ToString();

           // AverageProgress.Value = (int)Math.Floor(((decimal)finishedtasks / totaltasks * 100));
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshElements();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (projectID == projects.Count() - 1) projectID = 0;
            else projectID++;
            RefreshElements();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (projectID == 0) projectID = projects.Count() - 1 ;
            else projectID--;
            RefreshElements();
        }

        private void lblFinishedTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
