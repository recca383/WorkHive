﻿using System;
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
            ForgotPasswordPage.GoBackToSecondStep();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var memberselected = members.FirstOrDefault(m => m.Email == ForgotPassword._email);
            if(!(MemberModelAccess.ChangePassword(memberselected, txtNewPassword.Text, txtConfirmPassword.Text)))
            {
                ParentForm.Hide();
            }
            

        }
    }
}