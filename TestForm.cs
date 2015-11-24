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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            member.Id = Convert.ToInt32(textBox1.Text);

            member = member.Select(member.Id);
            MessageBox.Show(member.FName + member.LName + member.Address1 + member.AccId +" Bal: " + member.Balance);
        }
    }
}
