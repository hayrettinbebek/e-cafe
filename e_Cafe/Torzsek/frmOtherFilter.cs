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
    public partial class frmOtherFilter : Form
    {
        public frmOtherFilter()
        {
            InitializeComponent();
        }

        private void frmOtherFilter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKKCSOPORT' table. You can move, or remove it, as needed.
            this.cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);
            // TODO: This line of code loads data into the 'eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER' table. You can move, or remove it, as needed.
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cIKCSOP_OTHER_FILTERTableAdapter.Update(eCAFEDataSetOTHER_FILTER);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cIKCSOP_OTHER_FILTERTableAdapter.Fill(this.eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER, Convert.ToInt16(cmbFilter.SelectedValue));

        }
    }
}
