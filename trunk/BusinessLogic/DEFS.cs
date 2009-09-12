using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using NSpring.Logging;
using NSpring.Logging.EventFormatters;
using System.Drawing.Printing;


namespace BusinessLogic
{
    
    public abstract class DEFS
    {
        public static string ConSTR = "X";//@"server=ERNIE-HOME\SQLEXPRESS;database=ECAFE;uid=sa;password=x";
        public static string DefPrinter = "X";//@"server=ERNIE-HOME\SQLEXPRESS;database=ECAFE;uid=sa;password=x";

        public static string DefProgramLocation = "X";
        public static Color Asztal_hatter = Color.FromArgb(102, 102, 102); //System.Drawing.Color.Gray;
        public static Color Selected_Color = Color.FromArgb(102, 102, 102); //System.Drawing.Color.DarkGray; 
        public static Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        public static Font fRendelInfo = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        public static Font fFoglalasokInfo = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        public static Size CIKK_BTN_SIZE = new Size(150, 75);
        
        public static int NyitNap_EV;
        public static int NyitNap_HO;
        public static int NyitNap_NAP;

        private static Logger APP_LOG;

        

       // public static SysParList R_SYSPAR;

        public static Rights UserRights;

        //public static Megys_list GlobalMegysList = new Megys_list();

        #region felhasználókezelés
        public static _User LogInUser;
        public static void UserLogout(int _u_id)
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmdNyitNap = new SqlCommand("sp_logout", c);
            cmdNyitNap.CommandType = System.Data.CommandType.StoredProcedure;

            cmdNyitNap.Parameters.Add("@user_id", SqlDbType.Int);
            cmdNyitNap.Parameters["@user_id"].Direction = ParameterDirection.Input;
            cmdNyitNap.Parameters["@user_id"].Value = _u_id;
           
            c.Open();
            cmdNyitNap.ExecuteNonQuery();
           
            c.Close();


        }

        public static void UserLogin(int _u_id)
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmdNyitNap = new SqlCommand("sp_login", c);
            cmdNyitNap.CommandType = System.Data.CommandType.StoredProcedure;

            cmdNyitNap.Parameters.Add("@user_id", SqlDbType.Int);
            cmdNyitNap.Parameters["@user_id"].Direction = ParameterDirection.Input;
            cmdNyitNap.Parameters["@user_id"].Value = _u_id;

            c.Open();
            cmdNyitNap.ExecuteNonQuery();

