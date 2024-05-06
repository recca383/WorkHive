using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Views.Cards
{
    public partial class TaskCard : UserControl
    {
        private Size TaskCardOriginalSize;
        private Rectangle recpanel2;
        private Rectangle recpanel3;
        private Rectangle recpictureBox1;
        
        public TaskCard()
        {
            InitializeComponent();
            this.Resize += TaskCard_Resize;
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
        }

        private void TaskCard_Resize(object sender, EventArgs e)
        {
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
            resize_Control(pictureBox1, recpictureBox1);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(TaskCardOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(TaskCardOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
    }
}
