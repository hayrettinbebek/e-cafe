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

namespace e_Cafe
{
    public partial class MRendeles : Form
    {
        Asztal _SelAsztal;
        TBLObj _bl;
        int _InactivityCounter;

        #region Constructor
        public MRendeles(Asztal iAsztal, TBLObj iConn)
        {
            InitializeComponent();
            _SelAsztal = iAsztal;
            _bl = iConn;
            label1.Text = _SelAsztal.fASZTAL_SZAM + ". asztal";
            _InactivityCounter = 0;
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

        private void InitMenuButtons()
        {
            Cikkcsoport_list cl = new Cikkcsoport_list(_bl);

            TableLayoutPanel tlpButtons = new TableLayoutPanel();
            pnlButtonPlace.Controls.Add(tlpButtons);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            tlpButtons.RowCount = cl.lCIKKCSOPORT.Count+1;
            
            for (int i = 0; i < (cl.lCIKKCSOPORT.Count); i++)
            {

                CikkcsopButton bt = new CikkcsopButton(cl.lCIKKCSOPORT[i]);
                bt.Location = new Point(0, 0);
                bt.Text = cl.lCIKKCSOPORT[i].fCIKKCSOPORT_NEV;
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


        #endregion 


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CikkcsopMenuClick(object sender, EventArgs e)
        {

            bool Call = true;

            OTF_list otf = new OTF_list(((CikkcsopButton)sender)._Cikkcsoport.fCIKKCSOPORT_ID, _bl);
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
                    bt.Text = otf.lOTF[i].fOTHER_NAME;
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

            if (Call) { loadCikkek(((CikkcsopButton)sender)._Cikkcsoport.fCIKKCSOPORT_ID, -1); }
        }

        private void AlcsopMenuClick(object sender, EventArgs e)
        {
            loadCikkek(((OtherFButton)sender)._OTF.fCIKKCSOPORT_ID, ((OtherFButton)sender)._OTF.fOTF_ID);
        }

        private void loadCikkek(int pCikkcsoport, int pAlcsoportId)
        {
            Cikk_list lCikkList = new Cikk_list(_bl);
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
                flpCikkek.Controls.Add(cb);

            }

        }

        private void dataRepeater1_ItemTemplate_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("fuck");
        }








    }
}
