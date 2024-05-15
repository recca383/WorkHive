namespace WorkHive.Views.Admin.DashboardPages
{
    partial class ProjectTasks
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
            this.btnArchived = new System.Windows.Forms.Label();
            this.btnCompleted = new System.Windows.Forms.Label();
            this.btnOngoing = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Label();
            this.TasksName = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArchived
            // 
            this.btnArchived.AutoSize = true;
            this.btnArchived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.Location = new System.Drawing.Point(845, 32);
            this.btnArchived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(97, 25);
            this.btnArchived.TabIndex = 11;
            this.btnArchived.Text = "Archived";
            // 
            // btnCompleted
            // 
            this.btnCompleted.AutoSize = true;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(621, 32);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(116, 25);
            this.btnCompleted.TabIndex = 10;
            this.btnCompleted.Text = "Completed";
            // 
            // btnOngoing
            // 
            this.btnOngoing.AutoSize = true;
            this.btnOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(421, 32);
            this.btnOngoing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(94, 25);
            this.btnOngoing.TabIndex = 9;
            this.btnOngoing.Text = "Ongoing";
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(280, 32);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(37, 25);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "All";
            // 
            // TasksName
            // 
            this.TasksName.AutoSize = true;
            this.TasksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksName.Location = new System.Drawing.Point(15, 11);
            this.TasksName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TasksName.Name = "TasksName";
            this.TasksName.Size = new System.Drawing.Size(143, 51);
            this.TasksName.TabIndex = 12;
            this.TasksName.Text = "Tasks";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WorkHive.Properties.Resources.EKIS;
            this.pictureBox5.Location = new System.Drawing.Point(1191, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // ProjectTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.TasksName);
            this.Controls.Add(this.btnArchived);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnOngoing);
            this.Controls.Add(this.btnAll);
            this.Name = "ProjectTasks";
            this.Size = new System.Drawing.Size(1243, 721);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnArchived;
        private System.Windows.Forms.Label btnCompleted;
        private System.Windows.Forms.Label btnOngoing;
        private System.Windows.Forms.Label btnAll;
        private System.Windows.Forms.Label TasksName;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
