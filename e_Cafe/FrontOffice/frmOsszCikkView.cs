using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.FrontOffice
{
    public partial class frmOsszCikkView : Form
    {
        private int AktCikkId;
        public frmOsszCikkView(int _cikkId)
        {
            AktCikkId = _cikkId;
            InitializeComponent();
            cIKKTableAdapter.Fill(dsReceptText.CIKK, AktCikkId);
            Cikk c = new Cikk(AktCikkId,new System.Data.SqlClient.SqlConnection(DEFS.ConSTR));
            lblCikkNeve.Text = c.MEGNEVEZES;
            rECEPTTableAdapter.Fill(dsReceptCikkek.RECEPT, AktCikkId);


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
