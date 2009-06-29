using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.FrontOffice;
using e_Cafe.Reports;
using GUI;
using NSpring.Logging;
using XPTable.Renderers;

namespace e_Cafe
{
    public partial class MRendeles : Form
    {
        Asztal _SelAsztal;
        bool _isOsszetettCikViewer;
        bool reset_scrolls;
        int _InactivityCounter;
        ResourceManager myResources;
        Object LastCikkcsopMenu;
        Object LastOtherFilterMenu;
        TableLayoutPanel tlpButtons;
        Partner usedPartner = null;

        private static int CCSOP_BTN_SIZE = 60;

        Cikkcsoport_list cl = new Cikkcsoport_list(new SqlConnection(DEFS.ConSTR));

        Cikk_list lCikkList = new Cikk_list(CikkListContructType.ForRendeles);
        Rendeles _AktRendeles;

        int CikkCsopScrollPos = 0;
        int MaxScroll = 0;
        int needScroll = 0;

        int Cikkek_ScrollPos = 0;
        int Cikkek_MaxScroll = 0;
        int Cikkek_needScroll = 0;
        

        int AlCsopScrollPos = 0;
        int Alcsop_MaxScroll = 0;
        int Alcsop_needScroll = 0;

        #region Constructor
        public MRendeles(Asztal iAsztal)
        {
            System.Reflection.Assembly myAssembly;
            myAssembly = this.GetType().Assembly;
            myResources = new ResourceManager("e_Cafe.OtherImages", myAssembly);
            _isOsszetettCikViewer = false;
            InitializeComponent();
            _SelAsztal = iAsztal;
            
            //label1.Text = _SelAsztal.fASZTAL_SZAM + ". asztal";
            _InactivityCounter = 0;
            _AktRendeles = new Rendeles(_SelAsztal.fASZTAL_ID, _SelAsztal.fRENDELES_ID);



           
            initRendelTabla();

            
        }

        public MRendeles(bool OsszCikk)
        {
            System.Reflection.Assembly myAssembly;
            myAssembly = this.GetType().Assembly;
            myResources = new ResourceManager("e_Cafe.OtherImages", myAssembly);

            InitializeComponent();
            _isOsszetettCikViewer = OsszCikk;
            //label1.Text = _SelAsztal.fASZTAL_SZAM + ". asztal";
            _InactivityCounter = 0;
            pnlRendeles.Visible = false;
            pnlFunctions.Visible=false;
            

        }


        public MRendeles(Partner pPartner)
        {
            System.Reflection.Assembly myAssembly;
            myAssembly = this.GetType().Assembly;
            myResources = new ResourceManager("e_Cafe.OtherImages", myAssembly);
            _isOsszetettCikViewer = false;
            InitializeComponent();
            _SelAsztal = null;

            //label1.Text = _SelAsztal.fASZTAL_SZAM + ". asztal";
            _InactivityCounter = 0;
            _AktRendeles = new Rendeles(pPartner);




            initRendelTabla();


        }

        #endregion




        #region Inactivity tools

        private void pnlButtons_Click(object sender, EventArgs e)
        {
            resetCounter();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            resetCounter();
        }

        private void pnlRendeles_Click(object sender, EventArgs e)
        {
            resetCounter();
        }
        private void resetCounter()
        {
            _InactivityCounter = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_InactivityCounter == 50)
            {
                this.Close();
            }
            else { _InactivityCounter++; }
        }
        #endregion

        #region Gombok

