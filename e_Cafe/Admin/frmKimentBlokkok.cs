using System;
using System.Collections.Generic;
using System.Windows.Forms;
using e_Cafe.UserControls;
using BusinessLogic;
using e_Cafe.Reports;
using eCafe_SzamlakorTableAdaptersAlias = e_Cafe.SQL.DataSets.eCafe_SzamlakorTableAdapters;

namespace e_Cafe.Admin
{
    public partial class frmKimentBlokkok : UserForm
    {
        List<Szamla> tmpSZL = (new SzamlaList()).getList();

        public frmKimentBlokkok()
        {
            InitializeComponent();
            DEFS.MakeSummariesOnSzamla();
        }

        private void filterableDataGrid1_Load(object sender, EventArgs e)
        {

        }

        private void DatumSelect(object sender, EventArgs e)
        {

        }

        private void szamlaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void frmKimentBlokkok_Load(object sender, EventArgs e)
        {

            
            szfTA.Fill(eSZLA.SZAMLA_FEJ);
            sztTA.Fill(eSZLA.SZAMLA_TETEL);

            ReloadList();
        }

        private void ReloadList()
        {



        }


        private void button6_Click(object sender, EventArgs e)
        {
            doPrinting dp = new doPrinting();
            try
            {
                dp.setReportMaker(new BlokkReport((int)advBandedGridView1.GetFocusedRowCellValue("SZAMLA_FEJ_ID")));
            }
            catch { }
            dp.doPrint();
        }

        private void chkMind_CheckedChanged(object sender, EventArgs e)
        {
            tmpSZL = (new SzamlaList()).getList();
            ReloadList();
        }

        private void eCafeSzamlakorBindingSource_CurrentChanged(object sender, EventArgs e)
        {


        }

        private void advBandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                labelControl1.Text = Convert.ToString((int)advBandedGridView1.GetFocusedRowCellValue("SZAMLA_FEJ_ID"));
            }
            catch { }
        }

        private void advBandedGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                labelControl1.Text = Convert.ToString((int)advBandedGridView1.GetFocusedRowCellValue("SZAMLA_FEJ_ID"));
            }
            catch { }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                labelControl1.Text = Convert.ToString((int)advBandedGridView1.GetFocusedRowCellValue("SZAMLA_FEJ_ID"));
            }
            catch { }
        }
    }
}
