﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public enum sex
    {
        None,
        Male,
        Female
    }
    public enum bloodType
    {
        None,
        A,
        B,
        AB,
        O
    }

    public class MemberModel
    {
        //user: Id, Username, password, role, TaskID
        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string ExtensionName { get; set; }
        public string  FullName 
        { get 
            {
                if (MiddleName != "" && ExtensionName != "")
                {
                    return FirstName + " "+ MiddleName + "." + " " + LastName + " " + ExtensionName;
                }
                else
                {
                    return FirstName + " " + LastName;
                }
                
            } 
        }

        public int ContactNumber { get; set; }
        public sex Sex { get; set;} = sex.None;
        public bloodType BloodType { get; set; } = bloodType.None;
        public DateTime Birthdate { get; set; } =  DateTime.Now;
        public string Password { get; set; }
        public bool IsLeader { get; set; }
        public string Profile_Pic { get; set; } = " ";
        public string HouseNumber { get; set; } = " ";
        public string Street { get; set; } = " ";
        public string Barangay { get; set; } = " ";
        public string City_Municipality { get; set; } = " ";
        public string Province { get; set; } = " ";
        public int ZipCode {  get; set; } = 0;
        public string Address { 
            get
            {
                return City_Municipality + ", " + Province;
            } 
        }

    }
}
