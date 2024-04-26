using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.LandingPage.LandingPagePages;
using WorkHive.Views.Pages;

namespace WorkHive.Views.LandingPage
{
    public partial class Landing_Page : Form
    {
        static DashboardNavigation dashboardNavigation;
        public Landing_Page()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
        }
        private void Initialize_Navigation_Controls()
        {
            List<UserControl> list = new List<UserControl>()
            { new Sign_In(), new Sign_Up() };

            dashboardNavigation = new DashboardNavigation(list, LandingPageViewPanel);
            dashboardNavigation.Display(0);
        }
        public static void btnSign_InEvent()
        {
            dashboardNavigation.Display(0);
        }
        public static void btnSign_UpEvent()
        {
            dashboardNavigation.Display(1);
        }

    }
}
