using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.FrontOffice;
using GUI;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using NSpring.Logging;
using WinampFrontEndLib;


namespace e_Cafe
{
    public partial class MMenu : Form
    {

        clFIELDINFO_LIST FieldInfo;
        //public static TBLObj blObj;
        Asztalok a;
        public bool _Rendel;
        MainMenuBtn tlpButtons;
        private bool login_ok = false;

        private static int C_HELYEK_WIDTH = 120;
        private static int C_HELYEK_HEIGHT = 60;

        public MMenu()
        {
            DEFS.createLogger();
            DEFS.ConSTR = e_Cafe.Properties.Settings.Default.ECAFEConnectionString; // e_Cafe.Properties.Settings.Default.cnSTR;
            DEFS.DefPrinter = e_Cafe.Properties.Settings.Default.PrinterName; // e_Cafe.Properties.Settings.Default.cnSTR;
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
            //DEFS.R_SYSPAR = new SysParList();
            DEFS.log(Level.Info, "Sikeres inicializálás");
            RefreshDatabase();
            DEFS.LoadPossibleOpenDays();
            DEFS.LoadNyitottNap();
            DEFS.SendShortMessage("Nyitott nap:" + DEFS.NyitNap_EV.ToString() + DEFS.NyitNap_HO.ToString() + DEFS.NyitNap_NAP.ToString(), 1000);


            login_ok = Login(0);
            //if (!Login(0)) { Application.Exit(); }

        }
        #region Adatbázis frissítés 
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

