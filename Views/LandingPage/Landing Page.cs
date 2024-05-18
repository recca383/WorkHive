using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
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
        public Landing_Page()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
            LandingPageViewPanel.Controls.Clear();
            LandingPageViewPanel.Controls.Add(new Sign_In());
            
        }       

        private void Initialize_Navigation_Controls()
        {
            //List<UserControl> list = new List<UserControl>()
            UserControl[] list = 
            { new Sign_In(), new Sign_Up() };

        }
        public void btnSign_InEvent(object sender, EventArgs e)
        {
            LandingPageViewPanel.Controls.Clear();
            LandingPageViewPanel.Controls.Add(new Sign_In());
            //MailNotif.Send();
        }
        public void btnSign_UpEvent(object sender, EventArgs e)
        {
            LandingPageViewPanel.Controls.Clear();
            LandingPageViewPanel.Controls.Add(new Sign_Up());
        }

    }
}
