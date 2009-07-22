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
    
    public partial class frmMegrendelesKeszites : Form
    {
        private String LEZART_RENDELES_VAN = "Ez a megrednelés már lezárásra került nem rögzíthet további tételeket!";
        private Megrendeles aktMegr = null;
        private Cikk_list aktCikkList = null;

        public frmMegrendelesKeszites()
        {
            InitializeComponent();
        }

        private void frmMegrendelesKeszites_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMegrendeles.MEGRENDELES_FEJ' table. You can move, or remove it, as needed.
            this.mEGRENDELES_FEJTableAdapter.FillNyitott(this.dsMegrendeles.MEGRENDELES_FEJ);

            this.pARTNERTableAdapter.FillSzallito(this.dsPartnerek.PARTNER, 1);
            tsKilep.Image = global::GUI.Properties.Resources.Close.ToBitmap();
            btnKilep.Image = global::GUI.Properties.Resources.Close.ToBitmap();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedTab == tpTetelek) && (aktMegr == null))
            {
                DEFS.SendInfoMessage("Nincs megrendelés kiválasztva!");
                tabControl1.SelectedTab = tpFej;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpTetelek;
        }

        private void mEGRENDELESFEJBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (mEGRENDELESFEJBindingSource.Current != null)
            {
                aktMegr = new Megrendeles((int)((DataRowView)mEGRENDELESFEJBindingSource.Current)["MEGRENDELES_FEJ_ID"], new SqlConnection(DEFS.ConSTR));
                aktCikkList = new Cikk_list(new Partner(aktMegr.SZALLITO_ID));
                cikkBindingSource.Clear();
                foreach (var c in aktCikkList.lCIKK)
                {
                    cikkBindingSource.Add(c);
                }
                megrendelesSorBindingSource.Clear();
                foreach (var m in aktMegr.getSorok())
                {
                    megrendelesSorBindingSource.Add(m);
                }

                if (aktMegr.LEZART != 0)
                {
                    pnlLezart.BackgroundImage = global::GUI.Properties.Resources.Delete.ToBitmap();
                    pnlLezart.BackgroundImageLayout = ImageLayout.Stretch;
                    pnlLezart2.BackgroundImage = global::GUI.Properties.Resources.Delete.ToBitmap();
                    pnlLezart2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    pnlLezart.BackgroundImage = null;
                    pnlLezart2.BackgroundImage = null;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSzallito.Checked)
            {
                aktCikkList = new Cikk_list(new Partner(aktMegr.SZALLITO_ID));
                cikkBindingSource.Clear();
                foreach (var c in aktCikkList.lCIKK)
                {
                    cikkBindingSource.Add(c);
                }

            }
            if (chkMind.Checked)
            {
                aktCikkList = new Cikk_list(CikkListContructType.CikkSelector);
                cikkBindingSource.Clear();
                foreach (var c in aktCikkList.lCIKK)
                {
                     cikkBindingSource.Add(c);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aktMegr = new Megrendeles((int)cmbSzallito.SelectedValue);
            aktMegr.Save();
            mEGRENDELES_FEJTableAdapter.FillNyitott(dsMegrendeles.MEGRENDELES_FEJ);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aktMegr.LEZART == 0)
            {
                if (!aktMegr.CikkAlreadyExists((Cikk)lbCikkek.Items[lbCikkek.SelectedIndex]))
                {
                    aktMegr.addTetel((Cikk)lbCikkek.Items[lbCikkek.SelectedIndex], aktMegr.MEGRENDELES_FEJ_ID);
                    foreach (var m in aktMegr.lMegrendelesSorok)
                    {
                        m.Save();
                    }

                    megrendelesSorBindingSource.Clear();
                    foreach (var m in aktMegr.lMegrendelesSorok)
                    {
                        megrendelesSorBindingSource.Add(m);

                    }
                }
                else
                {
                    DEFS.SendInfoMessage("A cikk már a megrendeléshez hozzá lett rendelve!");
                }

            }
            else
            {
                DEFS.SendInfoMessage(LEZART_RENDELES_VAN);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var m in aktMegr.getSorok())
            {
                m.Save();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (aktMegr.ReadyForBook())
            {
                aktMegr.LEZART = 1;
                aktMegr.Save();
            }
            DEFS.SendInfoMessage("Formátum még nincs kialakítva!");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("kilépés előtt szeretne menteni?", "Kilépés a megrendelésekből", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aktMegr.Save();
                foreach (var m in aktMegr.lMegrendelesSorok)
                {
                    m.Save();
                }
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((MegrendelesSor)megrendelesSorBindingSource.Current).Delete();
            megrendelesSorBindingSource.Clear();
            foreach (var m in aktMegr.getSorok())
            {
                megrendelesSorBindingSource.Add(m);

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double tmp_kisz_menny = 0;
             
            if (aktMegr.LEZART == 0)
            {
                foreach (var ck in aktCikkList.lCIKK)
                {
                    tmp_kisz_menny = 0;
                    ck.getKeszlet();
                    if (ck.fKESZLET_ALL < ck.MINIMUM_KESZLET)
                    {
                        if (!aktMegr.CikkAlreadyExists(ck))
                        {
                            tmp_kisz_menny = (ck.getCurrentBeszallito(aktMegr.SZALLITO_ID)).KISZ_MENNY;
                            if (tmp_kisz_menny == 0) { tmp_kisz_menny = 1; }

                            aktMegr.addTetel(ck, aktMegr.MEGRENDELES_FEJ_ID, (Math.Round((ck.MINIMUM_KESZLET - ck.fKESZLET_ALL) / tmp_kisz_menny - 0.5, 0) + 1) * tmp_kisz_menny);
                            foreach (var m in aktMegr.lMegrendelesSorok)
                            {
                                m.Save();
                            }

                            megrendelesSorBindingSource.Clear();
                            foreach (var m in aktMegr.lMegrendelesSorok)
                            {
                                megrendelesSorBindingSource.Add(m);

                            }
                        }
                    }
                   
                }
            }
            else
            {
                DEFS.SendInfoMessage(LEZART_RENDELES_VAN);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double tmp_kisz_menny = 0;
            if (aktMegr.LEZART == 0)
            {
                foreach (var ck in aktCikkList.lCIKK)
                {
                    tmp_kisz_menny = 0;
                    ck.getKeszlet();
                    if (ck.fKESZLET_ALL < ck.OPTIMALIS_KESZLET)
                    {
                        if (!aktMegr.CikkAlreadyExists(ck))
                        {
                            tmp_kisz_menny = (ck.getCurrentBeszallito(aktMegr.SZALLITO_ID)).KISZ_MENNY;
                            if (tmp_kisz_menny == 0) { tmp_kisz_menny = 1; }

                            aktMegr.addTetel(ck, aktMegr.MEGRENDELES_FEJ_ID, (Math.Round((ck.OPTIMALIS_KESZLET - ck.fKESZLET_ALL) / tmp_kisz_menny - 0.5, 0) + 1) * tmp_kisz_menny);
                            foreach (var m in aktMegr.lMegrendelesSorok)
                            {
                                m.Save();
                            }

                            megrendelesSorBindingSource.Clear();
                            foreach (var m in aktMegr.lMegrendelesSorok)
                            {
                                megrendelesSorBindingSource.Add(m);

                            }
                        }
                    }

                }
            }
            else
            {
                DEFS.SendInfoMessage(LEZART_RENDELES_VAN);
            }
        }

        private void megrendelesSorBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           
        }

        private void megrendelesSorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            lblOsszMegrendeles.Text = aktMegr.GetSumErtek().ToString("# ###.00") + " Ft";
        }
    }
}
