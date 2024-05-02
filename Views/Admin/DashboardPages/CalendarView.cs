using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class CalendarView : UserControl
    {
        public CalendarView()
        {
            InitializeComponent();
        }

        private void CalendarView_Load(object sender, EventArgs e)
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
                CalendarCurrentDays calendarCDays = new CalendarCurrentDays();
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
