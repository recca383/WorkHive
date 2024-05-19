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
        private Size DashBoardViewOriginalSize;
        private Rectangle recDashboardlbl;
        private Rectangle recpanel1;
        private Rectangle recpanel9;
        private Rectangle recpanel7;
        private Rectangle recpanel8;
        private Rectangle recpanel4;
        private Rectangle recRefreshButton;
        private Rectangle recpanel5;
        private Rectangle recpanel2;
        private Rectangle recpanel3;

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


            this.Resize += DashboardView_Resize;
            DashBoardViewOriginalSize = this.Size;
            recDashboardlbl = new Rectangle(Dashboardlbl.Location, Dashboardlbl.Size);
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpanel9 = new Rectangle(panel9.Location, panel9.Size);
            recpanel7 = new Rectangle(panel7.Location, panel7.Size);
            recpanel8 = new Rectangle(panel8.Location, panel8.Size);
            recpanel4 = new Rectangle(panel4.Location, panel4.Size);
            recRefreshButton = new Rectangle(RefreshButton.Location, RefreshButton.Size);
            recpanel5 = new Rectangle(panel5.Location, panel5.Size);
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);

            
        }

        private void DashboardView_Resize(object sender, EventArgs e)
        {
            resize_Control(Dashboardlbl, recDashboardlbl);
            resize_Control(panel1, recpanel1);
            resize_Control(panel9, recpanel9);
            resize_Control(panel7, recpanel7);
            resize_Control(panel8, recpanel8);
            resize_Control(panel4, recpanel4);
            resize_Control(RefreshButton, recRefreshButton);
            resize_Control(panel5, recpanel5);
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(DashBoardViewOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(DashBoardViewOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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
            
            int finishedtasks = tasks
                .Where(t => t.TaskStatus == Status.Finished)
                .Count();
            int activetasks = tasks
                .Where(t => t.TaskStatus == Status.Ongoing)
                .Count();
            int totaltasks = activetasks + finishedtasks;

            lblTotalMembers.Text = members
                .Count()
                .ToString();
            lblActiveTasks.Text = activetasks
                .ToString();
            lblFinishedTasks.Text = finishedtasks
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
    }
}
