using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;
using WorkHive.Views.LandingPage;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class ProfileMember : UserControl
    {
        MemberModel currentMember;
        public ProfileMember(MemberModel currentMember)
        {
            this.currentMember = currentMember;
            InitializeComponent();
            InitializeElements();
            ProfileEditMember.OnUpdate += InitializeElements;
        }
        private void InitializeElements()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (currentMember.Profile_Pic == " ")
            {
                ProfilePictureADMIN.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                ProfilePictureADMIN.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), currentMember.Profile_Pic));
            }

            lblProfileName.Text = currentMember.FullName;
            lblPosition.Text = "MEMBER";

        }
        private void ResetPassBtn_Click(object sender, EventArgs e)
        {
            Dashboard_Member.btnResetPassword_Click();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing_Page landing_Page = new Landing_Page();
            ParentForm.Hide();
            landing_Page.Show();

        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Dashboard_Member.btnProfileEdit_Click();
        }


    }
}
