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
       
        public Sign_Up()
        {
            InitializeComponent();
           
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
                if (IsPasswordHasNumber(txtPassword.Text) && HasCapitalLetter(txtPassword.Text) && PasswordLength(txtPassword.Text) && HasSpecialCharacter(txtPassword.Text) && Utility.IsEmailValid(txtEmail.Text))
                if (model.Any(n => n.FirstName == txtName.Text)) new MessageBoxes("Username Taken");
                else if (model.Any(m => m.Email == txtEmail.Text)) new MessageBoxes("Email Already Used");
                else if (!(txtPassword.Text == txtConfirmPassword.Text)) new MessageBoxes("Password Does Not Match");
                else
                {
                    MemberModelAccess.AddMember(new MemberModel()
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
        private bool PasswordLength(string text)
        {
            string p = text;
            if (p.Length >= 8)
            {
                return true;
            }
            new MessageBoxes("Password must be at least 8 characters long");
            return false;

            
        }
        private bool HasSpecialCharacter(string text)
        {
            string specialCharacters = "!@#$%^&*()_+[]{}|;:'\",.<>?/~`-=";
            foreach (char c in text)
            {
                if (specialCharacters.Contains(c))
                {
                    return true;
                }
            }
            new MessageBoxes("Must have at least 1 special character");
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
