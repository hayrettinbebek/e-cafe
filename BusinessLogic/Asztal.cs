using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BusinessLogic
{
    public class Asztal
    {
        public int fASZTAL_ID;
        public int fASZTAL_TIPUS;
        public string fASZTAL_SZAM;
        public int fASZTAL_POS_X;
        public int fASZTAL_POS_Y;

        public Asztal()
        {
            fASZTAL_ID = -1;
            fASZTAL_SZAM = "";
            fASZTAL_TIPUS = -1;
            fASZTAL_POS_X = -1;
            fASZTAL_POS_Y = -1;
        }

        public Asztal(int iASZTAL_ID, string iASZTAL_SZAM, int iASZTAL_TIPUS, int iASZTAL_POS_X, int iASZTAL_POS_Y)
        {
            fASZTAL_ID = iASZTAL_ID;
            fASZTAL_SZAM = iASZTAL_SZAM;
            fASZTAL_TIPUS = iASZTAL_TIPUS;
            fASZTAL_POS_X = iASZTAL_POS_X;
            fASZTAL_POS_Y = iASZTAL_POS_Y;
        }
    }

    public class Asztal_List
    {
        private SqlConnection sc;

        public List<Asztal> lASZTAL = new List<Asztal>();

        public Asztal_List(TBLObj iBLObj)
        {
            TBLObj pBLObj = iBLObj;
            sc = iBLObj.sqlConnection;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT ASZTAL_ID, ASZTAL_SZAM, ASZTAL_TIPUS, ASZTAL_POS_X, ASZTAL_POS_Y  FROM ASZTAL ";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Asztal t = new Asztal((int)rdr["ASZTAL_ID"], rdr["ASZTAL_SZAM"].ToString(), (int)rdr["ASZTAL_TIPUS"], (int)rdr["ASZTAL_POS_X"], (int)rdr["ASZTAL_POS_Y"]);
                lASZTAL.Add(t);
            }
            rdr.Close();
        }

        public Asztal GetItem(int iASZTAL_ID)
        {
            Asztal ret = new Asztal();

            IEnumerable<Asztal> r = lASZTAL.Where(p => p.fASZTAL_ID == iASZTAL_ID);

            foreach (var n in r)
            {
                ret = n;
            }
            return ret;
        }
    }

}
