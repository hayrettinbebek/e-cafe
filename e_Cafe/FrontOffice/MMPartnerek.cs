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
        public bool SelectMode = false;
        public double neededHitel = 0;
        public Partner SelectedPartner;

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
            loadPartnerek(((ButtonBase)sender).Tag.ToString());
        }

        private void loadPartnerek(string pPartnerType)
        {
            flpPartner.Controls.Clear();
            Partner_list pl = new Partner_list(new SqlConnection(DEFS.ConSTR));
            switch (pPartnerType)
            {
                case "T":
                    {
                        for (int i = 0; i < pl.lVevok.Count; i++)
                        {
                            if (((Partner)pl.lVevok[i]).P_TIPUS == pPartnerType)
                            {
                                PartnerButton pb = new PartnerButton();
                                pb.fPARTNER = (Partner)pl.lVevok[i];
                                pb.Click += ShowPartner;
                                flpPartner.Controls.Add(pb);
                            }

                        }
                        break;
                    }
                case "V":
                    {
                        for (int i = 0; i < pl.lVevok.Count; i++)
                        {
                            PartnerButton pb = new PartnerButton();
                            pb.fPARTNER = (Partner)pl.lVevok[i];
                            pb.Click += ShowPartner;
                            flpPartner.Controls.Add(pb);

                        }

                        break;
                    }       

            }

        }
        private void ShowPartner(object sender, EventArgs e)
        {
            if (SelectMode)
            {
                SelectedPartner = ((PartnerButton)sender).fPARTNER;
                if (SelectedPartner.HITEL_SZABAD >= neededHitel)
                {
                    DEFS.DebugLog("Partnernak van hitelkerete:" + SelectedPartner.PARTNER_ID.ToString());
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DEFS.SendInfoMessage("A kiválasztott partnernak nincs elegendő hitelkerete");
                }
            }
            else
            {
                frmShadowLayer p = new frmShadowLayer();
                p.param = ((PartnerButton)sender).fPARTNER.PARTNER_ID;
                p.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShadowLayer p = new frmShadowLayer();
            p.param = -1;
            p.ShowDialog();

        }

        private void MMPartnerek_Load(object sender, EventArgs e)
        {


            //btnKivalaszt.Visible = SelectMode;


        }



        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            if (SelectedPartner != null)
            {
                if (SelectedPartner.HITEL_SZABAD >= 0)
                {
                    DEFS.SendInfoMessage("kiválasztott ID:" + SelectedPartner.PARTNER_ID.ToString());
                    this.Close();
                }
            }
        }
    }
}
