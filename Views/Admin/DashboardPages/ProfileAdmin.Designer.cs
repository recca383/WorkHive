namespace WorkHive.Views.Admin
{
    partial class ProfileAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileAdmin));
            this.AdminName = new Bunifu.UI.WinForms.BunifuLabel();
            this.Positionlbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnProfileBoxBG = new System.Windows.Forms.Panel();
            this.ProfilePictureADMIN = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MessageBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ResetPassBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProfileBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnProfileBoxBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureADMIN)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminName
            // 
            this.AdminName.AutoEllipsis = false;
            this.AdminName.CursorType = null;
            this.AdminName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName.ForeColor = System.Drawing.Color.White;
            this.AdminName.Location = new System.Drawing.Point(156, 64);
            this.AdminName.Margin = new System.Windows.Forms.Padding(4);
            this.AdminName.Name = "AdminName";
            this.AdminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminName.Size = new System.Drawing.Size(172, 39);
            this.AdminName.TabIndex = 6;
            this.AdminName.Text = "Wincel Crusit";
            this.AdminName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.AdminName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Positionlbl
            // 
            this.Positionlbl.AutoEllipsis = false;
            this.Positionlbl.BackColor = System.Drawing.Color.White;
            this.Positionlbl.CursorType = null;
            this.Positionlbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positionlbl.ForeColor = System.Drawing.Color.Black;
            this.Positionlbl.Location = new System.Drawing.Point(156, 102);
            this.Positionlbl.Margin = new System.Windows.Forms.Padding(4);
            this.Positionlbl.Name = "Positionlbl";
            this.Positionlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Positionlbl.Size = new System.Drawing.Size(62, 25);
            this.Positionlbl.TabIndex = 7;
            this.Positionlbl.Text = "ADMIN";
            this.Positionlbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Positionlbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnProfileBoxBG
            // 
            this.pnProfileBoxBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.pnProfileBoxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnProfileBoxBG.Controls.Add(this.ProfilePictureADMIN);
            this.pnProfileBoxBG.Controls.Add(this.Positionlbl);
            this.pnProfileBoxBG.Controls.Add(this.AdminName);
            this.pnProfileBoxBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnProfileBoxBG.Location = new System.Drawing.Point(0, 0);
            this.pnProfileBoxBG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnProfileBoxBG.Name = "pnProfileBoxBG";
            this.pnProfileBoxBG.Size = new System.Drawing.Size(383, 180);
            this.pnProfileBoxBG.TabIndex = 8;
            // 
            // ProfilePictureADMIN
            // 
            this.ProfilePictureADMIN.AllowFocused = false;
            this.ProfilePictureADMIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfilePictureADMIN.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePictureADMIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePictureADMIN.BackgroundImage")));
            this.ProfilePictureADMIN.BorderRadius = 20;
            this.ProfilePictureADMIN.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePictureADMIN.Image")));
            this.ProfilePictureADMIN.IsCircle = false;
            this.ProfilePictureADMIN.Location = new System.Drawing.Point(26, 47);
            this.ProfilePictureADMIN.Margin = new System.Windows.Forms.Padding(4);
            this.ProfilePictureADMIN.Name = "ProfilePictureADMIN";
            this.ProfilePictureADMIN.Size = new System.Drawing.Size(101, 95);
            this.ProfilePictureADMIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureADMIN.TabIndex = 1;
            this.ProfilePictureADMIN.TabStop = false;
            this.ProfilePictureADMIN.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // btnLogout
            // 
            this.btnLogout.Active = false;
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.ButtonText = "    Log Out";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Transparent;
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
            this.btnLogout.IconZoom = 75D;
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 386);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.White;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(383, 56);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "    Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.Black;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MessageBtn
            // 
            this.MessageBtn.Active = false;
            this.MessageBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.MessageBtn.BackColor = System.Drawing.Color.White;
            this.MessageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageBtn.BorderRadius = 0;
            this.MessageBtn.ButtonText = "     Message";
            this.MessageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.MessageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.MessageBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("MessageBtn.Iconimage")));
            this.MessageBtn.Iconimage_right = null;
            this.MessageBtn.Iconimage_right_Selected = null;
            this.MessageBtn.Iconimage_Selected = null;
            this.MessageBtn.IconMarginLeft = 25;
            this.MessageBtn.IconMarginRight = 0;
            this.MessageBtn.IconRightVisible = true;
            this.MessageBtn.IconRightZoom = 0D;
            this.MessageBtn.IconVisible = true;
            this.MessageBtn.IconZoom = 60D;
            this.MessageBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MessageBtn.IsTab = false;
            this.MessageBtn.Location = new System.Drawing.Point(0, 311);
            this.MessageBtn.Margin = new System.Windows.Forms.Padding(5);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Normalcolor = System.Drawing.Color.White;
            this.MessageBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.MessageBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.MessageBtn.selected = false;
            this.MessageBtn.Size = new System.Drawing.Size(379, 56);
            this.MessageBtn.TabIndex = 4;
            this.MessageBtn.Text = "     Message";
            this.MessageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageBtn.Textcolor = System.Drawing.Color.Black;
            this.MessageBtn.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBtn.Click += new System.EventHandler(this.MessageBtn_Click);
            // 
            // ResetPassBtn
            // 
            this.ResetPassBtn.Active = false;
            this.ResetPassBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ResetPassBtn.BackColor = System.Drawing.Color.White;
            this.ResetPassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetPassBtn.BorderRadius = 0;
            this.ResetPassBtn.ButtonText = "    Reset Password";
            this.ResetPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ResetPassBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ResetPassBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ResetPassBtn.Iconimage")));
            this.ResetPassBtn.Iconimage_right = null;
            this.ResetPassBtn.Iconimage_right_Selected = null;
            this.ResetPassBtn.Iconimage_Selected = null;
            this.ResetPassBtn.IconMarginLeft = 25;
            this.ResetPassBtn.IconMarginRight = 0;
            this.ResetPassBtn.IconRightVisible = true;
            this.ResetPassBtn.IconRightZoom = 0D;
            this.ResetPassBtn.IconVisible = true;
            this.ResetPassBtn.IconZoom = 65D;
            this.ResetPassBtn.IsTab = false;
            this.ResetPassBtn.Location = new System.Drawing.Point(0, 250);
            this.ResetPassBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ResetPassBtn.Name = "ResetPassBtn";
            this.ResetPassBtn.Normalcolor = System.Drawing.Color.White;
            this.ResetPassBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ResetPassBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ResetPassBtn.selected = false;
            this.ResetPassBtn.Size = new System.Drawing.Size(383, 56);
            this.ResetPassBtn.TabIndex = 3;
            this.ResetPassBtn.Text = "    Reset Password";
            this.ResetPassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetPassBtn.Textcolor = System.Drawing.Color.Black;
            this.ResetPassBtn.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassBtn.Click += new System.EventHandler(this.ResetPassBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Active = false;
            this.ProfileBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ProfileBtn.BackColor = System.Drawing.Color.White;
            this.ProfileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileBtn.BorderRadius = 0;
            this.ProfileBtn.ButtonText = "   Profile";
            this.ProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ProfileBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ProfileBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ProfileBtn.Iconimage")));
            this.ProfileBtn.Iconimage_right = null;
            this.ProfileBtn.Iconimage_right_Selected = null;
            this.ProfileBtn.Iconimage_Selected = null;
            this.ProfileBtn.IconMarginLeft = 25;
            this.ProfileBtn.IconMarginRight = 0;
            this.ProfileBtn.IconRightVisible = true;
            this.ProfileBtn.IconRightZoom = 0D;
            this.ProfileBtn.IconVisible = true;
            this.ProfileBtn.IconZoom = 70D;
            this.ProfileBtn.IsTab = false;
            this.ProfileBtn.Location = new System.Drawing.Point(0, 187);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Normalcolor = System.Drawing.Color.White;
            this.ProfileBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.ProfileBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProfileBtn.selected = false;
            this.ProfileBtn.Size = new System.Drawing.Size(383, 56);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.Text = "   Profile";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.Textcolor = System.Drawing.Color.Black;
            this.ProfileBtn.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 4);
            this.label2.TabIndex = 20;
            this.label2.Text = "                                             ";
            // 
            // ProfileAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnProfileBoxBG);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.MessageBtn);
            this.Controls.Add(this.ResetPassBtn);
            this.Controls.Add(this.ProfileBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfileAdmin";
            this.Size = new System.Drawing.Size(383, 465);
            this.pnProfileBoxBG.ResumeLayout(false);
            this.pnProfileBoxBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureADMIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox ProfilePictureADMIN;
        private Bunifu.Framework.UI.BunifuFlatButton ProfileBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ResetPassBtn;
        private Bunifu.Framework.UI.BunifuFlatButton MessageBtn;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.UI.WinForms.BunifuLabel AdminName;
        private Bunifu.UI.WinForms.BunifuLabel Positionlbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnProfileBoxBG;
        private System.Windows.Forms.Label label2;
    }
}