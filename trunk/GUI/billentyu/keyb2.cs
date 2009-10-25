using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GUI.billentyu
{
    [ToolboxItem(false)]
    public partial class keyb2 : UserControl
    {
        public TextBox OutTxtBox;

        public string resString;

        public InputType it = InputType.String;

        public keyb2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            txtRet.Focus();
            if (it == InputType.Number)
            {

                int isNumber = 0;
                if (int.TryParse(((Button)sender).Text.ToString(), out isNumber)) {
                    SendKeys.Send(((Button)sender).Text);
                }

                

            }
            else
            {             
                SendKeys.Send(((Button)sender).Text);
            }
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
            if (Parent.GetType() == typeof(frmTouchKeyboard))
            {
                ((frmTouchKeyboard)Parent).ResultString = resString;
                ((frmTouchKeyboard)Parent).DialogResult = DialogResult.OK;
                ((frmTouchKeyboard)Parent).Close();
            }

        }
    }
}
