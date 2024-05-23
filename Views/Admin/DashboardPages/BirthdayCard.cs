using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class BirthdayCard : UserControl
    {
        MemberModel member;
        public BirthdayCard(MemberModel member)
        {
            this.member = member;
            InitializeComponent();
            InitializeElements();
        }

        private void InitializeElements()
        {
            MemberBirthday.Text = member.Birthdate.ToString("MMMM dd yyyy");
            MemberName.Text = member.FirstName + "'s Birthday";

        }
    }
}
