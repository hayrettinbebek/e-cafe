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
        public int fASZTAL_ROTATE;
        public int fRENDELES_ID;


        public Asztal()
        {
            fASZTAL_ID = -1;
            fASZTAL_SZAM = "";
            fASZTAL_TIPUS = -1;
            fASZTAL_POS_X = -1;
            fASZTAL_POS_Y = -1;
            fRENDELES_ID = -1;
            vSelected = false;
        }

        public Asztal(int iASZTAL_ID, string iASZTAL_SZAM, int iASZTAL_TIPUS, int iASZTAL_POS_X, int iASZTAL_POS_Y, bool iSelected, int iASZTAL_ROTATE)
        {
            fASZTAL_ID = iASZTAL_ID;
            fASZTAL_SZAM = iASZTAL_SZAM;
            fASZTAL_TIPUS = iASZTAL_TIPUS;
            fASZTAL_POS_X = iASZTAL_POS_X;
            fASZTAL_POS_Y = iASZTAL_POS_Y;
            fASZTAL_ROTATE = iASZTAL_ROTATE;
            vSelected = iSelected;
            fRENDELES_ID = -1;
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
        
        
        public Asztal_List(int aHelyId)
        {
            
            sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT a.ASZTAL_ID, a.ASZTAL_SZAM, a.ASZTAL_TIPUS_ID, a.ASZTAL_POS_X, a.ASZTAL_POS_Y, " +
                    " a.ASZTAL_ROTATE, isnull((select max(RENDELES_ID) from RENDELES_FEJ where ASZTAL_ID = a.ASZTAL_ID),-1) as RENDELES_ID " +
                    " FROM ASZTAL a WHERE a.HELY_ID =" + aHelyId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Asztal t = new Asztal((int)rdr["ASZTAL_ID"], rdr["ASZTAL_SZAM"].ToString(), (int)rdr["ASZTAL_TIPUS_ID"], (int)rdr["ASZTAL_POS_X"], (int)rdr["ASZTAL_POS_Y"], false, (int)rdr["ASZTAL_ROTATE"]);
                t.fRENDELES_ID = (int)rdr["RENDELES_ID"];
                lASZTAL.Add(t);
            }
            rdr.Close();
            sc.Close();
        }

        public Asztal GetItem(int iASZTAL_ID)
        {
            Asztal _ret = new Asztal();
            var ret_asztal =
                from c in lASZTAL
                where c.fASZTAL_ID == iASZTAL_ID
                select c;
            ret_asztal.Each(c => _ret = c);
            return (_ret);


            //IEnumerable<Asztal> r = lASZTAL.Where(p => p.fASZTAL_ID == iASZTAL_ID);

            //foreach (var n in r)
            //{
            //    ret = n;
            //}
         
        }

        public int GetItemIndex(int iASZTAL_ID)
        {
            int _ret = -1;
            for (int i = 0; i < lASZTAL.Count; i++)
            {
                if (lASZTAL[i].fASZTAL_ID == iASZTAL_ID) { _ret = i; break; }
                else { _ret = -1; }

            }
            return (_ret);

            //var ret_asztal =
            //    from c in lASZTAL
            //    where c.fASZTAL_ID == iASZTAL_ID
            //    select c;
            //ret_asztal.Each(c => _ret = c.fASZTAL_ID);
            //return (_ret);


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
            sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
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
                
                //string s = "Hiba az asztal pozició mentése közben!";
                return false;
            }
            sc.Close();


        }

        public bool isUsed(int iASZTAL_ID)
        {
            //select ami lekérdezi a foglaltásgot

            return (GetItem(iASZTAL_ID).isUsed());
        }

    }

    #region Helyek
    public class Hely
    {
        public int fHELY_ID;
        public int fHELY_VAN_KEP;
        public string fHELY_NEV;

        public string HELY_NEV
        {
            get { return (fHELY_NEV); }


        }

        public Hely(int pHELY_ID, string pHELY_NEV, int pHELY_VAN_KEP)
        {

            fHELY_ID = pHELY_ID;
            fHELY_NEV = pHELY_NEV;
            fHELY_VAN_KEP = pHELY_VAN_KEP;
        }
    }

    public class Helyek
    {
       

        public List<Hely> lHelyek = new List<Hely>();

        public Helyek()
        {

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select h.HELY_ID, h.HELY_NEV, h.HELY_VAN_DESIGN from HELY h inner join ASZTAL a on h.HELY_ID = a.HELY_ID " +
                                " union " +
                                " select h.HELY_ID, h.HELY_NEV, h.HELY_VAN_DESIGN from HELY h where h.HELY_VAN_DESIGN = 0";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Hely t = new Hely((int)rdr["HELY_ID"],
                                (string)rdr["HELY_NEV"],
                                (int)rdr["HELY_VAN_DESIGN"]);
                lHelyek.Add(t);
            }
            rdr.Close();
            sc.Close();
        }

    }
    #endregion
}
