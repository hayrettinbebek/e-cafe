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
    public partial class numericKeyboar : UserControl
    {
        public TextBox OutTxtBox;

        public InputType it = InputType.Number;
        public string resString;


        public numericKeyboar()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            SendKeys.Send(((Button)sender).Tag.ToString());
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
           
        }

        private void keyb2_Load(object sender, EventArgs e)
        {
            if (OutTxtBox != null) { txtRet.Visible = false; }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            OutTxtBox.Text = txtRet.Text;
            OutTxtBox.Focus();
            SendKeys.Send("{TAB}");

        }


        public void doWhat(object sender, EventArgs e)
        {
                //      
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (OutTxtBox != null)
            {
                OutTxtBox.Text = txtRet.Text;
                OutTxtBox.Focus();
                SendKeys.Send("{TAB}");
            }
            else
            {
                resString = txtRet.Text;
            }
            if (Parent.GetType() == typeof(frmTouchNumKeyboard))
            {
                ((frmTouchNumKeyboard)Parent).ResultString = resString;
                ((frmTouchNumKeyboard)Parent).DialogResult = DialogResult.OK;
                ((frmTouchNumKeyboard)Parent).Close();
            }
            doWhat(sender,e);
        }
    }
}
