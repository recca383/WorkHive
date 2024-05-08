namespace WorkHive.Views.Cards
{
    partial class AdminCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxProfilePic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProfileName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProfileTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProfileEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProfilePhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picboxProfilePic);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(451, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 314);
            this.panel1.TabIndex = 0;
            // 
            // picboxProfilePic
            // 
            this.picboxProfilePic.AllowFocused = false;
            this.picboxProfilePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxProfilePic.BorderRadius = 50;
            this.picboxProfilePic.Image = global::WorkHive.Properties.Resources.Profile;
            this.picboxProfilePic.IsCircle = true;
            this.picboxProfilePic.Location = new System.Drawing.Point(28, 107);
            this.picboxProfilePic.Margin = new System.Windows.Forms.Padding(4);
            this.picboxProfilePic.Name = "picboxProfilePic";
            this.picboxProfilePic.Size = new System.Drawing.Size(133, 133);
            this.picboxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxProfilePic.TabIndex = 2;
            this.picboxProfilePic.TabStop = false;
            this.picboxProfilePic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::WorkHive.Properties.Resources.AdminCard_RIGHT;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 314);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.AdminCard_TOP;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblProfileName);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.lblProfileTitle);
            this.panel3.Controls.Add(this.lblProfileEmail);
            this.panel3.Controls.Add(this.lblProfilePhone);
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 216);
            this.panel3.TabIndex = 2;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoEllipsis = false;
            this.lblProfileName.CursorType = null;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.lblProfileName.Location = new System.Drawing.Point(17, 14);
            this.lblProfileName.Margin = new System.Windows.Forms.Padding(4);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfileName.Size = new System.Drawing.Size(95, 47);
            this.lblProfileName.TabIndex = 7;
            this.lblProfileName.Text = "Name";
            this.lblProfileName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfileName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoEllipsis = false;
            this.lblAddress.CursorType = null;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lblAddress.Location = new System.Drawing.Point(109, 151);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(158, 25);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "#9 Purok 9 San Juan ";
            this.lblAddress.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAddress.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.AutoEllipsis = false;
            this.lblProfileTitle.CursorType = null;
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(147)))), ((int)(((byte)(28)))));
            this.lblProfileTitle.Location = new System.Drawing.Point(17, 63);
            this.lblProfileTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfileTitle.Size = new System.Drawing.Size(51, 33);
            this.lblProfileTitle.TabIndex = 8;
            this.lblProfileTitle.Text = "Title";
            this.lblProfileTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfileTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoEllipsis = false;
            this.lblProfileEmail.CursorType = null;
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lblProfileEmail.Location = new System.Drawing.Point(109, 126);
            this.lblProfileEmail.Margin = new System.Windows.Forms.Padding(4);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfileEmail.Size = new System.Drawing.Size(166, 25);
            this.lblProfileEmail.TabIndex = 11;
            this.lblProfileEmail.Text = "Sample@sample.com";
            this.lblProfileEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfileEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblProfilePhone
            // 
            this.lblProfilePhone.AutoEllipsis = false;
            this.lblProfilePhone.CursorType = null;
            this.lblProfilePhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lblProfilePhone.Location = new System.Drawing.Point(109, 101);
            this.lblProfilePhone.Margin = new System.Windows.Forms.Padding(4);
            this.lblProfilePhone.Name = "lblProfilePhone";
            this.lblProfilePhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProfilePhone.Size = new System.Drawing.Size(85, 25);
            this.lblProfilePhone.TabIndex = 10;
            this.lblProfilePhone.Text = "09xxxxxxxx";
            this.lblProfilePhone.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProfilePhone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(18, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phone : \r\nEmail : \r\nAddress : \r\n";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AdminCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminCard";
            this.Size = new System.Drawing.Size(651, 314);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuLabel lblProfileName;
        private Bunifu.UI.WinForms.BunifuLabel lblAddress;
        private Bunifu.UI.WinForms.BunifuLabel lblProfileTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblProfileEmail;
        private Bunifu.UI.WinForms.BunifuLabel lblProfilePhone;
        private Bunifu.UI.WinForms.BunifuPictureBox picboxProfilePic;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
