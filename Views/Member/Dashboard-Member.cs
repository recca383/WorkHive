﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Admin;
using WorkHive.Views.Pages;
using WorkHive.Model;
using WorkHive.Views.LandingPage;
using WorkHive.Views.Member;
using WorkHive.Views.Member.DashboardPagesMember;
using WorkHive.Views.Cards;


namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class Dashboard_Member : Form
    {
        int ID;
        MemberModel CurrentUser;
        
        private static DashboardNavigation dashboardNavigation;
        public Dashboard_Member(MemberModel CurrentUser)
        {
            this.ID = CurrentUser.ID;
            InitializeComponent();
            RefreshImage();
            Initialize_Navigation_Controls();
            LoadProfilePic();
            ProjectCard.OnProjectTasksClick += btnTasksMember_Click;
            ProfileEditMember.OnUpdate += RefreshImage;
            ProfileEditMember.OnUpdate += LoadProfilePic;
            //profilepanel.Parent = ViewPanelMember;


        }
        public void RefreshImage()
        {
            CurrentUser = MemberModelAccess.GetMemberInfo(ID);
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (CurrentUser.Profile_Pic.Contains("C:\\") || CurrentUser.Profile_Pic.Contains("D:\\"))
            {
                ProfilePicBoxMember.Image = Image.FromFile(CurrentUser.Profile_Pic);
            }
            else if (CurrentUser.Profile_Pic == " ")
            {
                ProfilePicBoxMember.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                ProfilePicBoxMember.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), CurrentUser.Profile_Pic));
            }

        }
        private void Initialize_Navigation_Controls()
        {

            //List<UserControl> list = new List<UserControl>()
            UserControl[] list = 
            { new DashboardView(CurrentUser),new ProjectViewMember(), new TaskViewMember(),new CalendarView(), new MessageView(), new AboutUs(), new ProfileEditMember(CurrentUser), new ResetPasswordMember(CurrentUser)};

            dashboardNavigation = new DashboardNavigation(list, ViewPanelMember);
            dashboardNavigation.Display(0);
        }


        private void btnDashBoardMember_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(0);
        }
        private void btnProjectsMember_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(1);
        }
        private void btnTasksMember_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(2);
        }

        private void btnCalendarMember_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(3);
        }

        private void btnChatsMember_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(4);
        }
        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(5);
        }
        public static void btnProfileEdit_Click()
        {
            dashboardNavigation.Display(6);
        }
        public static void btnResetPassword_Click()
        {
            dashboardNavigation.Display(7);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing_Page landing_Page = new Landing_Page();
            landing_Page.Show();
        }
        private void LoadProfilePic()
        {
            profilepanel.Controls.Clear();
            ProfileMember profile = new ProfileMember(CurrentUser);
            profilepanel.Controls.Add(profile);
        }       
        
        private void ProfilePicBoxMember_Click(object sender, EventArgs e)
        {
            profilepanel.Parent = ViewPanelMember;
            profilepanel.BringToFront();
            if (profilepanel.Size == new Size(0, 0))
            {
                profilepanel.Size = new Size(293, 375);
                
            }
            else
            {
                profilepanel.Size = new Size(0, 0);
            }
        }

        private void btnMenuMember_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.sidebarmember.Width > 150)
            {
                sidebarmember.Width = 54;
                pictureBox1.Visible = false;
                btnMenuMember.Dock = DockStyle.Left;
                foreach (Button menubutton in sidebarmember.Controls.OfType<Button>())
                {
                    menubutton.Text = "";
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;

                }
            }
            else
            {
                sidebarmember.Width = 180;
                pictureBox1.Visible = true;
                btnMenuMember.Dock = DockStyle.None;
                foreach (Button menubutton in sidebarmember.Controls.OfType<Button>())
                {
                    menubutton.Text = "  " + menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;

                }

            }
        }

       
    }
}
