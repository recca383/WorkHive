using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Pages;

namespace WorkHive.Views
{
    public partial class Dashboard_Admin : Form
    {
        MemberModel CurrentUser;

        DashboardNavigation dashboardNavigation;
        public Dashboard_Admin(MemberModel CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            Initialize_Controls_According_To_User();
            Initialize_Navigation_Controls();
        }
        private void Initialize_Controls_According_To_User()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            ProfilePicBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent),CurrentUser.Profile_Pic));
        }
        private void Initialize_Navigation_Controls()
        {
            List<UserControl> list = new List<UserControl>()
            { new DashboardView(), new MemberView(), new TasksView() };

            dashboardNavigation = new DashboardNavigation(list, ViewPanel);
            dashboardNavigation.Display(0);
        }

        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {
            dashboardNavigation.Display(0);
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            dashboardNavigation.Display(1);
        }

        private void btnTasks_Click_1(object sender, EventArgs e)
        {
            dashboardNavigation.Display(2);
        }

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.sidebar.Width > 200)
            {
                sidebar.Width = 42;
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
                sidebar.Width = 244;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menubutton in sidebar.Controls.OfType<Button>())
                {
                    menubutton.Text = "  " + menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;

                }

            }
        }

        private void ViewPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
