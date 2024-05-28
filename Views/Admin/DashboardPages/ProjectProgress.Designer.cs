namespace WorkHive.Views.Admin.DashboardPages
{
    partial class ProjectProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectProgress));
            this.StatusColor = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AverageProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // StatusColor
            // 
            this.StatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.StatusColor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusColor.Location = new System.Drawing.Point(161, 260);
            this.StatusColor.Name = "StatusColor";
            this.StatusColor.Size = new System.Drawing.Size(16, 17);
            this.StatusColor.TabIndex = 16;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(183, 261);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(66, 18);
            this.Status.TabIndex = 15;
            this.Status.Text = "Finished";
            // 
            // ProjectName
            // 
            this.ProjectName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(3, 6);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(280, 35);
            this.ProjectName.TabIndex = 17;
            this.ProjectName.Text = "Project Name";
            this.ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ongoing";
            // 
            // AverageProgress
            // 
            this.AverageProgress.animated = false;
            this.AverageProgress.animationIterval = 5;
            this.AverageProgress.animationSpeed = 300;
            this.AverageProgress.AutoSize = true;
            this.AverageProgress.BackColor = System.Drawing.Color.White;
            this.AverageProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AverageProgress.BackgroundImage")));
            this.AverageProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            this.AverageProgress.LabelVisible = true;
            this.AverageProgress.LineProgressThickness = 8;
            this.AverageProgress.LineThickness = 5;
            this.AverageProgress.Location = new System.Drawing.Point(29, 37);
            this.AverageProgress.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.AverageProgress.MaxValue = 100;
            this.AverageProgress.Name = "AverageProgress";
            this.AverageProgress.ProgressBackColor = System.Drawing.Color.Black;
            this.AverageProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.AverageProgress.Size = new System.Drawing.Size(213, 213);
            this.AverageProgress.TabIndex = 14;
            this.AverageProgress.Value = 0;
            // 
            // ProjectProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.StatusColor);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.AverageProgress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectProgress";
            this.Size = new System.Drawing.Size(287, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCircleProgressbar AverageProgress;
        private System.Windows.Forms.Label StatusColor;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
