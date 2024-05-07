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
                MailNotif mail = new MailNotif(ForgotPassword._email, MailNotif.Mailfunctions.ResetPassword, code);

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
