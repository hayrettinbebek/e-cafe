using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public sealed class KeszletInfo
    {
        private static DataSet _dataSet;

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


    }
}
