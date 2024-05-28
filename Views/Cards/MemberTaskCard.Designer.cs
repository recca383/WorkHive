namespace WorkHive.Views.Cards
{
    partial class MemberTaskCard
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureboxFinished = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMarkAsDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TaskId = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.Deadlinetxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFinished)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureboxFinished);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 166);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(117, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 114);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.Tasks___PENDING_SOLO;
            this.pictureBox1.Location = new System.Drawing.Point(32, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureboxFinished
            // 
            this.pictureboxFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxFinished.Image = global::WorkHive.Properties.Resources.Tasks___BG;
            this.pictureboxFinished.Location = new System.Drawing.Point(0, 0);
            this.pictureboxFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureboxFinished.Name = "pictureboxFinished";
            this.pictureboxFinished.Size = new System.Drawing.Size(117, 166);
            this.pictureboxFinished.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxFinished.TabIndex = 14;
            this.pictureboxFinished.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnMarkAsDone);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(117, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 41);
            this.panel2.TabIndex = 1;
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.Active = false;
            this.btnMarkAsDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnMarkAsDone.BackColor = System.Drawing.Color.White;
            this.btnMarkAsDone.BackgroundImage = global::WorkHive.Properties.Resources.Button___Project;
            this.btnMarkAsDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarkAsDone.BorderRadius = 0;
            this.btnMarkAsDone.ButtonText = "Edit Status";
            this.btnMarkAsDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAsDone.DisabledColor = System.Drawing.Color.Gray;
            this.btnMarkAsDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMarkAsDone.Iconimage = null;
            this.btnMarkAsDone.Iconimage_right = null;
            this.btnMarkAsDone.Iconimage_right_Selected = null;
            this.btnMarkAsDone.Iconimage_Selected = null;
            this.btnMarkAsDone.IconMarginLeft = 0;
            this.btnMarkAsDone.IconMarginRight = 0;
            this.btnMarkAsDone.IconRightVisible = true;
            this.btnMarkAsDone.IconRightZoom = 0D;
            this.btnMarkAsDone.IconVisible = true;
            this.btnMarkAsDone.IconZoom = 90D;
            this.btnMarkAsDone.IsTab = false;
            this.btnMarkAsDone.Location = new System.Drawing.Point(780, 5);
            this.btnMarkAsDone.Margin = new System.Windows.Forms.Padding(5);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Normalcolor = System.Drawing.Color.White;
            this.btnMarkAsDone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnMarkAsDone.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMarkAsDone.selected = false;
            this.btnMarkAsDone.Size = new System.Drawing.Size(195, 33);
            this.btnMarkAsDone.TabIndex = 22;
            this.btnMarkAsDone.Text = "Edit Status";
            this.btnMarkAsDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMarkAsDone.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnMarkAsDone.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Active = false;
            this.btnDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.BackgroundImage = global::WorkHive.Properties.Resources.Button___Project;
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.BorderRadius = 0;
            this.btnDetails.ButtonText = "Details";
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetails.Iconimage = null;
            this.btnDetails.Iconimage_right = null;
            this.btnDetails.Iconimage_right_Selected = null;
            this.btnDetails.Iconimage_Selected = null;
            this.btnDetails.IconMarginLeft = 0;
            this.btnDetails.IconMarginRight = 0;
            this.btnDetails.IconRightVisible = true;
            this.btnDetails.IconRightZoom = 0D;
            this.btnDetails.IconVisible = true;
            this.btnDetails.IconZoom = 90D;
            this.btnDetails.IsTab = false;
            this.btnDetails.Location = new System.Drawing.Point(532, 5);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Normalcolor = System.Drawing.Color.White;
            this.btnDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetails.selected = false;
            this.btnDetails.Size = new System.Drawing.Size(195, 33);
            this.btnDetails.TabIndex = 21;
            this.btnDetails.Text = "Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDetails.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::WorkHive.Properties.Resources.Tasks_Cards_TOP;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(528, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblTask_Title
            // 
            this.lblTask_Title.AutoSize = true;
            this.lblTask_Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Title.Location = new System.Drawing.Point(7, 9);
            this.lblTask_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Title.Name = "lblTask_Title";
            this.lblTask_Title.Size = new System.Drawing.Size(189, 38);
            this.lblTask_Title.TabIndex = 9;
            this.lblTask_Title.Text = "Lorem Ipsum";
            // 
            // TaskId
            // 
            this.TaskId.AutoSize = true;
            this.TaskId.Location = new System.Drawing.Point(479, 101);
            this.TaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskId.Name = "TaskId";
            this.TaskId.Size = new System.Drawing.Size(49, 16);
            this.TaskId.TabIndex = 23;
            this.TaskId.Text = "TaskId";
            this.TaskId.Visible = false;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(9, 47);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(125, 28);
            this.lblProjectName.TabIndex = 21;
            this.lblProjectName.Text = "ProjectName";
            // 
            // Deadlinetxt
            // 
            this.Deadlinetxt.AutoSize = true;
            this.Deadlinetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadlinetxt.Location = new System.Drawing.Point(787, 84);
            this.Deadlinetxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deadlinetxt.Name = "Deadlinetxt";
            this.Deadlinetxt.Size = new System.Drawing.Size(65, 23);
            this.Deadlinetxt.TabIndex = 20;
            this.Deadlinetxt.Text = "April 5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WorkHive.Properties.Resources.Tasks_Cards_P2;
            this.pictureBox3.Location = new System.Drawing.Point(891, 96);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // lblTask_Date
            // 
            this.lblTask_Date.AutoSize = true;
            this.lblTask_Date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Date.Location = new System.Drawing.Point(10, 84);
            this.lblTask_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Date.Name = "lblTask_Date";
            this.lblTask_Date.Size = new System.Drawing.Size(65, 23);
            this.lblTask_Date.TabIndex = 18;
            this.lblTask_Date.Text = "April 5";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblTask_Title);
            this.panel4.Controls.Add(this.TaskId);
            this.panel4.Controls.Add(this.lblTask_Date);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblProjectName);
            this.panel4.Controls.Add(this.Deadlinetxt);
            this.panel4.Location = new System.Drawing.Point(117, 41);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 126);
            this.panel4.TabIndex = 24;
            // 
            // MemberTaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WorkHive.Properties.Resources.Card___Tasks2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MemberTaskCard";
            this.Size = new System.Drawing.Size(1147, 166);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFinished)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMarkAsDone;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetails;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureboxFinished;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTask_Title;
        private System.Windows.Forms.Label TaskId;
        private System.Windows.Forms.Label lblProjectName;
        private Bunifu.Framework.UI.BunifuCustomLabel Deadlinetxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTask_Date;
        private System.Windows.Forms.Panel panel4;
    }
}
