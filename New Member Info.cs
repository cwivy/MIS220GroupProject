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
    public partial class newMemForm : Form
    {
        private Member thisMember;
        private MemberDL thisMemberDL;
        
        
        public newMemForm()
        {
            InitializeComponent();
        }

        private void saveAccInfoButton_Click(object sender, EventArgs e)
        {


        }
        
        private void ClearTextBoxes()
        {
            firstNameBox.Text = " ";
            lastNameBox.Text = " ";
            DOBDateTimePicker.Value = DateTime.Now;
            address1Box.Text = " ";
            address2Box.Text = " ";
            cityBox.Text = " ";
            stateBox.Text = " ";
            zipBox.Text = " ";
            phoneNumBox.Text = " ";
        }
    }
}
