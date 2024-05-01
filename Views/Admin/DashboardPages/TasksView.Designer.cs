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
            this.Employees = new System.Windows.Forms.Label();
            this.TasksFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Label();
            this.btnOngoing = new System.Windows.Forms.Label();
            this.btnCompleted = new System.Windows.Forms.Label();
            this.btnArchived = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.Location = new System.Drawing.Point(15, 11);
            this.Employees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(154, 61);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Tasks";
            // 
            // TasksFlow
            // 
            this.TasksFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TasksFlow.Location = new System.Drawing.Point(36, 86);
            this.TasksFlow.Margin = new System.Windows.Forms.Padding(4);
            this.TasksFlow.Name = "TasksFlow";
            this.TasksFlow.Size = new System.Drawing.Size(1181, 631);
            this.TasksFlow.TabIndex = 3;
            this.TasksFlow.WrapContents = false;
            this.TasksFlow.Paint += new System.Windows.Forms.PaintEventHandler(this.TasksFlow_Paint);
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(349, 33);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(39, 27);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnOngoing
            // 
            this.btnOngoing.AutoSize = true;
            this.btnOngoing.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(448, 33);
            this.btnOngoing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(104, 27);
            this.btnOngoing.TabIndex = 5;
            this.btnOngoing.Text = "Ongoing";
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.AutoSize = true;
            this.btnCompleted.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(609, 33);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(130, 27);
            this.btnCompleted.TabIndex = 6;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnArchived
            // 
            this.btnArchived.AutoSize = true;
            this.btnArchived.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchived.Location = new System.Drawing.Point(792, 33);
            this.btnArchived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(107, 27);
            this.btnArchived.TabIndex = 7;
            this.btnArchived.Text = "Archived";
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
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
            // TasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.btnArchived);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnOngoing);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.TasksFlow);
            this.Controls.Add(this.Employees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksView";
            this.Size = new System.Drawing.Size(1243, 720);
            this.Load += new System.EventHandler(this.TasksView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.FlowLayoutPanel TasksFlow;
        private System.Windows.Forms.Label btnAll;
        private System.Windows.Forms.Label btnOngoing;
        private System.Windows.Forms.Label btnCompleted;
        private System.Windows.Forms.Label btnArchived;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
