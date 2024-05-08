using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WorkHive.Views.Cards
{
    public partial class AdminCard : UserControl
    {
        private Size AdminCardOriginalSize;
        private Rectangle recpanel1;
        private Rectangle recpanel2;
        private Rectangle recpanel3;

        


        public AdminCard(MemberModel member)
        {
            InitializeComponent();
            this.Resize += AdminCard_Resize;
            AdminCardOriginalSize = this.Size;
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            InitializeElements(member);
        }

        private void InitializeElements(MemberModel member)
        {
            lblProfileName.Text = member.FullName;
            lblProfileTitle.Text = "Leader";
            lblProfilePhone.Text = member.ContactNumber.ToString();
            lblProfileEmail.Text = member.Email;
            lblAddress.Text = member.Address;
            picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Directory.GetParent(Directory.GetCurrentDirectory()).FullName), member.Profile_Pic));
        }

        private void AdminCard_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpanel1);
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(AdminCardOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(AdminCardOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

    }
}
