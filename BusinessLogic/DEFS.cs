using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using NSpring.Logging;
using NSpring.Logging.EventFormatters;


namespace BusinessLogic
{
    
    public abstract class DEFS
    {
        public static string ConSTR = "X";//@"server=ERNIE-HOME\SQLEXPRESS;database=ECAFE;uid=sa;password=x";
        public static string DefProgramLocation = "X";
        public static Color Asztal_hatter = Color.FromArgb(102, 102, 102); //System.Drawing.Color.Gray;
        public static Color Selected_Color = Color.FromArgb(102, 102, 102); //System.Drawing.Color.DarkGray; 
        public static Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        public static Size CIKK_BTN_SIZE = new Size(250, 175);
        
        public static int NyitNap_EV;
        public static int NyitNap_HO;
        public static int NyitNap_NAP;

        private static Logger APP_LOG;

        public static _User LogInUser;

        public static SysParList R_SYSPAR;

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
        #endregion

        #region könyvelési napokkal kapcsolatos lekérdezések
        public static List<int> lEVEK = new List<int>();
        public static List<int> lHONAPOK = new List<int>();
        public static List<int> lNAPOK = new List<int>();

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

        public static void LoadPossibleOpenDays()
        {
            SqlConnection c = new SqlConnection(ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            
            cmd.CommandText = "select distinct EV from nap_nyitas order by 1 asc";
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lEVEK.Add((int)rdr["EV"]);
            }
            c.Close();
            rdr.Dispose();
            cmd.CommandText = "";
            cmd.CommandText = "select distinct HO from nap_nyitas order by 1 asc";
            c.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lHONAPOK.Add((int)rdr["HO"]);
            }
            c.Close();
            cmd.CommandText = "";
            cmd.CommandText = "select distinct NAP from nap_nyitas order by 1 asc";
            c.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lNAPOK.Add((int)rdr["NAP"]);
            }
            c.Close();


        }

        #endregion

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

        public static void SendShortMessage(string t, int seconds)
        {

            log(Level.Info, t);
            frmInfoMessage1 fi = new frmInfoMessage1();
            fi.lblMessage.Text = t;
            fi.tmrTime.Interval = seconds;
            fi.ShowDialog();


        }

        public static double getNetto(double BruttoSzam, double AfaSzaz)
        {
            return (BruttoSzam / (1 + (AfaSzaz / 100)));
        }

        public static double getBrutto(double NettoSzam, double AfaSzaz)
        {
            return (NettoSzam / (1 + (AfaSzaz / 100)));
        }
    }

    public enum Fizmond : int
    {
        Keszpenz = 1,
        Bankkartya = 2,
        Utalvany = 3,
        egyeb = 4
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
        public DynCombo(string pDisp, string pValue)
        {
            _disp = pDisp;
            _value = pValue;

        }

    }




   
}
