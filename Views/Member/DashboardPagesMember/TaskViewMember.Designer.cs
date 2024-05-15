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
            this.btnCompleted = new System.Windows.Forms.Label();
            this.btnOngoing = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Label();
            this.TasksName = new System.Windows.Forms.Label();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
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
            // btnCompleted
            // 
            this.btnCompleted.AutoSize = true;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(457, 29);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(95, 20);
            this.btnCompleted.TabIndex = 13;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnOngoing
            // 
            this.btnOngoing.AutoSize = true;
            this.btnOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(336, 29);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(76, 20);
            this.btnOngoing.TabIndex = 12;
            this.btnOngoing.Text = "Ongoing";
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(262, 29);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(29, 20);
            this.btnAll.TabIndex = 11;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
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
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.TasksFlow;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(914, 72);
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
            this.bunifuVScrollBar1.TabIndex = 15;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 50;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // TaskViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnOngoing);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.TasksFlow);
            this.Controls.Add(this.TasksName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskViewMember";
            this.Size = new System.Drawing.Size(932, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel TasksFlow;
        private System.Windows.Forms.Label btnCompleted;
        private System.Windows.Forms.Label btnOngoing;
        private System.Windows.Forms.Label btnAll;
        private System.Windows.Forms.Label TasksName;
    }
}
