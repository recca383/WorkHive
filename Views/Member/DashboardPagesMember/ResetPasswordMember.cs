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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class ResetPasswordMember : UserControl
    {
        MemberModel CurrentUser;
        private string _code;
        public ResetPasswordMember(MemberModel currentModel)
        {
            this.CurrentUser = currentModel;
            InitializeComponent();
            GenerateCode();
            
        }

        private void btnUpdatePasswordMember_Click(object sender, EventArgs e)
        {
            if (!(MemberModelAccess.ChangePassword(CurrentUser, txtCurrentPasswordMember.Text, txtNewPasswordMember.Text, txtConfirmPasswordMember.Text)))
            {
                txtCurrentPasswordMember.Clear();
                txtNewPasswordMember.Clear();
                txtConfirmPasswordMember.Clear();
            }
        }
       
        private async Task SendCode(string code)
        {

            try
            {
                MailNotif mail = new MailNotif(ForgotPassword._email, code);

                new MessageBoxes("Code Sent!");
            }
            catch (Exception e)
            {
                new MessageBoxes(e.Message);
            }

        }
        private void GenerateCode()
        {
            Random rnd = new Random();
            string code = "";
            for (int i = 0; i <= 5; i++)
            {
                int numcode = rnd.Next(0, 9);
                code += numcode.ToString();
            }
            _code = code;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendCode(_code);
        }

        private void txtCurrentPasswordMember_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentPasswordMember.Text == "")
            {
                txtCurrentPasswordMember.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPasswordMember.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPasswordMember_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPasswordMember.Text == "")
            {
                txtNewPasswordMember.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPasswordMember.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPasswordMember_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPasswordMember.Text == "")
            {
                txtConfirmPasswordMember.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPasswordMember.UseSystemPasswordChar = true;
            }
        }
    }
}
