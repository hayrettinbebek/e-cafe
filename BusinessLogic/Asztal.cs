using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using XPTable.Models;


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
        public int fNAME_VISIBLE;
        public int fUSEABLE;

        #region Foglalások

        public List<Foglalas> lFOGLALASOK
        {
            get { return(getFoglalasok()); }
        }

        public List<Foglalas> lFOGLALAS_PARAM_IDON_BELUL
        {
            get
            {
                List<Foglalas> iTmpRet = new List<Foglalas>();

                var ret_fogl =
                    from c in lFOGLALASOK
                    where (c.METTOL < (DateTime.Now).AddHours((int)Syspar2.GetValue(ParamCodes.SHOW_ORDER_BEFORE)) && c.MEDDIG >= DateTime.Now)
                    select c;
                ret_fogl.Each(c => iTmpRet.Add(c));


                return (iTmpRet);
            }
        }

       
        #endregion


        #region Constructor
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

        #endregion

        public bool isUsed()
        {
            //select ami lekérdezi a foglaltásgot

            return ((fASZTAL_ID % 2) == 0);
        }


        private List<Foglalas> getFoglalasok()
        {
            List<Foglalas> tmpl = new List<Foglalas>();


            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT FOGLAL_FROM ,FOGLAL_TO, NEV ,TELEFON FROM FOGLALAS WHERE ASZTAL_ID =" + fASZTAL_ID.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Foglalas t = new Foglalas((DateTime)rdr["FOGLAL_FROM"], (DateTime)rdr["FOGLAL_TO"], (string)rdr["NEV"], (string)rdr["TELEFON"]);
               
                tmpl.Add(t);
            }
            rdr.Close();
            sc.Close();

            return (tmpl);
        }

     }

    public class Asztal_List
    {
        

        public List<Asztal> lASZTAL = new List<Asztal>();
        
        
        public Asztal_List(int aHelyId)
        {

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT a.ASZTAL_ID, a.ASZTAL_SZAM, a.ASZTAL_TIPUS_ID, a.ASZTAL_POS_X, a.ASZTAL_POS_Y, " +
                    " a.ASZTAL_ROTATE, isnull((select max(RENDELES_ID) from RENDELES_FEJ f where f.ASZTAL_ID = a.ASZTAL_ID and isnull(f.FIZETVE,0) = 0 and isnull(AKTIV,1) = 1 ),-1) as RENDELES_ID,  " +
                    " isnull(USEABLE,1) as USEABLE, isnull(NAME_VISIBLE,1) as NAME_VISIBLE " +
                    " FROM ASZTAL a WHERE a.HELY_ID =" + aHelyId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Asztal t = new Asztal((int)rdr["ASZTAL_ID"], rdr["ASZTAL_SZAM"].ToString(), (int)rdr["ASZTAL_TIPUS_ID"], (int)rdr["ASZTAL_POS_X"], (int)rdr["ASZTAL_POS_Y"], false, (int)rdr["ASZTAL_ROTATE"]);
                t.fRENDELES_ID = (int)rdr["RENDELES_ID"];
                t.fNAME_VISIBLE = (int)rdr["NAME_VISIBLE"];
                t.fUSEABLE = (int)rdr["USEABLE"];
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
                SetAsztalPos(lASZTAL[i].fASZTAL_ID, lASZTAL[i].fASZTAL_POS_X, lASZTAL[i].fASZTAL_POS_Y, lASZTAL[i].fASZTAL_TIPUS, lASZTAL[i].fASZTAL_SZAM, lASZTAL[i].fASZTAL_ROTATE, lASZTAL[i].fUSEABLE, lASZTAL[i].fNAME_VISIBLE);

            }


        }
        private bool SetAsztalPos(int iASZTAL_ID, int iPos_x, int iPos_y, int aTip, string aSzam, int aRot, int useable, int name_vis)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE ASZTAL SET ASZTAL_POS_X = @POS_X, ASZTAL_POS_Y = @POS_Y, ASZTAL_ROTATE = @ROT, ASZTAL_TIPUS_ID = @A_TIP, ASZTAL_SZAM = @ASZAM, USEABLE = @USE, NAME_VISIBLE = @NAME_VIS WHERE ASZTAL_ID = @ASZTAL_ID";
            cmd.Parameters.Add(new SqlParameter("POS_X", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("POS_Y", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ASZTAL_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ASZAM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("A_TIP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ROT", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("USE", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("NAME_VIS", SqlDbType.Int));

            cmd.Parameters["POS_X"].Value = iPos_x;
            cmd.Parameters["POS_Y"].Value = iPos_y;
            cmd.Parameters["ASZTAL_ID"].Value = iASZTAL_ID;

            cmd.Parameters["ASZAM"].Value = aSzam;
            cmd.Parameters["A_TIP"].Value = aTip;
            cmd.Parameters["ROT"].Value = aRot;
            cmd.Parameters["USE"].Value = useable;
            cmd.Parameters["NAME_VIS"].Value = name_vis;

            try
            {
                cmd.ExecuteNonQuery();
                sc.Close();
                return true;
            }
            catch (Exception e)
            {
                sc.Close();
                DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                return false;
                
            }
            


        }

        public bool isUsed(int iASZTAL_ID)
        {
            //select ami lekérdezi a foglaltásgot

            return (GetItem(iASZTAL_ID).isUsed());
        }

    }


    #region Foglalás
    public class Foglalas
    {
        public DateTime METTOL;
        public DateTime MEDDIG;
        public string NEV;
        public string TELEFON;

       

        public Foglalas(DateTime pMETTOL, DateTime pMEDDIG, string pNEV, string pTELEFON)
        {

            METTOL = pMETTOL;
            MEDDIG = pMEDDIG;
            NEV = pNEV;
            TELEFON = pTELEFON;
        }

        public static ColumnModel getColumnModelInfo()
        {

            //1. oszlop
            //ImageColumn imageColumn = new ImageColumn("", 30);
            //imageColumn.Editable = false;

            TextColumn d_tol = new TextColumn("Tól", 85);
            d_tol.Editable = false;

            TextColumn d_ig = new TextColumn("Ig", 45);
            d_ig.Editable = false;

            TextColumn NevColumn = new TextColumn("Név", 170);
            NevColumn.Editable = false;
            NevColumn.Alignment = ColumnAlignment.Right;

            return (new ColumnModel(new Column[] { d_tol,d_ig, NevColumn }));
        }

        public static TableModel getTableModelInfo(List<Foglalas> ff)
        {
            TableModel tmpMod = new TableModel(new Row[] { });

            foreach (var lf in ff)
            {
                tmpMod.Rows.Add(new Row(new Cell[] {new Cell(lf.METTOL.ToString("MM.dd hh:mm")),
													new Cell(lf.MEDDIG.ToString("hh:mm")),
                                                    new Cell(lf.NEV)
													}));
                tmpMod.Rows.Add(new Row(new Cell[] {new Cell(),
													new Cell(),
                                                    new Cell(lf.TELEFON)
													}));
            }

            return (tmpMod);
        }
    }

    #endregion


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

            cmd.CommandText = "select h.HELY_ID, h.HELY_NEV, h.HELY_VAN_DESIGN from HELY h inner join ASZTAL a on h.HELY_ID = a.HELY_ID WHERE h.AKTIV = 1" +
                                " union " +
                                " select h.HELY_ID, h.HELY_NEV, h.HELY_VAN_DESIGN from HELY h where h.HELY_VAN_DESIGN = 0 and h.AKTIV = 1";

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
