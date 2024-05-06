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
            this.TaskName = new System.Windows.Forms.Label();
            this.TaskDeadline = new System.Windows.Forms.Label();
            this.TaskId = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.TaskId);
            this.panel11.Controls.Add(this.TaskName);
            this.panel11.Controls.Add(this.TaskDeadline);
            this.panel11.Location = new System.Drawing.Point(2, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(544, 29);
            this.panel11.TabIndex = 16;
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.Location = new System.Drawing.Point(3, 6);
            this.TaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(178, 19);
            this.TaskName.TabIndex = 12;
            this.TaskName.Text = "Final Project For ITEC 103";
            // 
            // TaskDeadline
            // 
            this.TaskDeadline.AutoSize = true;
            this.TaskDeadline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDeadline.Location = new System.Drawing.Point(463, 6);
            this.TaskDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskDeadline.Name = "TaskDeadline";
            this.TaskDeadline.Size = new System.Drawing.Size(85, 19);
            this.TaskDeadline.TabIndex = 13;
            this.TaskDeadline.Text = "06/10/2024";
            // 
            // TaskId
            // 
            this.TaskId.AutoSize = true;
            this.TaskId.Location = new System.Drawing.Point(310, 10);
            this.TaskId.Name = "TaskId";
            this.TaskId.Size = new System.Drawing.Size(35, 13);
            this.TaskId.TabIndex = 14;
            this.TaskId.Text = "label1";
            this.TaskId.Visible = false;
            // 
            // TaskSummaryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel11);
            this.Name = "TaskSummaryCard";
            this.Size = new System.Drawing.Size(549, 34);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.Label TaskDeadline;
        private System.Windows.Forms.Label TaskId;
    }
}
