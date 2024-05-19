namespace WorkHive.Views.Cards
{
    partial class ProjectCard
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
            this.lblProject_Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSummary = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProjectId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProject_Title
            // 
            this.lblProject_Title.AutoSize = true;
            this.lblProject_Title.BackColor = System.Drawing.Color.Transparent;
            this.lblProject_Title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject_Title.ForeColor = System.Drawing.Color.White;
            this.lblProject_Title.Location = new System.Drawing.Point(11, 15);
            this.lblProject_Title.Name = "lblProject_Title";
            this.lblProject_Title.Size = new System.Drawing.Size(148, 30);
            this.lblProject_Title.TabIndex = 10;
            this.lblProject_Title.Text = "Lorem Ipsum";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 19);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Sir Johnny Sins";
            // 
            // btnSummary
            // 
            this.btnSummary.Active = false;
            this.btnSummary.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSummary.BackColor = System.Drawing.Color.White;
            this.btnSummary.BackgroundImage = global::WorkHive.Properties.Resources.Button___Project;
            this.btnSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSummary.BorderRadius = 0;
            this.btnSummary.ButtonText = "Summary";
            this.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummary.DisabledColor = System.Drawing.Color.Gray;
            this.btnSummary.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSummary.Iconimage = null;
            this.btnSummary.Iconimage_right = null;
            this.btnSummary.Iconimage_right_Selected = null;
            this.btnSummary.Iconimage_Selected = null;
            this.btnSummary.IconMarginLeft = 0;
            this.btnSummary.IconMarginRight = 0;
            this.btnSummary.IconRightVisible = true;
            this.btnSummary.IconRightZoom = 0D;
            this.btnSummary.IconVisible = true;
            this.btnSummary.IconZoom = 90D;
            this.btnSummary.IsTab = false;
            this.btnSummary.Location = new System.Drawing.Point(464, 53);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Normalcolor = System.Drawing.Color.White;
            this.btnSummary.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSummary.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSummary.selected = false;
            this.btnSummary.Size = new System.Drawing.Size(170, 28);
            this.btnSummary.TabIndex = 12;
            this.btnSummary.Text = "Summary";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSummary.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSummary.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Active = false;
            this.btnTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTasks.BackColor = System.Drawing.Color.White;
            this.btnTasks.BackgroundImage = global::WorkHive.Properties.Resources.Button___Project;
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.BorderRadius = 0;
            this.btnTasks.ButtonText = "Tasks";
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.DisabledColor = System.Drawing.Color.Gray;
            this.btnTasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTasks.Iconimage = null;
            this.btnTasks.Iconimage_right = null;
            this.btnTasks.Iconimage_right_Selected = null;
            this.btnTasks.Iconimage_Selected = null;
            this.btnTasks.IconMarginLeft = 0;
            this.btnTasks.IconMarginRight = 0;
            this.btnTasks.IconRightVisible = true;
            this.btnTasks.IconRightZoom = 0D;
            this.btnTasks.IconVisible = true;
            this.btnTasks.IconZoom = 90D;
            this.btnTasks.IsTab = false;
            this.btnTasks.Location = new System.Drawing.Point(659, 53);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Normalcolor = System.Drawing.Color.White;
            this.btnTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTasks.selected = false;
            this.btnTasks.Size = new System.Drawing.Size(170, 28);
            this.btnTasks.TabIndex = 13;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTasks.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTasks.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ProjectId
            // 
            this.ProjectId.AutoSize = true;
            this.ProjectId.Location = new System.Drawing.Point(331, 68);
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.Size = new System.Drawing.Size(35, 13);
            this.ProjectId.TabIndex = 14;
            this.ProjectId.Text = "label1";
            this.ProjectId.Visible = false;
            // 
            // ProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WorkHive.Properties.Resources.ProjectBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ProjectId);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblProject_Title);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProjectCard";
            this.Size = new System.Drawing.Size(852, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblProject_Title;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSummary;
        private Bunifu.Framework.UI.BunifuFlatButton btnTasks;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label ProjectId;
    }
}