        #region Átvitel
        private void button1_Click(object sender, EventArgs e)
        {
            frmAsztalSelect fa = new frmAsztalSelect();
            fa.ShowDialog();
            if (fa.DialogResult == DialogResult.OK)
            {
                Rendeles nr = new Rendeles(fa.retA.fASZTAL_ID, fa.retA.fRENDELES_ID);
                foreach (var s in tblRendeles.SelectedItems)
                {
                    nr.addTetel(((eCell)s.Cells[0]).rSor._Cikk);
                    ((eCell)s.Cells[0]).rSor.DeleteSor();
                }
                nr.SaveRendeles();

                _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);

                initRendelTabla();
            }
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if ((Alcsop_needScroll + AlCsopScrollPos) < Alcsop_MaxScroll)
            {
                AlCsopScrollPos += Alcsop_needScroll;

                AlCsopScrollPos = Math.Min(AlCsopScrollPos, Alcsop_MaxScroll - Alcsop_needScroll);

                if (LastCikkcsopMenu != null) { VCikkcsopMenuClick(LastCikkcsopMenu, LastOtherFilterMenu, false, null); }
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

        private void button9_Click(object sender, EventArgs e)
        {
            //if ((Alcsop_needScroll + AlCsopScrollPos) < Alcsop_MaxScroll)
            //{
                AlCsopScrollPos -= Alcsop_needScroll;

                AlCsopScrollPos = Math.Max(AlCsopScrollPos, 0);
                if (LastCikkcsopMenu != null) {
                        VCikkcsopMenuClick(LastCikkcsopMenu,LastOtherFilterMenu, false, null);
                }
            //}
        }


        #endregion 


        #region Menü vezérélés
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

        private void VCikkcsopMenuClick(object sender, object senderAlcsop, bool r_scrolls, EventArgs e)
        {
            reset_scrolls = r_scrolls;
            CikkcsopMenuClick(sender, e);
            if (senderAlcsop != null) { AlcsopMenuClick(senderAlcsop, e); }
            reset_scrolls = true;
        }

        private void CikkcsopMenuClick(object sender, EventArgs e)
        {
            if (reset_scrolls)
            {
                AlCsopScrollPos = 0;
            }

            resetCounter();
           
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

                tlpOTFButtons.ColumnCount = otf.lOTF.Count+1;
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
            loadCikkek(((CikkcsopButton)sender)._Cikkcsoport.ID, -1);
            //if (Call) { loadCikkek(((CikkcsopButton)sender)._Cikkcsoport.fCIKKCSOPORT_ID, -1); }

            Alcsop_needScroll = pnlOtherFilter.Width / 120;
            
        }

        private void AlcsopMenuClick(object sender, EventArgs e)
        {
            resetCounter();
            LastOtherFilterMenu = sender;
            loadCikkek(((OtherFButton)sender)._OTF.CikkCsopID, ((OtherFButton)sender)._OTF.OID);
        }

        #endregion

        #region Cikk betöltés
        private void loadCikkek(int pCikkcsoport, int pAlcsoportId)
        {
            flpCikkek.Controls.Clear();
            //Cikk_list lCikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR),pCikkcsoport, true);
            List<Cikk> lButtons = new List<Cikk>();
            DEFS.log(Level.Debug, "LoadCikkek() "+ pAlcsoportId.ToString() + " Cikkcsoport: " + pCikkcsoport.ToString());
            Cikkek_needScroll = (flpCikkek.Width / (DEFS.CIKK_BTN_SIZE.Width + 4)) * (flpCikkek.Height / (DEFS.CIKK_BTN_SIZE.Height + 4));

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
                    if (_isOsszetettCikViewer && !(lButtons[i].OSSZETETT))
                    {
                        cb.Enabled = false;
                    }
                    cb.Click += onCikkClick;

                    //cb.CIml = ilCikkek;
                    flpCikkek.Controls.Add(cb);
                }
            }

            Cikkek_MaxScroll = lButtons.Count;
            
