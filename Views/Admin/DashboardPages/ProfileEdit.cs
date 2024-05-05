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
            AddDefaultValues();
        }
        private void AddDefaultValues()
        {
            Namelbl.Text = currentUser.FullName;
            Positionlbl.Text = "Leader";

            //enum of positions
            worklbl.Text = "Manager";
            
            Birthdatelbl.Text = currentUser.Birthdate.ToString();
            contactlbl.Text = currentUser.ContactNumber.ToString();
            emaillbl.Text = currentUser.Email;
            addresslbl.Text = currentUser.Address;

            firstnametxt.Text = currentUser.FirstName;
            Lastnametxt.Text = currentUser.LastName;
            Extensiontxt.Text = currentUser.ExtensionName;
            contacttxt.Text = currentUser.ContactNumber.ToString();
            emailtxt.Text = currentUser.Email;

            SexDrop.DataSource = Enum.GetNames(typeof(sex)) ;
            SexDrop.SelectedText = currentUser.Sex.ToString();

            bloodTypeDrop.DataSource = Enum.GetNames(typeof(bloodType));
            bloodTypeDrop.SelectedText = currentUser.BloodType.ToString();

            BirthPicker.Value = currentUser.Birthdate;

            HouseNumbertxt.Text = currentUser.HouseNumber.ToString();
            Streettxt.Text = currentUser.Street;
            barangaytxt.Text = currentUser.Barangay;
            citymunicipaltxt.Text = currentUser.City_Municipality;
            provincetxt.Text = currentUser.Province;
            zipcodetxt.Text = currentUser.ZipCode.ToString();

        }
    }
}
