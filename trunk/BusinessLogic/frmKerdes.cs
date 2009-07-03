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
    public partial class frmKerdes : Form
    {
        public frmKerdes()
        {
            InitializeComponent();
            btnOk.BackgroundImage = global::BusinessLogic.Properties.Resources.Ok.ToBitmap();
            btnNem.BackgroundImage = global::BusinessLogic.Properties.Resources.NO.ToBitmap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
