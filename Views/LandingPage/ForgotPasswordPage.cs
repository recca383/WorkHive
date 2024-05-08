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

namespace WorkHive.Views.LandingPage
{
    public partial class ForgotPasswordPage : Form
    {
        static DashboardNavigation forgotpasswordnavigation;
        public ForgotPasswordPage()
        {
            InitializeComponent();
            AddUserControls();

        }
        private void AddUserControls()
        {
            //List<UserControl> list = new List<UserControl>
            UserControl[] list = 
            { new ForgotPassword(), new VerifyPassword(), new NewPassword()};
            forgotpasswordnavigation = new DashboardNavigation(list, ForgotPasswordPanel);
            forgotpasswordnavigation.Display(0);
        }
        public void GoBackToFirstStep()
        {
            forgotpasswordnavigation.Display(0);
        }
        public void GoBackToSecondStep()
        {
            forgotpasswordnavigation.Display(1);
        }
        public void GoToSecondStep()
        {
            forgotpasswordnavigation.Display(1);
        }
        public void GoToThirdStep()
        {
            forgotpasswordnavigation.Display(2);
        }

    }
}
