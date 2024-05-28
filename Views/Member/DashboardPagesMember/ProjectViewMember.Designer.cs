namespace WorkHive.Views.Member.DashboardPagesMember
{
    partial class ProjectViewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectViewMember));
            this.ProjectSummaryMember = new System.Windows.Forms.Panel();
            this.ProjectsFlowMember = new System.Windows.Forms.FlowLayoutPanel();
            this.Dashboardlbl = new System.Windows.Forms.Label();
            this.RefreshButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectSummaryMember
            // 
            this.ProjectSummaryMember.BackColor = System.Drawing.Color.Transparent;
            this.ProjectSummaryMember.ForeColor = System.Drawing.Color.Transparent;
            this.ProjectSummaryMember.Location = new System.Drawing.Point(368, 57);
            this.ProjectSummaryMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectSummaryMember.Name = "ProjectSummaryMember";
            this.ProjectSummaryMember.Size = new System.Drawing.Size(595, 644);
            this.ProjectSummaryMember.TabIndex = 26;
            this.ProjectSummaryMember.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.AddTaskPanel_ControlRemoved);
            // 
            // ProjectsFlowMember
            // 
            this.ProjectsFlowMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectsFlowMember.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProjectsFlowMember.Location = new System.Drawing.Point(24, 90);
            this.ProjectsFlowMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectsFlowMember.Name = "ProjectsFlowMember";
            this.ProjectsFlowMember.Size = new System.Drawing.Size(1181, 631);
            this.ProjectsFlowMember.TabIndex = 27;
            this.ProjectsFlowMember.WrapContents = false;
            // 
            // Dashboardlbl
            // 
            this.Dashboardlbl.AutoSize = true;
            this.Dashboardlbl.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardlbl.Location = new System.Drawing.Point(11, 10);
            this.Dashboardlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dashboardlbl.Name = "Dashboardlbl";
            this.Dashboardlbl.Size = new System.Drawing.Size(216, 61);
            this.Dashboardlbl.TabIndex = 25;
            this.Dashboardlbl.Text = "Projects";
            // 
            // RefreshButton
            // 
            this.RefreshButton.AllowFocused = false;
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BorderRadius = 0;
            this.RefreshButton.Image = global::WorkHive.Properties.Resources.refresh;
            this.RefreshButton.IsCircle = false;
            this.RefreshButton.Location = new System.Drawing.Point(1181, 28);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(37, 32);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 30;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.bunifuVScrollBar1.BindingContainer = this.ProjectsFlowMember;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(1213, 90);
            this.bunifuVScrollBar1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.bunifuVScrollBar1.TabIndex = 28;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 61;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // ProjectViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectSummaryMember);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.ProjectsFlowMember);
            this.Controls.Add(this.Dashboardlbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectViewMember";
            this.Size = new System.Drawing.Size(1243, 721);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ProjectSummaryMember;
        private Bunifu.UI.WinForms.BunifuPictureBox RefreshButton;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel ProjectsFlowMember;
        private System.Windows.Forms.Label Dashboardlbl;
    }
}
