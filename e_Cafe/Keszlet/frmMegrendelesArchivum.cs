using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Keszlet
{
    public enum LoadTypes {
        archive,
        select
    }

    public partial class frmMegrendelesArchivum : Form
    {
        public LoadTypes LoadType = LoadTypes.archive;
        private Megrendeles aktMegr;

        public frmMegrendelesArchivum()
        {
            InitializeComponent();
        }

        private void frmMegrendelesArchivum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMegrendeles.MEGRENDELES_SOR' table. You can move, or remove it, as needed.
            this.mEGRENDELES_SORTableAdapter.Fill (this.dsMegrendeles.MEGRENDELES_SOR);
            // TODO: This line of code loads data into the 'dsMegrendeles.MEGRENDELES_FEJ' table. You can move, or remove it, as needed.
            if (LoadType == LoadTypes.select)
            {
                this.mEGRENDELES_FEJTableAdapter.FillArch(this.dsMegrendeles.MEGRENDELES_FEJ);
            }
            else
            {
                this.mEGRENDELES_FEJTableAdapter.Fill(this.dsMegrendeles.MEGRENDELES_FEJ);
            }

            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            aktMegr = new Megrendeles((int)((DataRowView)mEGRENDELESFEJBindingSource.Current)["MEGRENDELES_FEJ_ID"], new SqlConnection(DEFS.ConSTR));
            MessageBox.Show(aktMegr.MEGRENDELES_FEJ_ID.ToString());
        }
    }
}