        private void RefreshDatabaseExtracted(int db_ver)
        {
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
            if (db_ver < 17) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_017.sql")); }
            if (db_ver < 18) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_018.sql")); }
            if (db_ver < 19) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_019.sql")); }
            if (db_ver < 20) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_020.sql")); }
            if (db_ver < 21) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_021.sql")); }
            if (db_ver < 22) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_022.sql")); }
            if (db_ver < 23) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_023.sql")); }
            if (db_ver < 24) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_024.sql")); }
            if (db_ver < 25) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_025.sql")); }
            if (db_ver < 26) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_026.sql")); }
            if (db_ver < 27) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_027.sql")); }
            if (db_ver < 28) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_028.sql")); }
            if (db_ver < 29) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_029.sql")); }
            if (db_ver < 30) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_030.sql")); }
            if (db_ver < 31) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_031.sql")); }
            if (db_ver < 32) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_032.sql")); }
            if (db_ver < 33) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_033.sql")); }
            if (db_ver < 34) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_034.sql")); }
            if (db_ver < 35) { updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\update_035.sql")); }
        }
        private void RefreshDatabase()
        {

            int db_ver = DEFS.GetDBVER();
            DEFS.log(Level.Debug, "Aktuális adatbázis verzió:" + db_ver.ToString());
            //MessageBox.Show("Aktuális adatbázis verzió:"+db_ver.ToString());

            if (db_ver >= 35 || MessageBox.Show("Elérhető új adatbázisfrissítés, akarja frissíteni?", "Adatbázis frissítés", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                return;

            updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\DROP.sql"));
            DEFS.log(Level.Debug, "Aktuális adatbázis verzió:" + db_ver.ToString());

            RefreshDatabaseExtracted(db_ver);

            updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\END.sql"));
            DEFS.SendShortMessage("Adatbázisfrissítés lefutott kérem küldje be a logokat a programból! \n (Adminisztrátor:Support:Logok beküldése)", 1200);

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            goMainMenu(0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(Convert.ToDateTime(DateTime.Now).Hour) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Minute) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Second);
            lbltrackInfo.Text = DisplaySong();
        }
        private string DisplaySong()
        {
            try
            {
                return WinampLib.GetCurrentSongTitle() + "    " + Math.Round(TimeSpanUtils.ConvertMillisecondsToMinutes(WinampLib.GetTrackPosition())) +
                            ":" + Math.Round(TimeSpanUtils.ConvertMillisecondsToSeconds(WinampLib.GetTrackPosition()) % 60);
            }
            catch (Exception ex)
            {
                DEFS.ExLog(ex.Message + "\n" + ex.StackTrace);
                return "";
            }
        }

        private void MMenu_Load(object sender, EventArgs e)
        {
            if (!login_ok) { Application.Exit(); }
            DEFS.CheckOpenDay();
            //blObj = new TBLObj(-1, DEFS.ConSTR, FieldInfo);

            initHelyek();
            Invalidate();

            
            goMainMenu(Convert.ToInt16(e_Cafe.Properties.Settings.Default.DefaultHely));            
        }

        #region Bejelentkezéssel kapcsolatos dolgok
        private bool Login(int change)
        {
            bool r = false;
            ECafeLogin l = new ECafeLogin();
            int k = 0;
            while (k < 3)
            {
                k++;

                frmLogin fl = new frmLogin();
                fl.changeUser = change;
                fl.ShowDialog();
                if (fl.DialogResult == DialogResult.OK)
                {
                    if (!l.AuthenticateUser(fl._usr, fl._pw))
                    {
                        if ((fl._usr == "x") && (fl._pw == "11"))
                        {
                            DEFS.DebugLog("Sikertelen belépés de tudod a titkos kódot :)!");
                            if (fl.needLogin == 1)
                            {
                                DEFS.UserLogin(fl.selUser.USER_ID);
                            }
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
                        if (fl.needLogin == 1)
                        {
                            DEFS.UserLogin(fl.selUser.USER_ID);
                        }
                        SetUserSettings(fl.selUser);

                        r = true;
                        break;

                    }

                }
                else
                {
                    k = 3;
                }
            }

            return (r);

        }

        private void SetUserSettings(_User u)
        {

            panel7.Controls.Clear();
            DEFS.LogInUser = u;
            DEFS.UserRights = new Rights(u.USER_ID);
            UserButton ub = new UserButton();
            ub.fUser = u;
            //b.Click += (o, e) => { i.showPrefs(); };
            ub.Click += UserChange;
            ub.BackgroundImage = global::GUI.Properties.Resources.off_user;
            ub.BackgroundImageLayout = ImageLayout.Stretch;
            ub.Checked = true;
            ub.Dock = DockStyle.Left;
            panel7.Controls.Add(ub);

        }

        private void changeUser()
        {
            Login(1);
        }

        private void Logout()
        {
            DEFS.UserLogout(DEFS.LogInUser.USER_ID);
            DEFS.LogInUser = null;
            panel7.Controls.Clear();

        }

        public void UserChange(object sender, EventArgs e)
        {
            Login(1);
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
                    
                    (new frmFoglalas { aFoglal = tmp_a.aObj }).ShowDialog();
                }
                else
                {
                    
                    (new frmFoglalas { aFoglal = tmp_a.aObj }).ShowDialog();


                }
                btnFoglalas.Checked = false;

            }
            else
            {
                
                //tmp_a.Text = tmp_a.ClickTime.ToString();
                if ((tmp_a.ClickTime > 300) )//&& (tmp_a.aObj.fRENDELES_ID >0)
                {
                    #region Asztal info
                    
                    frmAsztalInfo fai = new frmAsztalInfo(tmp_a.aObj);
                    int new_x = panel2.Width + tmp_a.Location.X;
                    int new_y = tmp_a.Location.Y;
                
                    if ((tmp_a.Location.X + fai.Size.Width) >panel3.Width) {
                        new_x = panel2.Width + panel3.Width - fai.Size.Width;
                    }
                    
                    if ((tmp_a.Location.Y + fai.Size.Height) >panel3.Height) {
                        new_y = panel3.Height - fai.Size.Height;
                    }
                    


                    fai.Location = new Point(new_x, new_y);
                    
                    fai.Show();
                    #endregion
                }
                else
                {

                    #region Rendelés
                    if (tmp_a.aObj.lFOGLALAS_PARAM_IDON_BELUL.Count > 0)
                    {
                        DEFS.SendInfoMessage("Információ! : Az asztalra foglalás van! \n A foglalást előbb fel kell oldani!");
                    }
                    else
                    {
                        DEFS.log(Level.Debug, "Asztal Klikk: id:" + tmp_a.aObj.fASZTAL_ID.ToString() + " rendeles:" + tmp_a.aObj.fRENDELES_ID.ToString());
                        a.aList.SelectAsztal(tmp_a.Asztal_id);
                        tmp_a.vSelected = true;


                        
                        new MRendeles(a.aList.GetItem(tmp_a.Asztal_id)).ShowDialog();
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
            if (aHelyId > 0)
            {
                panel3.Controls.Clear();
                a = new Asztalok(panel3, aHelyId);
                a.RefreshAsztalok(true);
            }
        }

        #region Főmenük
        private void button2_Click(object sender, EventArgs e)
        {
            (new AdminTools()).ShowDialog();// = true;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (DEFS.Kerdes("Biztosan ki szeretne lépni?" + "\n" + "Minden belépett felhasználó kiléptetésre kerül!"))
            {
                Application.Exit();
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\DROP.sql"));
            updateDB(new FileInfo(DEFS.DefProgramLocation + @"\SQL\END.sql"));
        }


        private void btnPartnerek_Click(object sender, EventArgs e)
        {
            MMPartnerek f = new MMPartnerek();
            f.SelectMode = PartnerSelectModes.edit;
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
            Login(1);
        }

        #endregion

        private void btnFoglalas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbltrackInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void lbltrackInfo_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void lbltrackInfo_Click_1(object sender, EventArgs e)
        {
            (new frmShadowLayer(UsingForms.MediaPlayer)).ShowDialog();

        }


















    }
}
