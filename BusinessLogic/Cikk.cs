using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class Cikk
    {
        private SqlConnection sc;

        public int fCIKK_ID;
        public string fMEGNEVEZES;
        public int fCIKK_TIPUS;
        public int fCIKKCSOPORT_ID;

        public Cikk(int cikk_id, TBLObj iBLObj)
        {
            TBLObj pBLObj = iBLObj;
            sc = iBLObj.sqlConnection;
            // itt jön hogy a DB ből kiszedi az értékeket.
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID  FROM CIKK ";
            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                fCIKK_ID = (int)rdr["CIKK_ID"];
                fMEGNEVEZES = (string)rdr["MEGNEVEZES"];
                fCIKK_TIPUS = (int)rdr["CIKK_TIPUS"];
                fCIKKCSOPORT_ID = (int)rdr["CIKKCSOPORT_ID"];

            }
            rdr.Close();
        }

        public Cikk(TBLObj iBLObj)
        {
            TBLObj pBLObj = iBLObj;
            sc = iBLObj.sqlConnection;
            fCIKK_ID = -1;
        }

        public void Save(TBLObj iBLObj)
        {
            // a mentés valósítja meg.
        }

        
    }

    class Recept
    {
    }

    class CikkListByCsoport
    {
    }


    class Cikkcsoport
    {
        private SqlConnection sc;

        public int fCIKKCSOPORT_ID;
        public string fCIKKCSOPORT_NEV;

        public Cikkcsoport(int cikk_id, TBLObj iBLObj)
        {
            TBLObj pBLObj = iBLObj;
            sc = iBLObj.sqlConnection;
            // itt jön hogy a DB ből kiszedi az értékeket.
        }

        public Cikkcsoport(TBLObj iBLObj)
        {
            TBLObj pBLObj = iBLObj;
            sc = iBLObj.sqlConnection;
            fCIKKCSOPORT_ID = -1;
        }
    }
}
