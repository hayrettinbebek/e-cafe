using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe
{
    public partial class frmBevetelSor : Form
    {
        private int cikk_id;
        private int def_rakt;
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
                def_rakt = fc.DEF_RAKT;
                lblCikk.Text = fc.CIKK_NEV;
                afa_szaz = fc.AFA_SZAZ;
                lblMert.Text = fc.c.OSSZETETT.ToString();
                
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
                DEFS.SendValidatingMessage("Mennyigég", txtMenny.Text);
            }
            try
            {
                double d = Convert.ToDouble(txtEgys.Text);
            }
            catch (Exception e)
            {
                ret = false;
                DEFS.SendValidatingMessage("Mennyigég", txtEgys.Text);
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
                retSor.RAKTAR_ID = def_rakt;
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
    }
}
