namespace WorkHive.Views.Admin
{
    partial class CalendarCurrentDays
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
            this.lblDays = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(11, 11);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(29, 20);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "00";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(11, 43);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(44, 16);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "label1";
            this.lblTaskName.Visible = false;
            // 
            // CalendarCurrentDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblDays);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalendarCurrentDays";
            this.Size = new System.Drawing.Size(163, 100);
            this.Load += new System.EventHandler(this.CalendarCurrentDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblTaskName;
    }
}
