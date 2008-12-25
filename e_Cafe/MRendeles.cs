using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

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

        private void InitMenuButtons()
        {
            Cikkcsoport_list cl = new Cikkcsoport_list(_bl);

            TableLayoutPanel tlpButtons = new TableLayoutPanel();
            pnlButtonPlace.Controls.Add(tlpButtons);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            tlpButtons.RowCount = (cl.lCIKKCSOPORT.Count * 2) - 1;
            
            int iSplitterCount= 0;

            for (int i = 0; i < (cl.lCIKKCSOPORT.Count); i++)
            {
                //tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, 40));
                //if ((i % 2) == 0)
                //{
                    
                    Button bt = new Button();
                    //bt.Image = b;
                    bt.Location = new Point(0, 0);
                    bt.Text = cl.lCIKKCSOPORT[i].fCIKKCSOPORT_NEV;
                    bt.TextAlign = ContentAlignment.BottomLeft;

                    bt.Dock = DockStyle.Fill;
                    tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, 60));
                    tlpButtons.Controls.Add(bt);
                    //iSplitterCount++;
                    

                //}
                //else
                //{
                    //Panel pn = new Panel();
                    //pn.Location = new Point(0, 0);
                    //pn.Height = 10;
                    //tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, 10));
                    //tlpButtons.Controls.Add(pn);
                    //pn.Dock = DockStyle.Fill;

                //}
            }
            tlpButtons.Refresh();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void dataRepeater1_ItemTemplate_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("fuck");
        }








    }
}
