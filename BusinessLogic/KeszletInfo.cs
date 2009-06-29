using System.Text;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public sealed class KeszletInfo
    {
        //private static DataSet _dataSet;

        public static DataSet CreateDataSet(int _Raktar, int _Cikk)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection(DEFS.ConSTR);
            //IDbConnection cn = new System.Data.OleDb.OleDbConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();
            //IDbDataAdapter adapterSender = new System.Data.OleDb.OleDbDataAdapter();
            //IDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            SqlDataAdapter adapterSender = new SqlDataAdapter();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from keszlet_fej where RAKTAR_ID = " + _Raktar.ToString() + " AND CIKK_ID = " +_Cikk.ToString() ;
            cn.Open();
            adapterSender.SelectCommand = cmd;
            adapterSender.Fill(ds);
            ds.Tables[0].TableName = "KESZLET_FEJ";

            cmd.CommandText = "SELECT * FROM keszlet_sor where RAKTAR_ID = " + _Raktar.ToString() + " AND CIKK_ID = " +_Cikk.ToString() ;
            adapterSender.Fill(ds);
            ds.Tables[1].TableName = "KESZLET_SOR";


            ds.Relations.Add("FEJ2SOR",// ds.Tables[0].Columns["EV"],ds.Tables[1].Columns["EV"]);
                                new DataColumn[] {ds.Tables[0].Columns["EV"],
                                    ds.Tables[0].Columns["HO"],
                                    ds.Tables[0].Columns["NAP"],
                                    ds.Tables[0].Columns["CIKK_ID"],
                                    ds.Tables[0].Columns["RAKTAR_ID"]
                                    },
                               new DataColumn[] {ds.Tables[1].Columns["EV"],
                                    ds.Tables[1].Columns["HO"],
                                    ds.Tables[1].Columns["NAP"],
                                    ds.Tables[1].Columns["CIKK_ID"],
                                    ds.Tables[1].Columns["RAKTAR_ID"]
                                    });

            cn.Close();


            return ds;
        }


        //public static List<KeszletSor> getAktKeszletKarton()
        //{



        //}

//        select kf.KESZLET_NYITO,
//       KF.KESZLET_ERTEK_NYITO ,
//    kf.beszerzesi_ar,
//    kf.CIKK_ID,
//    r.RAKTAR_KOD,
//    c.CIKKCSOPORT_ID,
//    m.MEGYS_MEGNEVEZES,
//    c.MINIMUM_KESZLET,
//    c.OPTIMALIS_KESZLET


//from KESZLET_FEJ kf
//inner join nap_nyitas n on kf.EV = n.EV and kf.HO = n.HO and kf.NAP = n.NAP
//inner join CIKK c on kf. CIKK_ID = c.CIKK_ID
//inner join MEGYS m on c.MEGYS_ID = m.MEGYS_ID
//inner join RAKTAR r on kf.RAKTAR_ID = r.RAKTAR_ID

//where n.LEZART = 0




    }

    public class KeszletKarton
    {
        private List<KeszletSor> lKESZLETKARTON = new List<KeszletSor>();


            public KeszletKarton()
            {

            }

    }

    public class KeszletSor
    {
        private double _KESZLET_NYITO;
        private double _KESZLET_ERTEK_NYITO;
        private double _BESZERZESI_AR;
        private string fRAKTAR_KOD;
        private int fCIKKCSOPORT_ID;
        private int fCIKK_ID;
        private double fMINIMUM_KESZLET;
        private double fOPTIMALIS_KESZLET;
        private string fMEGYS_MEGNEVEZES;


        public KeszletSor()
        {

        }


        public double KESZLET_NYITO
        {
            get { return (_KESZLET_NYITO); }
            set { _KESZLET_NYITO = value; }
        }

        public double KESZLET_ERTEK_NYITO
        {
            get { return (_KESZLET_ERTEK_NYITO); }
            set { _KESZLET_ERTEK_NYITO = value; }
        }

        public double BESZERZESI_AR
        {
            get { return (_BESZERZESI_AR); }
            set { _BESZERZESI_AR = value; }
        }

        public string RAKTAR_KOD
        {
            get { return (fRAKTAR_KOD); }
            set { fRAKTAR_KOD = value; }
        }

        public int CIKKCSOPORT_ID
        {
            get { return (fCIKKCSOPORT_ID); }
            set { fCIKKCSOPORT_ID = value; }
        }


        public int CIKK_ID
        {
            get { return (fCIKK_ID); }
            set { fCIKK_ID = value; }
        }

        public string MEGYS_MEGNEVEZES
        {
            get { return (fMEGYS_MEGNEVEZES); }
            set { fMEGYS_MEGNEVEZES = value; }
        }

        public double MINIMUM_KESZLET
        {
            get { return (fMINIMUM_KESZLET); }
            set { fMINIMUM_KESZLET = value; }
        }
        public double OPTIMALIS_KESZLET
        {
            get { return (fOPTIMALIS_KESZLET); }
            set { fOPTIMALIS_KESZLET = value; }
        }






    }
}
