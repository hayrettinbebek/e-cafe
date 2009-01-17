using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.billentyu
{
    public partial class TouchKeyboard : Form
    {
        public TouchKeyboard()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            SendKeys.Send(((Button)sender).Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
             txtRet.Focus();
             SendKeys.Send("{BACKSPACE}");
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //this.close();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            SendKeys.Send(" ");
        }


    }
}
