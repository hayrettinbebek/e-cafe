using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using XPTable.Renderers;


namespace e_Cafe.FrontOffice
{
    public partial class frmAsztalInfo : Form
    {
        private Asztal used_asztal;
        public frmAsztalInfo(Asztal aa)
        {
            InitializeComponent();
            used_asztal = aa;
            lblAsztalSzam.Text = aa.fASZTAL_SZAM + " . asztal";
            Rendeles r = new Rendeles(aa.fASZTAL_ID, aa.fRENDELES_ID);
            tblRendelesek.ColumnModel = r.getColumnModelInfo();
            tblRendelesek.HeaderRenderer = new GradientHeaderRenderer();
            tblRendelesek.TableModel = r.getTableModelInfo();

            tblRendelesek.Font = DEFS.fRendelInfo;
            tblRendelesek.TableModel.RowHeight = 40;
        }

        private void btnNem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
