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
using WorkHive.Views.LandingPage.LandingPagePages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class MemberView : UserControl
    {
        private Size MemberViewOriginalSize;
        private Rectangle recMembersName;
        private Rectangle recMembersFlow;
        private Rectangle recbunifuVScrollBar1;
        List<MemberModel> members;
        public MemberView()
        {
            InitializeComponent();
            RefreshMemberElements();
            ProfileEdit.OnUpdate += RefreshMemberElements;
            this.Resize += MemberView_Resize;
            MemberViewOriginalSize = this.Size;
            recMembersName = new Rectangle(MembersName.Location, MembersName.Size);
            recMembersFlow = new Rectangle(MembersFlow.Location, MembersFlow.Size);
            recbunifuVScrollBar1 = new Rectangle(bunifuVScrollBar1.Location, bunifuVScrollBar1.Size);
        }

        private void MemberView_Resize(object sender, EventArgs e)
        {
            resize_Control(MembersName, recMembersName);
            resize_Control(MembersFlow, recMembersFlow);
            resize_Control(bunifuVScrollBar1, recbunifuVScrollBar1);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(MemberViewOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(MemberViewOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void RefreshMemberElements()
        {
            MembersFlow.Controls.Clear();
            members = MemberModelAccess.GetMemberModel();
            List<UserControl> users = new List<UserControl>();

            if (members.Count < 1)
            {
                new MessageBoxes("Wala pang laman, palagyan ng design to HAHAHAHA");
            }
            else
            {
                foreach (MemberModel member in members.OrderBy(n => n.IsLeader).OrderBy(n => n.FirstName))
                {
                    if (member.IsLeader)
                    {
                        users.Add(new AdminCard(member));
                    }
                    else
                    {

                        users.Add(new ProfileCard(member));
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
