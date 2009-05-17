using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;


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
         //   eCAFEDataSet.AcceptChanges();
            dataGridView1.EndEdit();
            cIKKCSOPORTBindingSource.EndEdit();
            cIKKCSOPORTBindingSource.MoveFirst();
            cIKKCSOPORTTableAdapter.Update(eCAFEDataSet);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cIKKCSOPORTBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DEFS.SendValidatingMessage("Megnevezés vagy Áfa", "A mező értéke nem lehet üres"+e.Exception.Message);
        }
    }
}
