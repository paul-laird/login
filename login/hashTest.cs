using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Helpers;

namespace login
{
    public partial class hashTest : Form
    {
        public hashTest()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            label1.Text = Crypto.HashPassword(textBox1.Text);
            textBox2.Text = Crypto.HashPassword(textBox1.Text);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (Crypto.VerifyHashedPassword(label1.Text, textBox1.Text))
                MessageBox.Show("Verified");
        }
    }
}
