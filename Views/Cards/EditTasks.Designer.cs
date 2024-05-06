namespace WorkHive.Views.Admin
{
    partial class EditTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTasks));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.EditpictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eDIT3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.eDITBox2 = new System.Windows.Forms.PictureBox();
            this.lblEditTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEditTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EditTaskProgress = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.EditArchived = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EditpictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDIT3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDITBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // EditpictureBox1
            // 
            this.EditpictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditpictureBox1.Image = global::WorkHive.Properties.Resources.Tasks_Cards_P1;
            this.EditpictureBox1.Location = new System.Drawing.Point(0, 0);
            this.EditpictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditpictureBox1.Name = "EditpictureBox1";
            this.EditpictureBox1.Size = new System.Drawing.Size(88, 135);
            this.EditpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditpictureBox1.TabIndex = 15;
            this.EditpictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditpictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 135);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.eDIT3);
            this.panel2.Location = new System.Drawing.Point(118, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 33);
            this.panel2.TabIndex = 17;
            // 
            // eDIT3
            // 
            this.eDIT3.Image = global::WorkHive.Properties.Resources.Tasks_Cards_TOP;
            this.eDIT3.Location = new System.Drawing.Point(0, 0);
            this.eDIT3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eDIT3.Name = "eDIT3";
            this.eDIT3.Size = new System.Drawing.Size(396, 32);
            this.eDIT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eDIT3.TabIndex = 13;
            this.eDIT3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.EditFlatButton);
            this.panel3.Controls.Add(this.eDITBox2);
            this.panel3.Controls.Add(this.lblEditTask_Title);
            this.panel3.Controls.Add(this.lblEditTask_Date);
            this.panel3.Controls.Add(this.EditTaskProgress);
            this.panel3.Controls.Add(this.EditArchived);
            this.panel3.Location = new System.Drawing.Point(118, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 102);
            this.panel3.TabIndex = 18;
            // 
            // EditFlatButton
            // 
            this.EditFlatButton.Active = false;
            this.EditFlatButton.Activecolor = System.Drawing.Color.Transparent;
            this.EditFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.EditFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditFlatButton.BorderRadius = 0;
            this.EditFlatButton.ButtonText = "bunifuFlatButton1";
            this.EditFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.EditFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EditFlatButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("EditFlatButton.Iconimage")));
            this.EditFlatButton.Iconimage_right = null;
            this.EditFlatButton.Iconimage_right_Selected = null;
            this.EditFlatButton.Iconimage_Selected = null;
            this.EditFlatButton.IconMarginLeft = 0;
            this.EditFlatButton.IconMarginRight = 0;
            this.EditFlatButton.IconRightVisible = true;
            this.EditFlatButton.IconRightZoom = 0D;
            this.EditFlatButton.IconVisible = true;
            this.EditFlatButton.IconZoom = 75D;
            this.EditFlatButton.IsTab = false;
            this.EditFlatButton.Location = new System.Drawing.Point(694, 7);
            this.EditFlatButton.Name = "EditFlatButton";
            this.EditFlatButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EditFlatButton.OnHovercolor = System.Drawing.Color.Red;
            this.EditFlatButton.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.EditFlatButton.selected = false;
            this.EditFlatButton.Size = new System.Drawing.Size(42, 50);
            this.EditFlatButton.TabIndex = 14;
            this.EditFlatButton.Text = "bunifuFlatButton1";
            this.EditFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditFlatButton.Textcolor = System.Drawing.Color.White;
            this.EditFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // 
            // eDITBox2
            // 
            this.eDITBox2.Image = global::WorkHive.Properties.Resources.Tasks_Cards_P2;
            this.eDITBox2.Location = new System.Drawing.Point(668, 78);
            this.eDITBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eDITBox2.Name = "eDITBox2";
            this.eDITBox2.Size = new System.Drawing.Size(139, 29);
            this.eDITBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.eDITBox2.TabIndex = 12;
            this.eDITBox2.TabStop = false;
            // 
            // lblEditTask_Title
            // 
            this.lblEditTask_Title.AutoSize = true;
            this.lblEditTask_Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTask_Title.Location = new System.Drawing.Point(5, 7);
            this.lblEditTask_Title.Name = "lblEditTask_Title";
            this.lblEditTask_Title.Size = new System.Drawing.Size(148, 30);
            this.lblEditTask_Title.TabIndex = 8;
            this.lblEditTask_Title.Text = "Lorem Ipsum";
            // 
            // lblEditTask_Date
            // 
            this.lblEditTask_Date.AutoSize = true;
            this.lblEditTask_Date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTask_Date.Location = new System.Drawing.Point(8, 38);
            this.lblEditTask_Date.Name = "lblEditTask_Date";
            this.lblEditTask_Date.Size = new System.Drawing.Size(49, 19);
            this.lblEditTask_Date.TabIndex = 9;
            this.lblEditTask_Date.Text = "April 5";
            // 
            // EditTaskProgress
            // 
            this.EditTaskProgress.Animation = 0;
            this.EditTaskProgress.AnimationStep = 10;
            this.EditTaskProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditTaskProgress.BackgroundImage")));
            this.EditTaskProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.EditTaskProgress.BorderRadius = 5;
            this.EditTaskProgress.BorderThickness = 2;
            this.EditTaskProgress.Location = new System.Drawing.Point(8, 68);
            this.EditTaskProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditTaskProgress.MaximumValue = 100;
            this.EditTaskProgress.MinimumValue = 0;
            this.EditTaskProgress.Name = "EditTaskProgress";
            this.EditTaskProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.EditTaskProgress.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.EditTaskProgress.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.EditTaskProgress.Size = new System.Drawing.Size(611, 10);
            this.EditTaskProgress.TabIndex = 10;
            this.EditTaskProgress.Value = 0;
            // 
            // EditArchived
            // 
            this.EditArchived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.EditArchived.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.EditArchived.Checked = true;
            this.EditArchived.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.EditArchived.ForeColor = System.Drawing.Color.White;
            this.EditArchived.Location = new System.Drawing.Point(604, 22);
            this.EditArchived.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditArchived.Name = "EditArchived";
            this.EditArchived.Size = new System.Drawing.Size(20, 20);
            this.EditArchived.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(331, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 13);
            this.txtID.TabIndex = 15;
            this.txtID.Text = "label1";
            this.txtID.Visible = false;
            // 
            // EditTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditTasks";
            this.Size = new System.Drawing.Size(860, 135);
            ((System.ComponentModel.ISupportInitialize)(this.EditpictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eDIT3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDITBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox EditpictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox eDIT3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox eDITBox2;
        public Bunifu.Framework.UI.BunifuCustomLabel lblEditTask_Title;
        public Bunifu.Framework.UI.BunifuCustomLabel lblEditTask_Date;
        public Bunifu.UI.Winforms.BunifuProgressBar EditTaskProgress;
        public Bunifu.Framework.UI.BunifuCheckbox EditArchived;
        private Bunifu.Framework.UI.BunifuFlatButton EditFlatButton;
        private System.Windows.Forms.Label txtID;
    }
}
