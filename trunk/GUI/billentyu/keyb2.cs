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
    }
}
