namespace WorkHive.Views.Cards
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
            this.lblTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TaskProgress = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTask_Title
            // 
            this.lblTask_Title.AutoSize = true;
            this.lblTask_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Title.Location = new System.Drawing.Point(126, 47);
            this.lblTask_Title.Name = "lblTask_Title";
            this.lblTask_Title.Size = new System.Drawing.Size(171, 31);
            this.lblTask_Title.TabIndex = 0;
            this.lblTask_Title.Text = "Lorem Ipsum";
            // 
            // lblTask_Date
            // 
            this.lblTask_Date.AutoSize = true;
            this.lblTask_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Date.Location = new System.Drawing.Point(129, 78);
            this.lblTask_Date.Name = "lblTask_Date";
            this.lblTask_Date.Size = new System.Drawing.Size(44, 16);
            this.lblTask_Date.TabIndex = 1;
            this.lblTask_Date.Text = "April 5";
            // 
            // TaskProgress
            // 
            this.TaskProgress.Animation = 0;
            this.TaskProgress.AnimationStep = 10;
            this.TaskProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaskProgress.BackgroundImage")));
            this.TaskProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.BorderRadius = 5;
            this.TaskProgress.BorderThickness = 2;
            this.TaskProgress.Location = new System.Drawing.Point(132, 106);
            this.TaskProgress.MaximumValue = 100;
            this.TaskProgress.MinimumValue = 0;
            this.TaskProgress.Name = "TaskProgress";
            this.TaskProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.Size = new System.Drawing.Size(611, 10);
            this.TaskProgress.TabIndex = 2;
            this.TaskProgress.Value = 0;
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TaskProgress);
            this.Controls.Add(this.lblTask_Date);
            this.Controls.Add(this.lblTask_Title);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(860, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Date;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Title;
        public Bunifu.UI.Winforms.BunifuProgressBar TaskProgress;
    }
}
