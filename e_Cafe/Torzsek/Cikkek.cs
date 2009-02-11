using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

using System.Diagnostics;

namespace e_Cafe
{
    public partial class Cikkek : Form
    {

        private SqlConnection sc;
        private int AktCikkId;
        


        public Cikkek()
        {
            InitializeComponent();
            sc = MMenu.blObj.sqlConnection;
        }

        private void loadData()
        {
            
            Cikk_list l = new Cikk_list(new SqlConnection(DEFS.ConSTR));
            cikkBindingSource.Clear();

            foreach (var c in l.lCIKK)
            {
                cikkBindingSource.Add(c);
            }

            Cikkcsoport_list cl = new Cikkcsoport_list(new SqlConnection(DEFS.ConSTR));
            cikkcsoportBindingSource.Clear();

            foreach (var s in cl.lCIKKCSOPORT)
            {
                cikkcsoportBindingSource.Add(s);
            }
            
            ertTipBindingSource.Clear();
            ertTipBindingSource.Add(new ertTip("L", "Folyó"));
            ertTipBindingSource.Add(new ertTip("D", "Darab"));

            RaktarLista rr = new RaktarLista(new SqlConnection(DEFS.ConSTR));
            raktarBindingSource.Clear();

            foreach (var r in rr.lRAKTAR)
            {
                raktarBindingSource.Add(r);
            }
        }

        private void Cikkek_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void cikkBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (cmbCikkcsop.SelectedIndex != -1)
            {
                OTF_list o = new OTF_list((int)cmbCikkcsop.SelectedValue, new SqlConnection(DEFS.ConSTR));
                oTFBindingSource.Clear();

                foreach (var s in o.lOTF)
                {
                    oTFBindingSource.Add(s);
                }

            }
            if (cikkBindingSource.Current != null)
            {
                AktCikkId = ((Cikk)cikkBindingSource.Current).CIKK_ID;
                if (((Cikk)cikkBindingSource.Current).CIKK_ID != -1)
                {
                    cikkKiszerelesBindingSource.Clear();

                    foreach (var s in ((Cikk)cikkBindingSource.Current).CIKK_KISZERELES.lCikkKiszereles)
                    {
                        cikkKiszerelesBindingSource.Add(s);
                    }

                }
            }

            MessageBox.Show("cikkBindingSource_PositionChanged: " + ((Cikk)cikkBindingSource.Current).MEGNEVEZES);



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Debug.Write( ((Cikk)cikkBindingSource.Current).ALAP_RAKTAR.ToString()+'-' );
            //Debug.Write(((Cikk)cikkBindingSource.Current).ALCSOPORT.ToString() + '-');
            //Debug.Write(((Cikk)cikkBindingSource.Current).CIKKCSOPORT_ID.ToString() + '-');
            //Debug.Write(((Cikk)cikkBindingSource.Current).ERTEKESITES_TIPUSA.ToString() + '-');
            //Debug.WriteLine(((Cikk)cikkBindingSource.Current).MEGNEVEZES.ToString());
            foreach (var k in cikkKiszerelesBindingSource.List)
            {
                ((CikkKiszereles)k).Save();
            }

            foreach (var s in cikkBindingSource.List)
            {
                ((Cikk)s).Save();
            }

            //((Cikk)cikkBindingSource.Current).Save();
            loadData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           //if (chkOsszetett.Checked) {tbOsszetett.v
        }

        private void tbOsszetett_Click(object sender, EventArgs e)
        {

        }

        private void cikkKiszerelesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new CikkKiszereles(-1, AktCikkId, "", 0);

            //((CikkKiszereles)cikkKiszerelesBindingSource.Current).LIT_KISZ_CIKK_ID = AktCikkId;
            

        }

        private void cikkBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Cikk();
        }

        private void cikkBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((Cikk)cikkBindingSource.Current).MEGNEVEZES);
        }

        private void cikkBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CurrentItemChanged: " +((Cikk)cikkBindingSource.Current).MEGNEVEZES);
        }








    }
}
