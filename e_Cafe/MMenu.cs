using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BusinessLogic;
using GUI;
using GUI.billentyu;


namespace e_Cafe
{
    public partial class MMenu : Form
    {
        
        clFIELDINFO_LIST FieldInfo;
        public static TBLObj blObj;
        Asztalok a;
        public  bool _Rendel;
        MainMenuBtn tlpButtons;

        private static int C_HELYEK_WIDTH = 150;
        private static int C_HELYEK_HEIGHT = 60;


        public string DebugMessage
        {
            set { label1.Text = value; }
        }


        public MMenu()
        {
            string s = System.IO.File.ReadAllText(@"ConnSTR.txt");
            EmailSending x = new EmailSending();

            //try
            //{
            //    if (System.IO.File.Exists(@"update.bat"))
            //    {
            //        System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //        //proc.EnableRaisingEvents = false;
            //        proc.StartInfo.UseShellExecute = false;
            //        proc.StartInfo.FileName = "update.bat";
            //        proc.Start();
            //        System.IO.File.Move("update.bat", "update_ok.bat");
            //        string l = System.IO.File.ReadAllText(@"output.log");
            //        x.send_mail(l);
            //    }
            //}
            //catch (Exception c)
            //{
                
            //    x.send_mail(c);
            //}

            //try
            //{

                DEFS.ConSTR = e_Cafe.Properties.Settings.Default.ECAFEConnectionString; // e_Cafe.Properties.Settings.Default.cnSTR;
                InitializeComponent();
                FieldInfo = new clFIELDINFO_LIST(DEFS.ConSTR);
                _Rendel = false;
            //}
            //catch (Exception c) {
                
            //    x.send_mail(c);
            //}

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goMainMenu(0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(Convert.ToDateTime(DateTime.Now).Hour) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Minute) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Second);
        }

        private void MMenu_Load(object sender, EventArgs e)
        {

            blObj = new TBLObj(-1, DEFS.ConSTR, FieldInfo);
            DEFS.LoadNyitottNap();

            initHelyek();
            Invalidate();

            MessageBox.Show("Nyitott nap:"+DEFS.NyitNap_EV.ToString() + DEFS.NyitNap_HO.ToString() + DEFS.NyitNap_NAP.ToString());
        }


        private void initHelyek()
        {
            Helyek cl = new Helyek(blObj);

            tlpButtons = new MainMenuBtn();

            //TableLayoutPanel tlpButtons = new TableLayoutPanel();
            tlpButtons.Location = new Point(panel8.Width+17, panel6.Height+panel7.Height);

            tlpButtons.Height = panel8.Height;
            tlpButtons.Width = C_HELYEK_WIDTH;
            //mf.Controls.Add(tlpButtons);
            pnlHelyek.Controls.Add(tlpButtons);
            //this.Controls.Add(tlpButtons);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tlpButtons.BringToFront();


            tlpButtons.RowCount = cl.lHelyek.Count + 1;
            
            for (int i = 0; i < (cl.lHelyek.Count); i++)
            {

                HelyButton bt = new HelyButton(cl.lHelyek[i]);
                
                bt.Location = new Point(0, 0);
                bt.Text = cl.lHelyek[i].fHELY_NEV;
                bt.TextAlign = ContentAlignment.BottomLeft;
                bt.Location = new Point(0, 0);
                bt.Width = C_HELYEK_WIDTH;
                bt.Height = C_HELYEK_HEIGHT;
                bt.Dock = DockStyle.Fill;
                bt.BackgroundImage = btmImgList.Images[0];
                bt.BackgroundImageLayout = ImageLayout.Stretch;
                //bt.ImageList = btmImgList;
                //bt.ImageIndex = 0;
                bt.HInit();


                bt.Click += HelyMenuClick;
                bt.CheckedChanged += HelyOnCheckedChanged;



                tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Absolute, C_HELYEK_HEIGHT));
                tlpButtons.Controls.Add(bt);
            }
            tlpButtons.Refresh();

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


        public void Asztal_click(object sender, EventArgs e)
        {

                Asztal_Button tmp_a = (Asztal_Button)sender;

            if (tmp_a.ClickTime >700) {
                a.aList.SelectAsztal(tmp_a.Asztal_id);
                tmp_a.vSelected = true;

                DebugMessage = tmp_a.Asztal_id.ToString() + tmp_a.vSelected.ToString();

                MRendeles mr = new MRendeles(a.aList.GetItem(tmp_a.Asztal_id), blObj);
                mr.ShowDialog();
                a.RefreshAsztalok(true);

                // Választó lista megjelenítése
                /*
                                if (!a.aList.isUsed(tmp_a.Asztal_id))
                                {

                    
                                    // ha szükség van előválaztóra!!
                                    TableActionSelect preAsk = new TableActionSelect("Asztal " + a.aList.GetItem(tmp_a.Asztal_id).fASZTAL_SZAM.ToString() + ": Válasszon feladatok!");
                                    preAsk.ShowDialog();
                                    if (preAsk.DialogResult == DialogResult.OK)
                                    {
                                        if (preAsk.pChoice == "R")
                                        {
                                            panel3.Controls.Clear();
                                            CikkValaszt cv = new CikkValaszt(panel3, blObj);
                                            panel3.Controls.Add(cv);
                                            cv.Dock = DockStyle.Fill;
                                            cv.InitCikkValaszt();
                            
                                        }
                                    }
                    


                                }
                                else 
                                { // A rendelések panel aktivizálása
                                    nr1.rtHeader.Text = tmp_a.Asztal_id.ToString() + ". asztal rendelései:";


                                }
                */
            }
            tlpButtons.BringToFront();
            tlpButtons.Invalidate();

        }
        public void goMainMenu(int aHelyId)
        {
            panel3.Controls.Clear();
            a = new Asztalok(panel3, blObj, aHelyId);
            a.RefreshAsztalok(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                AdminTools adm = new AdminTools(blObj);
                adm.ShowDialog();// = true;
            //}
            //catch (Exception c)
            //{
            //    EmailSending x = new EmailSending();
            //    x.send_mail(c);
            //}
            //adm.Show();
        }






        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            tlpButtons.Invalidate();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int t = 2;

                double g = 2101 / (t-2);

            }
            catch (Exception c)
            {
                EmailSending x = new EmailSending();
                x.send_mail(c);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TouchKeyboard tk = new TouchKeyboard();
            tk.ShowDialog();
            textBox1.Text = tk.txtRet.Text;
        }

        private void btnPartnerek_Click(object sender, EventArgs e)
        {
            Szallito s = new Szallito(1, new SqlConnection(DEFS.ConSTR));
            MessageBox.Show(s.ToString());
        }











    }
}
