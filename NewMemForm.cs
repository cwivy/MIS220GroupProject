using System;
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
    public partial class NewMemForm : Form
    {   
        
        //----------Members--------------
        private Member thisMember;
        //private MemberDL thisMemberDL;
        

        //-------Constructors------------
        public NewMemForm()
        {
            thisMember = new Member();
            InitializeComponent();
        }

        //----------Methods--------------
        private void CopyFormToObject()
        {
            thisMember.FName = firstNameBox.Text.ToString();
            thisMember.LName = lastNameBox.Text.ToString();
            thisMember.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
            thisMember.Address1 = address1Box.Text.ToString();
            thisMember.Address2 = address2Box.Text.ToString();
            thisMember.City = cityBox.Text.ToString();
            thisMember.State = stateBox.Text.ToString();
            thisMember.Zip = Convert.ToInt32(zipBox.Text);
            thisMember.Phone = Convert.ToString(phoneNumBox);
        }

        //--------Event Handlers-----------
        private void saveAccInfoButton_Click(object sender, EventArgs e)
        {
            CopyFormToObject();
            //string zipString;


            //thisMember.FName = firstNameBox.Text.ToString();
            //thisMember.LName = lastNameBox.Text.ToString();
            //thisMember.DateOfBirth = Convert.ToDateTime(DOBDateTimePicker.Text);
            //thisMember.Address1 = address1Box.Text.ToString();
            //thisMember.Address2 = address2Box.Text.ToString();
            //thisMember.City = cityBox.Text.ToString();
            //thisMember.State = stateBox.Text.ToString();
            //thisMember.Zip = Convert.ToInt32(zipBox.Text);
            //thisMember.Phone = Convert.ToString(phoneNumBox);

            thisMember.CreateAccount();
        }
    }
}
