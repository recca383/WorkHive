using Microsoft.CodeAnalysis.Text;
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
    public partial class MessageBoxes : Form
    {

        public MessageBoxes(string message)
        {
            InitializeComponent();
            TextLabel.Text = message;
            this.Show();
          
        }

      
        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
