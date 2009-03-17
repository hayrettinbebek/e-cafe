using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe
{
    public partial class frmBevetel : Form
    {
        private int p_id;
        public int bevfej_id = -1;

        Bevetel_fej aktBevfej;

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
                aktBevfej = new Bevetel_fej(bevfej_id, new SqlConnection(DEFS.ConSTR));

            }
            fillFields();
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
                ;
                frmBevetelSor fs = new frmBevetelSor();
                fs.ShowDialog();
                if (fs.DialogResult == DialogResult.OK)
                {
                    fs.retSor.BEVETEL_FEJ_ID = bevfej_id;


                    aktBevfej.lBevetelSorok.Add(fs.retSor);
                    DEFS.DebugLog("Sor hozáfűzve" + fs.retSor.BEVETEL_FEJ_ID.ToString());

                }
                initGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFej();
            SaveSorok();
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

        }
    }
}
