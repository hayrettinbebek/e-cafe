using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Keszlet
{
    public partial class frmBeszerzesSzallitoCikkei : Form
    {
        private int partner_id = -1;
        public frmBeszerzesSzallitoCikkei(int p_id)
        {
            InitializeComponent();
            partner_id = p_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var szc in szallitoCikkekBindingSource)
            {
                if (((SzallitoCikkek)szc).P_MENNYISEG > 0)
                {
                    BevetelSor retSor = new BevetelSor();

                    retSor.BESZ_AR = ((SzallitoCikkek)szc).P_EGYSEGAR;
                    retSor.MENNY = ((SzallitoCikkek)szc).P_MENNYISEG;
                    retSor.NETTO_ERTEK = ((SzallitoCikkek)szc).P_MENNYISEG * ((SzallitoCikkek)szc).P_EGYSEGAR;
                    retSor.MEGJEGYZES = "";
                    retSor.FELADVA = 0;
                    retSor.CIKK_ID = ((SzallitoCikkek)szc).P_CIKK.CIKK_ID;
                    retSor.RAKTAR_ID = ((SzallitoCikkek)szc).P_RAKTAR;

                    retSor.AFA_ERTEK = ((SzallitoCikkek)szc).P_MENNYISEG * ((SzallitoCikkek)szc).P_EGYSEGAR * (((SzallitoCikkek)szc).P_CIKK.AFA_SZAZ / 100);
                    retSor.BRUTTO_ERTEK = ((SzallitoCikkek)szc).P_MENNYISEG * ((SzallitoCikkek)szc).P_EGYSEGAR * (1 + (((SzallitoCikkek)szc).P_CIKK.AFA_SZAZ / 100));

                    TemporaryBevetelSorok.BevetelSorok.Add(retSor);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmBeszerzesSzallitoCikkei_Load(object sender, EventArgs e)
        {
            TemporaryBevetelSorok.BevetelSorok.Clear();
            szallitoCikkekBindingSource.Clear();

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, isnull(BESZ_AR,0) as BESZ_AR  FROM CIKK_BESZALLITOK WHERE PARTNER_ID =" + partner_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                szallitoCikkekBindingSource.Add(new SzallitoCikkek((int)rdr["CIKK_ID"], (double)rdr["BESZ_AR"]));
            }
            c.Close();
           
        }
    }
}
