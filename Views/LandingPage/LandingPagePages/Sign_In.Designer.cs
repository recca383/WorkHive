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
            this.btnSignUp = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnForgotPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(325, 332);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(123, 16);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "New here? Sign-Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(41, 274);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(399, 37);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(41, 238);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(399, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(41, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.AutoSize = true;
            this.btnForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPass.Location = new System.Drawing.Point(38, 332);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(145, 16);
            this.btnForgotPass.TabIndex = 8;
            this.btnForgotPass.Text = "Forgot your Password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome!";
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.label3);
            this.Name = "Sign_In";
            this.Size = new System.Drawing.Size(495, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label btnForgotPass;
        private System.Windows.Forms.Label label3;
    }
}
