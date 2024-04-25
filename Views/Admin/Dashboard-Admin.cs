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
    }
}
