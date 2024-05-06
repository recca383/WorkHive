using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Views.Admin.DashboardPages;

namespace WorkHive.Views.Admin
{
    public partial class EditTasks : UserControl
    {
        private Size EditTaskCardOriginalSize;
        private Rectangle recpanel2;
        private Rectangle recpanel3;
        private Rectangle recEditpictureBox1;

        private int Id;
        public EditTasks(int id)
        {
            Id = id;
            txtID.Text = id.ToString();
            InitializeComponent();
            this.Resize += EditTasks_Resize;
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            recEditpictureBox1 = new Rectangle(EditpictureBox1.Location, EditpictureBox1.Size);
        }

        private void EditTasks_Resize(object sender, EventArgs e)
        {
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
            resize_Control(EditpictureBox1, recEditpictureBox1);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(EditTaskCardOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(EditTaskCardOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            
        }

    }
}
