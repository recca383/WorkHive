namespace WorkHive.Views.Admin.DashboardPages
{
    partial class ProjectView
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
            this.Dashboardlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dashboardlbl
            // 
            this.Dashboardlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dashboardlbl.AutoSize = true;
            this.Dashboardlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardlbl.Location = new System.Drawing.Point(15, 11);
            this.Dashboardlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dashboardlbl.Name = "Dashboardlbl";
            this.Dashboardlbl.Size = new System.Drawing.Size(242, 51);
            this.Dashboardlbl.TabIndex = 1;
            this.Dashboardlbl.Text = "Dashboard";
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dashboardlbl);
            this.Name = "ProjectView";
            this.Size = new System.Drawing.Size(1243, 721);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboardlbl;
    }
}
