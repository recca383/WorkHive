﻿namespace WorkHive.Views
{
    partial class Dashboard_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            this.PnTitleBar = new System.Windows.Forms.Panel();
            this.profilepanel = new System.Windows.Forms.Panel();
            this.Notificationbtn = new System.Windows.Forms.PictureBox();
            this.ProfilePicBox = new WorkHive.Views.CircularPictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnProjects = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashBoard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChats = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMembers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificationbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnTitleBar
            // 
            this.PnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.PnTitleBar.Controls.Add(this.profilepanel);
            this.PnTitleBar.Controls.Add(this.Notificationbtn);
            this.PnTitleBar.Controls.Add(this.ProfilePicBox);
            this.PnTitleBar.Controls.Add(this.btnMenu);
            this.PnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTitleBar.Location = new System.Drawing.Point(164, 0);
            this.PnTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnTitleBar.Name = "PnTitleBar";
            this.PnTitleBar.Size = new System.Drawing.Size(1020, 81);
            this.PnTitleBar.TabIndex = 8;
            // 
            // profilepanel
            // 
            this.profilepanel.BackColor = System.Drawing.Color.Transparent;
            this.profilepanel.Location = new System.Drawing.Point(633, 35);
            this.profilepanel.Name = "profilepanel";
            this.profilepanel.Size = new System.Drawing.Size(0, 0);
            this.profilepanel.TabIndex = 3;
            // 
            // Notificationbtn
            // 
            this.Notificationbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notificationbtn.BackColor = System.Drawing.Color.Transparent;
            this.Notificationbtn.Image = ((System.Drawing.Image)(resources.GetObject("Notificationbtn.Image")));
            this.Notificationbtn.Location = new System.Drawing.Point(920, 33);
            this.Notificationbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Notificationbtn.Name = "Notificationbtn";
            this.Notificationbtn.Size = new System.Drawing.Size(23, 22);
            this.Notificationbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Notificationbtn.TabIndex = 2;
            this.Notificationbtn.TabStop = false;
            // 
            // ProfilePicBox
            // 
            this.ProfilePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicBox.Image")));
            this.ProfilePicBox.Location = new System.Drawing.Point(962, 23);
            this.ProfilePicBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfilePicBox.Name = "ProfilePicBox";
            this.ProfilePicBox.Size = new System.Drawing.Size(36, 37);
            this.ProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicBox.TabIndex = 0;
            this.ProfilePicBox.TabStop = false;
            this.ProfilePicBox.Click += new System.EventHandler(this.ProfilePicBox_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(3, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(46, 63);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(164, 81);
            this.ViewPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1020, 599);
            this.ViewPanel.TabIndex = 9;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint);
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = global::WorkHive.Properties.Resources.NEW_Sidebar_BG;
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.Controls.Add(this.btnProjects);
            this.sidebar.Controls.Add(this.btnDashBoard);
            this.sidebar.Controls.Add(this.btnChats);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.btnTasks);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.btnMembers);
            this.sidebar.Controls.Add(this.btnCalendar);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(164, 680);
            this.sidebar.TabIndex = 7;
            // 
            // btnProjects
            // 
            this.btnProjects.Active = true;
            this.btnProjects.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnProjects.BackColor = System.Drawing.Color.Transparent;
            this.btnProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjects.BorderRadius = 0;
            this.btnProjects.ButtonText = "   Projects";
            this.btnProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjects.DisabledColor = System.Drawing.Color.Gray;
            this.btnProjects.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProjects.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProjects.Iconimage")));
            this.btnProjects.Iconimage_right = null;
            this.btnProjects.Iconimage_right_Selected = null;
            this.btnProjects.Iconimage_Selected = null;
            this.btnProjects.IconMarginLeft = 20;
            this.btnProjects.IconMarginRight = 0;
            this.btnProjects.IconRightVisible = true;
            this.btnProjects.IconRightZoom = 0D;
            this.btnProjects.IconVisible = true;
            this.btnProjects.IconZoom = 40D;
            this.btnProjects.IsTab = false;
            this.btnProjects.Location = new System.Drawing.Point(0, 164);
            this.btnProjects.Margin = new System.Windows.Forms.Padding(0);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProjects.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnProjects.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProjects.selected = true;
            this.btnProjects.Size = new System.Drawing.Size(188, 41);
            this.btnProjects.TabIndex = 9;
            this.btnProjects.Tag = "Projects";
            this.btnProjects.Text = "   Projects";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.Textcolor = System.Drawing.Color.White;
            this.btnProjects.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Active = true;
            this.btnDashBoard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashBoard.BorderRadius = 0;
            this.btnDashBoard.ButtonText = "   Dashboard";
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashBoard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashBoard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Iconimage")));
            this.btnDashBoard.Iconimage_right = null;
            this.btnDashBoard.Iconimage_right_Selected = null;
            this.btnDashBoard.Iconimage_Selected = null;
            this.btnDashBoard.IconMarginLeft = 20;
            this.btnDashBoard.IconMarginRight = 0;
            this.btnDashBoard.IconRightVisible = true;
            this.btnDashBoard.IconRightZoom = 0D;
            this.btnDashBoard.IconVisible = true;
            this.btnDashBoard.IconZoom = 40D;
            this.btnDashBoard.IsTab = false;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 82);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashBoard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnDashBoard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashBoard.selected = true;
            this.btnDashBoard.Size = new System.Drawing.Size(188, 41);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Tag = "Dashboard";
            this.btnDashBoard.Text = "   Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Textcolor = System.Drawing.Color.White;
            this.btnDashBoard.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnChats
            // 
            this.btnChats.Active = true;
            this.btnChats.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnChats.BackColor = System.Drawing.Color.Transparent;
            this.btnChats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChats.BorderRadius = 0;
            this.btnChats.ButtonText = "   Chats";
            this.btnChats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChats.DisabledColor = System.Drawing.Color.Gray;
            this.btnChats.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChats.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChats.Iconimage")));
            this.btnChats.Iconimage_right = null;
            this.btnChats.Iconimage_right_Selected = null;
            this.btnChats.Iconimage_Selected = null;
            this.btnChats.IconMarginLeft = 20;
            this.btnChats.IconMarginRight = 0;
            this.btnChats.IconRightVisible = true;
            this.btnChats.IconRightZoom = 0D;
            this.btnChats.IconVisible = true;
            this.btnChats.IconZoom = 40D;
            this.btnChats.IsTab = false;
            this.btnChats.Location = new System.Drawing.Point(0, 286);
            this.btnChats.Margin = new System.Windows.Forms.Padding(0);
            this.btnChats.Name = "btnChats";
            this.btnChats.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChats.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnChats.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChats.selected = true;
            this.btnChats.Size = new System.Drawing.Size(188, 41);
            this.btnChats.TabIndex = 6;
            this.btnChats.Tag = "Chats";
            this.btnChats.Text = "   Chats";
            this.btnChats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChats.Textcolor = System.Drawing.Color.White;
            this.btnChats.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 81);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnTasks
            // 
            this.btnTasks.Active = true;
            this.btnTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.BorderRadius = 0;
            this.btnTasks.ButtonText = "   Tasks";
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.DisabledColor = System.Drawing.Color.Gray;
            this.btnTasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTasks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTasks.Iconimage")));
            this.btnTasks.Iconimage_right = null;
            this.btnTasks.Iconimage_right_Selected = null;
            this.btnTasks.Iconimage_Selected = null;
            this.btnTasks.IconMarginLeft = 20;
            this.btnTasks.IconMarginRight = 0;
            this.btnTasks.IconRightVisible = true;
            this.btnTasks.IconRightZoom = 0D;
            this.btnTasks.IconVisible = true;
            this.btnTasks.IconZoom = 40D;
            this.btnTasks.IsTab = false;
            this.btnTasks.Location = new System.Drawing.Point(0, 205);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(0);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTasks.selected = true;
            this.btnTasks.Size = new System.Drawing.Size(188, 41);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Tag = "Tasks";
            this.btnTasks.Text = "   Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Textcolor = System.Drawing.Color.White;
            this.btnTasks.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Active = true;
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "     Log Out";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 20;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 35D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 639);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = true;
            this.btnLogout.Size = new System.Drawing.Size(171, 41);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Tag = "Log Out";
            this.btnLogout.Text = "     Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Active = true;
            this.btnMembers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnMembers.BackColor = System.Drawing.Color.Transparent;
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMembers.BorderRadius = 0;
            this.btnMembers.ButtonText = "   Members";
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.DisabledColor = System.Drawing.Color.Gray;
            this.btnMembers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMembers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMembers.Iconimage")));
            this.btnMembers.Iconimage_right = null;
            this.btnMembers.Iconimage_right_Selected = null;
            this.btnMembers.Iconimage_Selected = null;
            this.btnMembers.IconMarginLeft = 20;
            this.btnMembers.IconMarginRight = 0;
            this.btnMembers.IconRightVisible = true;
            this.btnMembers.IconRightZoom = 0D;
            this.btnMembers.IconVisible = true;
            this.btnMembers.IconZoom = 40D;
            this.btnMembers.IsTab = false;
            this.btnMembers.Location = new System.Drawing.Point(0, 123);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(0);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMembers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnMembers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMembers.selected = true;
            this.btnMembers.Size = new System.Drawing.Size(188, 41);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Tag = "Members";
            this.btnMembers.Text = "   Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Textcolor = System.Drawing.Color.White;
            this.btnMembers.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Active = true;
            this.btnCalendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalendar.BorderRadius = 0;
            this.btnCalendar.ButtonText = "   Calendar";
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalendar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalendar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Iconimage")));
            this.btnCalendar.Iconimage_right = null;
            this.btnCalendar.Iconimage_right_Selected = null;
            this.btnCalendar.Iconimage_Selected = null;
            this.btnCalendar.IconMarginLeft = 20;
            this.btnCalendar.IconMarginRight = 0;
            this.btnCalendar.IconRightVisible = true;
            this.btnCalendar.IconRightZoom = 0D;
            this.btnCalendar.IconVisible = true;
            this.btnCalendar.IconZoom = 40D;
            this.btnCalendar.IsTab = false;
            this.btnCalendar.Location = new System.Drawing.Point(0, 245);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCalendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnCalendar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalendar.selected = true;
            this.btnCalendar.Size = new System.Drawing.Size(188, 41);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Tag = "Calendar";
            this.btnCalendar.Text = "   Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Textcolor = System.Drawing.Color.White;
            this.btnCalendar.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 680);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.PnTitleBar);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.PnTitleBar.ResumeLayout(false);
            this.PnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificationbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Notificationbtn;
        private System.Windows.Forms.Button btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashBoard;
        private Bunifu.Framework.UI.BunifuFlatButton btnMembers;
        private Bunifu.Framework.UI.BunifuFlatButton btnTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalendar;
        private Bunifu.Framework.UI.BunifuFlatButton btnChats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private CircularPictureBox ProfilePicBox;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel PnTitleBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel profilepanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnProjects;
    }
}