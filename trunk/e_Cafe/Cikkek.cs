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

namespace e_Cafe
{
    public partial class Cikkek : Form
    {

        private SqlConnection sc;



        public Cikkek()
        {
            InitializeComponent();
            sc = MMenu.blObj.sqlConnection;
        }

        private void Cikkek_Load(object sender, EventArgs e)
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

            

        }


        private void tsMent_Click(object sender, EventArgs e)
        {


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
        }








    }
}
