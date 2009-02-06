using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.billentyu
{
    public partial class keyb2 : UserControl
    {
        public TextBox OutTxtBox;

        public keyb2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            SendKeys.Send(((Button)sender).Text);
        }

        private void back_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            SendKeys.Send("{BACKSPACE}");

        }


        private void space_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            SendKeys.Send(" ");
        }

        private void txtRet_TextChanged(object sender, EventArgs e)
        {
            OutTxtBox.Text = txtRet.Text;
        }

        private void keyb2_Load(object sender, EventArgs e)
        {
            if (OutTxtBox != null) { txtRet.Visible = false; }
        }
    }
}
