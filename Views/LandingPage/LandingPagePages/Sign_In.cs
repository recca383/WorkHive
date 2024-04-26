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
            var memberModel = MemberModelAccess.GetMemberModel();
            var CurrentUser = memberModel.FirstOrDefault(c => c.Email == txtEmail.Text && c.Password == txtPassword.Text);

            if (CurrentUser == null)
            {
                MessageBox.Show("Wrong Credentials");
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

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

       /* private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn.PeformClick();
              
            } di gumagana sa flat button :(
        }*/


    }
}
