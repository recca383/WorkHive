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

namespace WorkHive.Views.Cards
{
    public partial class ProfileCard : UserControl
    {

        public ProfileCard(MemberModel member)
        {
            InitializeComponent();
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
    }
}
