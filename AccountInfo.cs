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
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        private Member thisMember;
        private MemberDL thisMemberDL;


        private void save_BTN_Click(object sender, EventArgs e)
        {
            string zipString;

            thisMember = new Member();
            thisMemberDL = new MemberDL();

            thisMember.FName = Convert.ToString(firstName_TXT);
            thisMember.LName = Convert.ToString(lastName_TXT);
            thisMember.Address1 = Convert.ToString(address1_TXT);
            thisMember.Address2 = Convert.ToString(address2_TXT);
            thisMember.City = Convert.ToString(city_TXT);
            thisMember.State = Convert.ToString(state_TXT);
            thisMember.Zip = Convert.ToInt32(zip_TXT);
            thisMember.Phone = Convert.ToString(phone_TXT);
            zipString = Convert.ToString(thisMember.Zip);

            thisMemberDL.CreateAccount(thisMember.FName, thisMember.LName, thisMember.Address1, thisMember.Address2, thisMember.Phone, thisMember.City, thisMember.State, zipString, thisMember.DateOfBirth);
        }
    }
}
