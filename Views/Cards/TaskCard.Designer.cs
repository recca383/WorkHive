﻿namespace WorkHive.Views.Cards
{
    partial class TaskCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TasksPanel = new System.Windows.Forms.Panel();
            this.Archived = new Bunifu.Framework.UI.BunifuCheckbox();
            this.TaskProgress = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.lblTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TasksPanel
            // 
            this.TasksPanel.Location = new System.Drawing.Point(822, 63);
            this.TasksPanel.Name = "TasksPanel";
            this.TasksPanel.Size = new System.Drawing.Size(177, 85);
            this.TasksPanel.TabIndex = 4;
            // 
            // Archived
            // 
            this.Archived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Archived.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Archived.Checked = true;
            this.Archived.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Archived.ForeColor = System.Drawing.Color.White;
            this.Archived.Location = new System.Drawing.Point(984, 27);
            this.Archived.Margin = new System.Windows.Forms.Padding(5);
            this.Archived.Name = "Archived";
            this.Archived.Size = new System.Drawing.Size(20, 20);
            this.Archived.TabIndex = 11;
            // 
            // TaskProgress
            // 
            this.TaskProgress.Animation = 0;
            this.TaskProgress.AnimationStep = 10;
            this.TaskProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaskProgress.BackgroundImage")));
            this.TaskProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.BorderRadius = 5;
            this.TaskProgress.BorderThickness = 2;
            this.TaskProgress.Location = new System.Drawing.Point(151, 127);
            this.TaskProgress.Margin = new System.Windows.Forms.Padding(5);
            this.TaskProgress.MaximumValue = 100;
            this.TaskProgress.MinimumValue = 0;
            this.TaskProgress.Name = "TaskProgress";
            this.TaskProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.Size = new System.Drawing.Size(815, 12);
            this.TaskProgress.TabIndex = 10;
            this.TaskProgress.Value = 0;
            // 
            // lblTask_Date
            // 
            this.lblTask_Date.AutoSize = true;
            this.lblTask_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Date.Location = new System.Drawing.Point(147, 93);
            this.lblTask_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Date.Name = "lblTask_Date";
            this.lblTask_Date.Size = new System.Drawing.Size(57, 20);
            this.lblTask_Date.TabIndex = 9;
            this.lblTask_Date.Text = "April 5";
            // 
            // lblTask_Title
            // 
            this.lblTask_Title.AutoSize = true;
            this.lblTask_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Title.Location = new System.Drawing.Point(143, 55);
            this.lblTask_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Title.Name = "lblTask_Title";
            this.lblTask_Title.Size = new System.Drawing.Size(215, 39);
            this.lblTask_Title.TabIndex = 8;
            this.lblTask_Title.Text = "Lorem Ipsum";
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Archived);
            this.Controls.Add(this.TaskProgress);
            this.Controls.Add(this.lblTask_Date);
            this.Controls.Add(this.lblTask_Title);
            this.Controls.Add(this.TasksPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(1147, 166);
            this.Load += new System.EventHandler(this.TaskCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel TasksPanel;
        public Bunifu.Framework.UI.BunifuCheckbox Archived;
        public Bunifu.UI.Winforms.BunifuProgressBar TaskProgress;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Date;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Title;
    }
}
