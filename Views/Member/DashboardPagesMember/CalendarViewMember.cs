﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Views.Admin;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class CalendarViewMember : UserControl
    {
        private Size CalendarViewOriginalSize;

        private Rectangle recDayContainer;
        private Rectangle recCalendarName;
        private Rectangle reclblDate;
        private Rectangle recbtnPrevious;
        private Rectangle recbtnNext;
        private Rectangle recSunday;
        private Rectangle recMonday;
        private Rectangle recTuesday;
        private Rectangle recWednesday;
        private Rectangle recThursday;
        private Rectangle recFriday;
        private Rectangle recSaturday;
        public CalendarViewMember()
        {
            InitializeComponent();
            this.Resize += CalendarView_Resize;
            CalendarViewOriginalSize = this.Size;

            recDayContainer = new Rectangle(DayContainer.Location, DayContainer.Size);
            recCalendarName = new Rectangle(CalendarName.Location, CalendarName.Size);
            reclblDate = new Rectangle(lblDate.Location, lblDate.Size);
            recbtnPrevious = new Rectangle(btnPrevious.Location, btnPrevious.Size);
            recbtnNext = new Rectangle(btnNext.Location, btnNext.Size);
            recSunday = new Rectangle(Sunday.Location, Sunday.Size);
            recMonday = new Rectangle(Monday.Location, Monday.Size);
            recTuesday = new Rectangle(Tuesday.Location, Tuesday.Size);
            recWednesday = new Rectangle(Wednesday.Location, Wednesday.Size);
            recThursday = new Rectangle(Thursday.Location, Thursday.Size);
            recFriday = new Rectangle(Friday.Location, Friday.Size);
            recSaturday = new Rectangle(Saturday.Location, Saturday.Size);

        }

        private void CalendarView_Resize(object sender, EventArgs e)
        {
            resize_Control(DayContainer, recDayContainer);
            resize_Control(CalendarName, recCalendarName);
            resize_Control(lblDate, reclblDate);
            resize_Control(btnPrevious, recbtnPrevious);
            resize_Control(btnNext, recbtnNext);
            resize_Control(Sunday, recSunday);
            resize_Control(Monday, recMonday);
            resize_Control(Tuesday, recTuesday);
            resize_Control(Wednesday, recWednesday);
            resize_Control(Thursday, recThursday);
            resize_Control(Friday, recFriday);
            resize_Control(Saturday, recSaturday);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(CalendarViewOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(CalendarViewOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void CalendarViewMember_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;

        private void displayDays()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            lblDate.Text = monthName + " " + currentYear;

            //LETS get the first day of the month.

            DateTime startofthemonth = new DateTime(currentYear, currentMonth, 1);

            //get the count of days of the month

            int days = DateTime.DaysInMonth(currentYear, currentMonth);

            //convert the startofthemonth to integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                CalendarDays calendarDays = new CalendarDays();
                DayContainer.Controls.Add(calendarDays);
            }

            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                CalendarCurrentDays calendarCDays = new CalendarCurrentDays(currentYear,currentMonth);
                calendarCDays.days(i);
                DayContainer.Controls.Add(calendarCDays);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            currentMonth += 1;

            // updates the year
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            displayDays();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            currentMonth -= 1;

            // updates the year
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            displayDays();
        }
    }
}
