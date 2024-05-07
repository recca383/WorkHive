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
using WorkHive.Model;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class ResetPasswordMember : UserControl
    {
        MemberModel CurrentUser;
        public ResetPasswordMember(MemberModel currentModel)
        {
            this.CurrentUser = currentModel;
            InitializeComponent();
        }

        private void btnUpdatePasswordMember_Click(object sender, EventArgs e)
        {
            if (!(MemberModelAccess.ChangePassword(CurrentUser, txtCurrentPasswordMember.Text, txtNewPasswordMember.Text, txtConfirmPasswordMember.Text)))
            {
                txtCurrentPasswordMember.Clear();
                txtNewPasswordMember.Clear();
                txtConfirmPasswordMember.Clear();
            }
        }
    }
}
