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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.AddTaskPanel = new System.Windows.Forms.Panel();
            this.btnAddtasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.RefreshButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.StatusFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ProjectFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksName
            // 
            this.TasksName.AutoSize = true;
            this.TasksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksName.Location = new System.Drawing.Point(15, 14);
            this.TasksName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TasksName.Name = "TasksName";
            this.TasksName.Size = new System.Drawing.Size(143, 51);
            this.TasksName.TabIndex = 2;
            this.TasksName.Text = "Tasks";
            // 
            // TasksFlow
            // 
            this.TasksFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TasksFlow.Location = new System.Drawing.Point(47, 86);
            this.TasksFlow.Margin = new System.Windows.Forms.Padding(4);
            this.TasksFlow.Name = "TasksFlow";
            this.TasksFlow.Size = new System.Drawing.Size(1157, 631);
            this.TasksFlow.TabIndex = 3;
            this.TasksFlow.WrapContents = false;
            // 
            // AddTaskPanel
            // 
            this.AddTaskPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.ForeColor = System.Drawing.Color.Transparent;
            this.AddTaskPanel.Location = new System.Drawing.Point(394, 4);
            this.AddTaskPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddTaskPanel.Name = "AddTaskPanel";
            this.AddTaskPanel.Size = new System.Drawing.Size(39, 44);
            this.AddTaskPanel.TabIndex = 18;
            this.AddTaskPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.AddTaskPanel_ControlRemoved);
            // 
            // btnAddtasks
            // 
            this.btnAddtasks.Active = false;
            this.btnAddtasks.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAddtasks.Location = new System.Drawing.Point(1169, 30);
            this.btnAddtasks.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddtasks.Name = "btnAddtasks";
            this.btnAddtasks.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddtasks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddtasks.selected = false;
            this.btnAddtasks.Size = new System.Drawing.Size(35, 34);
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
            this.bunifuVScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.TasksFlow;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1219, 86);
            this.bunifuVScrollBar1.Margin = new System.Windows.Forms.Padding(5);
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
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(24, 626);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 8;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 61;
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
            this.RefreshButton.Location = new System.Drawing.Point(1111, 30);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(37, 32);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.RefreshButton.Click += new System.EventHandler(this.btnAll_Click);
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
            this.StatusFilter.Location = new System.Drawing.Point(788, 30);
            this.StatusFilter.Margin = new System.Windows.Forms.Padding(4);
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(288, 32);
            this.StatusFilter.TabIndex = 20;
            this.StatusFilter.Text = null;
            this.StatusFilter.SelectedIndexChanged += new System.EventHandler(this.StatusFilter_SelectedIndexChanged);
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
            this.ProjectFilter.Location = new System.Drawing.Point(394, 30);
            this.ProjectFilter.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectFilter.Name = "ProjectFilter";
            this.ProjectFilter.Size = new System.Drawing.Size(288, 32);
            this.ProjectFilter.TabIndex = 21;
            this.ProjectFilter.Text = null;
            this.ProjectFilter.SelectedIndexChanged += new System.EventHandler(this.StatusFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Status : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Project Name : ";
            // 
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddTaskPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectFilter);
            this.Controls.Add(this.StatusFilter);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.btnAddtasks);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.TasksFlow);
            this.Controls.Add(this.TasksName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksView";
            this.Size = new System.Drawing.Size(1243, 720);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TasksName;
        private System.Windows.Forms.FlowLayoutPanel TasksFlow;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddtasks;
        private System.Windows.Forms.Panel AddTaskPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox RefreshButton;
        private Bunifu.UI.WinForms.BunifuDropdown StatusFilter;
        private Bunifu.UI.WinForms.BunifuDropdown ProjectFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
