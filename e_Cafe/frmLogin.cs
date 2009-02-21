using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Cafe
{
    public partial class frmLogin : Form
    {
        public string _usr;
        public string _pw;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _usr = txtUsr.Text;
            _pw = txtPw.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void keyb_Click(object sender, EventArgs e)
        {
            txtPw.Focus();
            SendKeys.Send(((Button)sender).Text);
        }
    }
}
