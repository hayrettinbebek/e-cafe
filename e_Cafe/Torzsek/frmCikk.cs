using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.Keszlet;
using e_Cafe.SQL;

namespace e_Cafe.Torzsek
{
    public partial class frmCikk : Form
    {
        //private Cikk_list cikkList = null;

        private Cikk aktCikk = null;
        private CikkFilter aktCikkfilter = new CikkFilter();
        public int recept = 0;
        public int aktiv = 1;

        public frmCikk()
        {
            InitializeComponent();
        }

        private void frmCikk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKeszletInfo.KESZLET_SOR' table. You can move, or remove it, as needed.
            this.kESZLET_SORTableAdapter.Fill(this.dsKeszletInfo.KESZLET_SOR);
            // TODO: This line of code loads data into the 'dsKeszletInfo.KESZLET_FEJ' table. You can move, or remove it, as needed.
            

            // TODO: This line of code loads data into the 'eCAFEDataSetCIKK.CIKK' table. You can move, or remove it, as needed.
            refreshDataset();
            if (recept != 1)
            {
                //tpRecept.Show();
                //tpRecept.Visible = true;
                tabControl1.TabPages.Remove(tpRecept);
            }
            //else
            //{
            //    tpRecept.Hide();
            //    tpRecept.Visible = false;

            //}
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

        private void RefreshSubData()
        {
            if (aktCikk != null)
            {
                tpRecept.Visible = aktCikk.OSSZETETT;
                cikkKeszletBindingSource.Clear();
                foreach (var k in aktCikk.lKESZLET)
                {
                    cikkKeszletBindingSource.Add(k);
                }
                cikkArBindingSource.Clear();
                foreach (var a in aktCikk.CIKK_ARAK)
                {
                    cikkArBindingSource.Add(a);
                }
            }
        }
        private void cIKKBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                grpKiszerelesek.Visible = (string)((DataRowView)cIKKBindingSource.Current)["ERTEKESITES_TIPUSA"] == "L";
                //grpEladAr.Visible = (string)((DataRowView)cIKKBindingSource.Current)["ERTEKESITES_TIPUSA"] == "L";


                //if (cikkList != null)
                //{
                    aktCikk = new Cikk((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"],true);
                    RefreshSubData();

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
                Cikk c = new Cikk((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"],true);
                c.AKTIV = 0;
                c.Save();
                refreshDataset();
            }
        }

        private void btnAktiv_Click(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                Cikk c = new Cikk((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"], true);
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
            //cIKKBindingSource.Filter = "MEGNEVEZES like '" + filterMegnevezes.Text + "%'";
            aktCikkfilter.FILTER_NEV = filterMegnevezes.Text;
            cIKKBindingSource.Filter = aktCikkfilter.getResult();
            
        }

        private void filterCikkcsop_TextChanged(object sender, EventArgs e)
        {
            aktCikkfilter.FILTER_CIKKCSOP = filterCikkcsop.Text;
            cIKKBindingSource.Filter = aktCikkfilter.getResult();
        }

        private void dataGridView2_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lITKISZBindingSource.AddNew();
        }

        private void filterAlcsoport_TextChanged(object sender, EventArgs e)
        {
            aktCikkfilter.FILTER_ALCSOPORT = filterAlcsoport.Text;
            cIKKBindingSource.Filter = aktCikkfilter.getResult();
        }

        private void cikkKeszletBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.kESZLET_FEJTableAdapter.Fill(this.dsKeszletInfo.KESZLET_FEJ, -1, -1);
            if (cikkKeszletBindingSource.Current != null)
            {
                if (aktCikk != null)
                {
                    this.kESZLET_FEJTableAdapter.Fill(this.dsKeszletInfo.KESZLET_FEJ, ((CikkKeszlet)cikkKeszletBindingSource.Current).RAKTAR_ID, aktCikk.CIKK_ID);
                    //gvKeszletInfo.DataSource = KeszletInfo.CreateDataSet(((CikkKeszlet)cikkKeszletBindingSource.Current).RAKTAR_ID, aktCikk.CIKK_ID).Tables[0].DefaultView;
                }
            }
           

        }

        private void gvKeszletInfo_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {


        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cikkKeszletBindingSource.Current != null)
            {
                frmAtvezetes fa = new frmAtvezetes(aktCikk.CIKK_ID, ((CikkKeszlet)cikkKeszletBindingSource.Current).RAKTAR_ID);

                fa.ShowDialog();
            }
            else
            {
                frmAtvezetes fa = new frmAtvezetes();

                fa.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cikkKeszletBindingSource.Current != null)
            {
                frmSelejtez fa = new frmSelejtez(aktCikk.CIKK_ID, ((CikkKeszlet)cikkKeszletBindingSource.Current).RAKTAR_ID);

                fa.ShowDialog();
            }
            else
            {
                frmSelejtez fa = new frmSelejtez();

                fa.ShowDialog();
            }
        }

        private void btnUjAr_Click(object sender, EventArgs e)
        {
            pnlUjArSor.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            

            aktCikk.AddCikkAr(dtpArFrom.Value, dtpArTo.Value, Convert.ToDouble(txtAr.Text));
            RefreshSubData();

            pnlUjArSor.Visible = false;
        }

        private void btnCikArSave_Click(object sender, EventArgs e)
        {
            
            foreach (var a in cikkArBindingSource)
            {
                ((CikkAr)a).Save();
            }
        }

        private void filter_RovidNev_TextChanged(object sender, EventArgs e)
        {
            aktCikkfilter.FILTER_ROVID_NEV = filter_RovidNev.Text;
            cIKKBindingSource.Filter = aktCikkfilter.getResult();
        }


    }
}

