namespace WorkHive.Views.LandingPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Enter Your Email Address To Receive A Verification Code.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.txtEmailAddress.Location = new System.Drawing.Point(41, 423);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmailAddress.MaxLength = 32767;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(323, 33);
            this.txtEmailAddress.TabIndex = 10;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email Address";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::WorkHive.Properties.Resources.BackButton;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(41, 51);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(21, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 14;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
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
            this.btnSend.Location = new System.Drawing.Point(41, 507);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(323, 41);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "SEND";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.ResetPassword;
            this.pictureBox1.Location = new System.Drawing.Point(91, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 650);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}