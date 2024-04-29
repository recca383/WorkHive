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
    public partial class Sign_Up : UserControl
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Landing_Page.btnSign_InEvent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            List<MemberModel> model = MemberModelAccess.GetMemberModel();
            if (model.Any(n => n.Username == txtName.Text)) MessageBox.Show("Username Taken");
            else if (model.Any(m => m.Email == txtEmail.Text)) MessageBox.Show("Email Already Used");
            else if (!(txtPassword.Text == txtConfirmPassword.Text)) MessageBox.Show("Password Does Not Match");
            else
            {
                MemberModelAccess.AddMember(new MemberModel()
                {
                    Username = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    IsLeader = true // change to false for creating member as default
                    
                });

                MessageBox.Show("Sign Up Complete!", "Complete", MessageBoxButtons.OK);
                txtName.Text = default;
                txtEmail.Text = default;
                txtPassword.Text = default;
                txtConfirmPassword.Text = default;


            }
        }

        /* private void textBox4_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {
                 button1.PeformClick();
             }
         }*/
    }
}
