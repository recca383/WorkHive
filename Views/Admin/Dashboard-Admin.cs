using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Admin;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.LandingPage;
using WorkHive.Views.Pages;
//using System.Diagnostics
using static System.Net.WebRequestMethods;

namespace WorkHive.Views
{

    public partial class Dashboard_Admin : Form
    {

        MemberModel CurrentUser;
        int ID;

        static DashboardNavigation dashboardNavigation;
        public Dashboard_Admin(MemberModel CurrentUser)
        {
            this.ID = CurrentUser.ID;
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            RefreshPicture();
            Initialize_Navigation_Controls();
            
        }

             
        public void RefreshPicture()
        {
            CurrentUser = MemberModelAccess.GetMemberInfo(ID);
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (CurrentUser.Profile_Pic == " ")
            {
                ProfilePicBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                ProfilePicBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), CurrentUser.Profile_Pic));
            }

        }
        private void Initialize_Navigation_Controls()
        {

            //List <UserControl> list = new List<UserControl>()
            UserControl[] list = 
            { new DashboardView(CurrentUser), new MemberView(), new TasksView(), new ProjectView(), new CalendarView(), new MessageView(), new ProfileEdit(CurrentUser), new ResetPassword(CurrentUser)};

            dashboardNavigation = new DashboardNavigation(list, ViewPanel);
            dashboardNavigation.Display(0);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(0);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(1);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(2);
        }
        private void btnProjects_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(3);
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(4);
        }
        private void btnChats_Click_1(object sender, EventArgs e)
        {
            dashboardNavigation.Display(5);
        }
        public static void btnProfileEdit_Click()
        {
            dashboardNavigation.Display(6);
        }
        public static void btnResetPassword_Click()
        {
            dashboardNavigation.Display(7);
        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.sidebar.Width > 150)
            {
                sidebar.Width = 54;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Left;
                foreach (Button menubutton in sidebar.Controls.OfType<Button>())
                {
                    menubutton.Text = "";
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;

                }
            }
            else
            {
                sidebar.Width = 180;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menubutton in sidebar.Controls.OfType<Button>())
                {
                    menubutton.Text = "  " + menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;

                }

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing_Page landingpage = new Landing_Page();
            this.Hide();
            landingpage.Show();
        }

        /*private void btnChats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start();
        }*/

        

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfilePicBox_Click(object sender, EventArgs e)
        {
            ProfileAdmin profile = new ProfileAdmin(CurrentUser);
            profilepanel.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.Show();
            profilepanel.Parent = ViewPanel;
            profilepanel.BringToFront();
            if (profilepanel.Size == new Size(0, 0))
            {
                profilepanel.Size = new Size(383, 465);
                
            }
            else
            {
                profilepanel.Size = new Size(0, 0);
            }
        }

      
    }

    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);
        } 
    }
}
