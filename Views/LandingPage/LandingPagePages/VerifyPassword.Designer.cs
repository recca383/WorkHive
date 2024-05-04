namespace WorkHive.Views.LandingPage.LandingPagePages
{
    partial class VerifyPassword
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyPassword));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnResendCode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnGoBackToFirstStep = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVerify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSendCode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBackToFirstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Verify Your Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 487);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 25);
            this.label2.TabIndex = 27;
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
            this.txtCode.Location = new System.Drawing.Point(103, 525);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(323, 33);
            this.txtCode.TabIndex = 25;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "Please Enter The 5-Digit Code Sent To Your Email Address.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 70;
            this.bunifuElipse2.TargetControl = this;
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnResendCode.CustomizableEdges = borderEdges6;
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
            this.btnResendCode.Location = new System.Drawing.Point(163, 569);
            this.btnResendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResendCode.Name = "btnResendCode";
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.BorderRadius = 3;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.btnResendCode.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.BorderRadius = 3;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.btnResendCode.OnPressedState = stateProperties12;
            this.btnResendCode.Size = new System.Drawing.Size(195, 30);
            this.btnResendCode.TabIndex = 30;
            this.btnResendCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResendCode.TextMarginLeft = 0;
            this.btnResendCode.UseDefaultRadiusAndThickness = true;
            this.btnResendCode.Click += new System.EventHandler(this.btnResendCode_Click);
            // 
            // btnGoBackToFirstStep
            // 
            this.btnGoBackToFirstStep.Image = global::WorkHive.Properties.Resources.BackButton;
            this.btnGoBackToFirstStep.ImageActive = null;
            this.btnGoBackToFirstStep.Location = new System.Drawing.Point(61, 68);
            this.btnGoBackToFirstStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoBackToFirstStep.Name = "btnGoBackToFirstStep";
            this.btnGoBackToFirstStep.Size = new System.Drawing.Size(21, 21);
            this.btnGoBackToFirstStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnGoBackToFirstStep.TabIndex = 29;
            this.btnGoBackToFirstStep.TabStop = false;
            this.btnGoBackToFirstStep.Zoom = 10;
            this.btnGoBackToFirstStep.Click += new System.EventHandler(this.btnGoBackToFirstStep_Click);
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
            this.btnVerify.Location = new System.Drawing.Point(103, 649);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerify.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVerify.selected = false;
            this.btnVerify.Size = new System.Drawing.Size(323, 41);
            this.btnVerify.TabIndex = 28;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerify.Textcolor = System.Drawing.Color.White;
            this.btnVerify.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.VerifyCode;
            this.pictureBox1.Location = new System.Drawing.Point(132, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnSendCode
            // 
            this.btnSendCode.AllowToggling = false;
            this.btnSendCode.AnimationSpeed = 200;
            this.btnSendCode.AutoGenerateColors = false;
            this.btnSendCode.BackColor = System.Drawing.Color.Transparent;
            this.btnSendCode.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSendCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendCode.BackgroundImage")));
            this.btnSendCode.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSendCode.ButtonText = "Send Code";
            this.btnSendCode.ButtonTextMarginLeft = 0;
            this.btnSendCode.ColorContrastOnClick = 45;
            this.btnSendCode.ColorContrastOnHover = 45;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnSendCode.CustomizableEdges = borderEdges5;
            this.btnSendCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSendCode.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSendCode.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSendCode.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSendCode.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSendCode.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSendCode.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.IconMarginLeft = 11;
            this.btnSendCode.IconPadding = 10;
            this.btnSendCode.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSendCode.IdleBorderRadius = 3;
            this.btnSendCode.IdleBorderThickness = 1;
            this.btnSendCode.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSendCode.IdleIconLeftImage = null;
            this.btnSendCode.IdleIconRightImage = null;
            this.btnSendCode.IndicateFocus = false;
            this.btnSendCode.Location = new System.Drawing.Point(163, 569);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCode.Name = "btnSendCode";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.BorderRadius = 3;
            stateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btnSendCode.onHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties10.BorderRadius = 3;
            stateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this.btnSendCode.OnPressedState = stateProperties10;
            this.btnSendCode.Size = new System.Drawing.Size(195, 30);
            this.btnSendCode.TabIndex = 31;
            this.btnSendCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendCode.TextMarginLeft = 0;
            this.btnSendCode.UseDefaultRadiusAndThickness = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // VerifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnResendCode);
            this.Controls.Add(this.btnGoBackToFirstStep);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerifyPassword";
            this.Size = new System.Drawing.Size(535, 764);
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBackToFirstStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnResendCode;
        private Bunifu.Framework.UI.BunifuImageButton btnGoBackToFirstStep;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCode;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSendCode;
    }
}
