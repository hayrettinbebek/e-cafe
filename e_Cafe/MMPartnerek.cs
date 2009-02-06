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
            loadPartnerek("V");
        }

        private void loadPartnerek(string pPartnerType)
        {
            flpPartner.Controls.Clear();
            Partner_list pl = new Partner_list(new SqlConnection(DEFS.ConSTR));
            switch (pPartnerType)
            {
                case "S":
                    {
                        for (int i = 0; i < pl.lSzallitok.Count; i++)
                        {
                            PartnerButton pb = new PartnerButton();
                            pb.fPARTNER = (Partner)pl.lSzallitok[i];
                            //cb.Click += onCikkClick;
                            flpPartner.Controls.Add(pb);

                        }
                        break;
                    }
                case "V":
                    {
                        for (int i = 0; i < pl.lVevok.Count; i++)
                        {
                            PartnerButton pb = new PartnerButton();
                            pb.fPARTNER = (Partner)pl.lVevok[i];
                            //cb.Click += onCikkClick;
                            flpPartner.Controls.Add(pb);

                        }

                        break;
                    }       

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShadowLayer p = new frmShadowLayer();
            p.param = -1;
            p.ShowDialog();

        }


    }
}
