using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e_Cafe.Reports;

using BusinessLogic;

namespace e_Cafe.Admin
{
    public partial class frmKimentBlokkok : Form
    {
        List<Szamla> tmpSZL = (new SzamlaList()).getList();

        public frmKimentBlokkok()
        {
            InitializeComponent();
        }

        private void filterableDataGrid1_Load(object sender, EventArgs e)
        {

        }

        private void DatumSelect(object sender, EventArgs e)
        {
            // ide jön a filter rész.
        }

        private void szamlaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (szamlaBindingSource.Current != null)
            {
                szamlatetelBindingSource.Clear();
                foreach (var t in ((Szamla)szamlaBindingSource.Current).lTETELEK)
                {
                    szamlatetelBindingSource.Add(t);
                }
            }
        }

        private void frmKimentBlokkok_Load(object sender, EventArgs e)
        {
            foreach (var s in tmpSZL)
            {

                szamlaBindingSource.Add(s);
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (szamlaBindingSource.Current != null)
            {
                doPrinting dp = new doPrinting();
                dp.setReportMaker(new BlokkReport(((Szamla)szamlaBindingSource.Current).FEJ_ID));
                dp.doPrint();
                //dp.doPreview();
            }
        }
    }
}
