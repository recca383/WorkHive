using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging.Design;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;

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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SignIn();

        }
        private void SignIn()
        {
            var memberModel = MemberModelAccess.GetMemberModel();
            var CurrentUser = memberModel.FirstOrDefault(c => c.Email == txtEmail.Text && c.Password == txtPassword.Text);

            if (CurrentUser == null)
            {
                MessageBox.Show("Wrong Credentials!");
               /*Messageboxes Wrong = new Messageboxes();
               Wrong.Show();*/
            }
            else if (CurrentUser.IsLeader)
            {
                Dashboard_Admin admin = new Dashboard_Admin(CurrentUser);
                admin.Show();
                this.ParentForm.Hide();

            }
            else if (!CurrentUser.IsLeader)
            {
                //member dashboard
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            var forgotPassword = new ForgotPasswordPage();
            forgotPassword.Show();
           // ParentForm.Enabled = false;
        }
    }
}
