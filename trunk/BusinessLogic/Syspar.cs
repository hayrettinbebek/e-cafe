using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class Syspar
    {
        public string PARAM_NAME;
        public string VALUE_S;
        public int VALUE_I;
        public double VALUE_F;

        public Syspar(string pName, string pVs, int pVI, double pVD)
        {
            PARAM_NAME = pName;
            VALUE_F = pVD;
            VALUE_I = pVI;
            VALUE_S = pVs;


        }
    }


    public class SysParList
    {


        public List<Syspar> lSyspar = new List<Syspar>();

        public SysParList()
        {

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT PARAM_NAME, isnull(PARAM_VALUE_S,'') as PARAM_VALUE_S, isnull(PARAM_VALUE_I,-1) as PARAM_VALUE_I, isnull(PARAM_VALUE_F,-1.0) as PARAM_VALUE_F FROM SYSPAR";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Syspar t = new Syspar((string)rdr["PARAM_NAME"],
                                (string)rdr["PARAM_VALUE_S"],
                                (int)rdr["PARAM_VALUE_I"],
                                (double)rdr["PARAM_VALUE_F"]);
                lSyspar.Add(t);
            }
            rdr.Close();
            sc.Close();
        }


        public int GetIntValue(string pParamName)
        {
            int ret = -1;
            var ret__Syspar =
                from c in lSyspar
                where (c.PARAM_NAME == pParamName)
                select c;
            ret__Syspar.Each(c => ret = c.VALUE_I);


            return (ret);
        }

        public string GetStrValue(string pParamName)
        {
            string ret = "";
            var ret__Syspar =
                from c in lSyspar
                where (c.PARAM_NAME == pParamName)
                select c;
            ret__Syspar.Each(c => ret = c.VALUE_S);


            return (ret);
        }

        public string GetStrValueFilterInt(string pParamName, int iFilter)
        {
            string ret = "";
            var ret__Syspar =
                from c in lSyspar
                where (c.PARAM_NAME == pParamName && c.VALUE_I == iFilter)
                select c;
            ret__Syspar.Each(c => ret = c.VALUE_S);


            return (ret);
        }
    }


    public class SYSTEM_GLOBAL_PARAMS
    {
        private int _SHOW_ORDER_BEFORE;
        private string _CEG_NEV;
        private string _CEG_CIM;
        private string _BLOKK_LABLEC1;
        private string _BLOKK_LABLEC2;
        private string _BLOKK_LABLEC3;
        private int _LELTAR_KOROK_SZAMA;
        private int _AUTO_PRINT_BLOKK;
        private string _OSSZ_REPORT_FORMAT;

        public int SHOW_ORDER_BEFORE
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public string CEG_NEV
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public string CEG_CIM
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public string BLOKK_LABLEC1
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public string BLOKK_LABLEC2
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public string BLOKK_LABLEC3
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }

        public int LELTAR_KOROK_SZAMA
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public int AUTO_PRINT_BLOKK
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }
        public string OSSZ_REPORT_FORMAT
        {
            get { return (_SHOW_ORDER_BEFORE); }
            set { SHOW_ORDER_BEFORE = value; }
        }


        public SYSTEM_GLOBAL_PARAMS()
        {

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT PARAM_NAME, isnull(PARAM_VALUE_S,'') as PARAM_VALUE_S, isnull(PARAM_VALUE_I,-1) as PARAM_VALUE_I, isnull(PARAM_VALUE_F,-1.0) as PARAM_VALUE_F FROM SYSPAR";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (((string)rdr["PARAM_NAME"]) == "SHOW_ORDER_BEFORE")
                { SHOW_ORDER_BEFORE = (int)rdr["PARAM_VALUE_I"]; }
                else
                    if (((string)rdr["PARAM_NAME"]) == "CEG_NEV")
                    { CEG_NEV = (string)rdr["PARAM_VALUE_S"]; }
                    else
                        if (((string)rdr["PARAM_NAME"]) == "CEG_CIM")
                        { CEG_CIM = (string)rdr["PARAM_VALUE_S"]; }
                        else
                            if (((string)rdr["PARAM_NAME"]) == "BLOKK_LABLEC1")
                            { BLOKK_LABLEC1 = (string)rdr["PARAM_VALUE_S"]; }
                            else
                                if (((string)rdr["PARAM_NAME"]) == "BLOKK_LABLEC2")
                                { BLOKK_LABLEC2 = (string)rdr["PARAM_VALUE_S"]; }
                                else
                                    if (((string)rdr["PARAM_NAME"]) == "BLOKK_LABLEC3")
                                    { BLOKK_LABLEC3 = (string)rdr["PARAM_VALUE_S"]; }
                                    else
                                        if (((string)rdr["PARAM_NAME"]) == "LELTAR_KOROK_SZAMA")
                                        { LELTAR_KOROK_SZAMA = (int)rdr["PARAM_VALUE_I"]; }
                                        else
                                            if (((string)rdr["PARAM_NAME"]) == "AUTO_PRINT_BLOKK")
                                            { AUTO_PRINT_BLOKK = (int)rdr["PARAM_VALUE_I"]; }
                                            else
                                                if (((string)rdr["PARAM_NAME"]) == "OSSZ_REPORT_FORMAT")
                                                { OSSZ_REPORT_FORMAT = (string)rdr["PARAM_VALUE_S"]; }
            }
            rdr.Close();
            sc.Close();
        }

        public void Save()
        {

            // ide kell propertynként a mentés megvalósítása
        }



    }
}
