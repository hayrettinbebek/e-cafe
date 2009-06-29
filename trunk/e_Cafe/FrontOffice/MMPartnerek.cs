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
    public enum PartnerSelectModes
    {
        hitelhez,
        Kedvezmeny,
        edit
    }
    public partial class MMPartnerek : Form
    {
        public PartnerSelectModes SelectMode = PartnerSelectModes.hitelhez;
        public double neededHitel = 0;
        public Partner SelectedPartner;

        private string last_selected = "";

        public MMPartnerek()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            last_selected = ((ButtonBase)sender).Tag.ToString();
            loadPartnerek(((ButtonBase)sender).Tag.ToString());

            if (((RadioButton)sender).Checked)
            {
                ((RadioButton)sender).BackgroundImage = global::GUI.Properties.Resources.on_menubtn;
            }
            else
            {
                ((RadioButton)sender).BackgroundImage = global::GUI.Properties.Resources.off_menuBtn;
            }
        }


        private void SetUserSettings()
        {

            panel5.Controls.Clear();
                       
            UserButton ub = new UserButton();
            ub.fUser = DEFS.LogInUser;
            
            ub.BackgroundImage = global::GUI.Properties.Resources.off_user;
            ub.BackgroundImageLayout = ImageLayout.Stretch;
            ub.Checked = true;
            ub.Dock = DockStyle.Fill;
            panel5.Controls.Add(ub);

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
                                pb.pnlRendel.Click += RendelToPartner;
                                if (((Partner)pl.lVevok[i]).RENDELES_ID > 0)
                                {
                                    pb.VAN_RENDEL = true;
                                }
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
                            if (((Partner)pl.lVevok[i]).RENDELES_ID > 0)
                            {
                                pb.VAN_RENDEL = true;
                            }
                            pb.pnlRendel.Click += RendelToPartner;
                            flpPartner.Controls.Add(pb);

                        }

                        break;
                    }       

            }

        }

        private void RendelToPartner(object sender, EventArgs e)
        {
            SelectedPartner = ((PartnerButton)((Panel)sender).Parent).fPARTNER;
           
            MRendeles mr = new MRendeles(SelectedPartner);
            mr.ShowDialog();

            loadPartnerek(last_selected);

        }
        private void ShowPartner(object sender, EventArgs e)
        {
            switch (SelectMode)
            {
                case PartnerSelectModes.hitelhez:
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

                        break;
                    }
                case PartnerSelectModes.Kedvezmeny:
                    {
                        SelectedPartner = ((PartnerButton)sender).fPARTNER;
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    }
                case PartnerSelectModes.edit:
                    {
                        frmShadowLayer p = new frmShadowLayer(UsingForms.PartnerInsert);
                        p.param = ((PartnerButton)sender).fPARTNER.PARTNER_ID;
                        p.ShowDialog();

                        break;
                    }
                default:
                    break;
            }
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShadowLayer p = new frmShadowLayer(UsingForms.PartnerInsert);
            p.param = -1;
            p.ShowDialog();

        }

        private void MMPartnerek_Load(object sender, EventArgs e)
        {


            btnPartnerNelkul.Visible = (SelectMode == PartnerSelectModes.edit);
            SetUserSettings();

        }



        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            if (SelectedPartner != null)
            {
                if (SelectedPartner.HITEL_SZABAD >= 0)
                {
                    DEFS.SendShortMessage("kiválasztott ID:" + SelectedPartner.PARTNER_ID.ToString(),500);
                    this.Close();
                }
            }
        }

        private void btnPartnerNelkul_Click(object sender, EventArgs e)
        {
            SelectedPartner = null;
            DialogResult = DialogResult.OK;
        }
    }
}
