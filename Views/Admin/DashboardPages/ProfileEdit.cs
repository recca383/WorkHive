using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;

namespace WorkHive.Views.Admin
{
    public partial class ProfileEdit : UserControl
    {
        MemberModel currentUser;
        public ProfileEdit(MemberModel _Currentuser)
        {
            this.currentUser = _Currentuser;
            InitializeComponent();
        }
    }
}
