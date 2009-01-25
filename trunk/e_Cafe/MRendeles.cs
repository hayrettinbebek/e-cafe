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

namespace e_Cafe
{
    public partial class MRendeles : Form
    {
        Asztal _SelAsztal;
        TBLObj _bl;
        int _InactivityCounter;
        ResourceManager myResources;

        Rendeles _AktRendeles;

        #region Constructor
        public MRendeles(Asztal iAsztal, TBLObj iConn)
        {
            System.Reflection.Assembly myAssembly;
            myAssembly = this.GetType().Assembly;
            myResources = new ResourceManager("e_Cafe.OtherImages", myAssembly);

            InitializeComponent();
            _SelAsztal = iAsztal;
            _bl = iConn;
            label1.Text = _SelAsztal.fASZTAL_SZAM + ". asztal";
            _InactivityCounter = 0;
            _AktRendeles = new Rendeles(_bl, _SelAsztal.fASZTAL_ID, _SelAsztal.fRENDELES_ID);

            InitMenuButtons();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion 




        #region Menü vezérélés
        private void InitMenuButtons()
        {
            Cikkcsoport_list cl = new Cikkcsoport_list(new SqlConnection(DEFS.ConSTR));

            TableLayoutPanel tlpButtons = new TableLayoutPanel();
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
                bt.ImageList = btmImgList;
                bt.ImageIndex = 0;
                tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, 70));
                tlpButtons.Controls.Add(bt);
                //bt.Invalidate();
            }
            tlpButtons.Refresh();
        }


        private void CikkcsopMenuClick(object sender, EventArgs e)
        {
            resetCounter();
            bool Call = true;

            OTF_list otf = new OTF_list(((CikkcsopButton)sender)._Cikkcsoport.fCIKKCSOPORT_ID, new SqlConnection(DEFS.ConSTR));
            if (otf.lOTF.Count > 0)
            {
                pnlOtherFilter.Visible = true;
                Call = false;

                TableLayoutPanel tlpOTFButtons = new TableLayoutPanel();

                pnlOtherFilter.Controls.Add(tlpOTFButtons);
                tlpOTFButtons.Dock = DockStyle.Fill;
                tlpOTFButtons.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

                tlpOTFButtons.ColumnCount = otf.lOTF.Count+1;
                tlpOTFButtons.RowCount = 1;

                for (int i = 0; i < (otf.lOTF.Count); i++)
                {

                    OtherFButton bt = new OtherFButton(otf.lOTF[i]);
                    bt.Location = new Point(0, 0);
                    bt.Text = otf.lOTF[i].ONEV;
                    bt.TextAlign = ContentAlignment.BottomLeft;
                    bt.Dock = DockStyle.Fill;
                    bt.Click += AlcsopMenuClick;
                    
                    tlpOTFButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Absolute, 120));
                    tlpOTFButtons.Controls.Add(bt);
                }
                tlpOTFButtons.Refresh();
            }
            else { pnlOtherFilter.Visible = false; pnlOldalsav.Visible = false; }

            if (pnlOtherFilter.Visible)
            {
                pnlOldalsav.Visible = true;
                pnlOldalsav.Height = ((CikkcsopButton)sender).Parent.Parent.Location.Y + ((CikkcsopButton)sender).Location.Y + ((CikkcsopButton)sender).Height - pnlOtherFilter.Height;
            }
            ((CikkcsopButton)sender).Refresh();
            loadCikkek(((CikkcsopButton)sender)._Cikkcsoport.fCIKKCSOPORT_ID, -1);
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
            Cikk_list lCikkList = new Cikk_list(new SqlConnection(DEFS.ConSTR));
            List<Cikk> lButtons = new List<Cikk>();
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
                cb.Click += onCikkClick;
                flpCikkek.Controls.Add(cb);

            }

        }

        #endregion

        #region Cikk események

        private void onCikkClick(object sender, EventArgs e)
        {

            _AktRendeles.addTetel(((CikkButton)sender).fCIKK);
            initRendelTabla();
        }

        #endregion

        private void dataRepeater1_ItemTemplate_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("fuck");
        }

        #region Rendelés tábla

        private void initRendelTabla()
        {
            resetCounter();
            tblRendeles.ColumnModel = _AktRendeles.fColumnModel;

            tblRendeles.HeaderRenderer = new GradientHeaderRenderer();


            // feltöltés default értékkel
            tblRendeles.TableModel = _AktRendeles.getTableModel();
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

        #endregion



        private void tblRendeles_CellClick(object sender, XPTable.Events.CellMouseEventArgs e)
        {
            if (tblRendeles.TableModel.Selections.IsRowSelected(e.Row)) {
                tblRendeles.TableModel.Selections.RemoveCell(e.Row, 0);
            } else {
            tblRendeles.TableModel.Selections.AddCell(e.Row, 0);
            }
        }

        private void btnDOWN_Click(object sender, EventArgs e)
        {
            if (_AktRendeles.lRendelesSor.Count > 9) { _AktRendeles._ScrollPos = Math.Min(_AktRendeles._ScrollPos + 1, _AktRendeles.lRendelesSor.Count-9); }
            initRendelTabla();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            if (_AktRendeles.lRendelesSor.Count > 9) { _AktRendeles._ScrollPos = Math.Max(_AktRendeles._ScrollPos-1,0); }
            initRendelTabla();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _AktRendeles.SaveRendeles();
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);
            
            initRendelTabla();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var s in tblRendeles.SelectedItems)
            {
                ((eCell)s.Cells[0]).rSor.DeleteSor();
            }
            _AktRendeles.InitRendeles(_AktRendeles.fRENDELES_ID);

            initRendelTabla();
            
            
        }














    }
}
