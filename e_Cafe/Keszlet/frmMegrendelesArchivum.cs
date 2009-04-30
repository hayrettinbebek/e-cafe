using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Cafe.Keszlet
{
    public partial class frmMegrendelesArchivum : Form
    {
        public frmMegrendelesArchivum()
        {
            InitializeComponent();
        }

        private void frmMegrendelesArchivum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMegrendeles.MEGRENDELES_SOR' table. You can move, or remove it, as needed.
            this.mEGRENDELES_SORTableAdapter.Fill(this.dsMegrendeles.MEGRENDELES_SOR);
            // TODO: This line of code loads data into the 'dsMegrendeles.MEGRENDELES_FEJ' table. You can move, or remove it, as needed.
            this.mEGRENDELES_FEJTableAdapter.Fill(this.dsMegrendeles.MEGRENDELES_FEJ);

        }
    }
}
