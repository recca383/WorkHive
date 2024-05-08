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
        private Size ResetPassOriginalSize;
        private Rectangle recEmployees;
        private Rectangle recbunifuPictureBox1;
        private Rectangle recbunifuPictureBox2;
        private Rectangle recbunifuLabel1;
        private Rectangle recbunifuLabel2;
        private Rectangle recbunifuLabel3;
        private Rectangle recbunifuLabel4;
        private Rectangle recbunifuLabel5;
        private Rectangle recbtnSend;
        private Rectangle rectxtCurrentPassword;
        private Rectangle rectxtNewPassword;
        private Rectangle rectxtConfirmPassword;
        private Rectangle rectxtCode;
        private Rectangle recbtnUpdatePassword;

        private string _code;
        MemberModel CurrentUser;
        public ResetPassword(MemberModel _CurrentUser)
        {
            this.CurrentUser = _CurrentUser;
            InitializeComponent();
            GenerateCode();
            this.Resize += ResetPassword_Resize;
            ResetPassOriginalSize = this.Size;
            recEmployees = new Rectangle(Employees.Location, Employees.Size);
            recbunifuPictureBox1 = new Rectangle(bunifuPictureBox1.Location, bunifuPictureBox1.Size);
            recbunifuPictureBox2 = new Rectangle(bunifuPictureBox2.Location, bunifuPictureBox2.Size);
            recbunifuLabel1 = new Rectangle(bunifuLabel1.Location, bunifuLabel1.Size);
            recbunifuLabel2 = new Rectangle(bunifuLabel2.Location, bunifuLabel2.Size);
            recbunifuLabel3 = new Rectangle(bunifuLabel3.Location, bunifuLabel3.Size);
            recbunifuLabel4 = new Rectangle(bunifuLabel4.Location, bunifuLabel4.Size);
            recbunifuLabel5 = new Rectangle(bunifuLabel5.Location, bunifuLabel5.Size);
            recbtnSend = new Rectangle(btnSend.Location, btnSend.Size);
            rectxtCurrentPassword = new Rectangle(txtCurrentPassword.Location, txtCurrentPassword.Size);
            rectxtNewPassword = new Rectangle(txtNewPassword.Location, txtNewPassword.Size);
            rectxtConfirmPassword = new Rectangle(txtConfirmPassword.Location, txtConfirmPassword.Size);
            rectxtCode = new Rectangle(txtCode.Location, txtCode.Size);
            recbtnUpdatePassword = new Rectangle(btnUpdatePassword.Location, btnUpdatePassword.Size);
        }

        private void ResetPassword_Resize(object sender, EventArgs e)
        {
            resize_Control(Employees, recEmployees);
            resize_Control(bunifuPictureBox1, recbunifuPictureBox1);
            resize_Control(bunifuPictureBox2, recbunifuPictureBox2);
            resize_Control(bunifuLabel1, recbunifuLabel1);
            resize_Control(bunifuLabel2, recbunifuLabel2);
            resize_Control(bunifuLabel3, recbunifuLabel3);
            resize_Control(bunifuLabel4, recbunifuLabel4);
            resize_Control(bunifuLabel5, recbunifuLabel5);
            resize_Control(btnSend, recbtnSend);
            resize_Control(txtCurrentPassword, rectxtCurrentPassword);
            resize_Control(txtNewPassword, rectxtNewPassword);
            resize_Control(txtConfirmPassword, rectxtConfirmPassword);
            resize_Control(txtCode, rectxtCode);
            resize_Control(btnUpdatePassword, recbtnUpdatePassword);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(ResetPassOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(ResetPassOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
