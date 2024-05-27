﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;
using WorkHive.Views.LandingPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WorkHive.Views.Admin
{
    public partial class ProfileAdmin : UserControl
    {
        readonly private MemberModel CurrentUser;
        public ProfileAdmin(MemberModel member)
        {
            ProfileEdit.OnUpdate += SetElememts;
            CurrentUser = member;
            InitializeComponent();
            SetElememts();
           
        }
        private void SetElememts()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (CurrentUser.Profile_Pic == " ")
            {
                ProfilePictureADMIN.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                ProfilePictureADMIN.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), CurrentUser.Profile_Pic));
            }

            AdminName.Text = CurrentUser.FullName;
            Positionlbl.Text = "ADMIN";

            
        }

        private void ResetPassBtn_Click(object sender, EventArgs e)
        {
            Dashboard_Admin.btnResetPassword_Click();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing_Page landing_Page = new Landing_Page();
            ParentForm.Hide();
            landing_Page.Show();
            
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Dashboard_Admin.btnProfileEdit_Click();
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            Dashboard_Admin dashboard_Admin = (Dashboard_Admin) ParentForm;
            dashboard_Admin.btnChats_Click_1(sender, e);
            //lagyan mo okoj
        }
    }
}
