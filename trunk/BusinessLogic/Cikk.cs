﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class Cikk
    {
        public int fCIKK_ID;
        public string fMEGNEVEZES;
        public int fCIKK_TIPUS;
        public int fCIKKCSOPORT_ID;

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

    class Cikk_list
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

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID  FROM CIKK";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Cikk t = new Cikk((int)rdr["CIKK_ID"],
                                  (string)rdr["MEGNEVEZES"], 
                                  (int)rdr["CIKK_TIPUS"], 
                                  (int)rdr["CIKKCSOPORT_ID"]);
                lCIKK.Add(t);
            }
            rdr.Close();
        }

    }

    class Recept
    {
    }

    class CikkListByCsoport
    {
    }

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
