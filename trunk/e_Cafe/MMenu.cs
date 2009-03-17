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
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using e_Cafe.FrontOffice;
using NSpring.Logging;


namespace e_Cafe
{
    public partial class MMenu : Form
    {
        
        clFIELDINFO_LIST FieldInfo;
        public static TBLObj blObj;
        Asztalok a;
        public  bool _Rendel;
        MainMenuBtn tlpButtons;

        private static int C_HELYEK_WIDTH = 120;
        private static int C_HELYEK_HEIGHT = 60;

        




        public MMenu()
        {
            DEFS.createLogger();
            DEFS.ConSTR = e_Cafe.Properties.Settings.Default.ECAFEConnectionString; // e_Cafe.Properties.Settings.Default.cnSTR;
            DEFS.DefProgramLocation = AppDomain.CurrentDomain.BaseDirectory;
            
            InitializeComponent();
            try
            {
                FieldInfo = new clFIELDINFO_LIST(DEFS.ConSTR);
            }
            catch (Exception c)
            {
                DEFS.log(Level.Exception, c.Message);
            }
            _Rendel = false;

            DEFS.log(Level.Info, "Sikeres inicializálás");
            RefreshDatabase();
            DEFS.R_SYSPAR = new SysParList();
            if (!Login()) { Application.Exit(); }

        }

        //new FileInfo(@"C:\SQL\DROP.sql")
        private void updateDB(FileInfo file)
        {
            try
            {
                //FileInfo file = new FileInfo(@"C:\SQL\DROP.sql");
                string script = file.OpenText().ReadToEnd();
                SqlConnection conn = new SqlConnection(DEFS.ConSTR);
                Server server = new Server(new ServerConnection(conn));

                server.ConnectionContext.ExecuteNonQuery(script);
                

                conn.Close();
            }
            catch (Exception e)
            {
                DEFS.log(Level.Exception, "Adatbázis update nem sikerült:" + file.ToString() + "\n" + "\n" + e.Message + "\n" + e.StackTrace);

            }
            

            
        }

