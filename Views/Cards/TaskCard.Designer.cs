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
            this.pictureboxFinished = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMarkAsDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TaskId = new System.Windows.Forms.Label();
            this.EditFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.Deadlinetxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTask_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask_Date = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFinished)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureboxFinished);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 166);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.pictureBox1.Image = global::WorkHive.Properties.Resources.Tasks___PENDING_SOLO;
            this.pictureBox1.Location = new System.Drawing.Point(29, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.pictureboxFinished.TabIndex = 12;
            this.pictureboxFinished.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnMarkAsDone);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(117, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 41);
            this.panel2.TabIndex = 5;
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.Active = false;
            this.btnMarkAsDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnMarkAsDone.BackColor = System.Drawing.Color.White;
            this.btnMarkAsDone.BackgroundImage = global::WorkHive.Properties.Resources.Button___Project;
            this.btnMarkAsDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarkAsDone.BorderRadius = 0;
            this.btnMarkAsDone.ButtonText = "Mark As Done";
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
            this.btnMarkAsDone.TabIndex = 19;
            this.btnMarkAsDone.Text = "Mark As Done";
            this.btnMarkAsDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMarkAsDone.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnMarkAsDone.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDetails.TabIndex = 18;
            this.btnDetails.Text = "Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDetails.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.TaskId);
            this.panel3.Controls.Add(this.EditFlatButton);
            this.panel3.Controls.Add(this.lblProjectName);
            this.panel3.Controls.Add(this.Deadlinetxt);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblTask_Title);
            this.panel3.Controls.Add(this.lblTask_Date);
            this.panel3.Location = new System.Drawing.Point(117, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 126);
            this.panel3.TabIndex = 13;
            // 
            // TaskId
            // 
            this.TaskId.AutoSize = true;
            this.TaskId.Location = new System.Drawing.Point(479, 101);
            this.TaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskId.Name = "TaskId";
            this.TaskId.Size = new System.Drawing.Size(49, 16);
            this.TaskId.TabIndex = 17;
            this.TaskId.Text = "TaskId";
            this.TaskId.Visible = false;
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
            this.EditFlatButton.Location = new System.Drawing.Point(965, 24);
            this.EditFlatButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditFlatButton.Name = "EditFlatButton";
            this.EditFlatButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EditFlatButton.OnHovercolor = System.Drawing.Color.Red;
            this.EditFlatButton.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.EditFlatButton.selected = false;
            this.EditFlatButton.Size = new System.Drawing.Size(49, 51);
            this.EditFlatButton.TabIndex = 16;
            this.EditFlatButton.Text = "bunifuFlatButton1";
            this.EditFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditFlatButton.Textcolor = System.Drawing.Color.White;
            this.EditFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFlatButton.Visible = false;
            this.EditFlatButton.Click += new System.EventHandler(this.EditFlatButton_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(9, 47);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(125, 28);
            this.lblProjectName.TabIndex = 14;
            this.lblProjectName.Text = "ProjectName";
            // 
            // Deadlinetxt
            // 
            this.Deadlinetxt.AutoSize = true;
            this.Deadlinetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deadlinetxt.Location = new System.Drawing.Point(788, 96);
            this.Deadlinetxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deadlinetxt.Name = "Deadlinetxt";
            this.Deadlinetxt.Size = new System.Drawing.Size(59, 23);
            this.Deadlinetxt.TabIndex = 13;
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
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblTask_Title
            // 
            this.lblTask_Title.AutoSize = true;
            this.lblTask_Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Title.Location = new System.Drawing.Point(7, 9);
            this.lblTask_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Title.Name = "lblTask_Title";
            this.lblTask_Title.Size = new System.Drawing.Size(189, 38);
            this.lblTask_Title.TabIndex = 8;
            this.lblTask_Title.Text = "Lorem Ipsum";
            // 
            // lblTask_Date
            // 
            this.lblTask_Date.AutoSize = true;
            this.lblTask_Date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask_Date.Location = new System.Drawing.Point(10, 96);
            this.lblTask_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask_Date.Name = "lblTask_Date";
            this.lblTask_Date.Size = new System.Drawing.Size(59, 23);
            this.lblTask_Date.TabIndex = 9;
            this.lblTask_Date.Text = "April 5";
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(1147, 166);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFinished)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureboxFinished;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTask_Title;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTask_Date;
        private Bunifu.Framework.UI.BunifuCustomLabel Deadlinetxt;
        private System.Windows.Forms.Label lblProjectName;
        private Bunifu.Framework.UI.BunifuFlatButton EditFlatButton;
        private System.Windows.Forms.Label TaskId;
        private Bunifu.Framework.UI.BunifuFlatButton btnMarkAsDone;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
