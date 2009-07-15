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
    public partial class frmTouchNumKeyboard : Form
    {
        public TextBox t = new TextBox();
        public bool every_key_close = false;
        public string defaultValue = "";
        public String ResultString;

        public frmTouchNumKeyboard(InputType t)
        {
            InitializeComponent();
            numericKeyboar1.it = t;
            numericKeyboar1.txtRet.Text = defaultValue;
            numericKeyboar1.btnRet.Click += doWhat;

        }


        public void doWhat(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
