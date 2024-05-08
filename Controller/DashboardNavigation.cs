using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Controller
{
    public class DashboardNavigation
    {
        UserControl[] navigation_bar_items;
        //List<UserControl> navigation_bar_items = new List<UserControl>();
        Panel panel;

        public DashboardNavigation(UserControl[] navigation_bar, Panel panel)
        {
            this.navigation_bar_items = navigation_bar;
            this.panel = panel;

            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i  < navigation_bar_items.Count(); i++)
            {
                navigation_bar_items[i].Dock = DockStyle.Fill;
                panel.Controls.Add(navigation_bar_items[i]);
            }
        }

        public void Display(int index)
        {
            if (index < navigation_bar_items.Count())
            {
                navigation_bar_items[index].BringToFront();
            }
        }
    }
}
