using System;
using System.Windows.Forms;

namespace e_Cafe.Torzsek
{
    public partial class frmAltKedvezm : Form
    {
        public frmAltKedvezm()
        {
            InitializeComponent();
        }

        private void frmAltKedvezm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsALTALANOS_KEDVEZMENY.ALTALANOS_KEDVEZMENY' table. You can move, or remove it, as needed.
            this.aLTALANOS_KEDVEZMENYTableAdapter.Fill(this.dsALTALANOS_KEDVEZMENY.ALTALANOS_KEDVEZMENY);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            aLTALANOS_KEDVEZMENYTableAdapter.Update(dsALTALANOS_KEDVEZMENY);
        }
    }
}
