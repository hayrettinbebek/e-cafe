using System;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe.Admin
{
    public partial class frmSyspar : Form
    {
        public frmSyspar()
        {
            InitializeComponent();
        }

        private void frmSyspar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSYSPAR.SYSPAR' table. You can move, or remove it, as needed.
            this.sYSPARTableAdapter.Fill(this.dsSYSPAR.SYSPAR);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sYSPARTableAdapter.Update(dsSYSPAR.SYSPAR);
            DEFS.R_SYSPAR = new SysParList();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }

  
}
