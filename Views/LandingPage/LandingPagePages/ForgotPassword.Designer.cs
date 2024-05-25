namespace WorkHive.Views.LandingPage.LandingPagePages
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExitForgotPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmailAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitForgotPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExitForgotPassword
            // 
            this.btnExitForgotPassword.Image = global::WorkHive.Properties.Resources.BackButton;
            this.btnExitForgotPassword.ImageActive = null;
            this.btnExitForgotPassword.Location = new System.Drawing.Point(61, 68);
            this.btnExitForgotPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExitForgotPassword.Name = "btnExitForgotPassword";
            this.btnExitForgotPassword.Size = new System.Drawing.Size(21, 21);
            this.btnExitForgotPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExitForgotPassword.TabIndex = 21;
            this.btnExitForgotPassword.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnExitForgotPassword, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnExitForgotPassword, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnExitForgotPassword, "");
            this.btnExitForgotPassword.Zoom = 10;
            this.btnExitForgotPassword.Click += new System.EventHandler(this.btnExitForgotPassword_Click);
            // 
            // btnSend
            // 
            this.btnSend.Active = false;
            this.btnSend.Activecolor = System.Drawing.Color.Transparent;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "SEND";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = null;
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 90D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(103, 593);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(337, 41);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "SEND";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnSend, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSend, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSend, "");
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email Address";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.ResetPassword;
            this.pictureBox1.Location = new System.Drawing.Point(138, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmailAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmailAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.txtEmailAddress.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtEmailAddress.HintText = "example@gmail.com";
            this.txtEmailAddress.isPassword = false;
            this.txtEmailAddress.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtEmailAddress.LineIdleColor = System.Drawing.Color.Gold;
            this.txtEmailAddress.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtEmailAddress.LineThickness = 3;
            this.txtEmailAddress.Location = new System.Drawing.Point(103, 509);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmailAddress.MaxLength = 32767;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(337, 33);
            this.txtEmailAddress.TabIndex = 17;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuToolTip1.SetToolTip(this.txtEmailAddress, "Enter your Email Address");
            this.bunifuToolTip1.SetToolTipIcon(this.txtEmailAddress, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtEmailAddress, "");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please Enter Your Email Address To Receive A Verification Code.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Forgot Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = true;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 1000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gold;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 10;
            this.bunifuToolTip1.ShowAlways = false;
            this.bunifuToolTip1.ShowBorders = true;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = "";
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExitForgotPassword);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(535, 764);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            ((System.ComponentModel.ISupportInitialize)(this.btnExitForgotPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnExitForgotPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}
