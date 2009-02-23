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
    public partial class frmAtvezetes : Form
    {
        private Cikk atvCikk;

        public frmAtvezetes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CikkSelector cs = new CikkSelector();
            cs.ShowDialog();
            if (cs.DialogResult == DialogResult.OK)
            {
                atvCikk = cs.c;
                lblCikkNev.Text = atvCikk.MEGNEVEZES;
                lblME.Text = atvCikk.MEGYS_MEGNEVEZES;
                cikkKeszletBindingSource.Clear();
                foreach (var k in atvCikk.lKESZLET)
                {
                    cikkKeszletBindingSource.Add(k);
                }

            }
        }

        private void cikkKeszletBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cikkKeszletBindingSource.Current != null)
            {
                lblKeszlet.Text = ((CikkKeszlet)cikkKeszletBindingSource.Current).fKESZLET.ToString() + " " + atvCikk.MEGYS_MEGNEVEZES;

                
            }
        }

        private void frmAtvezetes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetRAKTAR.RAKTAR' table. You can move, or remove it, as needed.
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);
            lblCikkNev.Text = "";
            lblKeszlet.Text = "";
            lblME.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = true;

            double menny = 0;
            int from_rakt = -1;
            int to_rakt = -1;

            if (atvCikk == null) { ok = false; }

            try
            {
                menny = Convert.ToDouble(txtMenny.Text);
            }
            catch (Exception x)
            {
                ok = false;
            }

            if (menny == 0) { ok = false; }

            if (cikkKeszletBindingSource.Current != null)
            {
                from_rakt = ((CikkKeszlet)cikkKeszletBindingSource.Current).fRAKTAR_ID;
            }
            if (!(from_rakt > 0)) { ok = false; }

            if (cmbToRakt.SelectedIndex < 0) { ok = false; }

            to_rakt = (int)cmbToRakt.SelectedValue;

            if (!(to_rakt > 0)) { ok = false; }

            if (ok)
            {
                SqlConnection c = new SqlConnection(DEFS.ConSTR);
                SqlCommand cmdKeszlAtvezet = new SqlCommand("SP_KESZLET_ATVEZET", c);

                cmdKeszlAtvezet.CommandType = System.Data.CommandType.StoredProcedure;




                cmdKeszlAtvezet.Parameters.Add("@from_raktar", SqlDbType.Int);
                cmdKeszlAtvezet.Parameters["@from_raktar"].Direction = ParameterDirection.Input;
                cmdKeszlAtvezet.Parameters["@from_raktar"].Value = from_rakt;
                cmdKeszlAtvezet.Parameters.Add("@to_raktar", SqlDbType.Int);
                cmdKeszlAtvezet.Parameters["@to_raktar"].Direction = ParameterDirection.Input;
                cmdKeszlAtvezet.Parameters["@to_raktar"].Value = to_rakt;
                cmdKeszlAtvezet.Parameters.Add("@cikk_id", SqlDbType.Int);
                cmdKeszlAtvezet.Parameters["@cikk_id"].Direction = ParameterDirection.Input;
                cmdKeszlAtvezet.Parameters["@cikk_id"].Value = atvCikk.CIKK_ID;
                cmdKeszlAtvezet.Parameters.Add("@menny", SqlDbType.Float);
                cmdKeszlAtvezet.Parameters["@menny"].Direction = ParameterDirection.Input;
                cmdKeszlAtvezet.Parameters["@menny"].Value = menny;
                c.Open();
                cmdKeszlAtvezet.ExecuteNonQuery();


                c.Close();

            }

            DEFS.SendInfoMessage("Átvezetés sikeres!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}