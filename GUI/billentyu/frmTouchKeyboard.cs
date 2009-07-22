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
    public partial class frmTouchKeyboard : Form
    {
       
        public string start_string = "";
        public TextBox t = new TextBox();

        public String ResultString;


        public frmTouchKeyboard(InputType t)
        {
            InitializeComponent();
            
            keyb21.it = t;

        }

        private void frmTouchKeyboard_Load(object sender, EventArgs e)
        {
            keyb21.txtRet.Text = start_string;
        }

        private void keyb21_Load(object sender, EventArgs e)
        {

        }
    }
}
