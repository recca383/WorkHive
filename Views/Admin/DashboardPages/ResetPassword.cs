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
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Admin
{
    
    public partial class ResetPassword : UserControl
    {
        private string _code;
        MemberModel CurrentUser;
        public ResetPassword(MemberModel _CurrentUser)
        {
            this.CurrentUser = _CurrentUser;
            InitializeComponent();
            GenerateCode();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(_code == txtCode.Text)
            {
                if (!(MemberModelAccess.ChangePassword(CurrentUser, txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text)))
                {
                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                }
            }
                
            
        }
        private async Task SendCode(string code)
        {

            try
            {
                MailNotif mail = new MailNotif(ForgotPassword._email, code);

                MessageBox.Show("Code Sent!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
    }
}
