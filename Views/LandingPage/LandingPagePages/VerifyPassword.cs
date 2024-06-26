﻿using Bunifu.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;

namespace WorkHive.Views.LandingPage.LandingPagePages
{
    public partial class VerifyPassword : UserControl
    {
        private string _code;
        public VerifyPassword()
        {
            InitializeComponent();
            GenerateCode();
        }

        private void btnGoBackToFirstStep_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage parent = this.ParentForm as ForgotPasswordPage;
            parent.GoBackToFirstStep();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage parent = this.ParentForm as ForgotPasswordPage;

            if (_code == txtCode.Text) parent.GoToThirdStep();
            else new MessageBoxes("Code doesn't match");

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
        private void btnResendCode_Click(object sender, EventArgs e)
        {
            
            SendCode(_code);
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            btnResendCode.Enabled = false;
            SendCode(_code);
            btnSendCode.Visible = false;

            btnResendCode.Enabled = true;
        }
    }
}
