using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using GUI;
using System.Resources;
using System.Data.SqlClient;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;
using e_Cafe.FrontOffice;
using NSpring.Logging;

namespace e_Cafe
{
    public partial class MRendeles : Form
    {
        Asztal _SelAsztal;
        bool _isOsszetettCikViewer;
        int _InactivityCounter;
        ResourceManager myResources;
        Object LastCikkcsopMenu;
        TableLayoutPanel tlpButtons;

        Cikk_list lCikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR), true);
        Rendeles _AktRendeles;

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

            InitMenuButtons();
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
            InitMenuButtons();

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion 




        #region Menü vezérélés
        private void InitMenuButtons()
        {
            Cikkcsoport_list cl = new Cikkcsoport_list(new SqlConnection(DEFS.ConSTR));

            tlpButtons = new TableLayoutPanel();
            pnlButtonPlace.Controls.Add(tlpButtons);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            tlpButtons.RowCount = cl.lCIKKCSOPORT.Count + 1;

            for (int i = 0; i < (cl.lCIKKCSOPORT.Count); i++)
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
                tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, 90));
                tlpButtons.Controls.Add(bt);
                //bt.Invalidate();
            }
            tlpButtons.AutoScroll = true;
            tlpButtons.Refresh();
        }


        private void CikkcsopMenuClick(object sender, EventArgs e)
        {
            
            resetCounter();
            bool Call;
            LastCikkcsopMenu = sender;

            OTF_list otf = new OTF_list(((CikkcsopButton)sender)._Cikkcsoport.ID, new SqlConnection(DEFS.ConSTR));
            if (otf.lOTF.Count > 0)
            {
                pnlOtherFilter.Visible = true;
                Call = false;

                TableLayoutPanel tlpOTFButtons = new TableLayoutPanel();

                pnlOtherFilter.Controls.Add(tlpOTFButtons);
                tlpOTFButtons.Dock = DockStyle.Fill;
                tlpOTFButtons.BringToFront();
                tlpOTFButtons.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

                tlpOTFButtons.ColumnCount = otf.lOTF.Count+1;
                tlpOTFButtons.RowCount = 1;

                for (int i = 0; i < (otf.lOTF.Count); i++)
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
            
        }

        private void AlcsopMenuClick(object sender, EventArgs e)
        {
            resetCounter();
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

            if (pAlcsoportId == -1)
            {
                lButtons = lCikkList.CikkListByCsoport(pCikkcsoport);
            }
            else
            {
                lButtons = lCikkList.CikkListByAlcsoport(pCikkcsoport, pAlcsoportId);
            }

            for (int i = 0; i < lButtons.Count; i++)
            {
                CikkButton cb = new CikkButton();
                cb.fCIKK = lButtons[i];
                if (_isOsszetettCikViewer && !(lButtons[i].OSSZETETT))
                {
                    cb.Enabled = false;
                }
                cb.Click += onCikkClick;
                if (lButtons[i].fKESZLET_ALL <= lButtons[i].OPTIMALIS_KESZLET)
                {
                    cb.BackgroundImage = global::GUI.Properties.Resources.piroson;
                }
                else
                {
                    cb.BackgroundImage = global::GUI.Properties.Resources.zoldon;
                }
                cb.BackgroundImageLayout = ImageLayout.Stretch;
                cb.BackColor = Color.Transparent;
                //cb.CIml = ilCikkek;
                flpCikkek.Controls.Add(cb);

            }

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
                if ((((CikkButton)sender).fCIKK.fKESZLET == 0) && (((CikkButton)sender).fCIKK.fKESZLET < ((CikkButton)sender).fCIKK.KISZ_MENNY))
                {
                    if (((CikkButton)sender).fCIKK.fKESZLET_ALL >= ((CikkButton)sender).fCIKK.KISZ_MENNY)
                    {
                        // nincs az alapértelmezett raktárban
                        ChooseKeszletek frm = new ChooseKeszletek(((CikkButton)sender).fCIKK.lKESZLET);
                        frm.ShowDialog(this);

                        if (frm.DialogResult == DialogResult.OK)
                        {

                            _AktRendeles.addTetel(((CikkButton)sender).fCIKK, frm.retRaktID);
                            _AktRendeles.SaveRendeles();
                            initRendelTabla();
                        }



                    }
                    else MessageBox.Show("Nincs elegendő készlet!!");
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
            if (LastCikkcsopMenu != null) { CikkcsopMenuClick(LastCikkcsopMenu,null); }
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            tblRendeles.ColumnModel = _AktRendeles.fColumnModel;

            tblRendeles.HeaderRenderer = new GradientHeaderRenderer();


            // feltöltés default értékkel
            tblRendeles.TableModel = _AktRendeles.getTableModel();
            tblRendeles.Font = DEFS.f2;
            tblRendeles.TableModel.RowHeight = 40;


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
        }

        private void tblRendeles_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {

            for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
            {
                tblRendeles.TableModel.Rows[i].Cells[0].Image = null;
            }

            foreach (var r in tblRendeles.SelectedItems)
            {
                r.Cells[0].Image = (Image)myResources.GetObject("OK_ICON");
            }


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

        #endregion



      
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (var s in tblRendeles.SelectedItems)
            {
                ((eCell)s.Cells[0]).rSor.DeleteSor();
            }
            _AktRendeles.SaveRendeles();
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            lCikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR), true);
            initRendelTabla();

            
            
        }

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
            mp.SelectMode = true;
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
            if (tblRendeles.SelectedItems.Length == 0)
            {
                for (int i = 0; i < tblRendeles.TableModel.Rows.Count; i++)
                {

                    tblRendeles.TableModel.Selections.AddCell(i, 0);
                }
            }
            foreach (var r in tblRendeles.SelectedItems)
            {
                ((eCell)r.Cells[0]).rSor.StornoSor();
            }
            _AktRendeles.SaveRendeles();
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);

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

            MMPartnerek mp = new MMPartnerek();
            mp.SelectMode = true;
            mp.neededHitel = 0;

            mp.ShowDialog();
            if (mp.DialogResult == DialogResult.OK)
            {
                // KP-s fizetés
                if (mp.SelectedPartner == null)
                {
                    szamla_fej_id = GenerateSzamlaFej(-99, _AktRendeles.fRENDELES_ID, fizmod);
                }
                else
                {
                    szamla_fej_id = GenerateSzamlaFej(mp.SelectedPartner.PARTNER_ID, _AktRendeles.fRENDELES_ID, fizmod);
                }
                if (szamla_fej_id != -1)
                {
                    foreach (var r in tblRendeles.SelectedItems)
                    {
                        AddSzlaTetel(szamla_fej_id, ((eCell)r.Cells[0]).rSor._SOR_ID);
                    }

                    frmReporting rep = new frmReporting();
                    rep.Szla_id = szamla_fej_id;
                    rep.ShowDialog();

                    DEFS.DebugLog("Rendelés fizetve");

                }
            }


            this.Close();
            

        }

        private int GenerateSzamlaFej(int partner_id, int rendeles_id, int p_fizmod)
        {
           
	        int retval = -1;

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdGenSzlaFej = new SqlCommand("sp_create_szamla_fej", c);
            cmdGenSzlaFej.CommandType = System.Data.CommandType.StoredProcedure;

            cmdGenSzlaFej.Parameters.Add("@p_partner_id", SqlDbType.Int);
            cmdGenSzlaFej.Parameters["@p_partner_id"].Direction = ParameterDirection.Input;
            cmdGenSzlaFej.Parameters["@p_partner_id"].Value = partner_id;

            cmdGenSzlaFej.Parameters.Add("@p_rendeles_id", SqlDbType.Int);
            cmdGenSzlaFej.Parameters["@p_rendeles_id"].Direction = ParameterDirection.Input;
            cmdGenSzlaFej.Parameters["@p_rendeles_id"].Value = rendeles_id;

            cmdGenSzlaFej.Parameters.Add("@p_fizmod", SqlDbType.Int);
            cmdGenSzlaFej.Parameters["@p_fizmod"].Direction = ParameterDirection.Input;
            cmdGenSzlaFej.Parameters["@p_fizmod"].Value = p_fizmod;

            cmdGenSzlaFej.Parameters.Add("@user_id", SqlDbType.Int);
            cmdGenSzlaFej.Parameters["@user_id"].Direction = ParameterDirection.Input;
            cmdGenSzlaFej.Parameters["@user_id"].Value = DEFS.LogInUser.USER_ID;
            

            cmdGenSzlaFej.Parameters.Add("@o_szamla_id", SqlDbType.Int);
            cmdGenSzlaFej.Parameters["@o_szamla_id"].Direction = ParameterDirection.Output;
            

            c.Open();
            cmdGenSzlaFej.ExecuteNonQuery();

            retval = (int)cmdGenSzlaFej.Parameters["@o_szamla_id"].Value;

            c.Close();

            return (retval);
        }

        private void AddSzlaTetel(int szla_fej_id, int sor_id)
        {

           

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdAddSzlaTetel = new SqlCommand("sp_add_szamla_tetel", c);
            cmdAddSzlaTetel.CommandType = System.Data.CommandType.StoredProcedure;

           
            cmdAddSzlaTetel.Parameters.Add("@p_szamla_fej_id", SqlDbType.Int);
            cmdAddSzlaTetel.Parameters["@p_szamla_fej_id"].Direction = ParameterDirection.Input;
            cmdAddSzlaTetel.Parameters["@p_szamla_fej_id"].Value = szla_fej_id;

            cmdAddSzlaTetel.Parameters.Add("@p_rendeles_sor_id", SqlDbType.Int);
            cmdAddSzlaTetel.Parameters["@p_rendeles_sor_id"].Direction = ParameterDirection.Input;
            cmdAddSzlaTetel.Parameters["@p_rendeles_sor_id"].Value = sor_id;

 
            c.Open();
            cmdAddSzlaTetel.ExecuteNonQuery();

        

            c.Close();

           
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










    }
}
