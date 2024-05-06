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
        private Size LandingPageOriginalSize;
        private Rectangle recpanel1;
        private Rectangle recpictureBox1;
        private Rectangle recLandingPageViewPanel;
        static DashboardNavigation dashboardNavigation;
        public Landing_Page()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
            this.Resize += Landing_Page_Resize; 
            LandingPageOriginalSize = this.Size;
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recLandingPageViewPanel = new Rectangle(LandingPageViewPanel.Location, LandingPageViewPanel.Size);
        }

        private void Landing_Page_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpanel1);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(LandingPageViewPanel, recLandingPageViewPanel);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(LandingPageOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(LandingPageOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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
            //MailNotif.Send();
        }
        public static void btnSign_UpEvent()
        {
            dashboardNavigation.Display(1);
        }

        private void LandingPageViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
