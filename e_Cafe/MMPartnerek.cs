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
using GUI;

namespace e_Cafe
{
    public partial class MMPartnerek : Form
    {
        public MMPartnerek()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            loadPartnerek();
        }

        private void loadPartnerek()
        {
            Partner_list pl = new Partner_list(new SqlConnection(DEFS.ConSTR));
            for (int i = 0; i < pl.lSzallitok.Count; i++)
            {
                PartnerButton pb = new PartnerButton();
                pb.fPARTNER = (Partner)pl.lSzallitok[i];
                //cb.Click += onCikkClick;
                flpPartner.Controls.Add(pb);

            }
        }
    }
}
