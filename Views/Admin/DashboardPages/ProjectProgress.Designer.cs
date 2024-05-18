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
            this.AverageProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AverageProgress
            // 
            this.AverageProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AverageProgress.animated = false;
            this.AverageProgress.animationIterval = 5;
            this.AverageProgress.animationSpeed = 300;
            this.AverageProgress.BackColor = System.Drawing.Color.White;
            this.AverageProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AverageProgress.BackgroundImage")));
            this.AverageProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            this.AverageProgress.LabelVisible = true;
            this.AverageProgress.LineProgressThickness = 8;
            this.AverageProgress.LineThickness = 5;
            this.AverageProgress.Location = new System.Drawing.Point(42, 0);
            this.AverageProgress.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.AverageProgress.MaxValue = 100;
            this.AverageProgress.Name = "AverageProgress";
            this.AverageProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.AverageProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.AverageProgress.Size = new System.Drawing.Size(201, 201);
            this.AverageProgress.TabIndex = 14;
            this.AverageProgress.Value = 0;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label21.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(86, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 17);
            this.label21.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(107, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 16);
            this.label20.TabIndex = 15;
            this.label20.Text = "Finished";
            // 
            // ProjectProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.AverageProgress);
            this.Name = "ProjectProgress";
            this.Size = new System.Drawing.Size(280, 247);
            this.Load += new System.EventHandler(this.ProjectProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCircleProgressbar AverageProgress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}
