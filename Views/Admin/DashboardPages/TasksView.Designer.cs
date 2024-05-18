namespace WorkHive.Views.Admin.DashboardPages
{
    partial class TasksView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksView));
            this.TasksName = new System.Windows.Forms.Label();
            this.TasksFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Label();
            this.btnOngoing = new System.Windows.Forms.Label();
            this.btnCompleted = new System.Windows.Forms.Label();
            this.btnArchived = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.AddTaskPanel = new System.Windows.Forms.Panel();
            this.btnAddtasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.RefreshButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksName
            // 
            this.TasksName.AutoSize = true;
            this.TasksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksName.Location = new System.Drawing.Point(11, 9);
            this.TasksName.Name = "TasksName";
            this.TasksName.Size = new System.Drawing.Size(116, 39);
            this.TasksName.TabIndex = 2;
            this.TasksName.Text = "Tasks";
            // 
            // TasksFlow
            // 
            this.TasksFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TasksFlow.Location = new System.Drawing.Point(27, 70);
            this.TasksFlow.Name = "TasksFlow";
            this.TasksFlow.Size = new System.Drawing.Size(886, 513);
            this.TasksFlow.TabIndex = 3;
            this.TasksFlow.WrapContents = false;
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(262, 27);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(29, 20);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnOngoing
            // 
            this.btnOngoing.AutoSize = true;
            this.btnOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(336, 27);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(76, 20);
            this.btnOngoing.TabIndex = 5;
            this.btnOngoing.Text = "Ongoing";
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.AutoSize = true;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(457, 27);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(95, 20);
            this.btnCompleted.TabIndex = 6;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnArchived
            // 
            this.btnArchived.AutoSize = true;
            this.btnArchived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.Location = new System.Drawing.Point(594, 27);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(78, 20);
            this.btnArchived.TabIndex = 7;
            this.btnArchived.Text = "Archived";
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // AddTaskPanel
            // 
            this.AddTaskPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.ForeColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.Location = new System.Drawing.Point(240, 27);
            this.AddTaskPanel.Name = "AddTaskPanel";
            this.AddTaskPanel.Size = new System.Drawing.Size(119, 122);
            this.AddTaskPanel.TabIndex = 18;
            this.AddTaskPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.AddTaskPanel_ControlRemoved);
            // 
            // btnAddtasks
            // 
            this.btnAddtasks.Active = false;
            this.btnAddtasks.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.BackColor = System.Drawing.Color.Transparent;
            this.btnAddtasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddtasks.BorderRadius = 0;
            this.btnAddtasks.ButtonText = "";
            this.btnAddtasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddtasks.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddtasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.Iconimage = null;
            this.btnAddtasks.Iconimage_right = global::WorkHive.Properties.Resources.Vector__3_;
            this.btnAddtasks.Iconimage_right_Selected = null;
            this.btnAddtasks.Iconimage_Selected = null;
            this.btnAddtasks.IconMarginLeft = 0;
            this.btnAddtasks.IconMarginRight = 0;
            this.btnAddtasks.IconRightVisible = true;
            this.btnAddtasks.IconRightZoom = 0D;
            this.btnAddtasks.IconVisible = true;
            this.btnAddtasks.IconZoom = 60D;
            this.btnAddtasks.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnAddtasks.IsTab = false;
            this.btnAddtasks.Location = new System.Drawing.Point(877, 24);
            this.btnAddtasks.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddtasks.Name = "btnAddtasks";
            this.btnAddtasks.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddtasks.selected = false;
            this.btnAddtasks.Size = new System.Drawing.Size(26, 28);
            this.btnAddtasks.TabIndex = 17;
            this.btnAddtasks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtasks.Textcolor = System.Drawing.Color.White;
            this.btnAddtasks.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtasks.Click += new System.EventHandler(this.btnAddtasks_Click);
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.TasksFlow;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(914, 70);
            this.bunifuVScrollBar1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(18, 509);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 8;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 50;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AllowFocused = false;
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BorderRadius = 0;
            this.RefreshButton.Image = global::WorkHive.Properties.Resources.refresh;
            this.RefreshButton.IsCircle = false;
            this.RefreshButton.Location = new System.Drawing.Point(833, 24);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 26);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.RefreshButton.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddTaskPanel);
            this.Controls.Add(this.btnAddtasks);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.btnArchived);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnOngoing);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.TasksFlow);
            this.Controls.Add(this.TasksName);
            this.Name = "TasksView";
            this.Size = new System.Drawing.Size(932, 585);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TasksName;
        private System.Windows.Forms.FlowLayoutPanel TasksFlow;
        private System.Windows.Forms.Label btnAll;
        private System.Windows.Forms.Label btnOngoing;
        private System.Windows.Forms.Label btnCompleted;
        private System.Windows.Forms.Label btnArchived;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddtasks;
        private System.Windows.Forms.Panel AddTaskPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox RefreshButton;
    }
}
