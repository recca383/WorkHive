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
using WorkHive.Controller;
using WorkHive.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WorkHive.Views.Cards
{
    public partial class ProfileCard : UserControl
    {
        MemberModel CurrentUser;
        int ID;

        public ProfileCard(MemberModel member)
        {
            InitializeComponent();
            InitializeElements(member);
        }

        private void InitializeElements(MemberModel member)
        {
            CurrentUser = MemberModelAccess.GetMemberInfo(ID);
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            lblProfileName.Text = member.FullName;
            lblProfileTitle.Text = "Member";
            lblProfilePhone.Text = member.ContactNumber.ToString();
            lblProfileEmail.Text = member.Email;
            lblAddress.Text = member.Address;
            
            if (CurrentUser.Profile_Pic.Contains("C:\\") || CurrentUser.Profile_Pic.Contains("D:\\"))
            {
                picboxProfilePic.Image = Image.FromFile(CurrentUser.Profile_Pic);
            }
            else if (CurrentUser.Profile_Pic == " ")
            {
                picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), CurrentUser.Profile_Pic));
            }
        }
    }
}
