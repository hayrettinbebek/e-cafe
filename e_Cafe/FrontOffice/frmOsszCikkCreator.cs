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
using GUI.billentyu;
using NSpring.Logging;
using NSpring.Logging.EventFormatters;


namespace e_Cafe.FrontOffice
{
    public partial class frmOsszCikkCreator : Form
    {
        public Cikk AktSzerkesztettCikk = null;

        Cikkcsoport_list cl = new Cikkcsoport_list(CikkcsoportContructType.Full);
        Cikk_list lCikkList = new Cikk_list(CikkListContructType.ForRendeles);

        Object LastCikkcsopMenu;
        Object LastOtherFilterMenu;


        private static int CCSOP_BTN_SIZE = 60;
        private TableLayoutPanel tlpButtons;

        bool reset_scrolls;
        int CikkCsopScrollPos = 0;
        int MaxScroll = 0;
        int needScroll = 0;

        int Cikkek_ScrollPos = 0;
        int Cikkek_MaxScroll = 0;
        int Cikkek_needScroll = 0;


        int AlCsopScrollPos = 0;
        int Alcsop_MaxScroll = 0;
        int Alcsop_needScroll = 0;


        public frmOsszCikkCreator()
        {
            InitializeComponent();
        }

        #region Gombok
        private void btnKilep_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (needScroll < MaxScroll)
            {
                CikkCsopScrollPos--;

                CikkCsopScrollPos = Math.Max(CikkCsopScrollPos, 0);
                InitMenuButtons();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((needScroll + CikkCsopScrollPos) < MaxScroll)
            {
                CikkCsopScrollPos++;

                CikkCsopScrollPos = Math.Min(CikkCsopScrollPos, MaxScroll);

                InitMenuButtons();
            }
        }

        private void btnPrevCikk_Click(object sender, EventArgs e)
        {

            if (Cikkek_needScroll < Cikkek_MaxScroll)
            {
                Cikkek_ScrollPos -= ((flpCikkek.Width - 10) / DEFS.CIKK_BTN_SIZE.Width);

                Cikkek_ScrollPos = Math.Max(Cikkek_ScrollPos, 0);
                if (LastCikkcsopMenu != null) { VCikkcsopMenuClick(LastCikkcsopMenu, LastOtherFilterMenu, true, null); }
            }
        }

        private void btnNextCikk_Click(object sender, EventArgs e)
        {

            if (Cikkek_needScroll < Cikkek_MaxScroll)
            {
                Cikkek_ScrollPos += ((flpCikkek.Width - 10) / DEFS.CIKK_BTN_SIZE.Width);

                Cikkek_ScrollPos = Math.Min(Cikkek_ScrollPos, Cikkek_MaxScroll - Cikkek_needScroll);
                if (LastCikkcsopMenu != null) { VCikkcsopMenuClick(LastCikkcsopMenu, LastOtherFilterMenu, true, null); }
            }
        }

        private void btnAlcsopNext_Click(object sender, EventArgs e)
        {

            if ((Alcsop_needScroll + AlCsopScrollPos) < Alcsop_MaxScroll)
            {
                AlCsopScrollPos += Alcsop_needScroll;

                AlCsopScrollPos = Math.Min(AlCsopScrollPos, Alcsop_MaxScroll - Alcsop_needScroll);

                if (LastCikkcsopMenu != null) { VCikkcsopMenuClick(LastCikkcsopMenu, LastOtherFilterMenu, false, null); }
            }
        }

        private void btnAlcsopPrev_Click(object sender, EventArgs e)
        {

            //if ((Alcsop_needScroll + AlCsopScrollPos) < Alcsop_MaxScroll)
            //{
            AlCsopScrollPos -= Alcsop_needScroll;

            AlCsopScrollPos = Math.Max(AlCsopScrollPos, 0);
            if (LastCikkcsopMenu != null)
            {
                VCikkcsopMenuClick(LastCikkcsopMenu, LastOtherFilterMenu, false, null);
            }
            //}
        }

        private void VCikkcsopMenuClick(object sender, object senderAlcsop, bool r_scrolls, EventArgs e)
        {
            reset_scrolls = r_scrolls;
            CikkcsopMenuClick(sender, e);
            if (senderAlcsop != null) { AlcsopMenuClick(senderAlcsop, e); }
            reset_scrolls = true;
        }

