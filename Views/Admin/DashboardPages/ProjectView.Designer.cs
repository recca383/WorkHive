namespace WorkHive.Views.Admin.DashboardPages
{
    partial class ProjectView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectView));
            this.Dashboardlbl = new System.Windows.Forms.Label();
            this.ProjectsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectSummary = new System.Windows.Forms.Panel();
            this.RefreshButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnAddProject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboardlbl
            // 
            this.Dashboardlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dashboardlbl.AutoSize = true;
            this.Dashboardlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardlbl.Location = new System.Drawing.Point(15, 11);
            this.Dashboardlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dashboardlbl.Name = "Dashboardlbl";
            this.Dashboardlbl.Size = new System.Drawing.Size(187, 51);
            this.Dashboardlbl.TabIndex = 1;
            this.Dashboardlbl.Text = "Projects";
            // 
            // ProjectsFlow
            // 
            this.ProjectsFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProjectsFlow.Location = new System.Drawing.Point(24, 90);
            this.ProjectsFlow.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectsFlow.Name = "ProjectsFlow";
            this.ProjectsFlow.Size = new System.Drawing.Size(1181, 631);
            this.ProjectsFlow.TabIndex = 21;
            this.ProjectsFlow.WrapContents = false;
            // 
            // ProjectSummary
            // 
            this.ProjectSummary.BackColor = System.Drawing.Color.Transparent;
            this.ProjectSummary.ForeColor = System.Drawing.Color.Transparent;
            this.ProjectSummary.Location = new System.Drawing.Point(368, 57);
            this.ProjectSummary.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectSummary.Name = "ProjectSummary";
            this.ProjectSummary.Size = new System.Drawing.Size(595, 644);
            this.ProjectSummary.TabIndex = 19;
            this.ProjectSummary.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.AddTaskPanel_ControlRemoved);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AllowFocused = false;
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BorderRadius = 0;
            this.RefreshButton.Image = global::WorkHive.Properties.Resources.refresh;
            this.RefreshButton.IsCircle = false;
            this.RefreshButton.Location = new System.Drawing.Point(1124, 30);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(37, 32);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 24;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Active = true;
            this.btnAddProject.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProject.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddProject.BorderRadius = 0;
            this.btnAddProject.ButtonText = "";
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProject.Iconimage = null;
            this.btnAddProject.Iconimage_right = global::WorkHive.Properties.Resources.Vector__3_;
            this.btnAddProject.Iconimage_right_Selected = null;
            this.btnAddProject.Iconimage_Selected = null;
            this.btnAddProject.IconMarginLeft = 0;
            this.btnAddProject.IconMarginRight = 0;
            this.btnAddProject.IconRightVisible = true;
            this.btnAddProject.IconRightZoom = 0D;
            this.btnAddProject.IconVisible = true;
            this.btnAddProject.IconZoom = 60D;
            this.btnAddProject.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnAddProject.IsTab = false;
            this.btnAddProject.Location = new System.Drawing.Point(1181, 28);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddProject.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddProject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProject.selected = true;
            this.btnAddProject.Size = new System.Drawing.Size(35, 34);
            this.btnAddProject.TabIndex = 23;
            this.btnAddProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProject.Textcolor = System.Drawing.Color.White;
            this.btnAddProject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
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
            this.bunifuVScrollBar1.BindingContainer = this.ProjectsFlow;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1213, 90);
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
            this.bunifuVScrollBar1.TabIndex = 22;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 61;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectSummary);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.ProjectsFlow);
            this.Controls.Add(this.Dashboardlbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectView";
            this.Size = new System.Drawing.Size(1243, 721);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboardlbl;
        private System.Windows.Forms.FlowLayoutPanel ProjectsFlow;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.Panel ProjectSummary;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProject;
        private Bunifu.UI.WinForms.BunifuPictureBox RefreshButton;
    }
}
