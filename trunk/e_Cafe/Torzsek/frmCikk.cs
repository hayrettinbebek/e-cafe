﻿using System;
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
        private Cikk_list cikkList = null;

        private Cikk aktCikk = null;

        public frmCikk()
        {
            InitializeComponent();
        }

        private void frmCikk_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'eCAFEDataSetCIKK.CIKK' table. You can move, or remove it, as needed.
            this.cIKKTableAdapter.Fill(this.eCAFEDataSetCIKK.CIKK);

            cikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR));

            
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

                

                if (cikkList != null)
                {
                    aktCikk = cikkList.CikkByID((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);

                    tpRecept.Visible = aktCikk.OSSZETETT;

                    cikkKeszletBindingSource.Clear();
                    foreach (var k in aktCikk.lKESZLET)
                    {
                        cikkKeszletBindingSource.Add(k);
                    }
                }


                lIT_KISZTableAdapter.Fill(eCAFEDataSetCIKK.LIT_KISZ, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
                taRecept.Fill(dsReceptText.CIKK, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);
                taReceptCikkek.Fill(dsReceptCikkek.RECEPT, (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"]);

            }
        }

        private void lITKISZBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = eCAFEDataSetCIKK.LIT_KISZ.AddLIT_KISZRow((int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"], "", 0);
           
           
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

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (cIKKBindingSource.Current != null)
            {
                frmUjCikk fu = new frmUjCikk();
                fu.CikkID = (int)((DataRowView)cIKKBindingSource.Current)["CIKK_ID"];
                fu.ShowDialog();
            }
        }

        private void btnKiszerelések_Click(object sender, EventArgs e)
        {
            lIT_KISZTableAdapter.Update(eCAFEDataSetCIKK.LIT_KISZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taRecept.Update(dsReceptText.CIKK);

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


    }
}
