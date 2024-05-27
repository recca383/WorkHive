using Bunifu.Framework.UI;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
using static System.Net.Mime.MediaTypeNames;

namespace WorkHive.Views.LandingPage.LandingPagePages
{
    public partial class Sign_Up : UserControl
    {
        MemberModelAccess memberModelAccess = new MemberModelAccess();

        private Size SignUpOriginalSize;
        private Rectangle reclabel3;
        private Rectangle reclabel6;
        private Rectangle rectxtName;
        private Rectangle rectxtEmail;
        private Rectangle rectxtPassword;
        private Rectangle rectxtConfirmPassword;
        private Rectangle recbtnSignUp;
        private Rectangle recbtnSignIn;
        public Sign_Up()
        {
            InitializeComponent();
            this.Resize += Sign_Up_Resize;
            SignUpOriginalSize = this.Size;
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            rectxtName = new Rectangle(txtName.Location, txtName.Size);
            rectxtEmail = new Rectangle(txtEmail.Location, txtEmail.Size);
            rectxtPassword = new Rectangle(txtPassword.Location, txtPassword.Size);
            rectxtConfirmPassword = new Rectangle(txtConfirmPassword.Location, txtConfirmPassword.Size);
            recbtnSignIn = new Rectangle(btnSignIn.Location, btnSignIn.Size);
            recbtnSignUp = new Rectangle(btnSignUp.Location, btnSignUp.Size);
        }

        private void Sign_Up_Resize(object sender, EventArgs e)
        {
            resize_Control(label3, reclabel3);
            resize_Control(label6, reclabel6);
            resize_Control(txtEmail, rectxtEmail);
            resize_Control(txtName, rectxtName);
            resize_Control(txtPassword, rectxtPassword);
            resize_Control(txtConfirmPassword, rectxtConfirmPassword);
            resize_Control(btnSignIn, recbtnSignIn);
            resize_Control(btnSignUp, recbtnSignUp);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(SignUpOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(SignUpOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Landing_Page parent = this.ParentForm as Landing_Page;
            parent.btnSign_InEvent(sender, e);
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
            if (txtName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "") new MessageBoxes("Empty Text Box\nFill up all Text Boxed");
            else
            {
                if (IsPasswordHasNumber(txtPassword.Text) && HasCapitalLetter(txtPassword.Text) && Utility.IsEmailValid(txtEmail.Text))
                if (model.Any(n => n.FirstName == txtName.Text)) new MessageBoxes("Username Taken");
                else if (model.Any(m => m.Email == txtEmail.Text)) new MessageBoxes("Email Already Used");
                else if (!(txtPassword.Text == txtConfirmPassword.Text)) new MessageBoxes("Password Does Not Match");
                else
                {
                    memberModelAccess.AddMember(new MemberModel()
                    {
                        ID = model.Count,
                        FirstName = txtName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        IsLeader = false // change to false for creating member as default

                    });

                    new MessageBoxes("Sign Up Complete!");
                    txtName.Text = default;
                    txtEmail.Text = default;
                    txtPassword.Text = default;
                    txtConfirmPassword.Text = default;


                }
            }
            
        }

        private bool IsPasswordHasNumber(string text)
        {
            foreach(char c in text)
            {

                int p;
                if (int.TryParse(c.ToString(), out p))
                {
                    return true;
                    
                }

            }
            new MessageBoxes("Must Have atleast 1 number");
            return false;


        }
        private bool HasCapitalLetter(string text)
        {
            foreach (char c in text)
            {
                if (c >= 65 && c <= 90)
                {
                    return true;
                }

            }
            new MessageBoxes("Must Have atleast 1 Capital Letter");
            return false;
            

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            Controller.Utility.PasswordInitialVisibility(txtPassword);
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            Controller.Utility.PasswordInitialVisibility(txtConfirmPassword);
        }
        
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            Controller.Utility.ShowPasswordFunction(txtPassword, ShowPassword);
        }

        private void ShowPassword2_Click(object sender, EventArgs e)
        {
            Controller.Utility.ShowPasswordFunction(txtConfirmPassword, ShowPassword2);
        }
    }
}
