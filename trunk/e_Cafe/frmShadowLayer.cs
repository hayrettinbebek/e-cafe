using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Cafe
{
    public partial class frmShadowLayer : Form
    {
        public int param;

        public frmShadowLayer()
        {
            InitializeComponent();
            param = 0;
        }

        private void frmShadowLayer_Load(object sender, EventArgs e)
        {
            if (param == 0) { Close(); }
            frmPartnerInsert p = new frmPartnerInsert(param);
            p.ShowDialog();
            Close();
        }
    }
}
