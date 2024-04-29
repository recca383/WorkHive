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
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Cards
{
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
        }

        static DashboardNavigation dashboardNavigation;
        private void Initialize_Navigation_Controls()
        {
            List<UserControl> list = new List<UserControl>()
            { new Sign_In(), new Sign_Up() };

            dashboardNavigation = new DashboardNavigation(list, TasksPanel);
            dashboardNavigation.Display(0);
        }

        private void lblTask_Title_Click(object sender, EventArgs e)
        {

        }

        private void TaskCard_Load(object sender, EventArgs e)
        {

        }
    }
}
