using System;
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
using WorkHive.Model;
using WorkHive.Views.Admin;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.LandingPage;
using WorkHive.Views.Pages;

namespace WorkHive.Views
{
    public partial class Dashboard_Admin : Form
    {
        private Size DashBoardAdminOriginalSize;
        private Rectangle recViewPanel;
        private Rectangle recPnTitleBar;
        private Rectangle recbtnMenu;
        private Rectangle recNotificationbtn;
        private Rectangle recProfilePicBox;
        private Rectangle recsidebar;
        private Rectangle recpanel3;
        private Rectangle recpictureBox1;
        private Rectangle recpictureBox2;
        private Rectangle recbtnLogout;
        private Rectangle recbtnChats;
        private Rectangle recbtnCalendar;
        private Rectangle recbtnEditTasks;
        private Rectangle recbtnTasks;
        private Rectangle recbtnMembers;
        private Rectangle recbtnDashBoard;


        readonly MemberModel CurrentUser;

        static DashboardNavigation dashboardNavigation;
        public Dashboard_Admin(MemberModel CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            Initialize_Controls_According_To_User();
            Initialize_Navigation_Controls();
            this.Resize += Dashboard_Admin_Resize; 
            DashBoardAdminOriginalSize = this.Size;
            recViewPanel = new Rectangle(ViewPanel.Location, ViewPanel.Size);
            recPnTitleBar = new Rectangle(PnTitleBar.Location, PnTitleBar.Size);
            recbtnMenu = new Rectangle(btnMenu.Location, btnMenu.Size);
            recNotificationbtn = new Rectangle(Notificationbtn.Location, Notificationbtn.Size);
            recProfilePicBox = new Rectangle(ProfilePicBox.Location, ProfilePicBox.Size);
            recsidebar = new Rectangle(sidebar.Location, sidebar.Size);
            recpanel3 = new Rectangle(recpanel3.Location, panel3.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpictureBox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recbtnLogout = new Rectangle(btnLogout.Location, btnLogout.Size);
            recbtnChats = new Rectangle(btnChats.Location, btnChats.Size);
            recbtnCalendar = new Rectangle(btnCalendar.Location, btnCalendar.Size);
            recbtnEditTasks = new Rectangle(btnEditTasks.Location, btnEditTasks.Size);
            recbtnTasks = new Rectangle(btnTasks.Location,btnTasks.Size);
            recbtnMembers = new Rectangle(btnMembers.Location, btnMembers.Size);
            recbtnDashBoard = new Rectangle(btnDashBoard.Location, btnDashBoard.Size);
        }

        private void Dashboard_Admin_Resize(object sender, EventArgs e)
        {
            resize_Control(ViewPanel, recViewPanel);
            resize_Control(PnTitleBar, recPnTitleBar);
            resize_Control(btnMenu, recbtnMenu);
            resize_Control(Notificationbtn, recNotificationbtn);
            resize_Control(ProfilePicBox, recProfilePicBox);
            resize_Control(sidebar, recsidebar);
            resize_Control(panel3, recpanel3);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(pictureBox2, recpictureBox2);
            resize_Control(btnLogout, recbtnLogout);
            resize_Control(btnChats, recbtnChats);
            resize_Control(btnCalendar, recbtnCalendar);
            resize_Control(btnEditTasks, recbtnEditTasks);
            resize_Control(btnTasks, recbtnTasks);
            resize_Control(btnMembers, recbtnMembers);
            resize_Control(btnDashBoard, recbtnDashBoard);

        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(DashBoardAdminOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(DashBoardAdminOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void Initialize_Controls_According_To_User()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (CurrentUser.Profile_Pic == null)
            {
                ProfilePicBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                ProfilePicBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), CurrentUser.Profile_Pic));
            }

        }
        private void Initialize_Navigation_Controls()
        {
            List<UserControl> list = new List<UserControl>()
            { new DashboardView(CurrentUser), new MemberView(), new TasksView(), new Edit_TaskView(), new CalendarView(), new ProfileEdit(CurrentUser), new ResetPassword(CurrentUser)};

            dashboardNavigation = new DashboardNavigation(list, ViewPanel);
            dashboardNavigation.Display(0);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(0);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(1);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(2);
        }
        private void btnEditTasks_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(3);
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(4);
        }
        public static void btnProfileEdit_Click()
        {
            dashboardNavigation.Display(5);
        }
        public static void btnResetPassword_Click()
        {
            dashboardNavigation.Display(6);
        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.sidebar.Width > 150)
            {
                sidebar.Width = 54;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Left;
                foreach (Button menubutton in sidebar.Controls.OfType<Button>())
                {
                    menubutton.Text = "";
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;

                }
            }
            else
            {
                sidebar.Width = 180;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menubutton in sidebar.Controls.OfType<Button>())
                {
                    menubutton.Text = "  " + menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;

                }

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing_Page landingpage = new Landing_Page();
            this.Hide();
            landingpage.Show();
        }

        private void btnChats_Click(object sender, EventArgs e)
        {

        }

        

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfilePicBox_Click(object sender, EventArgs e)
        {
            ProfileAdmin profile = new ProfileAdmin(CurrentUser);
            profilepanel.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.Show();
            profilepanel.Parent = ViewPanel;
            profilepanel.BringToFront();
            if (profilepanel.Size == new Size(0, 0))
            {
                profilepanel.Size = new Size(383, 465);
                
            }
            else
            {
                profilepanel.Size = new Size(0, 0);
            }
        }
    }

    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);
        } 
    }
}
