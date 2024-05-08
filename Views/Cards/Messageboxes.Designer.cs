namespace WorkHive.Views.LandingPage.LandingPagePages
{
    partial class MessageBoxes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxes));
            this.OkayButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkayButton
            // 
            this.OkayButton.Active = false;
            this.OkayButton.Activecolor = System.Drawing.Color.Transparent;
            this.OkayButton.BackColor = System.Drawing.Color.White;
            this.OkayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OkayButton.BorderRadius = 5;
            this.OkayButton.ButtonText = "Okay";
            this.OkayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkayButton.DisabledColor = System.Drawing.Color.Gray;
            this.OkayButton.ForeColor = System.Drawing.Color.White;
            this.OkayButton.Iconcolor = System.Drawing.Color.Transparent;
            this.OkayButton.Iconimage = null;
            this.OkayButton.Iconimage_right = null;
            this.OkayButton.Iconimage_right_Selected = null;
            this.OkayButton.Iconimage_Selected = null;
            this.OkayButton.IconMarginLeft = 0;
            this.OkayButton.IconMarginRight = 0;
            this.OkayButton.IconRightVisible = true;
            this.OkayButton.IconRightZoom = 0D;
            this.OkayButton.IconVisible = true;
            this.OkayButton.IconZoom = 90D;
            this.OkayButton.IsTab = false;
            this.OkayButton.Location = new System.Drawing.Point(158, 128);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Normalcolor = System.Drawing.Color.White;
            this.OkayButton.OnHovercolor = System.Drawing.Color.Gold;
            this.OkayButton.OnHoverTextColor = System.Drawing.SystemColors.WindowText;
            this.OkayButton.selected = false;
            this.OkayButton.Size = new System.Drawing.Size(68, 24);
            this.OkayButton.TabIndex = 7;
            this.OkayButton.Text = "Okay";
            this.OkayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkayButton.Textcolor = System.Drawing.Color.White;
            this.OkayButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextLabel);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 80);
            this.panel1.TabIndex = 6;
            // 
            // TextLabel
            // 
            this.TextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextLabel.AutoEllipsis = true;
            this.TextLabel.AutoSize = false;
            this.TextLabel.AutoSizeHeightOnly = true;
            this.TextLabel.BackColor = System.Drawing.Color.White;
            this.TextLabel.CursorType = null;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TextLabel.Location = new System.Drawing.Point(11, 17);
            this.TextLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextLabel.Size = new System.Drawing.Size(215, 28);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Sample Text";
            this.TextLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.TextLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 39;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MessageBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorkHive.Properties.Resources.Messagebox21;
            this.ClientSize = new System.Drawing.Size(237, 158);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MessageBoxes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton OkayButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel TextLabel;
    }
}