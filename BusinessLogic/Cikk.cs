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

        public void Save(TBLObj iBLObj)
        {
            // a mentés valósítja meg.
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

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID  FROM CIKK";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Cikk t = new Cikk((int)rdr["CIKK_ID"],
                                  (string)rdr["MEGNEVEZES"], 
                                  (int)rdr["CIKK_TIPUS"], 
                                  (int)rdr["CIKKCSOPORT_ID"]);
                t.fOTHER_FILTER_ID = (int)rdr["OTHER_FILTER_ID"];
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
