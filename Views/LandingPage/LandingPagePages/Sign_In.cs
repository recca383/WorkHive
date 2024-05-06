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

namespace WorkHive.Views.LandingPage.LandingPagePages
{
    public partial class Sign_In : UserControl
    {
        private Size SigninOriginalSize;
        private Rectangle reclabel3;
        private Rectangle rectxtEmail;
        private Rectangle rectxtPassword;
        private Rectangle recbtnSignIn;
        private Rectangle recbtnForgotPass;
        private Rectangle recbtnSignUp;
        public Sign_In()
        {
             
            InitializeComponent();
            this.Resize += Sign_In_Resize1;
            SigninOriginalSize = this.Size;
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            rectxtEmail = new Rectangle(txtEmail.Location, txtEmail.Size);
            rectxtPassword = new Rectangle(txtPassword.Location, txtPassword.Size);
            recbtnSignIn = new Rectangle(btnSignIn.Location, btnSignIn.Size);
            recbtnForgotPass = new Rectangle(btnForgotPass.Location, btnForgotPass.Size);
            recbtnSignUp = new Rectangle(btnSignUp.Location, btnSignUp.Size);
        }

        private void Sign_In_Resize1(object sender, EventArgs e)
        {
            resize_Control(label3, reclabel3);
            resize_Control(txtEmail, rectxtEmail);
            resize_Control(txtPassword, rectxtPassword);
            resize_Control(btnSignIn, recbtnSignIn);
            resize_Control(btnForgotPass, recbtnForgotPass);
            resize_Control(btnSignUp, recbtnSignUp);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(SigninOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(SigninOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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
