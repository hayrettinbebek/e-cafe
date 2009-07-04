using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e_Cafe.Keszlet;
using BusinessLogic;

namespace e_Cafe
{
    public partial class frmBevetel : Form
    {
        private int p_id;
        public int bevfej_id = -1;

        Bevetel_fej aktBevfej;


        private int cikk_id;
        public BevetelSor retSor;
        private double afa_szaz;

        private BevetelSor aktSor;


        public frmBevetel()
        {
            InitializeComponent();
        }

        private void frmBevetel_Load(object sender, EventArgs e)
        {
            if (bevfej_id == -1)
            {
                aktBevfej = new Bevetel_fej();
            }
            else
            {
                aktBevfej = new Bevetel_fej(bevfej_id);

            }
            p_id = aktBevfej.PARTNER_ID;
            fillFields();
            pnlAddCikk.Visible = false;
        }
        private void initGrid()
        {
            bevetelSorBindingSource.Clear();
            foreach (var bv in aktBevfej.lBevetelSorok)
            {
                bevetelSorBindingSource.Add(bv);
            }
        }

        private void fillFields()
        {
            txtSzallitolevel.Text = aktBevfej.SZALLITOLEVEL_SZAM;
            txtSzamlaszam.Text = aktBevfej.SZAMLASZAM;
            dtpDatum.Value = aktBevfej.DATUM;
            initGrid();
            Szallito sz = new Szallito(p_id);
            lblSzallito.Text = sz.P_NEV + " " + sz.P_NEV2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartnerSelector fc = new PartnerSelector();
            //fc.Parent = this;
            fc.ShowDialog();

            if (fc.DialogResult == DialogResult.OK)
            {
                p_id = fc.p_id;
                lblSzallito.Text = fc.p_nev;
               
            }
        }

        private bool SaveFej()
        {
            if ((txtSzallitolevel.Text == "") && (txtSzamlaszam.Text == ""))
            {

                DEFS.SendInfoMessage("Szállítólevél vagy számlaszám megadása kötelező!!");
                return false;
            }
            else 
            {
                aktBevfej.SZALLITOLEVEL_SZAM = txtSzallitolevel.Text;
                aktBevfej.SZAMLASZAM = txtSzamlaszam.Text;
                aktBevfej.DATUM = dtpDatum.Value;
                aktBevfej.PARTNER_ID = p_id;

                bevfej_id = aktBevfej.Save();
                return true;
            }
        }

        private void SaveSorok()
        {
            foreach (var bv in aktBevfej.lBevetelSorok)
            {
                bv.Save();
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (SaveFej())
            {
                this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);
                pnlAddCikk.Visible = true;
                initGrid();
            }

            aktSor = null;
            dataGridView1.Enabled = false;
            lblCikk.Text = "Kérem válasszon cikket!";
            cikk_id = -1;

            
            
            afa_szaz = -99;
            lblMert.Text = "";
            lblPenz.Text = "";
            txtMegj.Text = "";
            txtMenny.Text = "";
            txtEgys.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFej();
            SaveSorok();

            if (DEFS.Kerdes("Szeretné a rendelés készletre vezetni és ezzel a megrendelést végelegesíteni?"))
            {
                foreach (var bs in aktBevfej.lBevetelSorok)
                {
                    if (bs.FELADVA == 0)
                    {
                        bs.FELADVA = 1;
                        bs.Save();
                    }
                }
                aktBevfej.KONYVELT = true;
                aktBevfej.Save();
            }


            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bevetelSorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            txtVegAfa.Text = "";
            txtVegBrutto.Text = "";
            txtVegNet.Text = "";

            double vegAfa = 0;
            double vegNet = 0;
            double vegBrutto = 0;

            foreach (var bv in aktBevfej.lBevetelSorok)
            {
                vegAfa += bv.AFA_ERTEK;
                vegNet += bv.NETTO_ERTEK;
                vegBrutto += bv.BRUTTO_ERTEK;

            }

            txtVegAfa.Text = vegAfa.ToString("# ##0.00");
            txtVegBrutto.Text = vegBrutto.ToString("# ##0.00");
            txtVegNet.Text = vegNet.ToString("# ##0.00");
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);
            if (bevetelSorBindingSource.Current != null)
            {
                aktSor = ((BevetelSor)bevetelSorBindingSource.Current);

                cikk_id = aktSor.CIKK_ID;
                Cikk tc = new Cikk(cikk_id,true);
                lblMert.Text = tc.MEGYS_MEGNEVEZES;
                lblPenz.Text = "Ft / " + tc.MEGYS_MEGNEVEZES.ToString();
                txtMegj.Text = aktSor.MEGJEGYZES;
                txtMenny.Text = aktSor.MENNY.ToString();
                txtEgys.Text = aktSor.BESZ_AR.ToString();

                cmbRaktar.SelectedValue = tc.ALAP_RAKTAR;
                lblCikk.Text = tc.MEGNEVEZES;
                afa_szaz = tc.AFA_SZAZ;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBeszerzesSzallitoCikkei f = new frmBeszerzesSzallitoCikkei(p_id);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                if (SaveFej())
                {
                    foreach (var bs in TemporaryBevetelSorok.BevetelSorok)
                    {
                        bs.BEVETEL_FEJ_ID = aktBevfej.BEVETEL_FEJ_ID;
                        aktBevfej.lBevetelSorok.Add(bs);
                    }
                }
            }
            initGrid();
        }

