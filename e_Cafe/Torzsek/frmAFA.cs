using System;
using System.Windows.Forms;
using BusinessLogic;


namespace e_Cafe.Torzsek
{
    public partial class frmAFA : Form
    {
        public frmAFA()
        {
            InitializeComponent();
        }

        private void frmAFA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetAFA.AFA' table. You can move, or remove it, as needed.
            this.aFATableAdapter.Fill(this.eCAFEDataSetAFA.AFA);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            aFATableAdapter.Update(eCAFEDataSetAFA);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DEFS.updateAfaSzazalekokOnCikkek();
        }




    }
}
