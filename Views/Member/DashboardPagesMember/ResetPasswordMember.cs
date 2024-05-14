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
        private Size ResetPassMemberOriginalSize;
        private Rectangle recMmberResetPass;
        private Rectangle recbunifuPictureBox1;
        private Rectangle recbunifuPictureBox2;
        private Rectangle recbunifuLabel1;
        private Rectangle recbunifuLabel2;
        private Rectangle recbunifuLabel3;
        private Rectangle recbunifuLabel4;
        private Rectangle recbunifuLabel5;
        private Rectangle recbtnSend;
        private Rectangle rectxtCurrentPasswordMember;
        private Rectangle rectxtNewPasswordMember;
        private Rectangle rectxtConfirmPasswordMember;
        private Rectangle rectxtCode;
        private Rectangle recbtnUpdatePassword;

        MemberModel CurrentUser;
        private string _code;
        public ResetPasswordMember(MemberModel currentModel)
        {
            this.CurrentUser = currentModel;
            InitializeComponent();
            GenerateCode();
            this.Resize += ResetPasswordMember_Resize;
            ResetPassMemberOriginalSize = this.Size;
            recMmberResetPass = new Rectangle(MmberResetPass.Location, MmberResetPass.Size);
            recbunifuPictureBox1 = new Rectangle(bunifuPictureBox1.Location, bunifuPictureBox1.Size);
            recbunifuPictureBox2 = new Rectangle(bunifuPictureBox2.Location, bunifuPictureBox2.Size);
            recbunifuLabel1 = new Rectangle(bunifuLabel1.Location, bunifuLabel1.Size);
            recbunifuLabel2 = new Rectangle(bunifuLabel2.Location, bunifuLabel2.Size);
            recbunifuLabel3 = new Rectangle(bunifuLabel3.Location, bunifuLabel3.Size);
            recbunifuLabel4 = new Rectangle(bunifuLabel4.Location, bunifuLabel4.Size);
            recbunifuLabel5 = new Rectangle(bunifuLabel5.Location, bunifuLabel5.Size);
            recbtnSend = new Rectangle(btnSend.Location, btnSend.Size);
            rectxtCurrentPasswordMember = new Rectangle(txtCurrentPasswordMember.Location, txtCurrentPasswordMember.Size);
            rectxtNewPasswordMember = new Rectangle(txtNewPasswordMember.Location, txtNewPasswordMember.Size);
            rectxtConfirmPasswordMember = new Rectangle(txtConfirmPasswordMember.Location, txtConfirmPasswordMember.Size);
            rectxtCode = new Rectangle(txtCode.Location, txtCode.Size);
            recbtnUpdatePassword = new Rectangle(btnUpdatePassword.Location, btnUpdatePassword.Size);
        }
        private void ResetPasswordMember_Resize(object sender, EventArgs e)
        {
            resize_Control(MmberResetPass, recMmberResetPass);
            resize_Control(bunifuPictureBox1, recbunifuPictureBox1);
            resize_Control(bunifuPictureBox2, recbunifuPictureBox2);
            resize_Control(bunifuLabel1, recbunifuLabel1);
            resize_Control(bunifuLabel2, recbunifuLabel2);
            resize_Control(bunifuLabel3, recbunifuLabel3);
            resize_Control(bunifuLabel4, recbunifuLabel4);
            resize_Control(bunifuLabel5, recbunifuLabel5);
            resize_Control(btnSend, recbtnSend);
            resize_Control(txtCurrentPasswordMember, rectxtCurrentPasswordMember);
            resize_Control(txtNewPasswordMember, rectxtNewPasswordMember);
            resize_Control(txtConfirmPasswordMember, rectxtConfirmPasswordMember);
            resize_Control(txtCode, rectxtCode);
            resize_Control(btnUpdatePassword, recbtnUpdatePassword);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(ResetPassMemberOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(ResetPassMemberOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            Controller.Utilities.PasswordInitialVisibility(txtCurrentPasswordMember);
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            Controller.Utilities.PasswordInitialVisibility(txtNewPasswordMember);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Controller.Utilities.PasswordInitialVisibility(txtConfirmPasswordMember);
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            Controller.Utilities.ShowPasswordFunction(txtCurrentPasswordMember, ShowPassword);
        }

        private void ShowPassword2_Click(object sender, EventArgs e)
        {
            Controller.Utilities.ShowPasswordFunction(txtNewPasswordMember, ShowPassword2);
        }

        private void ShowPassword3_Click(object sender, EventArgs e)
        {
            Controller.Utilities.ShowPasswordFunction(txtConfirmPasswordMember, ShowPassword3);
        }

    }
}
