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
            this.OkayButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TextLabel = new System.Windows.Forms.Label();
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
            this.OkayButton.Location = new System.Drawing.Point(211, 158);
            this.OkayButton.Margin = new System.Windows.Forms.Padding(5);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Normalcolor = System.Drawing.Color.White;
            this.OkayButton.OnHovercolor = System.Drawing.Color.Gold;
            this.OkayButton.OnHoverTextColor = System.Drawing.SystemColors.WindowText;
            this.OkayButton.selected = false;
            this.OkayButton.Size = new System.Drawing.Size(91, 30);
            this.OkayButton.TabIndex = 7;
            this.OkayButton.Text = "Okay";
            this.OkayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkayButton.Textcolor = System.Drawing.SystemColors.GrayText;
            this.OkayButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextLabel);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 103);
            this.panel1.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 39;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoEllipsis = true;
            this.TextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.Location = new System.Drawing.Point(0, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(316, 103);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Sample Text";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorkHive.Properties.Resources.Messagebox21;
            this.ClientSize = new System.Drawing.Size(316, 194);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MessageBoxes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton OkayButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label TextLabel;
    }
}