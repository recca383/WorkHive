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
            this.MembersName = new System.Windows.Forms.Label();
            this.MembersFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MembersName
            // 
            this.MembersName.AutoSize = true;
            this.MembersName.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersName.Location = new System.Drawing.Point(11, 10);
            this.MembersName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MembersName.Name = "MembersName";
            this.MembersName.Size = new System.Drawing.Size(151, 60);
            this.MembersName.TabIndex = 1;
            this.MembersName.Text = "Users";
            // 
            // MembersFlow
            // 
            this.MembersFlow.AutoScroll = true;
            this.MembersFlow.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.MembersFlow.Location = new System.Drawing.Point(0, 123);
            this.MembersFlow.Margin = new System.Windows.Forms.Padding(5);
            this.MembersFlow.Name = "MembersFlow";
            this.MembersFlow.Size = new System.Drawing.Size(1360, 617);
            this.MembersFlow.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MembersName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 123);
            this.panel2.TabIndex = 5;
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MembersFlow);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MemberView";
            this.Size = new System.Drawing.Size(1360, 740);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MembersName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel MembersFlow;
    }
}