            // lehetséges oszlopok * sorok
            


        }

        #endregion

        #region Cikk események

        private void onCikkClick(object sender, EventArgs e)
        {
            if (_isOsszetettCikViewer)
            {
                frmOsszCikkView fo = new frmOsszCikkView(((CikkButton)sender).fCIKK.CIKK_ID);
                fo.ShowDialog();
            }
            else
            {
                if (((((CikkButton)sender).fCIKK.fKESZLET == 0) && (((CikkButton)sender).fCIKK.fKESZLET < ((CikkButton)sender).fCIKK.KISZ_MENNY)) /*|| (DEFS.UserRights.HasRight("ALLOW_NEG_BOOK"))*/)
                {
                    if (((CikkButton)sender).fCIKK.fKESZLET_ALL >= ((CikkButton)sender).fCIKK.KISZ_MENNY) 
                    {
                        // nincs az alapértelmezett raktárban
                        ChooseKeszletek frm = new ChooseKeszletek(((CikkButton)sender).fCIKK.lKESZLET);
                        frm.needMenny = ((CikkButton)sender).fCIKK.KISZ_MENNY;
                        frm.ShowDialog(this);

                        if (frm.DialogResult == DialogResult.OK)
                        {
                            DEFS.doKeszletAtvezet(frm.retRaktID, ((CikkButton)sender).fCIKK.ALAP_RAKTAR, ((CikkButton)sender).fCIKK.CIKK_ID, frm.retMenny);
                            ((CikkButton)sender).fCIKK.getKeszlet();
                            ((CikkButton)sender).re_SetCikk();

                            _AktRendeles.addTetel(((CikkButton)sender).fCIKK);
                            _AktRendeles.SaveRendeles();
                            initRendelTabla();
                        }



                    }
                    else if (DEFS.UserRights.HasRight("ALLOW_NEG_BOOK"))
                    {
                        _AktRendeles.addTetel(((CikkButton)sender).fCIKK);
                        _AktRendeles.SaveRendeles();
                        ((CikkButton)sender).fCIKK.getKeszlet();
                        ((CikkButton)sender).re_SetCikk();
                        ((CikkButton)sender).Refresh();
                        initRendelTabla();
                    }


                    else
                    {
                        MessageBox.Show("Nincs elegendő készlet!!");
                    }
                }
                else
                {

                    _AktRendeles.addTetel(((CikkButton)sender).fCIKK);
                    _AktRendeles.SaveRendeles();
                    ((CikkButton)sender).fCIKK.getKeszlet();
                    ((CikkButton)sender).re_SetCikk();
                    ((CikkButton)sender).Refresh();
                    initRendelTabla();

                }
            }
        }

        #endregion


        #region Rendelés tábla

        private void initRendelTabla()
        {
            resetCounter();
            if (LastCikkcsopMenu != null) { VCikkcsopMenuClick(LastCikkcsopMenu, LastOtherFilterMenu, true, null); }
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            tblRendeles.ColumnModel = _AktRendeles.fColumnModel;

            tblRendeles.HeaderRenderer = new GradientHeaderRenderer();


            // feltöltés default értékkel
            tblRendeles.TableModel = _AktRendeles.getTableModel();
            tblRendeles.Font = DEFS.f2;
            tblRendeles.TableModel.RowHeight = 40;
            RendelTableSelectionRefresh();

            initSums();
            


        }

        private void initRendelTablaNoDraw()
        {
            resetCounter();
            //if (LastCikkcsopMenu != null) { CikkcsopMenuClick(LastCikkcsopMenu, null); }
            //_AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            tblRendeles.ColumnModel = _AktRendeles.fColumnModel;

            tblRendeles.HeaderRenderer = new GradientHeaderRenderer();


            // feltöltés default értékkel
            tblRendeles.TableModel = _AktRendeles.getTableModel();
            tblRendeles.Font = DEFS.f2;
            tblRendeles.TableModel.RowHeight = 40;
            RendelTableSelectionRefresh();
            initSums();
        }

        private void initRendelTablaSumNoDraw()
        {
            resetCounter();
            //if (LastCikkcsopMenu != null) { CikkcsopMenuClick(LastCikkcsopMenu, null); }
            //_AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            tblRendeles.ColumnModel = _AktRendeles.fColumnModelSum;

            tblRendeles.HeaderRenderer = new GradientHeaderRenderer();


            // feltöltés default értékkel
            tblRendeles.TableModel = _AktRendeles.getTableModelSum();
            tblRendeles.Font = DEFS.f2;
            tblRendeles.TableModel.RowHeight = 40;
            initSums();
        }

        private void RendelTableSelectionRefresh()
        {
            for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
            {
                tblRendeles.TableModel.Rows[i].Cells[0].Image = global::GUI.Properties.Resources.pipaoff;
            }



            foreach (var r in tblRendeles.SelectedItems)
            {
                r.Cells[0].Image = global::GUI.Properties.Resources.pipaon;
            }
            initSums();
        }

        private void tblRendeles_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            RendelTableSelectionRefresh();
        }

        private void tblRendeles_CellClick(object sender, XPTable.Events.CellMouseEventArgs e)
        {
            if (tblRendeles.TableModel.Selections.IsRowSelected(e.Row))
            {
                tblRendeles.TableModel.Selections.RemoveCell(e.Row, 0);
            }
            else
            {
                tblRendeles.TableModel.Selections.AddCell(e.Row, 0);
            }
        }


        #endregion

        #region Rendelés tábla kezelése
        private double selectionFizetendo()
        {
            double rTmp = 0;

            foreach (var r in tblRendeles.SelectedItems)
            {
                rTmp += ((eCell)r.Cells[0]).rSor._db * ((eCell)r.Cells[0]).rSor._Ertek;
            }
            return (rTmp);

        }

        private void btnDOWN_Click(object sender, EventArgs e)
        {
            if (_AktRendeles.lRendelesSor.Count > 9) { _AktRendeles._ScrollPos = Math.Min(_AktRendeles._ScrollPos + 1, _AktRendeles.lRendelesSor.Count - 9); }
            initRendelTablaNoDraw();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            if (_AktRendeles.lRendelesSor.Count > 9) { _AktRendeles._ScrollPos = Math.Max(_AktRendeles._ScrollPos - 1, 0); }
            initRendelTablaNoDraw();
        }
        
        //összeset kijelöl
        private void button8_Click(object sender, EventArgs e)
        {
            tblRendeles.TableModel.Selections.Clear();

            for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
            {

                tblRendeles.TableModel.Selections.AddCell(i, 0);
            }

        }
        // töröl
        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (var s in tblRendeles.SelectedItems)
            {
                ((eCell)s.Cells[0]).rSor.DeleteSor();
            }
            _AktRendeles.SaveRendeles();
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            lCikkList = new Cikk_list(CikkListContructType.ForRendeles);
            initRendelTabla();



        }

        private void initSums()
        {
            if (_AktRendeles != null)
            {

                if (_AktRendeles.KEDVEZMENY > 0)
                {
                    lblKedvText.Visible = true;
                    lblKedvValue.Visible = true;
                    lblFizetValue.Visible = true;
                    lblFizetText.Visible = true;
                }


                if (tblRendeles.SelectedItems.Length > 0)
                {
                    double tmpOssz = 0;
                    double tmpKedv = 0;

                    foreach (var s in tblRendeles.SelectedItems)
                    {
                        tmpOssz += ((eCell)s.Cells[0]).rSor._Ertek;
                        tmpKedv += ((eCell)s.Cells[0]).rSor.KEDVEZMENY;
                    }
                    lblKedvValue.Text = tmpKedv.ToString("# ##0");
                    lblOsszValue.Text = tmpOssz.ToString("# ##0");
                    lblFizetValue.Text = (tmpOssz - tmpKedv).ToString("# ##0");

                }
                else
                {
                    lblKedvValue.Text = _AktRendeles.KEDVEZMENY.ToString("# ##0");
                    lblOsszValue.Text = _AktRendeles.OSSZESEN.ToString("# ##0");
                    lblFizetValue.Text = _AktRendeles.FIZETENDO.ToString("# ##0");
                }

            }
            else
            {
                lblKedvText.Visible = false;
                lblKedvValue.Visible = false;
                lblFizetValue.Visible = false;
                lblFizetText.Visible = false;
            }
            


        }
        #endregion



      
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

 

        private void rbOsszetett_CheckedChanged(object sender, EventArgs e)
        {
            initRendelTablaSumNoDraw();
        }

        private void rbReszletes_CheckedChanged(object sender, EventArgs e)
        {
            initRendelTablaNoDraw();
        }

        #region Hitel
        private void btnHitel_Click(object sender, EventArgs e)
        {
            if (tblRendeles.SelectedItems.Length == 0)
            {
                for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
                {

                    tblRendeles.TableModel.Selections.AddCell(i, 0);
                }
            }

            MMPartnerek mp = new MMPartnerek();
            mp.SelectMode = PartnerSelectModes.hitelhez;
            mp.neededHitel = selectionFizetendo();

            mp.ShowDialog();
            if (mp.DialogResult == DialogResult.OK)
            {

                foreach (var r in tblRendeles.SelectedItems)
                {
                    SetHitel(mp.SelectedPartner.PARTNER_ID,((eCell)r.Cells[0]).rSor._SOR_ID);
                }
                DEFS.DebugLog("Rendelés hitellel fizetve");
                

            }
            this.Close();



        }

        private void SetHitel(int partner_id, int sor_id)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdHitelToPartner = new SqlCommand("sp_addRendeles_to_Hitel", c);
            cmdHitelToPartner.CommandType = System.Data.CommandType.StoredProcedure;

            cmdHitelToPartner.Parameters.Add("@p_partner_id", SqlDbType.Int);
            cmdHitelToPartner.Parameters["@p_partner_id"].Direction = ParameterDirection.Input;
            cmdHitelToPartner.Parameters["@p_partner_id"].Value = partner_id;

            cmdHitelToPartner.Parameters.Add("@rendel_sor_id", SqlDbType.Int);
            cmdHitelToPartner.Parameters["@rendel_sor_id"].Direction = ParameterDirection.Input;
            cmdHitelToPartner.Parameters["@rendel_sor_id"].Value = sor_id;
            

            c.Open();
            cmdHitelToPartner.ExecuteNonQuery();
            c.Close();
        }
        #endregion

        #region Stornózás
        private void button2_Click(object sender, EventArgs e)
        {
            int szamla_fej_id = -1;
            if (tblRendeles.SelectedItems.Length == 0)
            {
                for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
                {

                    tblRendeles.TableModel.Selections.AddCell(i, 0);
                }
            }

            szamla_fej_id = DEFS.GenerateSzamlaFej(-99, _AktRendeles.fRENDELES_ID, 9);
            if (szamla_fej_id != -1)
            {
                foreach (var r in tblRendeles.SelectedItems)
                {
                    DEFS.AddSzlaTetel(szamla_fej_id, ((eCell)r.Cells[0]).rSor._SOR_ID);
                    DEFS.AddStornoSzlaTetel(szamla_fej_id, ((eCell)r.Cells[0]).rSor._SOR_ID);

                    ((eCell)r.Cells[0]).rSor.StornoSor();

                }
                _AktRendeles.SaveRendeles();
                _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);

                doPrinting dp = new doPrinting();
                dp.setReportMaker(new BlokkReport(szamla_fej_id));
                dp.doPrint();

            }
            initRendelTabla();
            DEFS.DebugLog("Rendelés sztornózva");
            this.Close();
        }

        #endregion

        #region Számlázás
        private void button3_Click(object sender, EventArgs e)
        {
            Fizetes((int)Fizmond.Keszpenz);
        }

        private void Fizetes(int fizmod)
        {
            int szamla_fej_id = -1;
            if (tblRendeles.SelectedItems.Length == 0)
            {
                for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
                {

                    tblRendeles.TableModel.Selections.AddCell(i, 0);
                }
            }
            // PArtner választás nem szükséges csak HITELNÉL
            //MMPartnerek mp = new MMPartnerek();
            //mp.SelectMode = true;
            //mp.neededHitel = 0;

            ////mp.ShowDialog();
            //if (mp.DialogResult == DialogResult.OK)
            //{
                // KP-s fizetés
                //if (mp.SelectedPartner == null)
                //{
                    szamla_fej_id = DEFS.GenerateSzamlaFej(-99, _AktRendeles.fRENDELES_ID, fizmod);
                //}
                //else
                //{
                //    szamla_fej_id = DEFS.GenerateSzamlaFej(mp.SelectedPartner.PARTNER_ID, _AktRendeles.fRENDELES_ID, fizmod);
                //}
                if (szamla_fej_id != -1)
                {
                    foreach (var r in tblRendeles.SelectedItems)
                    {
                        DEFS.AddSzlaTetel(szamla_fej_id, ((eCell)r.Cells[0]).rSor._SOR_ID);
                    }

                    doPrinting dp = new doPrinting();
                    dp.setReportMaker(new BlokkReport(szamla_fej_id));
                    dp.doPrint();

                    DEFS.DebugLog("Rendelés fizetve");

                }
            //}


            this.Close();
            

        }

       
        

        private void button6_Click(object sender, EventArgs e)
        {
            Fizetes((int)Fizmond.Utalvany);
        }

        #endregion

        private void button11_Click(object sender, EventArgs e)
        {

            tlpButtons.AutoScrollPosition = new Point(900,60);
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

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (needScroll < MaxScroll)
            {
                CikkCsopScrollPos++;

                CikkCsopScrollPos = Math.Min(CikkCsopScrollPos, MaxScroll);

                InitMenuButtons();
            }
        }

        private void MRendeles_Load(object sender, EventArgs e)
        {
            MaxScroll = cl.lCIKKCSOPORT.Count;
            needScroll = (pnlButtonPlace.Height - 100) / CCSOP_BTN_SIZE; // Convert.ToInt16(Math.Round((double)((pnlButtonPlace.Height - 100) / CCSOP_BTN_SIZE), 0));
            InitMenuButtons();
            loadCikkek(-1, -1);


        }

        private void flpCikkek_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MRendeles_FormClosed(object sender, FormClosedEventArgs e)
        {
            DEFS.doRepairTables();
        }

        private void btnKedv_Click(object sender, EventArgs e)
        {
            frmShadowLayer p = new frmShadowLayer(UsingForms.KedvezmenyValaszt);
            
            p.ShowDialog();

            if (p.ke != null)
            {
                if (p.ke.SZAZALEK > 0)
                {
                    int tmpszaz = p.ke.SZAZALEK;
                    if (tblRendeles.SelectedItems.Length > 0)
                    {
                        foreach (var s in tblRendeles.SelectedItems)
                        {
                            ((eCell)s.Cells[0]).rSor.addKedvezmSzaz(tmpszaz);
                            if (p.ke._Partner != null)
                            {
                                ((eCell)s.Cells[0]).rSor._KEDV_PARTNER_ID = p.ke._Partner.PARTNER_ID;

                            }
                            else
                            {
                                ((eCell)s.Cells[0]).rSor._KEDV_PARTNER_ID = -1;
                            }
                                
                        }
                    }
                    else
                    {
                        _AktRendeles.addKedvezmSzaz(tmpszaz);
                        if (p.ke._Partner != null)
                        {
                            _AktRendeles.fPARTNER_ID = p.ke._Partner.PARTNER_ID;
                        }
                        else
                        {
                            _AktRendeles.fPARTNER_ID = -1;
                        }
                    }
                }
                else if (p.ke.ERTEK > 0)
                {
                    double tmpFt = p.ke.ERTEK;
                    if (tblRendeles.SelectedItems.Length > 0)
                    {
                        double tmpValue = 0;
                        foreach (var s in tblRendeles.SelectedItems)
                        {
                            tmpValue += ((eCell)s.Cells[0]).rSor._Ertek;
                        }

                        foreach (var s in tblRendeles.SelectedItems)
                        {
                            if (tmpValue == 0)
                            {
                                ((eCell)s.Cells[0]).rSor.addKedvezmFt(0);
                            }
                            else
                            {
                                ((eCell)s.Cells[0]).rSor.addKedvezmFt((tmpFt * ((eCell)s.Cells[0]).rSor._Ertek) / tmpValue);
                            }
                        }
                    }
                    else
                    {
                        _AktRendeles.addKedvezmFt(tmpFt);

                    }
                }
                _AktRendeles.SaveRendeles();
                
                initSums();
            }

            
            
        }











    }
}
