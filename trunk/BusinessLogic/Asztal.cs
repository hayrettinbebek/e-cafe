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
        public bool vSelected;

        public Asztal()
        {
            fASZTAL_ID = -1;
            fASZTAL_SZAM = "";
            fASZTAL_TIPUS = -1;
            fASZTAL_POS_X = -1;
            fASZTAL_POS_Y = -1;
            vSelected = false;
        }

        public Asztal(int iASZTAL_ID, string iASZTAL_SZAM, int iASZTAL_TIPUS, int iASZTAL_POS_X, int iASZTAL_POS_Y, bool iSelected)
        {
            fASZTAL_ID = iASZTAL_ID;
            fASZTAL_SZAM = iASZTAL_SZAM;
            fASZTAL_TIPUS = iASZTAL_TIPUS;
            fASZTAL_POS_X = iASZTAL_POS_X;
            fASZTAL_POS_Y = iASZTAL_POS_Y;
            vSelected = iSelected;
        }

        public bool isUsed()
        {
            //select ami lekérdezi a foglaltásgot

            return ((fASZTAL_ID % 2) == 0);
        }
    }

    public class Asztal_List
    {
        private SqlConnection sc;

        public List<Asztal> lASZTAL = new List<Asztal>();
        TBLObj pBLObj;
        
        public Asztal_List(TBLObj iBLObj)
        {
            pBLObj = iBLObj;
            sc = pBLObj.sqlConnection;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT ASZTAL_ID, ASZTAL_SZAM, ASZTAL_TIPUS_ID, ASZTAL_POS_X, ASZTAL_POS_Y  FROM ASZTAL ";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Asztal t = new Asztal((int)rdr["ASZTAL_ID"], rdr["ASZTAL_SZAM"].ToString(), (int)rdr["ASZTAL_TIPUS_ID"], (int)rdr["ASZTAL_POS_X"], (int)rdr["ASZTAL_POS_Y"], false);
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

        public int GetItemIndex(int iASZTAL_ID)
        {
            int _ret = -1;
            for (int i = 0; i < lASZTAL.Count; i++)
            {
                if (lASZTAL[i].fASZTAL_ID == iASZTAL_ID) { _ret = i; break; }
                else { _ret = -1; }

            }
            return(_ret);

        }

        public void SelectAsztal(int iASZTAL_ID)
        {

            for (int i = 0; i < lASZTAL.Count; i++)
            {
                if (lASZTAL[i].fASZTAL_ID == iASZTAL_ID) { lASZTAL[i].vSelected = true; }
                else { lASZTAL[i].vSelected = false; }

            }


        }
        public void  SaveList()
        {
            
            for (int i = 0; i < lASZTAL.Count; i++)
            {
                SetAsztalPos(lASZTAL[i].fASZTAL_ID, lASZTAL[i].fASZTAL_POS_X, lASZTAL[i].fASZTAL_POS_Y);

            }


        }
        private bool SetAsztalPos(int iASZTAL_ID, int iPos_x, int iPos_y)
        {
            sc = pBLObj.sqlConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE ASZTAL SET ASZTAL_POS_X = @POS_X, ASZTAL_POS_Y = @POS_Y WHERE ASZTAL_ID = @ASZTAL_ID";
            cmd.Parameters.Add(new SqlParameter("POS_X", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("POS_Y", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ASZTAL_ID", SqlDbType.Int));

            cmd.Parameters["POS_X"].Value = iPos_x;
            cmd.Parameters["POS_Y"].Value = iPos_y;
            cmd.Parameters["ASZTAL_ID"].Value = iASZTAL_ID;

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                
                string s = "Hiba az asztal pozició mentése közben mentése közben!";
                return false;
            }


        }

        public bool isUsed(int iASZTAL_ID)
        {
            //select ami lekérdezi a foglaltásgot

            return (GetItem(iASZTAL_ID).isUsed());
        }

    }

}
