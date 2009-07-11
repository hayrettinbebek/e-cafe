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

        public String ResultString;

        public frmTouchNumKeyboard(InputType t)
        {
            InitializeComponent();
            numericKeyboar1.it = t;
            numericKeyboar1.btnRet.Click += doWhat;

        }


        public void doWhat(object sender, EventArgs e)
        {

        }
    }
}
