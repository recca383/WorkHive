using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuTextbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Views;
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Controller
{
    public static class Utility
    {
        public static void PasswordInitialVisibility(BunifuMaterialTextbox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.isPassword = false;
            }
            else
            {
                textbox.isPassword = true;
            }
        }
        public static void PasswordInitialVisibility(BunifuTextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.UseSystemPasswordChar = false;
            }
            else
            {
                textbox.UseSystemPasswordChar = true;
            }
        }
        public static void ShowPasswordFunction(BunifuMaterialTextbox textbox, CircularPictureBox circularPictureBox)
        {
            if (textbox.isPassword)
            {
                circularPictureBox.Image = Properties.Resources.eye_open;
                textbox.isPassword = false;
            }

            else
            {
                circularPictureBox.Image = Properties.Resources.eye_closed;
                textbox.isPassword = true;
            }

        }
        public static void ShowPasswordFunction(BunifuTextBox textbox, CircularPictureBox circularPictureBox)
        {
            if (textbox.UseSystemPasswordChar)
            {
                circularPictureBox.Image = Properties.Resources.eye_open;
                textbox.UseSystemPasswordChar = false;
            }
            else
            {
                circularPictureBox.Image = Properties.Resources.eye_closed;
                textbox.UseSystemPasswordChar = true;

            }
        }
        public static bool IsEmailValid(string email)
        {
            string[] validpostfixes = { "@gmail.com", "@yahoo.com", "@lspu.edu.ph", "@outlook.com" };

            foreach (string s in validpostfixes)
            {
                if (email.Contains(s)) return true;
            }

            new MessageBoxes("Please Input Valid Email");
            return false;
            
        }
    }
}
