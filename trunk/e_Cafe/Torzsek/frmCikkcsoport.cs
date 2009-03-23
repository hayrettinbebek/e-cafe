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
    public partial class frmCikkcsoport : Form
    {
        public frmCikkcsoport()
        {
            InitializeComponent();
        }

        private void frmCikkcsoport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetAFA.AFA' table. You can move, or remove it, as needed.
            this.aFATableAdapter.Fill(this.eCAFEDataSetAFA.AFA);
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKKCSOPORT' table. You can move, or remove it, as needed.
            cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cIKKCSOPORTTableAdapter.Update(eCAFEDataSet);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
