using System;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe
{
    public partial class frmBevetelSor : Form
    {
        private int cikk_id;
        
        public BevetelSor retSor;
        private double afa_szaz;

        public frmBevetelSor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                lblMert.Text = fc.c.MEGYS_ID.ToString();
                lblPenz.Text = "Ft / " + fc.c.MEGYS_ID.ToString();
                
            }
        }

        private Boolean CheckInput()
        {
            if (cikk_id > 0) { DEFS.DebugLog("Cikk kiválasztása sikeres:" + cikk_id.ToString()); }
            Boolean ret = true;

            try
            {
                double d = Convert.ToDouble(txtMenny.Text);
            }
            catch (Exception e)
            {
                ret = false;
                DEFS.SendValidatingMessage("Mennyigég", txtMenny.Text+" "+e.Message);
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
                DEFS.ExLog(e.Message +"-->" +e.StackTrace);
            }


            return (ret);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            retSor = new BevetelSor();

            if (CheckInput())
            {
                retSor.BESZ_AR = Convert.ToDouble(txtEgys.Text);
                retSor.MENNY = Convert.ToDouble(txtMenny.Text);
                retSor.NETTO_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text);
                retSor.MEGJEGYZES = txtMegj.Text;
                retSor.FELADVA = 0;
                retSor.CIKK_ID = cikk_id;
                retSor.RAKTAR_ID = (int)cmbRaktar.SelectedValue;
                
                retSor.AFA_ERTEK =  Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text)*(afa_szaz/100);
                retSor.BRUTTO_ERTEK = Convert.ToDouble(txtMenny.Text) * Convert.ToDouble(txtEgys.Text) * (1+(afa_szaz / 100));
                this.DialogResult = DialogResult.OK;
                Close(); 
            }
            else {
                this.DialogResult = DialogResult.No;
            }
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close(); 
        }

        private void lblCikk_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void frmBevetelSor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetRAKTAR.RAKTAR' table. You can move, or remove it, as needed.
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);

        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
