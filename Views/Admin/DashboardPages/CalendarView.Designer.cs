namespace WorkHive.Views.Admin.DashboardPages
{
    partial class CalendarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarView));
            this.CalendarName = new System.Windows.Forms.Label();
            this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Sunday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.CalendarScroll = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // CalendarName
            // 
            this.CalendarName.AutoSize = true;
            this.CalendarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarName.Location = new System.Drawing.Point(15, 11);
            this.CalendarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalendarName.Name = "CalendarName";
            this.CalendarName.Size = new System.Drawing.Size(205, 51);
            this.CalendarName.TabIndex = 2;
            this.CalendarName.Text = "Calendar";
            // 
            // DayContainer
            // 
            this.DayContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayContainer.Location = new System.Drawing.Point(26, 119);
            this.DayContainer.Name = "DayContainer";
            this.DayContainer.Size = new System.Drawing.Size(1185, 641);
            this.DayContainer.TabIndex = 3;
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.Location = new System.Drawing.Point(76, 92);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(70, 20);
            this.Sunday.TabIndex = 7;
            this.Sunday.Text = "Sunday";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.Location = new System.Drawing.Point(241, 92);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(73, 20);
            this.Monday.TabIndex = 8;
            this.Monday.Text = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.Location = new System.Drawing.Point(409, 92);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(79, 20);
            this.Tuesday.TabIndex = 9;
            this.Tuesday.Text = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.Location = new System.Drawing.Point(562, 92);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(105, 20);
            this.Wednesday.TabIndex = 10;
            this.Wednesday.Text = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.Location = new System.Drawing.Point(736, 92);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(86, 20);
            this.Thursday.TabIndex = 11;
            this.Thursday.Text = "Thursday";
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.Location = new System.Drawing.Point(922, 92);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(61, 20);
            this.Friday.TabIndex = 12;
            this.Friday.Text = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.Location = new System.Drawing.Point(1079, 92);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(83, 20);
            this.Saturday.TabIndex = 13;
            this.Saturday.Text = "Saturday";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(599, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(469, 42);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "MONTH YEAR";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalendarScroll
            // 
            this.CalendarScroll.AllowCursorChanges = true;
            this.CalendarScroll.AllowHomeEndKeysDetection = false;
            this.CalendarScroll.AllowIncrementalClickMoves = true;
            this.CalendarScroll.AllowMouseDownEffects = true;
            this.CalendarScroll.AllowMouseHoverEffects = true;
            this.CalendarScroll.AllowScrollingAnimations = true;
            this.CalendarScroll.AllowScrollKeysDetection = true;
            this.CalendarScroll.AllowScrollOptionsMenu = true;
            this.CalendarScroll.AllowShrinkingOnFocusLost = false;
            this.CalendarScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarScroll.AutoScroll = true;
            this.CalendarScroll.BackgroundColor = System.Drawing.Color.Silver;
            this.CalendarScroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CalendarScroll.BackgroundImage")));
            this.CalendarScroll.BindingContainer = this;
            this.CalendarScroll.BorderColor = System.Drawing.Color.Silver;
            this.CalendarScroll.BorderRadius = 14;
            this.CalendarScroll.BorderThickness = 1;
            this.CalendarScroll.DurationBeforeShrink = 2000;
            this.CalendarScroll.LargeChange = 10;
            this.CalendarScroll.Location = new System.Drawing.Point(1219, 118);
            this.CalendarScroll.Margin = new System.Windows.Forms.Padding(5);
            this.CalendarScroll.Maximum = 100;
            this.CalendarScroll.Minimum = 0;
            this.CalendarScroll.MinimumThumbLength = 18;
            this.CalendarScroll.Name = "CalendarScroll";
            this.CalendarScroll.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.CalendarScroll.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.CalendarScroll.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.CalendarScroll.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.CalendarScroll.ScrollBarColor = System.Drawing.Color.Silver;
            this.CalendarScroll.ShrinkSizeLimit = 3;
            this.CalendarScroll.Size = new System.Drawing.Size(24, 642);
            this.CalendarScroll.SmallChange = 1;
            this.CalendarScroll.TabIndex = 14;
            this.CalendarScroll.ThumbColor = System.Drawing.Color.Gray;
            this.CalendarScroll.ThumbLength = 63;
            this.CalendarScroll.ThumbMargin = 1;
            this.CalendarScroll.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.CalendarScroll.Value = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Active = true;
            this.btnPrevious.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.BorderRadius = 0;
            this.btnPrevious.ButtonText = "";
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrevious.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrevious.Iconimage = global::WorkHive.Properties.Resources.arrowleft;
            this.btnPrevious.Iconimage_right = null;
            this.btnPrevious.Iconimage_right_Selected = null;
            this.btnPrevious.Iconimage_Selected = null;
            this.btnPrevious.IconMarginLeft = 20;
            this.btnPrevious.IconMarginRight = 0;
            this.btnPrevious.IconRightVisible = true;
            this.btnPrevious.IconRightZoom = 0D;
            this.btnPrevious.IconVisible = true;
            this.btnPrevious.IconZoom = 40D;
            this.btnPrevious.IsTab = false;
            this.btnPrevious.Location = new System.Drawing.Point(1080, 29);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnPrevious.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnPrevious.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrevious.selected = true;
            this.btnPrevious.Size = new System.Drawing.Size(60, 39);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Tag = "Members";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevious.Textcolor = System.Drawing.Color.White;
            this.btnPrevious.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Active = true;
            this.btnNext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.BorderRadius = 0;
            this.btnNext.ButtonText = "";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledColor = System.Drawing.Color.Gray;
            this.btnNext.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNext.Iconimage = global::WorkHive.Properties.Resources.arrowright;
            this.btnNext.Iconimage_right = null;
            this.btnNext.Iconimage_right_Selected = null;
            this.btnNext.Iconimage_Selected = null;
            this.btnNext.IconMarginLeft = 20;
            this.btnNext.IconMarginRight = 0;
            this.btnNext.IconRightVisible = true;
            this.btnNext.IconRightZoom = 0D;
            this.btnNext.IconVisible = true;
            this.btnNext.IconZoom = 40D;
            this.btnNext.IsTab = false;
            this.btnNext.Location = new System.Drawing.Point(1151, 29);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.btnNext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(1)))));
            this.btnNext.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNext.selected = true;
            this.btnNext.Size = new System.Drawing.Size(60, 39);
            this.btnNext.TabIndex = 5;
            this.btnNext.Tag = "Members";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Textcolor = System.Drawing.Color.White;
            this.btnNext.TextFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.CalendarScroll);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.DayContainer);
            this.Controls.Add(this.CalendarName);
            this.Name = "CalendarView";
            this.Size = new System.Drawing.Size(1243, 823);
            this.Load += new System.EventHandler(this.CalendarView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalendarName;
        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private Bunifu.Framework.UI.BunifuFlatButton btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrevious;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Saturday;
        private Bunifu.UI.WinForms.BunifuVScrollBar CalendarScroll;
        private System.Windows.Forms.Label lblDate;
    }
}
