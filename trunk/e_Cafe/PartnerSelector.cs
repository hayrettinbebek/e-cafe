using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

using BusinessLogic;


namespace e_Cafe
{
    public partial class PartnerSelector : Form
    {
        public string p_nev;
        public int p_id;

        public PartnerSelector()
        {
            InitializeComponent();

            Partner_list p = new Partner_list(new SqlConnection(DEFS.ConSTR));
            partnerBindingSource.Clear();

            foreach (var c in p.lSzallitok)
            {
                partnerBindingSource.Add((Partner)c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (partnerBindingSource.Current != null)
            {
                p_id = ((Partner)partnerBindingSource.Current).PARTNER_ID;
                p_nev = ((Partner)partnerBindingSource.Current).P_NEV;

                DialogResult = DialogResult.OK;


                this.Close();
            }
        }
    }
}
