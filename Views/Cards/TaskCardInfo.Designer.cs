namespace WorkHive.Views.Cards
{
    partial class TaskCardInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCardInfo));
            this.Archived = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TaskProgress = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // Archived
            // 
            this.Archived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Archived.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Archived.Checked = true;
            this.Archived.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Archived.ForeColor = System.Drawing.Color.White;
            this.Archived.Location = new System.Drawing.Point(861, 5);
            this.Archived.Margin = new System.Windows.Forms.Padding(5);
            this.Archived.Name = "Archived";
            this.Archived.Size = new System.Drawing.Size(20, 20);
            this.Archived.TabIndex = 7;
            this.Archived.OnChange += new System.EventHandler(this.Archived_OnChange);
            // 
            // lblTask_Date
            // 
            this.lblTask_Date.AutoSize = true;
            this.lblTask_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Date.Location = new System.Drawing.Point(24, 71);
            this.lblTask_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Date.Name = "lblTask_Date";
            this.lblTask_Date.Size = new System.Drawing.Size(57, 20);
            this.lblTask_Date.TabIndex = 5;
            this.lblTask_Date.Text = "April 5";
            this.lblTask_Date.Click += new System.EventHandler(this.lblTask_Date_Click);
            // 
            // lblTask_Title
            // 
            this.lblTask_Title.AutoSize = true;
            this.lblTask_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Title.Location = new System.Drawing.Point(20, 33);
            this.lblTask_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Title.Name = "lblTask_Title";
            this.lblTask_Title.Size = new System.Drawing.Size(215, 39);
            this.lblTask_Title.TabIndex = 4;
            this.lblTask_Title.Text = "Lorem Ipsum";
            this.lblTask_Title.Click += new System.EventHandler(this.lblTask_Title_Click);
            // 
            // TaskProgress
            // 
            this.TaskProgress.Animation = 0;
            this.TaskProgress.AnimationStep = 10;
            this.TaskProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaskProgress.BackgroundImage")));
            this.TaskProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.BorderRadius = 5;
            this.TaskProgress.BorderThickness = 2;
            this.TaskProgress.Location = new System.Drawing.Point(28, 105);
            this.TaskProgress.Margin = new System.Windows.Forms.Padding(5);
            this.TaskProgress.MaximumValue = 100;
            this.TaskProgress.MinimumValue = 0;
            this.TaskProgress.Name = "TaskProgress";
            this.TaskProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.Size = new System.Drawing.Size(815, 12);
            this.TaskProgress.TabIndex = 6;
            this.TaskProgress.Value = 0;
            this.TaskProgress.onValueChange += new System.EventHandler(this.TaskProgress_onValueChange);
            // 
            // TaskCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 131);
            this.Controls.Add(this.Archived);
            this.Controls.Add(this.TaskProgress);
            this.Controls.Add(this.lblTask_Date);
            this.Controls.Add(this.lblTask_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskCardInfo";
            this.Text = "TaskCardInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCheckbox Archived;
        public Bunifu.UI.Winforms.BunifuProgressBar TaskProgress;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Date;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Title;
    }
}