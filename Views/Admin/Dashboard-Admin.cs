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
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Pages;

namespace WorkHive.Views
{
    public partial class Dashboard_Admin : Form
    {
        

        DashboardNavigation dashboardNavigation;
        public Dashboard_Admin()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
        }

        private void Initialize_Navigation_Controls()
        {
            List<UserControl> list = new List<UserControl>()
            { new DashboardView(), new MemberView(), new TasksView() };

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

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool sidebarExpand;

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // if sidebar is expanded, minimize
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashBoard.Width = sidebar.Width;
                    pnEmployees.Width = sidebar.Width;
                    pnTasks.Width = sidebar.Width;
                    edittasksContainer.Width = sidebar.Width;
                    pnCalendar.Width = sidebar.Width;
                    pnMail.Width = sidebar.Width;

                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 191)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashBoard.Width = sidebar.Width;
                    pnEmployees.Width = sidebar.Width;
                    pnTasks.Width = sidebar.Width;
                    edittasksContainer.Width = sidebar.Width;
                    pnCalendar.Width = sidebar.Width;
                    pnMail.Width = sidebar.Width;

                }
            }
        }

        bool edittasksExpand; 
      
        private void edittasksTransition_Tick(object sender, EventArgs e)
        {
            if (edittasksExpand == false)
            {
                edittasksContainer.Height += 10;
                if (edittasksContainer.Height >= 159)
                {
                    edittasksTransition.Stop();
                    edittasksExpand = true;
                }
            }
            else
            {
                edittasksContainer.Height -= 10;
                if (edittasksContainer.Height <= 65)
                {
                    edittasksTransition.Stop();
                    edittasksExpand = false;
                }
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            edittasksTransition.Start();
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
