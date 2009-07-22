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

            dynComboBindingSource.Clear();
            StringEnum mt = new StringEnum(typeof(MegrendelesAllapot));
            for (int cy = 0; cy <= Enum.GetValues(typeof(MegrendelesAllapot)).Length - 1; cy++)
            {
                int value = (int)Enum.Parse(typeof(MegrendelesAllapot), Enum.GetName(typeof(MegrendelesAllapot), cy ));
                dynComboBindingSource.Add(new DynCombo(mt.GetStringValue(Enum.GetName(typeof(MegrendelesAllapot), cy )), value));
            }

            if (LoadType == LoadTypes.select)
            {
                // Az 1-ES LEZART kodúak jönnek csak fel ezeket lehet bevételezni.
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
            if (aktMegr.LEZART == 1)
            {
                frmBevetel f = new frmBevetel();
                f.bevfej_id = TemporaryBevetelSorok.GenerateBevetelezesFromMegrendeles(aktMegr);

                f.ShowDialog();
            }
            else
            {
                if (aktMegr.LEZART == 0) { DEFS.SendInfoMessage("A megrendelés még nincs elküldve!"); }
                if (aktMegr.LEZART == 2) { DEFS.SendInfoMessage("A megrendelés már bevételezésre került!"); }
            }
        }
    }
}
