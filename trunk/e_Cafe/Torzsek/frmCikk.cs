using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NSpring.Logging;
using BusinessLogic;

namespace e_Cafe.Torzsek
{
    public partial class frmCikk : Form
    {
        public frmCikk()
        {
            InitializeComponent();
        }

        private void frmCikk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetRAKTAR.RAKTAR' table. You can move, or remove it, as needed.
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);
            // TODO: This line of code loads data into the 'eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER' table. You can move, or remove it, as needed.
            this.cIKCSOP_OTHER_FILTERTableAdapter.Fill(this.eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER);
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKKCSOPORT' table. You can move, or remove it, as needed.
            this.cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);
            // TODO: This line of code loads data into the 'eCAFEDataSetCIKK.CIKK' table. You can move, or remove it, as needed.
            this.cIKKTableAdapter.Fill(this.eCAFEDataSetCIKK.CIKK);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            
            cIKKTableAdapter.Update(eCAFEDataSetCIKK.CIKK);
            lIT_KISZTableAdapter.Update(eCAFEDataSetCIKK.LIT_KISZ);
        }
        

        private void cIKKBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null) {
            
            lIT_KISZTableAdapter.Fill(eCAFEDataSetCIKK.LIT_KISZ, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
            
              
            }
        }

        private void lITKISZBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = eCAFEDataSetCIKK.LIT_KISZ.AddLIT_KISZRow((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"], "", 0);
           
           
        }

        private void cIKKBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
            //e.NewObject = eCAFEDataSetCIKK.CIKK.AddCIKKRow();
            cIKKBindingSource.ResetBindings(true);
        }

        private void cIKKBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (!((((DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem)["MEGNEVEZES"].ToString()).Trim().Length > 0))
            //{ e.Cancel = true; DEFS.SendValidatingMessage("Megnevezés", "A mező értéke nem lehet üres!"); }


           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            cIKKBindingSource.AddNew();
        }


    }
}
