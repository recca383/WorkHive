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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WorkHive.Views.Member.DashboardPagesMember;

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
            Landing_Page parent = this.ParentForm as Landing_Page;
            parent.btnSign_UpEvent(sender, e);

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
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
                new MessageBoxes("Wrong Credentials!");
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
                Dashboard_Member dashboard = new Dashboard_Member(CurrentUser);
                dashboard.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            var forgotPassword = new ForgotPasswordPage();
            forgotPassword.Show();
           // ParentForm.Enabled = false;
        }
        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            Controller.Utility.PasswordInitialVisibility(txtPassword);
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            Controller.Utility.ShowPasswordFunction(txtPassword, ShowPassword);
        }
    }
}
