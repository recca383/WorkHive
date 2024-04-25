namespace WorkHive.Views.Admin.DashboardPages
{
    partial class MemberView
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
            this.MembersFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.Location = new System.Drawing.Point(29, 28);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(173, 42);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Members";
            // 
            // MembersFlow
            // 
            this.MembersFlow.Location = new System.Drawing.Point(82, 88);
            this.MembersFlow.Name = "MembersFlow";
            this.MembersFlow.Size = new System.Drawing.Size(810, 498);
            this.MembersFlow.TabIndex = 2;
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MembersFlow);
            this.Controls.Add(this.Employees);
            this.Name = "EmployeesView";
            this.Size = new System.Drawing.Size(932, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.FlowLayoutPanel MembersFlow;
    }
}
