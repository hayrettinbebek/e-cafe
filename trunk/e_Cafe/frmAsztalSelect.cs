using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;
using GUI;
using NSpring.Logging;

namespace e_Cafe
{
    public partial class frmAsztalSelect : Form
    {
        private static int C_HELYEK_WIDTH = 120;
        private static int C_HELYEK_HEIGHT = 60;
        MainMenuBtn tlpButtons;
        Asztalok a;

        public Asztal retA;

        public frmAsztalSelect()
        {
            InitializeComponent();
        }

        private void initHelyek()
        {
            Helyek cl = new Helyek();

            tlpButtons = new MainMenuBtn();

            //TableLayoutPanel tlpButtons = new TableLayoutPanel();
            tlpButtons.Location = new Point(panel8.Width + 17,  panel7.Height);

            tlpButtons.Height = panel8.Height;
            tlpButtons.Width = C_HELYEK_WIDTH;
            //mf.Controls.Add(tlpButtons);
            pnlHelyek.Controls.Add(tlpButtons);
            //this.Controls.Add(tlpButtons);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tlpButtons.BringToFront();


            tlpButtons.RowCount = cl.lHelyek.Count + 1;
            DEFS.log(Level.Debug, "Helyek betöltése");

            for (int i = 0; i < (cl.lHelyek.Count); i++)
            {

                HelyButton bt = new HelyButton(cl.lHelyek[i]);

                bt.Location = new Point(0, 0);
                bt.Text = cl.lHelyek[i].fHELY_NEV;
                bt.TextAlign = ContentAlignment.BottomLeft;
                bt.Location = new Point(0, 0);
                bt.Width = C_HELYEK_WIDTH;
                bt.Height = C_HELYEK_HEIGHT;
                bt.BackgroundImage = btmImgList.Images[0];
                bt.BackgroundImageLayout = ImageLayout.Stretch;

                bt.Dock = DockStyle.Fill;

                //bt.ImageList = btmImgList;
                //bt.ImageIndex = 0;
                //bt.HInit();


                bt.Click += HelyMenuClick;
                bt.CheckedChanged += HelyOnCheckedChanged;



                tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, C_HELYEK_HEIGHT));
                tlpButtons.Controls.Add(bt);
                DEFS.log(Level.Debug, "Hely:" + cl.lHelyek[i].fHELY_ID.ToString() + ":" + cl.lHelyek[i].fHELY_NEV.ToString() + ":" + cl.lHelyek[i].fHELY_VAN_KEP.ToString());
            }
            tlpButtons.Refresh();
            DEFS.log(Level.Debug, "Helyek inicializálása megtörtént");

        }
        private void HelyOnCheckedChanged(object sender, EventArgs e)
        {
            if (((HelyButton)sender).Checked)
            {
                ((HelyButton)sender).BackgroundImage = btmImgList.Images[1];
            }
            else { ((HelyButton)sender).BackgroundImage = btmImgList.Images[0]; }
        }

        private void HelyMenuClick(object sender, EventArgs e)
        {
            goMainMenu(((HelyButton)sender)._Hely.fHELY_ID);

            //this.Controls.SetChildIndex(tlpButtons, 0);
            tlpButtons.Invalidate();

        }

        public void goMainMenu(int aHelyId)
        {
            panel3.Controls.Clear();
            a = new Asztalok(true, panel3,  aHelyId);
            a.RefreshAsztalok(true);
        }

        public void Asztal_click(object sender, EventArgs e)
        {

            Asztal_Button tmp_a = (Asztal_Button)sender;
            retA = tmp_a.aObj;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void frmAsztalSelect_Load(object sender, EventArgs e)
        {
            initHelyek();
        }

       
    }


}
