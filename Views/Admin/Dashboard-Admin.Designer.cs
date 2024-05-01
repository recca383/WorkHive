namespace WorkHive.Views
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
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.ProfilePicBox = new WorkHive.Views.CircularPictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashBoard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChats = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.pnTitleBar.Controls.Add(this.ProfilePicBox);
            this.pnTitleBar.Controls.Add(this.pictureBox3);
            this.pnTitleBar.Controls.Add(this.btnMenu);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(251, 0);
            this.pnTitleBar.Margin = new System.Windows.Forms.Padding(5);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(1328, 117);
            this.pnTitleBar.TabIndex = 1;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(251, 117);
            this.ViewPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ViewPanel.MinimumSize = new System.Drawing.Size(1328, 763);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1328, 763);
            this.ViewPanel.TabIndex = 6;
            // 
            // ProfilePicBox
            // 
            this.ProfilePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicBox.Image")));
            this.ProfilePicBox.Location = new System.Drawing.Point(1166, 11);
            this.ProfilePicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfilePicBox.Name = "ProfilePicBox";
            this.ProfilePicBox.Size = new System.Drawing.Size(108, 97);
            this.ProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicBox.TabIndex = 0;
            this.ProfilePicBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1101, 47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(8, 9);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(64, 79);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Transparent;
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnDashBoard);
            this.sidebar.Controls.Add(this.btnEmployees);
            this.sidebar.Controls.Add(this.btnTasks);
            this.sidebar.Controls.Add(this.btnEditTasks);
            this.sidebar.Controls.Add(this.btnCalendar);
            this.sidebar.Controls.Add(this.btnChats);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MinimumSize = new System.Drawing.Size(251, 763);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(251, 837);
            this.sidebar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashBoard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Iconimage")));
            this.btnDashBoard.Iconimage_right = null;
            this.btnDashBoard.Iconimage_right_Selected = null;
            this.btnDashBoard.Iconimage_Selected = null;
            this.btnDashBoard.IconMarginLeft = 0;
            this.btnDashBoard.IconMarginRight = 0;
            this.btnDashBoard.IconRightVisible = true;
            this.btnDashBoard.IconRightZoom = 0D;
            this.btnDashBoard.IconVisible = true;
            this.btnDashBoard.IconZoom = 40D;
            this.btnDashBoard.IsTab = false;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 104);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashBoard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnDashBoard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashBoard.selected = true;
            this.btnDashBoard.Size = new System.Drawing.Size(251, 50);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Tag = "Dashboard";
            this.btnDashBoard.Text = "   Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Textcolor = System.Drawing.Color.White;
            this.btnDashBoard.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Active = true;
            this.btnEmployees.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployees.BorderRadius = 0;
            this.btnEmployees.ButtonText = "   Employees";
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployees.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployees.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Iconimage")));
            this.btnEmployees.Iconimage_right = null;
            this.btnEmployees.Iconimage_right_Selected = null;
            this.btnEmployees.Iconimage_Selected = null;
            this.btnEmployees.IconMarginLeft = 0;
            this.btnEmployees.IconMarginRight = 0;
            this.btnEmployees.IconRightVisible = true;
            this.btnEmployees.IconRightZoom = 0D;
            this.btnEmployees.IconVisible = true;
            this.btnEmployees.IconZoom = 40D;
            this.btnEmployees.IsTab = false;
            this.btnEmployees.Location = new System.Drawing.Point(0, 154);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmployees.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnEmployees.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployees.selected = true;
            this.btnEmployees.Size = new System.Drawing.Size(251, 50);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Tag = "Employees";
            this.btnEmployees.Text = "   Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Textcolor = System.Drawing.Color.White;
            this.btnEmployees.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
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
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTasks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTasks.Iconimage")));
            this.btnTasks.Iconimage_right = null;
            this.btnTasks.Iconimage_right_Selected = null;
            this.btnTasks.Iconimage_Selected = null;
            this.btnTasks.IconMarginLeft = 0;
            this.btnTasks.IconMarginRight = 0;
            this.btnTasks.IconRightVisible = true;
            this.btnTasks.IconRightZoom = 0D;
            this.btnTasks.IconVisible = true;
            this.btnTasks.IconZoom = 40D;
            this.btnTasks.IsTab = false;
            this.btnTasks.Location = new System.Drawing.Point(0, 204);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(0);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTasks.selected = true;
            this.btnTasks.Size = new System.Drawing.Size(251, 50);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Tag = "Tasks";
            this.btnTasks.Text = "   Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Textcolor = System.Drawing.Color.White;
            this.btnTasks.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnEditTasks
            // 
            this.btnEditTasks.Active = true;
            this.btnEditTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnEditTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnEditTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditTasks.BorderRadius = 0;
            this.btnEditTasks.ButtonText = "   Edit Tasks";
            this.btnEditTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTasks.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditTasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditTasks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditTasks.Iconimage")));
            this.btnEditTasks.Iconimage_right = null;
            this.btnEditTasks.Iconimage_right_Selected = null;
            this.btnEditTasks.Iconimage_Selected = null;
            this.btnEditTasks.IconMarginLeft = 0;
            this.btnEditTasks.IconMarginRight = 0;
            this.btnEditTasks.IconRightVisible = true;
            this.btnEditTasks.IconRightZoom = 0D;
            this.btnEditTasks.IconVisible = true;
            this.btnEditTasks.IconZoom = 40D;
            this.btnEditTasks.IsTab = false;
            this.btnEditTasks.Location = new System.Drawing.Point(0, 254);
            this.btnEditTasks.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEditTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnEditTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditTasks.selected = true;
            this.btnEditTasks.Size = new System.Drawing.Size(251, 50);
            this.btnEditTasks.TabIndex = 4;
            this.btnEditTasks.Tag = "Edit Tasks";
            this.btnEditTasks.Text = "   Edit Tasks";
            this.btnEditTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTasks.Textcolor = System.Drawing.Color.White;
            this.btnEditTasks.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTasks.Click += new System.EventHandler(this.btnEditTasks_Click);
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
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalendar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Iconimage")));
            this.btnCalendar.Iconimage_right = null;
            this.btnCalendar.Iconimage_right_Selected = null;
            this.btnCalendar.Iconimage_Selected = null;
            this.btnCalendar.IconMarginLeft = 0;
            this.btnCalendar.IconMarginRight = 0;
            this.btnCalendar.IconRightVisible = true;
            this.btnCalendar.IconRightZoom = 0D;
            this.btnCalendar.IconVisible = true;
            this.btnCalendar.IconZoom = 40D;
            this.btnCalendar.IsTab = false;
            this.btnCalendar.Location = new System.Drawing.Point(0, 304);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCalendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnCalendar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalendar.selected = true;
            this.btnCalendar.Size = new System.Drawing.Size(251, 50);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Tag = "Calendar";
            this.btnCalendar.Text = "   Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Textcolor = System.Drawing.Color.White;
            this.btnCalendar.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnChats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChats.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChats.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChats.Iconimage")));
            this.btnChats.Iconimage_right = null;
            this.btnChats.Iconimage_right_Selected = null;
            this.btnChats.Iconimage_Selected = null;
            this.btnChats.IconMarginLeft = 0;
            this.btnChats.IconMarginRight = 0;
            this.btnChats.IconRightVisible = true;
            this.btnChats.IconRightZoom = 0D;
            this.btnChats.IconVisible = true;
            this.btnChats.IconZoom = 40D;
            this.btnChats.IsTab = false;
            this.btnChats.Location = new System.Drawing.Point(0, 354);
            this.btnChats.Margin = new System.Windows.Forms.Padding(0);
            this.btnChats.Name = "btnChats";
            this.btnChats.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChats.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnChats.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChats.selected = true;
            this.btnChats.Size = new System.Drawing.Size(251, 50);
            this.btnChats.TabIndex = 6;
            this.btnChats.Tag = "Chats";
            this.btnChats.Text = "   Chats";
            this.btnChats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChats.Textcolor = System.Drawing.Color.White;
            this.btnChats.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 406);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 350);
            this.panel2.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Active = true;
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "   Log Out";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 40D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 758);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = true;
            this.btnLogout.Size = new System.Drawing.Size(325, 62);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Tag = "Chats";
            this.btnLogout.Text = "   Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1579, 837);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.sidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Button btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashBoard;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployees;
        private Bunifu.Framework.UI.BunifuFlatButton btnTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalendar;
        private Bunifu.Framework.UI.BunifuFlatButton btnChats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private CircularPictureBox ProfilePicBox;
    }
}