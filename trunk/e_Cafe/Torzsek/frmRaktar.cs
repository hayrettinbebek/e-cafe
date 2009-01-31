using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Cafe.Torzsek
{
    public partial class frmRaktar : Form
    {
        public frmRaktar()
        {
            InitializeComponent();
        }

        private void frmRaktar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetRAKTAR.RAKTAR' table. You can move, or remove it, as needed.
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);

        }

        private void frmRaktar_FormClosing(object sender, FormClosingEventArgs e)
        {
            rAKTARTableAdapter.Update(eCAFEDataSetRAKTAR);
        }
    }
}
