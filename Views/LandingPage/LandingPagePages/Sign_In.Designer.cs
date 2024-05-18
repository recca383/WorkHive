namespace WorkHive.Views.LandingPage.LandingPagePages
{
    partial class Sign_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_In));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ShowPassword = new WorkHive.Views.CircularPictureBox();
            this.btnForgotPass = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSignUp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome!";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowDrop = true;
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gold;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(56, 335);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(538, 34);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.HintText = "E-mail";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Gold;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gold;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(56, 273);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(538, 35);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ShowPassword
            // 
            this.ShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPassword.Image = global::WorkHive.Properties.Resources.eye_open;
            this.ShowPassword.Location = new System.Drawing.Point(558, 335);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(36, 27);
            this.ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassword.TabIndex = 31;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.AllowToggling = false;
            this.btnForgotPass.AnimationSpeed = 200;
            this.btnForgotPass.AutoGenerateColors = false;
            this.btnForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.BackColor1 = System.Drawing.Color.Transparent;
            this.btnForgotPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForgotPass.BackgroundImage")));
            this.btnForgotPass.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnForgotPass.ButtonText = "Forgot your Password?";
            this.btnForgotPass.ButtonTextMarginLeft = 0;
            this.btnForgotPass.ColorContrastOnClick = 45;
            this.btnForgotPass.ColorContrastOnHover = 45;
            this.btnForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.btnForgotPass.CustomizableEdges = borderEdges15;
            this.btnForgotPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForgotPass.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnForgotPass.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnForgotPass.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnForgotPass.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnForgotPass.ForeColor = System.Drawing.Color.DarkGray;
            this.btnForgotPass.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPass.IconMarginLeft = 11;
            this.btnForgotPass.IconPadding = 10;
            this.btnForgotPass.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPass.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.IdleBorderRadius = 3;
            this.btnForgotPass.IdleBorderThickness = 1;
            this.btnForgotPass.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.IdleIconLeftImage = null;
            this.btnForgotPass.IdleIconRightImage = null;
            this.btnForgotPass.IndicateFocus = false;
            this.btnForgotPass.Location = new System.Drawing.Point(55, 496);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForgotPass.Name = "btnForgotPass";
            stateProperties29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties29.BorderRadius = 3;
            stateProperties29.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties29.BorderThickness = 1;
            stateProperties29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties29.ForeColor = System.Drawing.Color.White;
            stateProperties29.IconLeftImage = null;
            stateProperties29.IconRightImage = null;
            this.btnForgotPass.onHoverState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties30.BorderRadius = 3;
            stateProperties30.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties30.BorderThickness = 1;
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties30.ForeColor = System.Drawing.Color.White;
            stateProperties30.IconLeftImage = null;
            stateProperties30.IconRightImage = null;
            this.btnForgotPass.OnPressedState = stateProperties30;
            this.btnForgotPass.Size = new System.Drawing.Size(186, 33);
            this.btnForgotPass.TabIndex = 15;
            this.btnForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnForgotPass.TextMarginLeft = 0;
            this.btnForgotPass.UseDefaultRadiusAndThickness = true;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AllowToggling = false;
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.AnimationSpeed = 200;
            this.btnSignUp.AutoGenerateColors = false;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.ButtonText = "New here? Sign-Up";
            this.btnSignUp.ButtonTextMarginLeft = 0;
            this.btnSignUp.ColorContrastOnClick = 45;
            this.btnSignUp.ColorContrastOnHover = 45;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.btnSignUp.CustomizableEdges = borderEdges16;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSignUp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignUp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignUp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.IconMarginLeft = 11;
            this.btnSignUp.IconPadding = 10;
            this.btnSignUp.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.IdleBorderRadius = 3;
            this.btnSignUp.IdleBorderThickness = 1;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSignUp.IdleIconLeftImage = null;
            this.btnSignUp.IdleIconRightImage = null;
            this.btnSignUp.IndicateFocus = false;
            this.btnSignUp.Location = new System.Drawing.Point(400, 496);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.BorderRadius = 3;
            stateProperties31.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties31.BorderThickness = 1;
            stateProperties31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.ForeColor = System.Drawing.Color.White;
            stateProperties31.IconLeftImage = null;
            stateProperties31.IconRightImage = null;
            this.btnSignUp.onHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties32.BorderRadius = 3;
            stateProperties32.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties32.BorderThickness = 1;
            stateProperties32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties32.ForeColor = System.Drawing.Color.White;
            stateProperties32.IconLeftImage = null;
            stateProperties32.IconRightImage = null;
            this.btnSignUp.OnPressedState = stateProperties32;
            this.btnSignUp.Size = new System.Drawing.Size(159, 33);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.TextMarginLeft = 0;
            this.btnSignUp.UseDefaultRadiusAndThickness = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Active = false;
            this.btnSignIn.Activecolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 0;
            this.btnSignIn.ButtonText = "SIGN IN";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Iconimage = null;
            this.btnSignIn.Iconimage_right = null;
            this.btnSignIn.Iconimage_right_Selected = null;
            this.btnSignIn.Iconimage_Selected = null;
            this.btnSignIn.IconMarginLeft = 0;
            this.btnSignIn.IconMarginRight = 0;
            this.btnSignIn.IconRightVisible = true;
            this.btnSignIn.IconRightZoom = 0D;
            this.btnSignIn.IconVisible = true;
            this.btnSignIn.IconZoom = 90D;
            this.btnSignIn.IsTab = false;
            this.btnSignIn.Location = new System.Drawing.Point(55, 425);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.OnHovercolor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSignIn.selected = false;
            this.btnSignIn.Size = new System.Drawing.Size(539, 55);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Textcolor = System.Drawing.Color.White;
            this.btnSignIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Sign_In
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sign_In";
            this.Size = new System.Drawing.Size(660, 809);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignIn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignUp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnForgotPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private CircularPictureBox ShowPassword;
    }
}
