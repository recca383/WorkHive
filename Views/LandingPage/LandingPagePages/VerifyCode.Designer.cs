namespace WorkHive.Views.LandingPage.LandingPagePages
{
    partial class VerifyCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyCode));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResendCode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVerify = new Bunifu.Framework.UI.BunifuFlatButton();
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "CODE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtCode.HintText = "";
            this.txtCode.isPassword = false;
            this.txtCode.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtCode.LineIdleColor = System.Drawing.Color.Gold;
            this.txtCode.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtCode.LineThickness = 3;
            this.txtCode.Location = new System.Drawing.Point(41, 408);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(323, 33);
            this.txtCode.TabIndex = 17;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please Enter The 5-Digit Code Sent To Your Email Address.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Verify Your Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResendCode
            // 
            this.btnResendCode.AllowToggling = false;
            this.btnResendCode.AnimationSpeed = 200;
            this.btnResendCode.AutoGenerateColors = false;
            this.btnResendCode.BackColor = System.Drawing.Color.Transparent;
            this.btnResendCode.BackColor1 = System.Drawing.Color.Transparent;
            this.btnResendCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResendCode.BackgroundImage")));
            this.btnResendCode.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnResendCode.ButtonText = "Resend Code";
            this.btnResendCode.ButtonTextMarginLeft = 0;
            this.btnResendCode.ColorContrastOnClick = 45;
            this.btnResendCode.ColorContrastOnHover = 45;
            this.btnResendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnResendCode.CustomizableEdges = borderEdges1;
            this.btnResendCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnResendCode.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnResendCode.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnResendCode.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnResendCode.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnResendCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnResendCode.ForeColor = System.Drawing.Color.DarkGray;
            this.btnResendCode.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnResendCode.IconMarginLeft = 11;
            this.btnResendCode.IconPadding = 10;
            this.btnResendCode.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnResendCode.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnResendCode.IdleBorderRadius = 3;
            this.btnResendCode.IdleBorderThickness = 1;
            this.btnResendCode.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnResendCode.IdleIconLeftImage = null;
            this.btnResendCode.IdleIconRightImage = null;
            this.btnResendCode.IndicateFocus = false;
            this.btnResendCode.Location = new System.Drawing.Point(101, 453);
            this.btnResendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResendCode.Name = "btnResendCode";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnResendCode.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnResendCode.OnPressedState = stateProperties2;
            this.btnResendCode.Size = new System.Drawing.Size(195, 30);
            this.btnResendCode.TabIndex = 22;
            this.btnResendCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResendCode.TextMarginLeft = 0;
            this.btnResendCode.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::WorkHive.Properties.Resources.BackButton;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(41, 51);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(21, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 21;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnVerify
            // 
            this.btnVerify.Active = false;
            this.btnVerify.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerify.BackgroundImage")));
            this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerify.BorderRadius = 0;
            this.btnVerify.ButtonText = "VERIFY";
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerify.Iconimage = null;
            this.btnVerify.Iconimage_right = null;
            this.btnVerify.Iconimage_right_Selected = null;
            this.btnVerify.Iconimage_Selected = null;
            this.btnVerify.IconMarginLeft = 0;
            this.btnVerify.IconMarginRight = 0;
            this.btnVerify.IconRightVisible = true;
            this.btnVerify.IconRightZoom = 0D;
            this.btnVerify.IconVisible = true;
            this.btnVerify.IconZoom = 90D;
            this.btnVerify.IsTab = false;
            this.btnVerify.Location = new System.Drawing.Point(41, 527);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerify.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVerify.selected = false;
            this.btnVerify.Size = new System.Drawing.Size(323, 41);
            this.btnVerify.TabIndex = 20;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerify.Textcolor = System.Drawing.Color.White;
            this.btnVerify.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.VerifyCode;
            this.pictureBox1.Location = new System.Drawing.Point(91, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // VerifyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 650);
            this.Controls.Add(this.btnResendCode);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerifyCode";
            this.Text = "VerifyCode";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnResendCode;
    }
}