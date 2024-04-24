using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Views.LandingPage.LandingPagePages
{
    public partial class Sign_In : UserControl
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Landing_Page.btnSign_UpEvent();
        }
    }
}
