﻿namespace WorkHive.Views.Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileAdmin));
            this.Profile = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ProfilePictureADMIN = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ProfileBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ResetPassBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MessageBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AdminName = new Bunifu.UI.WinForms.BunifuLabel();
            this.Positionlbl = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureADMIN)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.AllowFocused = false;
            this.Profile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Profile.BackColor = System.Drawing.Color.Transparent;
            this.Profile.BorderRadius = 0;
            this.Profile.Image = global::WorkHive.Properties.Resources.Profile_Box__2_;
            this.Profile.IsCircle = false;
            this.Profile.Location = new System.Drawing.Point(9, -5);
            this.Profile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(249, 354);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 0;
            this.Profile.TabStop = false;
            this.Profile.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // ProfilePictureADMIN
            // 
            this.ProfilePictureADMIN.AllowFocused = false;
            this.ProfilePictureADMIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfilePictureADMIN.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePictureADMIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePictureADMIN.BackgroundImage")));
            this.ProfilePictureADMIN.BorderRadius = 50;
            this.ProfilePictureADMIN.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePictureADMIN.Image")));
            this.ProfilePictureADMIN.IsCircle = true;
            this.ProfilePictureADMIN.Location = new System.Drawing.Point(26, 36);
            this.ProfilePictureADMIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfilePictureADMIN.Name = "ProfilePictureADMIN";
            this.ProfilePictureADMIN.Size = new System.Drawing.Size(76, 76);
            this.ProfilePictureADMIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfilePictureADMIN.TabIndex = 1;
            this.ProfilePictureADMIN.TabStop = false;
            this.ProfilePictureADMIN.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Active = false;
            this.ProfileBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.ProfileBtn.IconMarginLeft = 0;
            this.ProfileBtn.IconMarginRight = 0;
            this.ProfileBtn.IconRightVisible = true;
            this.ProfileBtn.IconRightZoom = 0D;
            this.ProfileBtn.IconVisible = true;
            this.ProfileBtn.IconZoom = 89D;
            this.ProfileBtn.IsTab = false;
            this.ProfileBtn.Location = new System.Drawing.Point(19, 132);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Normalcolor = System.Drawing.Color.White;
            this.ProfileBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ProfileBtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.ProfileBtn.selected = false;
            this.ProfileBtn.Size = new System.Drawing.Size(230, 46);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.Text = "   Profile";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.Textcolor = System.Drawing.Color.Black;
            this.ProfileBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ResetPassBtn
            // 
            this.ResetPassBtn.Active = false;
            this.ResetPassBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ResetPassBtn.BackColor = System.Drawing.Color.White;
            this.ResetPassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetPassBtn.BorderRadius = 0;
            this.ResetPassBtn.ButtonText = "   Reset Password";
            this.ResetPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ResetPassBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ResetPassBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ResetPassBtn.Iconimage")));
            this.ResetPassBtn.Iconimage_right = null;
            this.ResetPassBtn.Iconimage_right_Selected = null;
            this.ResetPassBtn.Iconimage_Selected = null;
            this.ResetPassBtn.IconMarginLeft = 0;
            this.ResetPassBtn.IconMarginRight = 0;
            this.ResetPassBtn.IconRightVisible = true;
            this.ResetPassBtn.IconRightZoom = 0D;
            this.ResetPassBtn.IconVisible = true;
            this.ResetPassBtn.IconZoom = 75D;
            this.ResetPassBtn.IsTab = false;
            this.ResetPassBtn.Location = new System.Drawing.Point(16, 177);
            this.ResetPassBtn.Name = "ResetPassBtn";
            this.ResetPassBtn.Normalcolor = System.Drawing.Color.White;
            this.ResetPassBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.ResetPassBtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.ResetPassBtn.selected = false;
            this.ResetPassBtn.Size = new System.Drawing.Size(232, 48);
            this.ResetPassBtn.TabIndex = 3;
            this.ResetPassBtn.Text = "   Reset Password";
            this.ResetPassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetPassBtn.Textcolor = System.Drawing.Color.Black;
            this.ResetPassBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MessageBtn
            // 
            this.MessageBtn.Active = false;
            this.MessageBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MessageBtn.BackColor = System.Drawing.Color.White;
            this.MessageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageBtn.BorderRadius = 0;
            this.MessageBtn.ButtonText = "    Mesage";
            this.MessageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.MessageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.MessageBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("MessageBtn.Iconimage")));
            this.MessageBtn.Iconimage_right = null;
            this.MessageBtn.Iconimage_right_Selected = null;
            this.MessageBtn.Iconimage_Selected = null;
            this.MessageBtn.IconMarginLeft = 0;
            this.MessageBtn.IconMarginRight = 0;
            this.MessageBtn.IconRightVisible = true;
            this.MessageBtn.IconRightZoom = 0D;
            this.MessageBtn.IconVisible = true;
            this.MessageBtn.IconZoom = 76D;
            this.MessageBtn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MessageBtn.IsTab = false;
            this.MessageBtn.Location = new System.Drawing.Point(16, 224);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Normalcolor = System.Drawing.Color.White;
            this.MessageBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.MessageBtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.MessageBtn.selected = false;
            this.MessageBtn.Size = new System.Drawing.Size(232, 41);
            this.MessageBtn.TabIndex = 4;
            this.MessageBtn.Text = "    Mesage";
            this.MessageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageBtn.Textcolor = System.Drawing.Color.Black;
            this.MessageBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "    Log Out";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 95D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(16, 264);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(227, 39);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "    Log Out";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AdminName
            // 
            this.AdminName.AutoEllipsis = false;
            this.AdminName.BackColor = System.Drawing.Color.White;
            this.AdminName.CursorType = null;
            this.AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName.ForeColor = System.Drawing.Color.Black;
            this.AdminName.Location = new System.Drawing.Point(106, 41);
            this.AdminName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminName.Name = "AdminName";
            this.AdminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminName.Size = new System.Drawing.Size(122, 24);
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
            this.Positionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positionlbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Positionlbl.Location = new System.Drawing.Point(113, 64);
            this.Positionlbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Positionlbl.Name = "Positionlbl";
            this.Positionlbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Positionlbl.Size = new System.Drawing.Size(47, 17);
            this.Positionlbl.TabIndex = 7;
            this.Positionlbl.Text = "ADMIN";
            this.Positionlbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Positionlbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ProfileAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(264, 341);
            this.ControlBox = false;
            this.Controls.Add(this.Positionlbl);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.MessageBtn);
            this.Controls.Add(this.ResetPassBtn);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ProfilePictureADMIN);
            this.Controls.Add(this.Profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureADMIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox Profile;
        private Bunifu.UI.WinForms.BunifuPictureBox ProfilePictureADMIN;
        private Bunifu.Framework.UI.BunifuFlatButton ProfileBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ResetPassBtn;
        private Bunifu.Framework.UI.BunifuFlatButton MessageBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.UI.WinForms.BunifuLabel AdminName;
        private Bunifu.UI.WinForms.BunifuLabel Positionlbl;
    }
}