        private void CikkcsopMenuClick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (AktSzerkesztettCikk != null)
                {
                    checkBox1.Text = ((CikkcsopButton)sender)._Cikkcsoport.NEV;
                    AktSzerkesztettCikk.CIKKCSOPORT_ID = ((CikkcsopButton)sender)._Cikkcsoport.ID;
                    AktSzerkesztettCikk.Save();
                }
                AktSzerkesztettCikk = new Cikk(AktSzerkesztettCikk.CIKK_ID, true);
                checkBox1.Checked = false;
                ((CikkcsopButton)sender).Checked = false;
                lblCikkcsopSelectInfo.Visible = false;
            }
            else
            {
                if (reset_scrolls)
                {
                    AlCsopScrollPos = 0;
                }



                LastCikkcsopMenu = sender;
                LastOtherFilterMenu = null;

                OTF_list otf = new OTF_list(((CikkcsopButton)sender)._Cikkcsoport.ID, new SqlConnection(DEFS.ConSTR));
                Alcsop_MaxScroll = otf.lOTF.Count;
                if (otf.lOTF.Count > 0)
                {
                    pnlOtherFilter.Visible = true;


                    TableLayoutPanel tlpOTFButtons = new TableLayoutPanel();

                    pnlOtherFilter.Controls.Add(tlpOTFButtons);
                    tlpOTFButtons.Dock = DockStyle.Fill;
                    tlpOTFButtons.BringToFront();
                    tlpOTFButtons.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

                    tlpOTFButtons.ColumnCount = otf.lOTF.Count + 1;
                    tlpOTFButtons.RowCount = 1;

                    for (int i = AlCsopScrollPos; i < (otf.lOTF.Count); i++)
                    {

                        OtherFButton bt = new OtherFButton(otf.lOTF[i]);
                        bt.Location = new Point(0, 0);
                        bt.Text = otf.lOTF[i].ONEV;
                        bt.TextAlign = ContentAlignment.TopCenter;
                        bt.Dock = DockStyle.Fill;
                        bt.Click += AlcsopMenuClick;

                        tlpOTFButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Absolute, 120));
                        tlpOTFButtons.Controls.Add(bt);
                    }
                    tlpOTFButtons.Refresh();
                }
                else { pnlOtherFilter.Visible = false;/* pnlOldalsav.Visible = false;*/ }

                if (pnlOtherFilter.Visible)
                {
                    //pnlOldalsav.Visible = true;
                    //pnlOldalsav.Height = ((CikkcsopButton)sender).Parent.Parent.Location.Y + ((CikkcsopButton)sender).Location.Y + ((CikkcsopButton)sender).Height - pnlOtherFilter.Height;
                }
                ((CikkcsopButton)sender).Refresh();
                loadCikkek(((CikkcsopButton)sender)._Cikkcsoport.ID, -1, null);
                //if (Call) { loadCikkek(((CikkcsopButton)sender)._Cikkcsoport.fCIKKCSOPORT_ID, -1); }

                Alcsop_needScroll = pnlOtherFilter.Width / 120;
            }
        }

        private void AlcsopMenuClick(object sender, EventArgs e)
        {

            LastOtherFilterMenu = sender;
            loadCikkek(((OtherFButton)sender)._OTF.CikkCsopID, ((OtherFButton)sender)._OTF.OID, null);
        }

        #endregion

        private void loadCikkek(int pCikkcsoport, int pAlcsoportId, string sFilter)
        {
            flpCikkek.Controls.Clear();
            //Cikk_list lCikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR),pCikkcsoport, true);
            List<Cikk> lButtons = new List<Cikk>();
            DEFS.log(Level.Debug, "LoadCikkek() " + pAlcsoportId.ToString() + " Cikkcsoport: " + pCikkcsoport.ToString());
            Cikkek_needScroll = (flpCikkek.Width / (DEFS.CIKK_BTN_SIZE.Width + 4)) * (flpCikkek.Height / (DEFS.CIKK_BTN_SIZE.Height + 4));
            if (sFilter != null)
            {
                lButtons = lCikkList.CikkFilter(sFilter);

            }
            else
                if (pCikkcsoport == -1)
                {

                    lButtons = lCikkList.CikkListByTOP();
                }
                else
                {

                    if (pAlcsoportId == -1)
                    {
                        if (pnlOtherFilter.Visible == true)
                        {
                            lButtons = lCikkList.CikkListByCsoportTOP(pCikkcsoport);
                        }
                        else
                        {
                            lButtons = lCikkList.CikkListByCsoport(pCikkcsoport);
                        }

                    }
                    else
                    {
                        lButtons = lCikkList.CikkListByAlcsoport(pCikkcsoport, pAlcsoportId);
                    }
                }

            int j = 0;
            for (int i = Cikkek_ScrollPos; i < lButtons.Count; i++)
            {
                if (++j <= Cikkek_needScroll)
                {
                    CikkButton cb = new CikkButton();
                    cb.fCIKK = lButtons[i];
                    //if (_isOsszetettCikViewer && !(lButtons[i].OSSZETETT))
                    //{
                    //    cb.Enabled = false;
                    //}
                    cb.Click += onCikkClick;

                    //cb.CIml = ilCikkek;
                    flpCikkek.Controls.Add(cb);
                }
            }

            Cikkek_MaxScroll = lButtons.Count;

            // lehetséges oszlopok * sorok



        }
        private void onCikkClick(object sender, EventArgs e)
        {
            if (AktSzerkesztettCikk != null)
            {
                AktSzerkesztettCikk.AddReceptTetel(((CikkButton)sender).fCIKK.CIKK_ID, ((CikkButton)sender).fCIKK.KISZ_MENNY);
                rECEPTTableAdapter.Fill(dsReceptCikkek.RECEPT, AktSzerkesztettCikk.CIKK_ID);
            }


        }

        private void frmOsszCikkCreator_Load(object sender, EventArgs e)
        {
            MaxScroll = cl.lCIKKCSOPORT.Count;
            needScroll = (pnlButtonPlace.Height - 100) / CCSOP_BTN_SIZE; // Convert.ToInt16(Math.Round((double)((pnlButtonPlace.Height - 100) / CCSOP_BTN_SIZE), 0));
            InitMenuButtons();
        }

        private void InitMenuButtons()
        {


            tlpButtons = new TableLayoutPanel();
            pnlButtonPlace.Controls.Add(tlpButtons);
            tlpButtons.BringToFront();
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            tlpButtons.RowCount = cl.lCIKKCSOPORT.Count + 1;


            int j = 0;
            for (int i = CikkCsopScrollPos; i < (cl.lCIKKCSOPORT.Count); i++)
            {
                if (j < needScroll)
                {
                    CikkcsopButton bt = new CikkcsopButton(cl.lCIKKCSOPORT[i]);
                    bt.Location = new Point(0, 0);
                    bt.Text = cl.lCIKKCSOPORT[i].NEV;
                    bt.TextAlign = ContentAlignment.BottomLeft;
                    bt.Dock = DockStyle.Fill;

                    bt.BackColor = Color.Transparent;
                    bt.Click += CikkcsopMenuClick;
                    //bt.ImageList = btmImgList;

                    bt.BackgroundImageLayout = ImageLayout.Stretch;

                    //bt.ImageIndex = 0;
                    tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, CCSOP_BTN_SIZE));
                    tlpButtons.Controls.Add(bt);
                    //bt.Invalidate();
                }
                j++;
            }
            //tlpButtons.AutoScroll = true;
            tlpButtons.Refresh();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = InputText.getString(true, textBox1.Text);
            if (AktSzerkesztettCikk == null)
            {
                AktSzerkesztettCikk = new Cikk(-1, textBox1.Text, 2, -1);
                AktSzerkesztettCikk.ERTEKESITES_TIPUSA = "D";
                AktSzerkesztettCikk.Save();
            }
            else
            {
                AktSzerkesztettCikk.MEGNEVEZES = textBox1.Text;
                AktSzerkesztettCikk.Save();

            }

            rECEPTTableAdapter.Fill(dsReceptCikkek.RECEPT, AktSzerkesztettCikk.CIKK_ID);
        }

        private void btnReceptek_Click(object sender, EventArgs e)
        {
            if (AktSzerkesztettCikk != null)
            {
                if (AktSzerkesztettCikk.ELADASI_AR < 0)
                {
                    DEFS.SendInfoMessage("Nem adott meg eladási árat!");
                }
                else if ((AktSzerkesztettCikk.CIKKCSOPORT_ID < 0))
                {
                    DEFS.SendInfoMessage("Nem rendelte cikkcsoporthoz!");
                }
                else if (dataRepeater1.ItemCount == 0)
                {
                    DEFS.SendInfoMessage("Nincsenek összetevők");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = InputText.getInt2(true).ToString();
            if (AktSzerkesztettCikk != null)
            {
                AktSzerkesztettCikk.ELADASI_AR = Convert.ToDouble(textBox2.Text);
                //AktSzerkesztettCikk.NETTO_AR = DEFS.getNetto(Convert.ToDouble(textBox2.Text), 20);

                AktSzerkesztettCikk.Save();

            }

            rECEPTTableAdapter.Fill(dsReceptCikkek.RECEPT, AktSzerkesztettCikk.CIKK_ID);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblCikkcsopSelectInfo.Visible = true;

            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = InputText.getString(true, textBox3.Text);
            loadCikkek(-1, -1, textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmTouchNumKeyboard ft = new frmTouchNumKeyboard(InputType.Number);
            //ft.every_key_close = true;


            //    while (ft.DialogResult != DialogResult.OK)
            //    {
            //        ft.defaultValue = label7.Text;
            //        ft.ShowDialog();

            //        label7.Text =  ft.ResultString;



            //    }





            int Parent_cikk_id = (int)((DataRowView)rECEPTBindingSource.Current)["OSSZ_CIKK_ID"];
            int load_cikk_id = (int)((DataRowView)rECEPTBindingSource.Current)["OSSZ_CIKK_TARTOZEK_ID"];

            double menny =  InputText.getDouble(false);

            receptTableAdapter1.Delete(Parent_cikk_id, load_cikk_id);
            receptTableAdapter1.Insert(Parent_cikk_id, load_cikk_id, Convert.ToDecimal(menny));

            rECEPTTableAdapter.Fill(dsReceptCikkek.RECEPT, AktSzerkesztettCikk.CIKK_ID);

        }

    }
}
