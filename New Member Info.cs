﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS220GroupProject
{
    public partial class newMemForm : Form
    {
        private Member thisMember;
        private MemberDL thisMemerDL;
        
        public newMemForm()
        {
            InitializeComponent();
        }

        private void saveAccInfoButton_Click(object sender, EventArgs e)
        {
            string zipString;
            
            thisMember = new Member();
            thisMemerDL = new MemberDL();

            thisMember.FName = firstNameBox.Text;
            thisMember.LName = lastNameBox.Text;
            thisMember.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
            thisMember.Address1 = address1Box.Text;
            thisMember.Address2 = address2Box.Text;
            thisMember.City = cityBox.Text;
            thisMember.State = stateBox.Text;
            thisMember.Zip = Convert.ToInt32(zipBox.Text);
            thisMember.Phone = Convert.ToString(phoneNumBox);
            zipString = Convert.ToString(thisMember.Zip);
            
            thisMemerDL.CreateAccount(thisMember.FName, thisMember.LName, thisMember.Address1, thisMember.Address2, thisMember.Phone, thisMember.City, thisMember.State, zipString, thisMember.DateOfBirth);
        }
    }
}
