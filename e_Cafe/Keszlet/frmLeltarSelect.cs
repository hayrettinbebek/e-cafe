using System;
using System.Data;
using System.Windows.Forms;
using e_Cafe.Reports;

namespace e_Cafe.Keszlet
{
    public partial class frmLeltarSelect : Form
    {
        public frmLeltarSelect()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (lELTARFEJBindingSource.Current != null)
            {
                frmLeltarIv fli = new frmLeltarIv((int)((DataRowView)lELTARFEJBindingSource.Current)["LELTAR_FEJ_ID"]);
                fli.ShowDialog();
            }

 
            
        }

        private void lezartChanged(object sender, EventArgs e)
        {
            if (chkLezartak.MyCheckBox.Checked)
            {
                lELTARFEJBindingSource.Filter = "LEZART in (1,0)";
            }
            else
            {
                lELTARFEJBindingSource.Filter = "LEZART in (0)";
            }
        }

        private void frmLeltarSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLeltar.LELTAR_FEJ' table. You can move, or remove it, as needed.
            this.lELTAR_FEJTableAdapter.Fill(this.dsLeltar.LELTAR_FEJ);
            chkLezartak.MyCheckBox.CheckedChanged += lezartChanged;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (lELTARFEJBindingSource.Current != null)
            {
                doPrinting dp = new doPrinting();
                dp.setReportMaker(new LeltarIv((int)((DataRowView)lELTARFEJBindingSource.Current)["LELTAR_FEJ_ID"]));
                dp.doPreview();
            }
        }
    }
}