            c.Close();


        }
        #endregion

        public static string GetSorszam(string tipus, string prefix, int hossz)
        {
            string retval = "";
            int tmp_ret_num = 0;

            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmdNyitNap = new SqlCommand("SP_GET_SORSZAM", c);
            cmdNyitNap.CommandType = System.Data.CommandType.StoredProcedure;

            cmdNyitNap.Parameters.Add("@TYPE", SqlDbType.VarChar);
            cmdNyitNap.Parameters["@TYPE"].Direction = ParameterDirection.Input;
            cmdNyitNap.Parameters["@TYPE"].Value = tipus;
            
            cmdNyitNap.Parameters.Add("@SZAM", SqlDbType.Int);
            cmdNyitNap.Parameters["@SZAM"].Direction = ParameterDirection.Output;
            

            
            c.Open();
            cmdNyitNap.ExecuteNonQuery();

            tmp_ret_num = (int)cmdNyitNap.Parameters["@SZAM"].Value;

            if (tmp_ret_num > 0)
            {
                retval = (prefix + tmp_ret_num.ToString().PadLeft(hossz, '0'));

            }
            c.Close();

            return retval;
        }

        #region számlázás
        public static int GenerateSzamlaFej(int partner_id, int rendeles_id, int p_fizmod)
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

        public static void AddSzlaTetel(int szla_fej_id, int sor_id)
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

        public static void AddEgyebSzlaTetel(int szla_fej_id, int sor_id)
        {

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdAddSzlaTetel = new SqlCommand("sp_add_egyeb_szamla_tetel", c);
            cmdAddSzlaTetel.CommandType = System.Data.CommandType.StoredProcedure;


            cmdAddSzlaTetel.Parameters.Add("@p_szamla_fej_id", SqlDbType.Int);
            cmdAddSzlaTetel.Parameters["@p_szamla_fej_id"].Direction = ParameterDirection.Input;
            cmdAddSzlaTetel.Parameters["@p_szamla_fej_id"].Value = szla_fej_id;

            cmdAddSzlaTetel.Parameters.Add("@p_partner_befizetes_id", SqlDbType.Int);
            cmdAddSzlaTetel.Parameters["@p_partner_befizetes_id"].Direction = ParameterDirection.Input;
            cmdAddSzlaTetel.Parameters["@p_partner_befizetes_id"].Value = sor_id;


            c.Open();
            cmdAddSzlaTetel.ExecuteNonQuery();



            c.Close();


        }

        public static void AddStornoSzlaTetel(int szla_fej_id, int sor_id)
        {



            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdAddSzlaTetel = new SqlCommand("sp_add_storno_szamla_tetel", c);
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
        #endregion

        #region könyvelési napokkal kapcsolatos lekérdezések
        public static List<OpenDay> lNYITOTT_NAPOK = new List<OpenDay>();


        public static void LoadNyitottNap()
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmdNyitNap = new SqlCommand("getNyitottNap", c);
            cmdNyitNap.CommandType = System.Data.CommandType.StoredProcedure;

            cmdNyitNap.Parameters.Add("@EV", SqlDbType.Int);
            cmdNyitNap.Parameters["@EV"].Direction = ParameterDirection.Output;
            cmdNyitNap.Parameters.Add("@HO", SqlDbType.Int);
            cmdNyitNap.Parameters["@HO"].Direction = ParameterDirection.Output;
            cmdNyitNap.Parameters.Add("@NAP", SqlDbType.Int);
            cmdNyitNap.Parameters["@NAP"].Direction = ParameterDirection.Output;

            c.Open();
            cmdNyitNap.ExecuteNonQuery();
            NyitNap_EV = (int)cmdNyitNap.Parameters["@EV"].Value;
            NyitNap_HO = (int)cmdNyitNap.Parameters["@HO"].Value;
            NyitNap_NAP = (int)cmdNyitNap.Parameters["@NAP"].Value;
            c.Close();


        }

        public static void CheckOpenDay()
        {
            if ((DateTime.Now - (new DateTime(NyitNap_EV, NyitNap_HO, NyitNap_NAP))).Days > 1)
            {
                DEFS.SendInfoMessage("A nyitott nap régebbi mint 1 napos! Kérem ellenőrizze a nap nyitásokat!");

            }
            


        }

        public static void LoadPossibleOpenDays()
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            
            cmd.CommandText = "select distinct EV, HO, NAP from nap_nyitas order by 1 asc";
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lNYITOTT_NAPOK.Add( new OpenDay((int)rdr["EV"],(int)rdr["HO"],(int)rdr["NAP"])  );
            }
            c.Close();
        }

        #endregion

        #region Konvertálásaok
        public static int BoolToInt(bool b)
        {
            if (b)
            {
                return (1);
            }
            else
            {
                return (0);
            }

        }


        public static bool IntToBool(int i)
        {
            if (i>0)
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }
        #endregion 

        public static void updateAfaSzazalekokOnCikkek()
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "update cikk  set cikk.eladasi_ar_netto = cikk.eladasi_ar*100/(100+a.afa_ertek) from cikk  " +
                               " inner join cikkcsoport cs on cikk.cikkcsoport_id = cs.cikkcsoport_id inner join afa a on cs.afa_kod = a.afa_kod " +
                               " where isnull(cikk.eladasi_ar_netto,0) > 0";
            c.Open();
            cmd.ExecuteNonQuery();

            c.Close();
        }

        public static int GetDBVER()
        {
            int tmpret = 0;
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT Cast(DB_VER as integer) as DB_VER FROM VERSION";
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                tmpret = (int)rdr["DB_VER"];
            }

            return tmpret;
        }

        #region Loggolás és hibakezelés
        public static void createLogger()
        {
            APP_LOG = Logger.CreateFileLogger(AppDomain.CurrentDomain.BaseDirectory + "\\log\\e_cafe_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" +
                                                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second +".log");
            APP_LOG.IsBufferingEnabled = true;
            APP_LOG.BufferSize = 1000;
            APP_LOG.EventFormatter = new PatternEventFormatter("{mm}/{dd}/{yyyy} {time}  [{ln:uc}]  {msg}");
            APP_LOG.Open();
        }
        

        public static void ExLog( string t)
        {
            if (!APP_LOG.IsOpen) { APP_LOG.Open(); }
            APP_LOG.Log("\n");
            APP_LOG.Log(Level.Exception, t);
            APP_LOG.Log("\n");


            APP_LOG.Close();
        }

        public static void DebugLog(string t)
        {
            if (!APP_LOG.IsOpen) { APP_LOG.Open(); }
            APP_LOG.Log("\n");
            APP_LOG.Log(Level.Debug, t);
            APP_LOG.Log("\n");


            APP_LOG.Close();
        }

        public static void ObjLog(string t, object o)
        {
            if (!APP_LOG.IsOpen) { APP_LOG.Open(); }
            APP_LOG.Log("\n");
            APP_LOG.Log(t, o.ToString());
            APP_LOG.Log("\n");


            APP_LOG.Close();
        }


        public static void log(Level l, string t)
        {
            if (!APP_LOG.IsOpen) {APP_LOG.Open();}
            APP_LOG.Log("\n");
            APP_LOG.Log(l, t);
            APP_LOG.Log("\n");

            APP_LOG.Close();
        }

        public static void SendSaveErrMessage(string t)
        {
            string s = "Hiba a mentés során!" + "\n" + "Oka:" +"\n";
            log(Level.Exception, s + t);
            MessageBox.Show(s + t);

        }

        public static void SendValidatingMessage(string hol, string t)
        {
            string s = "Érvénytelen adatok a "+hol+ " mezőben !" + "\n" + "Oka:" + "\n";
            log(Level.Exception, s + t);

            frmInfoMessage1 fi = new frmInfoMessage1();
            fi.lblMessage.Text = s + t;
            fi.tmrTime.Enabled = false;
            fi.ShowDialog();
            

        }

        public static void SendInfoMessage(string t)
        {
            
            log(Level.Info, t);
            frmInfoMessage1 fi = new frmInfoMessage1();
            fi.lblMessage.Text = t;
            fi.tmrTime.Enabled = false;
            fi.ShowDialog();
            

        }

        public static bool Kerdes(string kerdes_szoveg)
        {
            // true-t ad vissza ha IGEN-t választottunk.
            log(Level.Info, kerdes_szoveg);
            frmKerdes fi = new frmKerdes();
            fi.lblMessage.Text = kerdes_szoveg;
             
            fi.ShowDialog();
            if (fi.DialogResult == DialogResult.OK)
            {
                return (true);
            }
            else
            {
                return (false);
            }


        }

        public static void SendShortMessage(string t, int seconds)
        {

            log(Level.Info, t);
            frmInfoMessage1 fi = new frmInfoMessage1();
            fi.lblMessage.Text = t;
            fi.tmrTime.Interval = seconds;
            fi.ShowDialog();


        }
        #endregion

        #region konvertálások
        public static double getNetto(double BruttoSzam, double AfaSzaz)
        {
            return (BruttoSzam / (1 + (AfaSzaz / 100)));
        }

        public static double getBrutto(double NettoSzam, double AfaSzaz)
        {
            return (NettoSzam / (1 + (AfaSzaz / 100)));
        }

        public static int MMtoInch(int iMM)
        {
            return Convert.ToInt16(Math.Round(((iMM / 25.4) * 100)));
        }

        #endregion

        public static void doKeszletAtvezet(int fromRakt, int toRakt, int CikkID, double mennyiseg)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdKeszlAtvezet = new SqlCommand("SP_KESZLET_ATVEZET", c);

            cmdKeszlAtvezet.CommandType = System.Data.CommandType.StoredProcedure;




            cmdKeszlAtvezet.Parameters.Add("@from_raktar", SqlDbType.Int);
            cmdKeszlAtvezet.Parameters["@from_raktar"].Direction = ParameterDirection.Input;
            cmdKeszlAtvezet.Parameters["@from_raktar"].Value = fromRakt;
            cmdKeszlAtvezet.Parameters.Add("@to_raktar", SqlDbType.Int);
            cmdKeszlAtvezet.Parameters["@to_raktar"].Direction = ParameterDirection.Input;
            cmdKeszlAtvezet.Parameters["@to_raktar"].Value = toRakt;
            cmdKeszlAtvezet.Parameters.Add("@cikk_id", SqlDbType.Int);
            cmdKeszlAtvezet.Parameters["@cikk_id"].Direction = ParameterDirection.Input;
            cmdKeszlAtvezet.Parameters["@cikk_id"].Value = CikkID;
            cmdKeszlAtvezet.Parameters.Add("@menny", SqlDbType.Float);
            cmdKeszlAtvezet.Parameters["@menny"].Direction = ParameterDirection.Input;
            cmdKeszlAtvezet.Parameters["@menny"].Value = mennyiseg;
            c.Open();
            cmdKeszlAtvezet.ExecuteNonQuery();


            c.Close();



        }

        public static int doCreateLeltarIv(int prakt, int pCikkcsop)
        {
            int retval = -1;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmdKeszlAtvezet = new SqlCommand("sp_create_leltariv", c);

            cmdKeszlAtvezet.CommandType = System.Data.CommandType.StoredProcedure;




            cmdKeszlAtvezet.Parameters.Add("@p_cikkcsop_id", SqlDbType.Int);
            cmdKeszlAtvezet.Parameters["@p_cikkcsop_id"].Direction = ParameterDirection.Input;
            cmdKeszlAtvezet.Parameters["@p_cikkcsop_id"].Value = pCikkcsop;


            cmdKeszlAtvezet.Parameters.Add("@p_raktar_id", SqlDbType.Int);
            cmdKeszlAtvezet.Parameters["@p_raktar_id"].Direction = ParameterDirection.Input;
            cmdKeszlAtvezet.Parameters["@p_raktar_id"].Value = prakt;


            cmdKeszlAtvezet.Parameters.Add("@p_leltar_id", SqlDbType.Int);
            cmdKeszlAtvezet.Parameters["@p_leltar_id"].Direction = ParameterDirection.Output;
            

            c.Open();
            cmdKeszlAtvezet.ExecuteNonQuery();
            retval = (int)cmdKeszlAtvezet.Parameters["@p_leltar_id"].Value;
            
            c.Close();

            return (retval);

        }

        public static void doRepairTables()
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmdNyitNap = new SqlCommand("sp_repair_Tables", c);
            cmdNyitNap.CommandType = System.Data.CommandType.StoredProcedure;

            c.Open();
            cmdNyitNap.ExecuteNonQuery();

            c.Close();


        }

        #region NapiZaras Check
        public static bool checkTartozasok()
        {
            return true;
        }
        public static bool checkNegativKeszlet()
        {
            bool van = true;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select count(*) as DB from keszlet_fej f " +
                                " inner join nap_nyitas n on f.EV = n.EV and f.HO = n.HO and f.NAP = n.NAP where "+
                                " n.LEZART = 0 and Round(isnull(f.KESZLET_NYITO,0) + isnull(f.KESZLET_NAPI,0),2) < 0";
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            van = false;
            while (rdr.Read())
            {
                if ((int)rdr["DB"] > 0)
                {
                    van = true;
                }
                else
                {
                    van = false;
                }
            }
            c.Close();

            return (!van);
        }
        public static bool checkDatabaseKonsist()
        {
            return true;
        }
        public static bool checkNyitottRendeles()
        {
            bool van = true;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select count(*) as DB from rendeles_fej where aktiv = 1";
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((int)rdr["DB"] > 0)
                {
                    van = true ;
                }
                else
                {
                    van = false;
                }
            }
            c.Close();

            return (!van);

            
            
        }

        #endregion

        #region InputValidators

        public static bool isOnlyNumber(Keys c)
        {
            bool ok = true;

            if (c < Keys.D0 || c > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (c < Keys.NumPad0 || c > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (c != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        ok = false;
                    }
                }
            }

            return (ok);
        }

        #endregion


        public static string getdefaultprinter()
        {
            string printername;
            PrintDocument getprintername = new PrintDocument();
            printername = getprintername.PrinterSettings.PrinterName;
            return printername;
        }

    }

    public enum Fizmond : int
    {
        Keszpenz = 1,
        Bankkartya = 2,
        Utalvany = 3,
        egyeb = 4
    }
    public enum MobilTipus
    {
        [StringValue("Mobil")]
        mobil = 1,
        [StringValue("E-Mail")]
        email = 2,
        [StringValue("Vezetékes")]
        vezetekes = 3

    }

    public enum MegrendelesAllapot
    {
        [StringValue("Nyitott")]
        mobil = 0,
        [StringValue("Elküldött/Bevételezhető")]
        email = 1,
        [StringValue("Bevételezett")]
        vezetekes = 2

    }
    public enum CimTipus
    {
        [StringValue("Székhely")]
        szekhely = 1,
        [StringValue("Állandó lakcím")]
        allandolakcim = 2,
        [StringValue("Levelezési cím")]
        levelezcim = 3,
        [StringValue("Tartózkodási hely")]
        tarthely = 4


    }

    public class ertTip
    {
        private string _KOD;
        private string _NEV;

        public string KOD
        {
            get { return (_KOD); }
            set { _KOD = value; }
        }

        public string NEV
        {
            get { return (_NEV); }
            set { _NEV = value; }
        }
        public ertTip(string k, string n)
        {
            _KOD = k;
            _NEV = n;
        }
    }

    public class DynCombo
    {

        #region DISPLAY_MEMBER
        private string _disp;
        public string DISPLAY_MEMBER
        {
            get { return (_disp); }
            set { _disp = value; }
        }
        #endregion

        #region VALUE_MEMBER
        private string _value;
        public string VALUE_MEMBER
        {
            get { return (_value); }
            set { _value = value; }
        }
        #endregion

        #region VALUE_MEMBER_INT
        private int _value_int;
        public int VALUE_MEMBER_INT
        {
            get { return (_value_int); }
            set { _value_int = value; }
        }
        #endregion
        public DynCombo(string pDisp, string pValue)
        {
            _disp = pDisp;
            _value = pValue;

        }


        public DynCombo(string pDisp, int pValue)
        {
            _disp = pDisp;
            _value_int = pValue;

        }

    }

    public class OpenDayCombo
    {

        #region DISPLAY_MEMBER
        private string _disp;
        public string DISPLAY_MEMBER
        {
            get { return (_disp); }
            set { _disp = value; }
        }
        #endregion

        #region VALUE_MEMBER
        private string _value;
        public string VALUE_MEMBER
        {
            get { return (_value); }
            set { _value = value; }
        }
        #endregion

        
        public OpenDay _OD;
        public OpenDay OD
        {
            get { return (_OD); }
            set { _OD = value; }
        }
        

        public OpenDayCombo(string pDisp, string pValue, OpenDay pOd)
        {
            _disp = pDisp;
            _value = pValue;
            _OD = pOd;

        }

    }

    public class OpenDay
    {
        public int EV;
        public int HO;
        public int NAP;

        public OpenDay(int pEV, int pHO, int pNAP)
        {
            EV = pEV;
            HO = pHO;
            NAP = pNAP;

        }

    }

  




   
}
