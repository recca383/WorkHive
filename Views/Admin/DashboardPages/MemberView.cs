using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Cards;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class MemberView : UserControl
    {
        List<MemberModel> members;
        public MemberView()
        {
            InitializeComponent();
            AddMemberElements();
        }

        private void AddMemberElements()
        {
            

            members = MemberModelAccess.GetMemberModel();
            List<UserControl> users = new List<UserControl>();

            if (members is null)
            {
                MessageBox.Show("Wala pang laman, palagyan ng design to HAHAHAHA");
            }
            else
            {
                var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
                foreach (MemberModel member in members)
                {
                    if (member.IsLeader)
                    {
                        AdminCard adminCard = new AdminCard();
                        adminCard.lblProfileName.Text = member.FullName;
                        adminCard.lblProfileTitle.Text = "Leader";
                        adminCard.lblProfilePhone.Text = member.ContactNumber.ToString();
                        adminCard.lblProfileEmail.Text = member.Email;
                        adminCard.picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), member.Profile_Pic));
                        users.Add(adminCard);
                    }
                    else
                    {
                        ProfileCard memberCard = new ProfileCard();
                        memberCard.lblProfileName.Text = member.FullName;
                        memberCard.lblProfileTitle.Text = "Member";
                        memberCard.lblProfilePhone.Text = member.ContactNumber.ToString();
                        memberCard.lblProfileEmail.Text = member.Email;
                        memberCard.picboxProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), member.Profile_Pic));
                        users.Add(memberCard);
                    }
                        
                }
            }
            foreach (var cards in users)
            {
                MembersFlow.Controls.Add(cards);
            }

        }
    }
}
