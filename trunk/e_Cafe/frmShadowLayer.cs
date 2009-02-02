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
        public frmShadowLayer()
        {
            InitializeComponent();

        }

        private void frmShadowLayer_Load(object sender, EventArgs e)
        {
            frmPartnerInsert p = new frmPartnerInsert();
            p.ShowDialog();
            Close();
        }
    }
}
