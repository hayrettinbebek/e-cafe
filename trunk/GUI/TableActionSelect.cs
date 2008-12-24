using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class TableActionSelect : Form
    {
        public string pChoice;

        public TableActionSelect(string iAsk)
        {
            InitializeComponent();
            label1.Text = iAsk;
            pChoice = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pChoice = "F";
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pChoice = "R";
            this.DialogResult = DialogResult.OK;
        }
    }
}
