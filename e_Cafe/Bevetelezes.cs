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

        private void bevetelfejBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Bevetel_fej();
            ((Bevetel_fej)e.NewObject).DATUM = DateTime.Now;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (var k in bevetelfejBindingSource.List)
            {
                if (((Bevetel_fej)k).isModified) { ((Bevetel_fej)k).Save(); }
            }

            foreach (var s in bevetelSorBindingSource.List)
            {
                ((BevetelSor)s).Save();
            }

            loadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bevetelfejBindingSource.AddNew();
        }

        private void loadData()
        {
            BevetelFList l = new BevetelFList(new SqlConnection(DEFS.ConSTR));
            bevetelfejBindingSource.Clear();

            foreach (var c in l.lBevFej)
            {
                bevetelfejBindingSource.Add(c);
            }

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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns.IndexOf(dgvcCIKK))
            {
                CikkSelector fc = new CikkSelector();
                //fc.Parent = this;
                fc.ShowDialog();

                if (fc.DialogResult == DialogResult.OK)
                {
                    if (bevetelSorBindingSource.Current != null)
                    {
                        ((BevetelSor)bevetelSorBindingSource.Current).CIKK_ID = fc.CIKK_ID;
                        ((BevetelSor)bevetelSorBindingSource.Current).RAKTAR_ID = fc.DEF_RAKT;
                    }
                }
            }
        }

        private void bevetelfejBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (bevetelfejBindingSource.Current != null)
            {
                AktBevId = ((Bevetel_fej)bevetelfejBindingSource.Current).BEVETEL_FEJ_ID;
                if (((Bevetel_fej)bevetelfejBindingSource.Current).BEVETEL_FEJ_ID != -1)
                {
                    bevetelSorBindingSource.Clear();

                    foreach (var s in ((Bevetel_fej)bevetelfejBindingSource.Current).lBevetelSorok)
                    {
                        bevetelSorBindingSource.Add(s);
                    }

                }
            }
        }
    }
}
