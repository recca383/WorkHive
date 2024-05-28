namespace WorkHive.Views.Cards
{
    partial class TaskSummaryCard
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.ProjectName = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.Label();
            this.TaskDeadline = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.ProjectName);
            this.panel11.Controls.Add(this.TaskName);
            this.panel11.Controls.Add(this.TaskDeadline);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(786, 42);
            this.panel11.TabIndex = 16;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(4, 10);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(114, 23);
            this.ProjectName.TabIndex = 14;
            this.ProjectName.Text = "Project Name";
            // 
            // TaskName
            // 
            this.TaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(326, 10);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(134, 23);
            this.TaskName.TabIndex = 12;
            this.TaskName.Text = "Task Name";
            this.TaskName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TaskDeadline
            // 
            this.TaskDeadline.AutoSize = true;
            this.TaskDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDeadline.Location = new System.Drawing.Point(630, 10);
            this.TaskDeadline.Name = "TaskDeadline";
            this.TaskDeadline.Size = new System.Drawing.Size(95, 23);
            this.TaskDeadline.TabIndex = 13;
            this.TaskDeadline.Text = "06/10/2024";
            // 
            // TaskSummaryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskSummaryCard";
            this.Size = new System.Drawing.Size(786, 42);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.Label TaskDeadline;
        private System.Windows.Forms.Label ProjectName;
    }
}
