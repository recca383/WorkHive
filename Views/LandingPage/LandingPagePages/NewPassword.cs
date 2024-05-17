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
    public partial class NewPassword : UserControl
    {
        List<MemberModel> members = MemberModelAccess.GetMemberModel();

        public NewPassword()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage parent = this.ParentForm as ForgotPasswordPage;
            parent.GoBackToSecondStep();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var memberselected = members.FirstOrDefault(m => m.Email == ForgotPassword._email);
            if(!(MemberModelAccess.ChangePassword(memberselected, txtNewPassword.Text, txtConfirmPassword.Text)))
            {
                ParentForm.Hide();
            }

        }

        private void txtNewPassword_OnValueChanged(object sender, EventArgs e)
        {
            Controller.Utility.PasswordInitialVisibility(txtNewPassword);
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            Controller.Utility.PasswordInitialVisibility(txtConfirmPassword);
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            Controller.Utility.ShowPasswordFunction(txtNewPassword, ShowPassword);
        }

        private void ShowPassword2_Click(object sender, EventArgs e)
        {
            Controller.Utility.ShowPasswordFunction(txtConfirmPassword, ShowPassword2);
        }
    }
}
