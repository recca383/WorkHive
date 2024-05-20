namespace WorkHive.Views.Admin.DashboardPages
{
    partial class BirthdayCard
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
            this.MemberName = new System.Windows.Forms.Label();
            this.MemberBirthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MemberName
            // 
            this.MemberName.AutoSize = true;
            this.MemberName.BackColor = System.Drawing.Color.Transparent;
            this.MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberName.Location = new System.Drawing.Point(80, 25);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(179, 20);
            this.MemberName.TabIndex = 0;
            this.MemberName.Text = "Nathaniel\'s Birthday";
            // 
            // MemberBirthday
            // 
            this.MemberBirthday.AutoSize = true;
            this.MemberBirthday.BackColor = System.Drawing.Color.Transparent;
            this.MemberBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberBirthday.Location = new System.Drawing.Point(195, 52);
            this.MemberBirthday.Name = "MemberBirthday";
            this.MemberBirthday.Size = new System.Drawing.Size(88, 13);
            this.MemberBirthday.TabIndex = 1;
            this.MemberBirthday.Text = "June 06, 2024";
            // 
            // BirthdayCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::WorkHive.Properties.Resources.BirthdayCard;
            this.Controls.Add(this.MemberBirthday);
            this.Controls.Add(this.MemberName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BirthdayCard";
            this.Size = new System.Drawing.Size(286, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.Label MemberBirthday;
    }
}
