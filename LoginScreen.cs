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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (loginUser_TXT.Text.ToString() != "admin")
            {
                MemberHome form = new MemberHome();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                AdminHome aForm = new AdminHome();
                aForm.ShowDialog();
                this.Close();
            }
        }



    }
}
