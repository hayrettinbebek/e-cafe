using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    /*
    public class Syspar
    {
        public ParamCodes PARAM_CODE;



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

        public void Save()
        {

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

    */

    public static class Syspar2
    {
        public static Object GetValue(ParamCodes c)
        {
            Object ret_obj = null;
            string search_obj = c.ToString();
            string field_name = "";
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;



            switch (GetType(c))
            {
                case ParamTypes.egesz:
                    field_name = "PARAM_VALUE_I";
                    break;
                case ParamTypes.szoveg:
                    field_name = "PARAM_VALUE_S";
                    break;
                case ParamTypes.tizedes:
                    field_name= "PARAM_VALUE_F";
                    break;
                case ParamTypes.image:
                    field_name = "PARAM_VALUE_IMAGE";
                    break;
                default:
                    field_name = "";
                    break;
            }

            if (field_name != "")
            {
                cmd.CommandText = "select " + field_name + " as VALUE from syspar where PARAM_NAME = '" + search_obj + "'";

                SqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    ret_obj = rdr["VALUE"];
                }
                sc.Close();
                if (ret_obj == null) { return (Object)(""); }
                else
                {
                    return (Object)(ret_obj);
                }
            }
            else
            {
                return ("");
            }
        }

        public static ParamTypes GetType(ParamCodes cc)
        {
            if (cc == ParamCodes.SHOW_ORDER_BEFORE)
            {
                return ParamTypes.egesz;
            }
            else if (cc == ParamCodes.CEG_NEV)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.SHOW_ORDER_BEFORE)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.SHOW_ORDER_BEFORE)
            {
                return (ParamTypes.egesz);
            }
            else if (cc == ParamCodes.CEG_CIM)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.BLOKK_LABLEC1)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.BLOKK_LABLEC2)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.BLOKK_LABLEC3)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.AUTO_PRINT_BLOKK)
            {
                return (ParamTypes.egesz);
            }
            else if (cc == ParamCodes.LELTAR_KOROK_SZAMA)
            {
                return (ParamTypes.egesz);
            }
            else if (cc == ParamCodes.OSSZ_REPORT_FORMAT)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.BLOKK_LOGO_PATH)
            {
                return (ParamTypes.szoveg);
            }
            else if (cc == ParamCodes.CIKK_GORGET_MODE)
            {
                return (ParamTypes.szoveg);
            }
            else
            {
                return ParamTypes.egesz;
            }
        }

        public static void SetValues(ParamCodes uc, Object val){
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            string search_obj = uc.ToString();
            string field_name = "";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            switch (GetType(uc))
            {
                case ParamTypes.egesz:
                    field_name = "PARAM_VALUE_I";
                    break;
                case ParamTypes.szoveg:
                    field_name = "PARAM_VALUE_S";
                    break;
                case ParamTypes.tizedes:
                    field_name = "PARAM_VALUE_F";
                    break;
                case ParamTypes.image:
                    field_name = "PARAM_VALUE_IMAGE";
                    break;
                default:
                    field_name = "";
                    break;
            }

            if (field_name != "")
            {

                string sql_str = "IF EXISTS(select '' from syspar where PARAM_NAME = '" + search_obj + "') BEGIN " +
                                " UPDATE SYSPAR SET " + field_name + " = '" + val.ToString() + "' WHERE PARAM_NAME = '" + search_obj + "' " +
                                " end else begin INSERT INTO syspar (PARAM_NAME, " + field_name + ") VALUES ('" + search_obj + "' ,'" + val.ToString() + "') END ";
                cmd.CommandText = sql_str;

                cmd.ExecuteNonQuery();
                sc.Close();
            }

        }
    }

    public enum ParamTypes
    {
        egesz,
        szoveg,
        tizedes,
        image
    }
    public enum ParamCodes
    {
        SHOW_ORDER_BEFORE,
        CEG_NEV,
        CEG_CIM,
        BLOKK_LABLEC1,
        BLOKK_LABLEC2,
        BLOKK_LABLEC3,
        AUTO_PRINT_BLOKK,
        LELTAR_KOROK_SZAMA,
        OSSZ_REPORT_FORMAT,
        BLOKK_LOGO_PATH,
        CIKK_GORGET_MODE

    }
    


   
}
