using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class LoginDialog : Form1
    {
        public LoginDialog()
        {
            InitializeComponent();
            loginToolStripMenuItem.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = LoginHandler.processLogin(txtUser.Text, txtPasswd.Text);
            if (success)
            {
                MessageBox.Show("logged in!");
                this.Close();
            }
        }
    }
}
