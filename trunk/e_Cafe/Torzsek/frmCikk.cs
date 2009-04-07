using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NSpring.Logging;
using BusinessLogic;
using e_Cafe.SQL;

namespace e_Cafe.Torzsek
{
    public partial class frmCikk : Form
    {
        //private Cikk_list cikkList = null;

        private Cikk aktCikk = null;
        public int recept = 0;
        public int aktiv = 1;

        public frmCikk()
        {
            InitializeComponent();
        }

        private void frmCikk_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'eCAFEDataSetCIKK.CIKK' table. You can move, or remove it, as needed.
            refreshDataset();
            if (recept == 1)
            {
                tpRecept.Show();
            }
            btnAktiv.Visible = (aktiv == 0);
            btnDelete.Visible = (aktiv == 1);
            //cikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR));

            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }
        

        private void cIKKBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                grpKiszerelesek.Visible = (string)((DataRowView)cIKKBindingSource.Current)["ERTEKESITES_TIPUSA"] == "L";
                //grpEladAr.Visible = (string)((DataRowView)cIKKBindingSource.Current)["ERTEKESITES_TIPUSA"] == "L";


                //if (cikkList != null)
                //{
                    aktCikk = new Cikk((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"],true,new SqlConnection(DEFS.ConSTR));

                    if (aktCikk != null)
                    {
                        tpRecept.Visible = aktCikk.OSSZETETT;

                        cikkKeszletBindingSource.Clear();
                        foreach (var k in aktCikk.lKESZLET)
                        {
                            cikkKeszletBindingSource.Add(k);
                        }
                    }
                //}
                txtBeszAR.Text =  Cikk.getBeszAr((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);

                lIT_KISZTableAdapter.Fill(eCAFEDataSetCIKK.LIT_KISZ, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
                taRecept.Fill(dsReceptText.CIKK, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
                taReceptCikkek.Fill(dsReceptCikkek.RECEPT, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);

            }
        }

        private void lITKISZBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = eCAFEDataSetCIKK.LIT_KISZ.AddLIT_KISZRow((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"], "", 0, 0);
           
           
        }

        private void cIKKBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
            //e.NewObject = eCAFEDataSetCIKK.CIKK.AddCIKKRow();
            cIKKBindingSource.ResetBindings(true);
        }

        private void cIKKBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            frmUjCikk fu = new frmUjCikk();
            fu.ShowDialog();
            refreshDataset();

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                frmUjCikk fu = new frmUjCikk();
                fu.CikkID = (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"];
                fu.ShowDialog();
                refreshDataset();
            }
        }

        private void refreshDataset()
        {
            this.cIKKTableAdapter.Fill(this.eCAFEDataSetCIKK.CIKK, recept, aktiv);
        }

        private void btnKiszerelések_Click(object sender, EventArgs e)
        {
            lIT_KISZTableAdapter.Update(eCAFEDataSetCIKK.LIT_KISZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //taRecept.Update(dsReceptText.CIKK);
            taRecept.Update(rtfReceptLeiras.Text, txtRecMod.Text, txtRecAlk.Text, txtRecPoh.Text, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUjTartozek_Click(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                frmCikkReceptAd fca = new frmCikkReceptAd();
                fca.Parent_cikk_id = (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"];
                fca.ShowDialog();

                
                taReceptCikkek.Fill(dsReceptCikkek.RECEPT, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
            }
        }

        private void btnReceptCikkModosit_Click(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                frmCikkReceptAd fca = new frmCikkReceptAd();
                fca.Parent_cikk_id = (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"];
                fca.load_cikk_id = (int)((DataRowView)bsReceptCikkek.Current)["OSSZ_CIKK_TARTOZEK_ID"];
                fca.ShowDialog();


                taReceptCikkek.Fill(dsReceptCikkek.RECEPT, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
            }
        }

        private void txtMegnevezes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                frmCikkReceptAd fca = new frmCikkReceptAd();
                fca.rECEPTTableAdapter.Delete((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"], (int)((DataRowView)bsReceptCikkek.Current)["OSSZ_CIKK_TARTOZEK_ID"]);
                fca.Dispose();
                taReceptCikkek.Fill(dsReceptCikkek.RECEPT, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                Cikk c = new Cikk((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"],true, new SqlConnection(DEFS.ConSTR));
                c.AKTIV = 0;
                c.Save();
                refreshDataset();
            }
        }

        private void btnAktiv_Click(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                Cikk c = new Cikk((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"], true, new SqlConnection(DEFS.ConSTR));
                c.AKTIV = 1;
                c.Save();
                refreshDataset();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void filterMegnevezes_TextChanged(object sender, EventArgs e)
        {
            cIKKBindingSource.Filter = "MEGNEVEZES like '" + filterMegnevezes.Text + "%'";
            
        }


    }
}

