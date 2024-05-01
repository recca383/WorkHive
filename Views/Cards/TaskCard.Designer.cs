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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TaskProgress = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.Archived = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Deadlinetxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 135);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.Tasks_Cards_P1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(88, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 33);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorkHive.Properties.Resources.Tasks_Cards_TOP;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Deadlinetxt);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblTask_Title);
            this.panel3.Controls.Add(this.lblTask_Date);
            this.panel3.Controls.Add(this.TaskProgress);
            this.panel3.Controls.Add(this.Archived);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(88, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 102);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WorkHive.Properties.Resources.Tasks_Cards_P2;
            this.pictureBox3.Location = new System.Drawing.Point(668, 78);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblTask_Title
            // 
            this.lblTask_Title.AutoSize = true;
            this.lblTask_Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Title.Location = new System.Drawing.Point(5, 7);
            this.lblTask_Title.Name = "lblTask_Title";
            this.lblTask_Title.Size = new System.Drawing.Size(148, 30);
            this.lblTask_Title.TabIndex = 8;
            this.lblTask_Title.Text = "Lorem Ipsum";
            // 
            // lblTask_Date
            // 
            this.lblTask_Date.AutoSize = true;
            this.lblTask_Date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Date.Location = new System.Drawing.Point(8, 38);
            this.lblTask_Date.Name = "lblTask_Date";
            this.lblTask_Date.Size = new System.Drawing.Size(49, 19);
            this.lblTask_Date.TabIndex = 9;
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
            this.TaskProgress.Location = new System.Drawing.Point(8, 68);
            this.TaskProgress.Margin = new System.Windows.Forms.Padding(4);
            this.TaskProgress.MaximumValue = 100;
            this.TaskProgress.MinimumValue = 0;
            this.TaskProgress.Name = "TaskProgress";
            this.TaskProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.TaskProgress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TaskProgress.Size = new System.Drawing.Size(611, 10);
            this.TaskProgress.TabIndex = 10;
            this.TaskProgress.Value = 0;
            // 
            // Archived
            // 
            this.Archived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Archived.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Archived.Checked = true;
            this.Archived.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Archived.ForeColor = System.Drawing.Color.White;
            this.Archived.Location = new System.Drawing.Point(604, 22);
            this.Archived.Margin = new System.Windows.Forms.Padding(4);
            this.Archived.Name = "Archived";
            this.Archived.Size = new System.Drawing.Size(20, 20);
            this.Archived.TabIndex = 11;
            // 
            // Deadlinetxt
            // 
            this.Deadlinetxt.AutoSize = true;
            this.Deadlinetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadlinetxt.Location = new System.Drawing.Point(720, 2);
            this.Deadlinetxt.Name = "Deadlinetxt";
            this.Deadlinetxt.Size = new System.Drawing.Size(49, 19);
            this.Deadlinetxt.TabIndex = 13;
            this.Deadlinetxt.Text = "April 5";
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(860, 135);
            this.Load += new System.EventHandler(this.TaskCard_Load);
            this.Click += new System.EventHandler(this.TaskCard_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Title;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTask_Date;
        public Bunifu.UI.Winforms.BunifuProgressBar TaskProgress;
        public Bunifu.Framework.UI.BunifuCheckbox Archived;
        public Bunifu.Framework.UI.BunifuCustomLabel Deadlinetxt;
    }
}
