namespace WorkHive.Views.Admin.DashboardPages
{
    partial class Edit_TaskView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_TaskView));
            this.EditTasksFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditArchived = new System.Windows.Forms.Label();
            this.EditTask = new System.Windows.Forms.Label();
            this.btnEditCompleted = new System.Windows.Forms.Label();
            this.btnEditOngoing = new System.Windows.Forms.Label();
            this.btnEditAll = new System.Windows.Forms.Label();
            this.AddTaskPanel = new System.Windows.Forms.Panel();
            this.btnAddtasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EditScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.SuspendLayout();
            // 
            // EditTasksFlow
            // 
            this.EditTasksFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTasksFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EditTasksFlow.Location = new System.Drawing.Point(36, 86);
            this.EditTasksFlow.Margin = new System.Windows.Forms.Padding(4);
            this.EditTasksFlow.Name = "EditTasksFlow";
            this.EditTasksFlow.Size = new System.Drawing.Size(1181, 631);
            this.EditTasksFlow.TabIndex = 10;
            this.EditTasksFlow.WrapContents = false;
            // 
            // btnEditArchived
            // 
            this.btnEditArchived.AutoSize = true;
            this.btnEditArchived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditArchived.Location = new System.Drawing.Point(792, 33);
            this.btnEditArchived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEditArchived.Name = "btnEditArchived";
            this.btnEditArchived.Size = new System.Drawing.Size(97, 25);
            this.btnEditArchived.TabIndex = 14;
            this.btnEditArchived.Text = "Archived";
            this.btnEditArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // EditTask
            // 
            this.EditTask.AutoSize = true;
            this.EditTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTask.Location = new System.Drawing.Point(15, 11);
            this.EditTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(234, 51);
            this.EditTask.TabIndex = 9;
            this.EditTask.Text = "Edit Tasks";
            // 
            // btnEditCompleted
            // 
            this.btnEditCompleted.AutoSize = true;
            this.btnEditCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompleted.Location = new System.Drawing.Point(609, 33);
            this.btnEditCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEditCompleted.Name = "btnEditCompleted";
            this.btnEditCompleted.Size = new System.Drawing.Size(116, 25);
            this.btnEditCompleted.TabIndex = 13;
            this.btnEditCompleted.Text = "Completed";
            this.btnEditCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnEditOngoing
            // 
            this.btnEditOngoing.AutoSize = true;
            this.btnEditOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOngoing.Location = new System.Drawing.Point(448, 33);
            this.btnEditOngoing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEditOngoing.Name = "btnEditOngoing";
            this.btnEditOngoing.Size = new System.Drawing.Size(94, 25);
            this.btnEditOngoing.TabIndex = 12;
            this.btnEditOngoing.Text = "Ongoing";
            this.btnEditOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnEditAll
            // 
            this.btnEditAll.AutoSize = true;
            this.btnEditAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAll.Location = new System.Drawing.Point(349, 33);
            this.btnEditAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEditAll.Name = "btnEditAll";
            this.btnEditAll.Size = new System.Drawing.Size(37, 25);
            this.btnEditAll.TabIndex = 11;
            this.btnEditAll.Text = "All";
            this.btnEditAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // AddTaskPanel
            // 
            this.AddTaskPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.ForeColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.Location = new System.Drawing.Point(309, 33);
            this.AddTaskPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddTaskPanel.Name = "AddTaskPanel";
            this.AddTaskPanel.Size = new System.Drawing.Size(0, 0);
            this.AddTaskPanel.TabIndex = 17;
            this.AddTaskPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.AddTaskPanel_ControlAdded);
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
            this.btnAddtasks.IconZoom = 100D;
            this.btnAddtasks.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnAddtasks.IsTab = false;
            this.btnAddtasks.Location = new System.Drawing.Point(1165, 19);
            this.btnAddtasks.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddtasks.Name = "btnAddtasks";
            this.btnAddtasks.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddtasks.selected = false;
            this.btnAddtasks.Size = new System.Drawing.Size(52, 52);
            this.btnAddtasks.TabIndex = 16;
            this.btnAddtasks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddtasks.Textcolor = System.Drawing.Color.White;
            this.btnAddtasks.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtasks.Click += new System.EventHandler(this.btnAddtasks_Click);
            // 
            // EditScrollBar1
            // 
            this.EditScrollBar1.AllowCursorChanges = true;
            this.EditScrollBar1.AllowHomeEndKeysDetection = false;
            this.EditScrollBar1.AllowIncrementalClickMoves = true;
            this.EditScrollBar1.AllowMouseDownEffects = true;
            this.EditScrollBar1.AllowMouseHoverEffects = true;
            this.EditScrollBar1.AllowScrollingAnimations = true;
            this.EditScrollBar1.AllowScrollKeysDetection = true;
            this.EditScrollBar1.AllowScrollOptionsMenu = true;
            this.EditScrollBar1.AllowShrinkingOnFocusLost = false;
            this.EditScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
            this.EditScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditScrollBar1.BackgroundImage")));
            this.EditScrollBar1.BindingContainer = this.EditTasksFlow;
            this.EditScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.EditScrollBar1.BorderRadius = 14;
            this.EditScrollBar1.BorderThickness = 1;
            this.EditScrollBar1.DurationBeforeShrink = 2000;
            this.EditScrollBar1.LargeChange = 10;
            this.EditScrollBar1.Location = new System.Drawing.Point(1219, 86);
            this.EditScrollBar1.Margin = new System.Windows.Forms.Padding(5);
            this.EditScrollBar1.Maximum = 100;
            this.EditScrollBar1.Minimum = 0;
            this.EditScrollBar1.MinimumThumbLength = 18;
            this.EditScrollBar1.Name = "EditScrollBar1";
            this.EditScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.EditScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.EditScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.EditScrollBar1.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.EditScrollBar1.ScrollBarColor = System.Drawing.Color.Silver;
            this.EditScrollBar1.ShrinkSizeLimit = 3;
            this.EditScrollBar1.Size = new System.Drawing.Size(24, 626);
            this.EditScrollBar1.SmallChange = 1;
            this.EditScrollBar1.TabIndex = 15;
            this.EditScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.EditScrollBar1.ThumbLength = 61;
            this.EditScrollBar1.ThumbMargin = 1;
            this.EditScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.EditScrollBar1.Value = 0;
            // 
            // Edit_TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddTaskPanel);
            this.Controls.Add(this.btnAddtasks);
            this.Controls.Add(this.EditScrollBar1);
            this.Controls.Add(this.btnEditArchived);
            this.Controls.Add(this.btnEditCompleted);
            this.Controls.Add(this.btnEditOngoing);
            this.Controls.Add(this.btnEditAll);
            this.Controls.Add(this.EditTasksFlow);
            this.Controls.Add(this.EditTask);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit_TaskView";
            this.Size = new System.Drawing.Size(1243, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuVScrollBar EditScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel EditTasksFlow;
        private System.Windows.Forms.Label btnEditArchived;
        private System.Windows.Forms.Label EditTask;
        private System.Windows.Forms.Label btnEditCompleted;
        private System.Windows.Forms.Label btnEditOngoing;
        private System.Windows.Forms.Label btnEditAll;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddtasks;
        private System.Windows.Forms.Panel AddTaskPanel;
    }
}
