using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class Cikk
    {
        public int fCIKK_ID;
        public string fMEGNEVEZES;
        public int fCIKK_TIPUS;
        public int fCIKKCSOPORT_ID;
        public int fOTHER_FILTER_ID;
        
        public int fDEFAULT_RAKTAR;
        public List<CikkKeszlet> lKESZLET = new List<CikkKeszlet>();

        public double fKESZLET
        {
            get
            {
                 double iTmpRet = 0;

            var ret_cikk =
                from c in lKESZLET
                where c.fRAKTAR_ID == fDEFAULT_RAKTAR
                select c;
            ret_cikk.Each(c => iTmpRet = c.fKESZLET );

            return (iTmpRet);
            }
        }


        public Cikk(int pCIKK_ID,
                    string pMEGNEVEZES,
                    int pCIKK_TIPUS,
                    int pCIKKCSOPORT_ID
                    )
        {

                fCIKK_ID = pCIKK_ID;
                fMEGNEVEZES = pMEGNEVEZES;
                fCIKK_TIPUS = pCIKK_TIPUS;
                fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;


        }

        public Cikk()
        {

            fCIKK_ID = -1;
        }

        public void getKeszlet()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("select * from GetKeszlet(@EV,@HO,@NAP,@cikk_id,@raktar_id)", c);
            gk.CommandType = CommandType.Text;
            gk.Parameters.Add("@EV", SqlDbType.Int);
            gk.Parameters["@EV"].Direction = ParameterDirection.Input;
            gk.Parameters["@EV"].Value = DEFS.NyitNap_EV;

            gk.Parameters.Add("@HO", SqlDbType.Int);
            gk.Parameters["@HO"].Direction = ParameterDirection.Input;
            gk.Parameters["@HO"].Value = DEFS.NyitNap_HO;

            gk.Parameters.Add("@NAP", SqlDbType.Int);
            gk.Parameters["@NAP"].Direction = ParameterDirection.Input;
            gk.Parameters["@NAP"].Value = DEFS.NyitNap_NAP;

            gk.Parameters.Add("@cikk_id", SqlDbType.Int);
            gk.Parameters["@cikk_id"].Direction = ParameterDirection.Input;
            gk.Parameters["@cikk_id"].Value = fCIKK_ID;

            gk.Parameters.Add("@raktar_id", SqlDbType.Int);
            gk.Parameters["@raktar_id"].Direction = ParameterDirection.Input;
            gk.Parameters["@raktar_id"].Value = -1;

            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                lKESZLET.Add(new CikkKeszlet((int)rdr["RAKTAR_ID"], (double)rdr["KESZLET"], (double)rdr["KESZLET_ERTEK"]));
            }

        }

        public Cikk(int pCikkId, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID," +
                            " isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR FROM CIKK WHERE CIKK_ID =" + pCikkId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                fCIKK_ID = (int)rdr["CIKK_ID"];
                fMEGNEVEZES = (string)rdr["MEGNEVEZES"];
                fCIKK_TIPUS = (int)rdr["CIKK_TIPUS"];
                fCIKKCSOPORT_ID = (int)rdr["CIKKCSOPORT_ID"];
                fOTHER_FILTER_ID = (int)rdr["OTHER_FILTER_ID"];
                fDEFAULT_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                
            }
            getKeszlet();

        }

        public void Save(TBLObj iBLObj)
        {
            // a mentés valósítja meg.
        }

        
    }


    public class CikkKeszlet
    {
        public int fRAKTAR_ID;
        public double fKESZLET;
        public double fKESZLET_ERTEK;


        public CikkKeszlet(int pRakt_id, double pKeszlet, double pKeszlet_ert)
        {
            fRAKTAR_ID = pRakt_id;
            fKESZLET = pKeszlet;
            fKESZLET_ERTEK = pKeszlet_ert;
        }

    }
    public class Cikk_list
    {
        private SqlConnection sc;

        public List<Cikk> lCIKK = new List<Cikk>();
        TBLObj pBLObj;

        public Cikk_list(TBLObj iBLObj)
        {
            pBLObj = iBLObj;
            sc = pBLObj.sqlConnection;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID, isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR  FROM CIKK";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Cikk t = new Cikk((int)rdr["CIKK_ID"],
                                  (string)rdr["MEGNEVEZES"], 
                                  (int)rdr["CIKK_TIPUS"], 
                                  (int)rdr["CIKKCSOPORT_ID"]);
                t.fOTHER_FILTER_ID = (int)rdr["OTHER_FILTER_ID"];
                t.fDEFAULT_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                t.getKeszlet();
                lCIKK.Add(t);
            }
            rdr.Close();
        }

        public List<Cikk> CikkListByCsoport(int iCsoportId)
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where c.fCIKKCSOPORT_ID == iCsoportId
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Cikk> CikkListByAlcsoport(int iCsoportId, int iAlcsoportId)
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where (c.fCIKKCSOPORT_ID == iCsoportId) && (c.fOTHER_FILTER_ID == iAlcsoportId)
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

    }

    class Recept
    {
    }



    #region Other filter
    public class OTF
    {
        public int fOTF_ID;
        public int fCIKKCSOPORT_ID;
        public string fOTHER_NAME;

        public OTF(int pOTF_ID,int pCIKKCSOPORT_ID, string pOTHER_NAME)
        {

            fOTF_ID = pOTF_ID;
            fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;
            fOTHER_NAME = pOTHER_NAME;
        }

        public OTF()
        {
            fOTF_ID = -1;
        }
    }

    public class OTF_list
    {
        private SqlConnection sc;

        public List<OTF> lOTF = new List<OTF>();
        TBLObj pBLObj;

        public OTF_list(int pCIKKCSOP_ID, TBLObj iBLObj)
        {
            pBLObj = iBLObj;
            sc = pBLObj.sqlConnection;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT OTHER_FILTER_ID ,CIKKCSOPORT_ID  ,OTHER_NAME FROM CIKCSOP_OTHER_FILTER WHERE CIKKCSOPORT_ID = " + pCIKKCSOP_ID.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                OTF t = new OTF((int)rdr["OTHER_FILTER_ID"], 
                                (int)rdr["CIKKCSOPORT_ID"],
                                (string)rdr["OTHER_NAME"]);
                lOTF.Add(t);
            }
            rdr.Close();
        }

    }
    #endregion

    #region Cikkcsoport
    public class Cikkcsoport
    {
        public int fCIKKCSOPORT_ID;
        public string fCIKKCSOPORT_NEV;

        public Cikkcsoport(int pCIKKCSOPORT_ID, string pCIKKCSOPORT_NEV)
        {

            fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;
            fCIKKCSOPORT_NEV = pCIKKCSOPORT_NEV;



        }

        public Cikkcsoport()
        {
            fCIKKCSOPORT_ID = -1;
        }
    }

    public class Cikkcsoport_list
    {
        private SqlConnection sc;

        public List<Cikkcsoport> lCIKKCSOPORT = new List<Cikkcsoport>();
        TBLObj pBLObj;

        public Cikkcsoport_list(TBLObj iBLObj)
        {
            pBLObj = iBLObj;
            sc = pBLObj.sqlConnection;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKKCSOPORT_ID, CIKKCSOPORT_NEV  FROM CIKKCSOPORT";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Cikkcsoport t = new Cikkcsoport((int)rdr["CIKKCSOPORT_ID"],
                                  (string)rdr["CIKKCSOPORT_NEV"]);
                lCIKKCSOPORT.Add(t);
            }
            rdr.Close();
        }

    }
    #endregion
}
