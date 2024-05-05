using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Views.LandingPage.LandingPagePages
{
    public partial class Messageboxes : UserControl
    {
        public Messageboxes()
        {
            InitializeComponent();
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
