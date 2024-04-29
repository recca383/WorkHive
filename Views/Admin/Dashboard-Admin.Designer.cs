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
            this.ProfilePicBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashBoard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilePicBox
            // 
            this.ProfilePicBox.AllowFocused = false;
            this.ProfilePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicBox.BorderRadius = 0;
            this.ProfilePicBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicBox.Image")));
            this.ProfilePicBox.IsCircle = false;
            this.ProfilePicBox.Location = new System.Drawing.Point(881, 11);
            this.ProfilePicBox.Name = "ProfilePicBox";
            this.ProfilePicBox.Size = new System.Drawing.Size(44, 44);
            this.ProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicBox.TabIndex = 7;
            this.ProfilePicBox.TabStop = false;
            this.ProfilePicBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(838, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnDashBoard);
            this.sidebar.Controls.Add(this.btnEmployees);
            this.sidebar.Controls.Add(this.btnTasks);
            this.sidebar.Controls.Add(this.btnEditTasks);
            this.sidebar.Controls.Add(this.btnCalendar);
            this.sidebar.Controls.Add(this.btnMail);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(183, 657);
            this.sidebar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 81);
            this.panel1.TabIndex = 1;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Active = false;
            this.btnDashBoard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashBoard.BorderRadius = 0;
            this.btnDashBoard.ButtonText = "  Dashboard";
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
            this.btnDashBoard.IconZoom = 30D;
            this.btnDashBoard.IsTab = false;
            this.btnDashBoard.Location = new System.Drawing.Point(3, 88);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnDashBoard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDashBoard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashBoard.selected = false;
            this.btnDashBoard.Size = new System.Drawing.Size(180, 41);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Tag = "Dashboard";
            this.btnDashBoard.Text = "  Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Textcolor = System.Drawing.Color.White;
            this.btnDashBoard.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Active = false;
            this.btnEmployees.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployees.BorderRadius = 0;
            this.btnEmployees.ButtonText = "  Employees";
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
            this.btnEmployees.IconZoom = 30D;
            this.btnEmployees.IsTab = false;
            this.btnEmployees.Location = new System.Drawing.Point(3, 135);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnEmployees.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEmployees.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployees.selected = false;
            this.btnEmployees.Size = new System.Drawing.Size(180, 41);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Tag = "Employees";
            this.btnEmployees.Text = "  Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Textcolor = System.Drawing.Color.White;
            this.btnEmployees.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Active = false;
            this.btnTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.BorderRadius = 0;
            this.btnTasks.ButtonText = "  Tasks";
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
            this.btnTasks.IconZoom = 30D;
            this.btnTasks.IsTab = false;
            this.btnTasks.Location = new System.Drawing.Point(3, 182);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTasks.selected = false;
            this.btnTasks.Size = new System.Drawing.Size(180, 41);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Tag = "Tasks";
            this.btnTasks.Text = "  Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Textcolor = System.Drawing.Color.White;
            this.btnTasks.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnEditTasks
            // 
            this.btnEditTasks.Active = false;
            this.btnEditTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnEditTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditTasks.BorderRadius = 0;
            this.btnEditTasks.ButtonText = "  Edit Tasks";
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
            this.btnEditTasks.IconZoom = 30D;
            this.btnEditTasks.IsTab = false;
            this.btnEditTasks.Location = new System.Drawing.Point(3, 229);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnEditTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditTasks.selected = false;
            this.btnEditTasks.Size = new System.Drawing.Size(180, 41);
            this.btnEditTasks.TabIndex = 4;
            this.btnEditTasks.Tag = "Edit Tasks";
            this.btnEditTasks.Text = "  Edit Tasks";
            this.btnEditTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTasks.Textcolor = System.Drawing.Color.White;
            this.btnEditTasks.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCalendar
            // 
            this.btnCalendar.Active = false;
            this.btnCalendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalendar.BorderRadius = 0;
            this.btnCalendar.ButtonText = "  Calendar";
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
            this.btnCalendar.IconZoom = 30D;
            this.btnCalendar.IsTab = false;
            this.btnCalendar.Location = new System.Drawing.Point(3, 276);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnCalendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCalendar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalendar.selected = false;
            this.btnCalendar.Size = new System.Drawing.Size(180, 41);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Tag = "Calendar";
            this.btnCalendar.Text = "  Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Textcolor = System.Drawing.Color.White;
            this.btnCalendar.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMail
            // 
            this.btnMail.Active = false;
            this.btnMail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMail.BorderRadius = 0;
            this.btnMail.ButtonText = "  Mail";
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.DisabledColor = System.Drawing.Color.Gray;
            this.btnMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMail.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMail.Iconimage")));
            this.btnMail.Iconimage_right = null;
            this.btnMail.Iconimage_right_Selected = null;
            this.btnMail.Iconimage_Selected = null;
            this.btnMail.IconMarginLeft = 0;
            this.btnMail.IconMarginRight = 0;
            this.btnMail.IconRightVisible = true;
            this.btnMail.IconRightZoom = 0D;
            this.btnMail.IconVisible = true;
            this.btnMail.IconZoom = 30D;
            this.btnMail.IsTab = false;
            this.btnMail.Location = new System.Drawing.Point(3, 323);
            this.btnMail.Name = "btnMail";
            this.btnMail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnMail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMail.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMail.selected = false;
            this.btnMail.Size = new System.Drawing.Size(180, 41);
            this.btnMail.TabIndex = 6;
            this.btnMail.Tag = "Mail";
            this.btnMail.Text = "  Mail";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.Textcolor = System.Drawing.Color.White;
            this.btnMail.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(4, 6);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(36, 52);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.pnTitleBar.Controls.Add(this.pictureBox3);
            this.pnTitleBar.Controls.Add(this.btnMenu);
            this.pnTitleBar.Controls.Add(this.ProfilePicBox);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(183, 0);
            this.pnTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(944, 63);
            this.pnTitleBar.TabIndex = 1;
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(183, 63);
            this.ViewPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(944, 594);
            this.ViewPanel.TabIndex = 6;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint_1);
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 657);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.sidebar);
            this.Name = "Dashboard_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Bunifu.UI.WinForms.BunifuPictureBox ProfilePicBox;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Button btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashBoard;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployees;
        private Bunifu.Framework.UI.BunifuFlatButton btnTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalendar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMail;
    }
}