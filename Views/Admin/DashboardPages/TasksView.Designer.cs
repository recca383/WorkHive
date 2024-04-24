namespace WorkHive.Views.Admin.DashboardPages
{
    partial class TasksView
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
            this.Employees = new System.Windows.Forms.Label();
            this.TasksFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Label();
            this.btnOngoing = new System.Windows.Forms.Label();
            this.btnCompleted = new System.Windows.Forms.Label();
            this.Archived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.Location = new System.Drawing.Point(29, 28);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(119, 42);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Tasks";
            // 
            // TasksFlow
            // 
            this.TasksFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TasksFlow.Location = new System.Drawing.Point(36, 83);
            this.TasksFlow.Name = "TasksFlow";
            this.TasksFlow.Size = new System.Drawing.Size(744, 414);
            this.TasksFlow.TabIndex = 3;
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(252, 40);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(26, 20);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "All";
            // 
            // btnOngoing
            // 
            this.btnOngoing.AutoSize = true;
            this.btnOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(326, 40);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(69, 20);
            this.btnOngoing.TabIndex = 5;
            this.btnOngoing.Text = "Ongoing";
            // 
            // btnCompleted
            // 
            this.btnCompleted.AutoSize = true;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(447, 40);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(86, 20);
            this.btnCompleted.TabIndex = 6;
            this.btnCompleted.Text = "Completed";
            // 
            // Archived
            // 
            this.Archived.AutoSize = true;
            this.Archived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archived.Location = new System.Drawing.Point(584, 40);
            this.Archived.Name = "Archived";
            this.Archived.Size = new System.Drawing.Size(70, 20);
            this.Archived.TabIndex = 7;
            this.Archived.Text = "Archived";
            // 
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Archived);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnOngoing);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.TasksFlow);
            this.Controls.Add(this.Employees);
            this.Name = "TasksView";
            this.Size = new System.Drawing.Size(810, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.FlowLayoutPanel TasksFlow;
        private System.Windows.Forms.Label btnAll;
        private System.Windows.Forms.Label btnOngoing;
        private System.Windows.Forms.Label btnCompleted;
        private System.Windows.Forms.Label Archived;
    }
}
