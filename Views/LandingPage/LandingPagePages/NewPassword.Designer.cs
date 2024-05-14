namespace WorkHive.Views.LandingPage.LandingPagePages
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPassword2 = new WorkHive.Views.CircularPictureBox();
            this.ShowPassword = new WorkHive.Views.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConfirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConfirmPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.HintText = "Confirm Password";
            this.txtConfirmPassword.isPassword = false;
            this.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtConfirmPassword.LineIdleColor = System.Drawing.Color.Gold;
            this.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtConfirmPassword.LineThickness = 3;
            this.txtConfirmPassword.Location = new System.Drawing.Point(82, 482);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(242, 27);
            this.txtConfirmPassword.TabIndex = 41;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.OnValueChanged += new System.EventHandler(this.txtConfirmPassword_OnValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.HintText = "At least 8 Characters";
            this.txtNewPassword.isPassword = false;
            this.txtNewPassword.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtNewPassword.LineIdleColor = System.Drawing.Color.Gold;
            this.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtNewPassword.LineThickness = 3;
            this.txtNewPassword.Location = new System.Drawing.Point(82, 417);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(242, 27);
            this.txtNewPassword.TabIndex = 39;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword.OnValueChanged += new System.EventHandler(this.txtNewPassword_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::WorkHive.Properties.Resources.BackButton;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(46, 55);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(21, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(81, 543);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(243, 33);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.NewPassword;
            this.pictureBox1.Location = new System.Drawing.Point(99, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "Please Enter Your New Password. It Must Contain 8 Characters.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Create New Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPassword2
            // 
            this.ShowPassword2.Image = global::WorkHive.Properties.Resources.Userdefault;
            this.ShowPassword2.Location = new System.Drawing.Point(292, 466);
            this.ShowPassword2.Name = "ShowPassword2";
            this.ShowPassword2.Size = new System.Drawing.Size(27, 37);
            this.ShowPassword2.TabIndex = 44;
            this.ShowPassword2.TabStop = false;
            this.ShowPassword2.Click += new System.EventHandler(this.ShowPassword2_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Image = global::WorkHive.Properties.Resources.Userdefault;
            this.ShowPassword.Location = new System.Drawing.Point(292, 404);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(27, 37);
            this.ShowPassword.TabIndex = 43;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ShowPassword2);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "NewPassword";
            this.Size = new System.Drawing.Size(401, 621);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CircularPictureBox ShowPassword2;
        private CircularPictureBox ShowPassword;
    }
}