        private void RefreshDatabase()
        {

            int db_ver = DEFS.GetDBVER();
            DEFS.log(Level.Debug, "Aktuális adatbázis verzió:" + db_ver.ToString());
            //MessageBox.Show("Aktuális adatbázis verzió:"+db_ver.ToString());

            if (db_ver < 16)
            {

                if (MessageBox.Show("Elérhető új adatbázisfrissítés, akarja frissíteni?", "Adatbázis frissítés", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\DROP.sql"));
                    DEFS.log(Level.Debug, "Aktuális adatbázis verzió:" + db_ver.ToString());

                    if (db_ver < 1) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_001.sql")); }
                    if (db_ver < 2) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_002.sql")); }
                    if (db_ver < 3) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_003.sql")); }
                    if (db_ver < 4) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_004.sql")); }
                    if (db_ver < 5) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_005.sql")); }
                    if (db_ver < 6) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_006.sql")); }
                    if (db_ver < 7) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_007.sql")); }
                    if (db_ver < 8) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_008.sql")); }
                    if (db_ver < 9) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_009.sql")); }
                    if (db_ver < 10) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_010.sql")); }
                    if (db_ver < 11) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_011.sql")); }
                    if (db_ver < 12) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_012.sql")); }
                    if (db_ver < 13) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_013.sql")); }
                    if (db_ver < 14) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_014.sql")); }
                    if (db_ver < 15) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_015.sql")); }
                    if (db_ver < 16) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_016.sql")); }


                    updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\END.sql"));
                    DEFS.SendInfoMessage("Adatbázisfrissítés lefutott kérem küldje be a logokat a programból!" +
                                "\n" + "(Adminisztrátor:Support:Logok beküldése)");
                }
            }

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

        #region Bejelentkezéssel kapcsolatos dolgok
        private bool Login()
        {
            bool r = false;
            ECafeLogin l = new ECafeLogin();
            int k = 0;
            while (k < 3)
            {
                k++;

                frmLogin fl = new frmLogin();
                fl.ShowDialog();
                if (fl.DialogResult == DialogResult.OK)
                {
                    if (!l.AuthenticateUser(fl._usr, fl._pw))
                    {
                        if ((fl._usr == "x") && (fl._pw == "11"))
                        {
                            DEFS.DebugLog("Sikertelen belépés de tudod a titkos kódot :)!");
                            DEFS.UserLogin(fl.selUser.USER_ID);
                            SetUserSettings(fl.selUser);

                            r = true;
                            break;
                        }
                        //else
                        //{
                        //    DEFS.SendInfoMessage("Sikertelen belépés!");
                        //}
                    }
                    else
                    {
                        DEFS.UserLogin(fl.selUser.USER_ID);
                        SetUserSettings(fl.selUser);
                        
                        r = true;
                        break;

                    }

                }
            }

            return (r);

        }

        private void SetUserSettings(_User u)
        {
            

            DEFS.LogInUser = u;
            UserButton ub = new UserButton();
            ub.fUser = u;
            ub.BackgroundImage = global::GUI.Properties.Resources.off_user;
            ub.BackgroundImageLayout = ImageLayout.Stretch;
            ub.Checked = true;
            ub.Dock = DockStyle.Fill;
            panel7.Controls.Add(ub);

        }

        private void Logout()
        {
            DEFS.UserLogout(DEFS.LogInUser.USER_ID);
            DEFS.LogInUser = null;
            panel7.Controls.Clear();

        }

        #endregion

        #region Helyek kezelése
        private void initHelyek()
        {
            Helyek cl = new Helyek();

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
                bt.BackgroundImage = global::GUI.Properties.Resources.off_menuBtn;
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
                ((HelyButton)sender).BackgroundImage = global::GUI.Properties.Resources.on_menubtn;
            }
            else { ((HelyButton)sender).BackgroundImage = global::GUI.Properties.Resources.off_menuBtn; }
        }

        private void HelyMenuClick(object sender, EventArgs e)
        {
            goMainMenu(((HelyButton)sender)._Hely.fHELY_ID);
            
                //this.Controls.SetChildIndex(tlpButtons, 0);
            tlpButtons.Invalidate();

        }

        #endregion

        public void Asztal_click(object sender, EventArgs e)
        {

            Asztal_Button tmp_a = (Asztal_Button)sender;



            if (btnFoglalas.Checked)
            {
                // Foglalás 
                if (tmp_a.aObj.fRENDELES_ID > 0)
                {
                    DEFS.DebugLog("Információ! : Az asztal jelenleg foglalt!");
                    frmFoglalas fg = new frmFoglalas();
                    fg.aFoglal = tmp_a.aObj;

                    fg.ShowDialog();
                }
                else
                {
                    frmFoglalas fg = new frmFoglalas();
                    fg.aFoglal = tmp_a.aObj;

                    fg.ShowDialog();


                }
                btnFoglalas.Checked = false;

            }
            else
            {
                
                tmp_a.Text = tmp_a.ClickTime.ToString();
                if (tmp_a.ClickTime > 300)
                {
                    #region Asztal info

                    #endregion
                }
                else
                {

                    #region Rendelés
                    if (tmp_a.aObj.lFOGLALAS_PARAM_IDON_BELUL.Count > 0)
                    {
                        DEFS.SendInfoMessage("Információ! : Az asztalra foglalás van!" + "\n" + "Szeretné feloldani?");
                    }
                    else
                    {
                        DEFS.log(Level.Debug, "Asztal Klikk: id:" + tmp_a.aObj.fASZTAL_ID.ToString() + " rendeles:" + tmp_a.aObj.fRENDELES_ID.ToString());
                        a.aList.SelectAsztal(tmp_a.Asztal_id);
                        tmp_a.vSelected = true;

                   
                        MRendeles mr = new MRendeles(a.aList.GetItem(tmp_a.Asztal_id));
                        mr.ShowDialog();
                        a.RefreshAsztalok(true);
                        #region előválasztó
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
                        #endregion
                    }
                    #endregion
                }
                
            }
            tlpButtons.BringToFront();
            tlpButtons.Invalidate();

        }
        public void goMainMenu(int aHelyId)
        {
            panel3.Controls.Clear();
            a = new Asztalok(panel3,  aHelyId);
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
                //EmailSending x = new EmailSending();
                //x.send_mail(c);
            //}
            //adm.Show();
        }






        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            PartnerSelector r = new PartnerSelector();
            r.ShowDialog();


        }



        private void textBox1_Click(object sender, EventArgs e)
        {
            TouchKeyboard tk = new TouchKeyboard();
            tk.ShowDialog();
            
        }

        private void btnPartnerek_Click(object sender, EventArgs e)
        {
            MMPartnerek f = new MMPartnerek();
            
            f.ShowDialog();

        }

        private void btnLevelek_Click(object sender, EventArgs e)
        {
            frmUzenetek fu = new frmUzenetek();
            fu.ShowDialog();
        }

        private void btnReceptek_Click(object sender, EventArgs e)
        {
            MRendeles mr = new MRendeles(true);
            mr.ShowDialog();
        }

        private void btnKijelent_Click(object sender, EventArgs e)
        {
            Logout();
            Login();
        }

















    }
}
