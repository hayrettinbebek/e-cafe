using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BusinessLogic
{
    public partial class frmInfoMessage1 : Form
    {
        public frmInfoMessage1()
        {
            InitializeComponent();
            button12.BackgroundImage = global::BusinessLogic.Properties.Resources.Ok.ToBitmap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
