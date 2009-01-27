using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


using BusinessLogic;

namespace e_Cafe
{
    public partial class CikkSelector : Form
    {
        public int CIKK_ID;
        public int DEF_RAKT;

        public CikkSelector()
        {
            InitializeComponent();
            Cikk_list l = new Cikk_list(new SqlConnection(DEFS.ConSTR));
            cikkBindingSource.Clear();

            foreach (var c in l.lCIKK)
            {
                cikkBindingSource.Add(c);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cikkBindingSource.Current != null)
            {
                DEF_RAKT = ((Cikk)cikkBindingSource.Current).ALAP_RAKTAR;
                CIKK_ID = ((Cikk)cikkBindingSource.Current).CIKK_ID;

                DialogResult = DialogResult.OK;


                this.Close();
            }
        }


    }
}