        private void pnlAddCikk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCikk_Click(object sender, EventArgs e)
        {
            CikkSelector fc = new CikkSelector();
            //fc.Parent = this;
            fc.ShowDialog();

            if (fc.DialogResult == DialogResult.OK)
            {

                cikk_id = fc.CIKK_ID;

                cmbRaktar.SelectedValue = fc.DEF_RAKT;
                lblCikk.Text = fc.CIKK_NEV;
                afa_szaz = fc.AFA_SZAZ;
                lblMert.Text = fc.c.MEGYS_MEGNEVEZES.ToString();
                lblPenz.Text = "Ft / " + fc.c.MEGYS_MEGNEVEZES.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUjCikk fc = new frmUjCikk();
            fc.ShowDialog();

            if (fc.DialogResult == DialogResult.OK)
            {
                cikk_id = fc.newCikk.CIKK_ID;
                cmbRaktar.SelectedValue = fc.newCikk.ALAP_RAKTAR;
                lblCikk.Text = fc.newCikk.MEGNEVEZES;
                afa_szaz = fc.newCikk.getAfaSzaz();
                lblMert.Text = fc.newCikk.MEGYS_MEGNEVEZES;
                lblPenz.Text = "Ft / " + fc.newCikk.MEGYS_MEGNEVEZES;

            }
        }

        private Boolean CheckInput()
        {
            Boolean ret = true;
            if (cikk_id > 0)
            {
                DEFS.DebugLog("Cikk kiválasztása sikeres:" + cikk_id.ToString());
                ret = true;
            }
            else
            {
                ret = false;
            }

            try
            {
                double d = Convert.ToDouble(txtMenny.Text);
            }
            catch (Exception e)
            {
                ret = false;
                DEFS.SendValidatingMessage("Mennyigég", txtMenny.Text + " " + e.Message);
                DEFS.ExLog(e.Message + "-->" + e.StackTrace);
            }
            try
            {
                double d = Convert.ToDouble(txtEgys.Text);
            }
            catch (Exception e)
            {
                ret = false;
                DEFS.SendValidatingMessage("Mennyigég", txtEgys.Text);
                DEFS.ExLog(e.Message + "-->" + e.StackTrace);
            }


            return (ret);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (aktSor != null)
            {
                if (CheckInput())
                {
                    
                    aktSor.BESZ_AR = Convert.ToDouble(txtEgys.Text);
                    aktSor.MENNY = Convert.ToDouble(txtMenny.Text);
                    aktSor.NETTO_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text);
                    aktSor.MEGJEGYZES = txtMegj.Text;
                    aktSor.FELADVA = 0;
                    aktSor.CIKK_ID = cikk_id;
                    aktSor.RAKTAR_ID = (int)cmbRaktar.SelectedValue;

                    aktSor.AFA_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text) * (afa_szaz / 100);
                    aktSor.BRUTTO_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text) * (1 + (afa_szaz / 100));
                    pnlAddCikk.Visible = false;
                    aktSor.Save();

                }
                else
                {
                    aktSor = null;
                    pnlAddCikk.Visible = false;
                }
            }
            else
            {
                if (CheckInput())
                {
                    retSor = new BevetelSor();
                    retSor.BESZ_AR = Convert.ToDouble(txtEgys.Text);
                    retSor.MENNY = Convert.ToDouble(txtMenny.Text);
                    retSor.NETTO_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text);
                    retSor.MEGJEGYZES = txtMegj.Text;
                    retSor.FELADVA = 0;
                    retSor.CIKK_ID = cikk_id;
                    retSor.RAKTAR_ID = (int)cmbRaktar.SelectedValue;

                    retSor.AFA_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text) * (afa_szaz / 100);
                    retSor.BRUTTO_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text) * (1 + (afa_szaz / 100));
                    pnlAddCikk.Visible = false;

                }
                else
                {
                    retSor = null;
                    pnlAddCikk.Visible = false;
                }

                if (retSor != null)
                {
                    retSor.BEVETEL_FEJ_ID = bevfej_id;


                    aktBevfej.lBevetelSorok.Add(retSor);
                    DEFS.DebugLog("Sor hozáfűzve" + retSor.BEVETEL_FEJ_ID.ToString());
                    retSor = null;
                }
                

            }
            dataGridView1.Enabled = true;
            initGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            retSor = null;
            pnlAddCikk.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlAddCikk.Visible = true;

        }
    }
}
