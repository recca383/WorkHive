namespace WorkHive.Views.Member.DashboardPagesMember
{
    partial class TaskViewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskViewMember));
            this.TasksFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.TasksName = new System.Windows.Forms.Label();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.RefreshButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.AddTaskPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.StatusFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksFlow
            // 
            this.TasksFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TasksFlow.Location = new System.Drawing.Point(27, 72);
            this.TasksFlow.Name = "TasksFlow";
            this.TasksFlow.Size = new System.Drawing.Size(886, 513);
            this.TasksFlow.TabIndex = 10;
            this.TasksFlow.WrapContents = false;
            // 
            // TasksName
            // 
            this.TasksName.AutoSize = true;
            this.TasksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksName.Location = new System.Drawing.Point(11, 11);
            this.TasksName.Name = "TasksName";
            this.TasksName.Size = new System.Drawing.Size(116, 39);
            this.TasksName.TabIndex = 9;
            this.TasksName.Text = "Tasks";
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
            this.bunifuVScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.TasksFlow;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(914, 72);
            this.bunifuVScrollBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.bunifuVScrollBar1.TabIndex = 15;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 50;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AllowFocused = false;
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BorderRadius = 0;
            this.RefreshButton.Image = global::WorkHive.Properties.Resources.refresh;
            this.RefreshButton.IsCircle = false;
            this.RefreshButton.Location = new System.Drawing.Point(885, 29);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 26);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 20;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // AddTaskPanel
            // 
            this.AddTaskPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.ForeColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.Location = new System.Drawing.Point(290, 8);
            this.AddTaskPanel.Name = "AddTaskPanel";
            this.AddTaskPanel.Size = new System.Drawing.Size(29, 36);
            this.AddTaskPanel.TabIndex = 26;
            this.AddTaskPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.AddTaskPanel_ControlRemoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Status : ";
            // 
            // ProjectFilter
            // 
            this.ProjectFilter.BackColor = System.Drawing.SystemColors.Control;
            this.ProjectFilter.BorderRadius = 1;
            this.ProjectFilter.Color = System.Drawing.Color.Gold;
            this.ProjectFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ProjectFilter.DisabledColor = System.Drawing.Color.Gray;
            this.ProjectFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjectFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ProjectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ProjectFilter.FillDropDown = false;
            this.ProjectFilter.FillIndicator = false;
            this.ProjectFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProjectFilter.FormattingEnabled = true;
            this.ProjectFilter.Icon = null;
            this.ProjectFilter.IndicatorColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProjectFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ProjectFilter.ItemBackColor = System.Drawing.Color.White;
            this.ProjectFilter.ItemBorderColor = System.Drawing.Color.White;
            this.ProjectFilter.ItemForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProjectFilter.ItemHeight = 26;
            this.ProjectFilter.ItemHighLightColor = System.Drawing.Color.Gold;
            this.ProjectFilter.Location = new System.Drawing.Point(290, 29);
            this.ProjectFilter.Name = "ProjectFilter";
            this.ProjectFilter.Size = new System.Drawing.Size(217, 32);
            this.ProjectFilter.TabIndex = 24;
            this.ProjectFilter.Text = null;
            // 
            // StatusFilter
            // 
            this.StatusFilter.BackColor = System.Drawing.SystemColors.Control;
            this.StatusFilter.BorderRadius = 1;
            this.StatusFilter.Color = System.Drawing.Color.Gold;
            this.StatusFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.StatusFilter.DisabledColor = System.Drawing.Color.Gray;
            this.StatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.StatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.StatusFilter.FillDropDown = false;
            this.StatusFilter.FillIndicator = false;
            this.StatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusFilter.FormattingEnabled = true;
            this.StatusFilter.Icon = null;
            this.StatusFilter.IndicatorColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.StatusFilter.ItemBackColor = System.Drawing.Color.White;
            this.StatusFilter.ItemBorderColor = System.Drawing.Color.White;
            this.StatusFilter.ItemForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusFilter.ItemHeight = 26;
            this.StatusFilter.ItemHighLightColor = System.Drawing.Color.Gold;
            this.StatusFilter.Location = new System.Drawing.Point(586, 29);
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(217, 32);
            this.StatusFilter.TabIndex = 25;
            this.StatusFilter.Text = null;
            this.StatusFilter.SelectedIndexChanged += new System.EventHandler(this.StatusFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Project Name : ";
            // 
            // TaskViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddTaskPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectFilter);
            this.Controls.Add(this.StatusFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.TasksFlow);
            this.Controls.Add(this.TasksName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskViewMember";
            this.Size = new System.Drawing.Size(932, 585);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel TasksFlow;
        private System.Windows.Forms.Label TasksName;
        private Bunifu.UI.WinForms.BunifuPictureBox RefreshButton;
        private System.Windows.Forms.Panel AddTaskPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown ProjectFilter;
        private Bunifu.UI.WinForms.BunifuDropdown StatusFilter;
        private System.Windows.Forms.Label label2;
    }
}
