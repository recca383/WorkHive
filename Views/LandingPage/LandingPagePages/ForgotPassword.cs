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
using WorkHive.Model;

namespace WorkHive.Views.LandingPage.LandingPagePages
{
    public partial class ForgotPassword : UserControl
    {
        public static string _email;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnExitForgotPassword_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            List<MemberModel> memberModels = MemberModelAccess.GetMemberModel();
            var emailVerification = memberModels.Any(m => m.Email == txtEmailAddress.Text);
            _email = txtEmailAddress.Text;

            ForgotPasswordPage parent = this.ParentForm as ForgotPasswordPage;

            if (emailVerification)
            {
                parent.GoBackToSecondStep();
            }
            else
            {
                MessageBox.Show("Email Does Not Exist");
            }
        }
    }
}
