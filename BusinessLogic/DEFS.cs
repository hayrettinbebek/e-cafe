using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    
    public abstract class DEFS
    {
        public static string ConSTR = "X";//@"server=ERNIE-HOME\SQLEXPRESS;database=ECAFE;uid=sa;password=x";
        public static Color  Asztal_hatter = System.Drawing.Color.Gray;// FromArgb( 70,128,64);
        public static Color Selected_Color = System.Drawing.Color.DarkGray; //FromArgb(126, 187, 121);
        public static Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

        public static int NyitNap_EV;
        public static int NyitNap_HO;
        public static int NyitNap_NAP;


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


   
}
