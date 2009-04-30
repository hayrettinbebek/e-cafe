using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe.Keszlet
{
    public partial class frmMegrendelesKeszites : Form
    {
        private Megrendeles aktMegr = null;

        public frmMegrendelesKeszites()
        {
            InitializeComponent();
        }

        private void frmMegrendelesKeszites_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMegrendeles.MEGRENDELES_FEJ' table. You can move, or remove it, as needed.
            this.mEGRENDELES_FEJTableAdapter.Fill(this.dsMegrendeles.MEGRENDELES_FEJ);

            this.pARTNERTableAdapter.FillSzallito(this.dsPartnerek.PARTNER, 1);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedTab == tpTetelek) && (aktMegr == null))
            {
                DEFS.SendInfoMessage("Nincs megrendelés kiválasztva!");
                tabControl1.SelectedTab = tpFej;
            }
        }
    }
}
