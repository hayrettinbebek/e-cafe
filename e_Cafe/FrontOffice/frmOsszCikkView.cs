﻿using System;
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
            Cikk c = new Cikk(AktCikkId,true);
            lblCikkNeve.Text = c.MEGNEVEZES;
            rECEPTTableAdapter.Fill(dsReceptCikkek.RECEPT, AktCikkId);


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
