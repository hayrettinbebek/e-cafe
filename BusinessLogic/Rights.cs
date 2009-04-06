using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class Rights
    {
        public List<Right> lRight = new List<Right>();

        public Rights(int _User)
        {

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT _JOG_ID FROM _USER_JOG WHERE _USER_ID = " +_User.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Right t = new Right((string)rdr["_JOG_ID"]);
                lRight.Add(t);
            }
            rdr.Close();
            sc.Close();
        }

        public bool HasRight(string jog)
        {
            bool ret = false;
            var ret__Syspar =
                from c in lRight
                where (c.RIGHT == jog)
                select c;
            ret__Syspar.Each(c => ret = (c.RIGHT == jog));


            return (ret);
        }

    }


    public class Right
    {
        public string RIGHT;
        public Right(string jog)
        {
            RIGHT = jog;
        }

    }
}
