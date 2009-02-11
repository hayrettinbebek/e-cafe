using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe
{
    public partial class Bevetelezes : Form
    {
        int AktBevId;
        public Bevetelezes()
        {
            InitializeComponent();
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bEVETEL_FEJTableAdapter.Update(eCAFEDataSetBEVETELEZES.BEVETEL_FEJ);
            bEVETEL_SORTableAdapter.Update(eCAFEDataSetBEVETELEZES.BEVETEL_SOR);


            loadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            eCAFEDataSetBEVETELEZESBindingSource.AddNew();
        }

        private void loadData()
        {
            //BevetelFList l = new BevetelFList(new SqlConnection(DEFS.ConSTR));
            //bevetelfejBindingSource.Clear();

            //foreach (var c in l.lBevFej)
            //{
            //    bevetelfejBindingSource.Add(c);
            //}

            Cikk_list cl = new Cikk_list(new SqlConnection(DEFS.ConSTR));
            cikkBindingSource.Clear();
            foreach (var cc in cl.lCIKK)
            {
                cikkBindingSource.Add(cc);
            }

            RaktarLista rl = new RaktarLista(new SqlConnection(DEFS.ConSTR));
            raktarBindingSource.Clear();
            foreach (var cc in rl.lRAKTAR)
            {
                raktarBindingSource.Add(cc);
            }
        }

        private void Bevetelezes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetBEVETELEZES.BEVETEL_FEJ' table. You can move, or remove it, as needed.
            this.bEVETEL_FEJTableAdapter.Fill(this.eCAFEDataSetBEVETELEZES.BEVETEL_FEJ);

            loadData();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tPSorok)
            {


            }
        }

        private void bevetelfejBindingSource_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void bevetelSorBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new BevetelSor();
            ((BevetelSor)e.NewObject).BEVETEL_FEJ_ID = AktBevId;
            ((BevetelSor)e.NewObject).FELADVA = 0;
        }

        private void bevetelfejBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
          //  bevetelfejBindingSource.ResetCurrentItem();
        }

        private void eCAFEDataSetBEVETELEZESBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (eCAFEDataSetBEVETELEZESBindingSource.Current != null)
            {

                bEVETEL_SORTableAdapter.Fill(eCAFEDataSetBEVETELEZES.BEVETEL_SOR, (int)((DataRowView)eCAFEDataSetBEVETELEZESBindingSource.Current)["BEVETEL_FEJ_ID"]);


            }
        }



        private void bEVETELSORBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bEVETELSORBindingSource.Current != null)
            {
                if (((DataRowView)bEVETELSORBindingSource.Current).IsNew == true) {

                    ((DataRowView)bEVETELSORBindingSource.Current)["BEVETEL_FEJ_ID"] = ((DataRowView)eCAFEDataSetBEVETELEZESBindingSource.Current)["BEVETEL_FEJ_ID"];
                }
                
            }
        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns.IndexOf(dgvcCIKK))
            {
                CikkSelector fc = new CikkSelector();
                //fc.Parent = this;
                fc.ShowDialog();

                if (fc.DialogResult == DialogResult.OK)
                {
                    if (bEVETELSORBindingSource.Current != null)
                    {
                        ((DataRowView)bEVETELSORBindingSource.Current)["CIKK_ID"] = fc.CIKK_ID;
                        ((DataRowView)bEVETELSORBindingSource.Current)["RAKTAR_ID"] = fc.DEF_RAKT;
                    }
                }
            }
        }


    }
}
