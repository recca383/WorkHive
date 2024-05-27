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
        public AdminCard(MemberModel member)
        {
            InitializeComponent();
            InitializeElements(member);
        }

        private void InitializeElements(MemberModel member)
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            lblProfileName.Text = member.FullName;
            lblProfileTitle.Text = "Leader";
            lblProfilePhone.Text = member.ContactNumber.ToString();
            lblProfileEmail.Text = member.Email;
            lblAddress.Text = member.Address;
            if (member.Profile_Pic == " ")
            {
                picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), member.Profile_Pic));
            }
        }

    }
}
