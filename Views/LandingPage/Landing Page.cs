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
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.LandingPage
{
    public partial class Landing_Page : Form
    {
        
        public Landing_Page()
        {
            Sign_In sign_In = new Sign_In();
            InitializeComponent();
            LandingPageViewPanel.Controls.Add(sign_In);
            sign_In.BringToFront();
        }



    }
}
