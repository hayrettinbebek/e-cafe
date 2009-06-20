using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using XPTable.Models;

namespace BusinessLogic
{
    public class Rendeles
    {
        private int _AsztalId;
        public int _ScrollPos;

        public int fRENDELES_ID;
        public int fASZTAL_ID;
        public DateTime fDATUM;
        public int fPARTNER_ID;
        public bool fFIZETVE;


        #region GUI elemek
        private ColumnModel _ColumnModel;
        
        public ColumnModel fColumnModel
        {
            get { return (_ColumnModel); }
            set {}
        }
        private ColumnModel _ColumnModelSum;

        public ColumnModel fColumnModelSum
        {
            get { return (_ColumnModelSum); }
            set { }
        }

        private void setColumnModel()
        {

            //1. oszlop
            ImageColumn imageColumn = new ImageColumn("", 30);
            imageColumn.Editable = false;

            NumberColumn numberColumn = new NumberColumn("db", 28);
            numberColumn.Editable = false;

            TextColumn textColumn = new TextColumn("név", 110);
            textColumn.Editable = false;

            NumberColumn ertekColumn = new NumberColumn("érték", 50);
            ertekColumn.Editable = false;
            
            
            DateTimeColumn datetimeColumn = new DateTimeColumn("idő", 70);
            datetimeColumn.DateTimeFormat = DateTimePickerFormat.Time;
            datetimeColumn.Editable = false;
            datetimeColumn.ShowDropDownButton = false;


            _ColumnModel = new ColumnModel(new Column[] {imageColumn,
																	  numberColumn,
																	  textColumn,
																	  ertekColumn,
																	  datetimeColumn});
        }

        private void setColumnModelSum()
        {

            //1. oszlop
            ImageColumn imageColumn = new ImageColumn("", 30);
            imageColumn.Editable = false;

            NumberColumn numberColumn = new NumberColumn("db", 28);
            numberColumn.Editable = false;

            TextColumn textColumn = new TextColumn("név", 110);
            textColumn.Editable = false;

            NumberColumn ertekColumn = new NumberColumn("érték", 50);
            ertekColumn.Editable = false;


            DateTimeColumn datetimeColumn = new DateTimeColumn("idő", 70);
            datetimeColumn.DateTimeFormat = DateTimePickerFormat.Time;
            datetimeColumn.Editable = false;
            datetimeColumn.ShowDropDownButton = false;


            _ColumnModelSum = new ColumnModel(new Column[] {
																	  numberColumn,
																	  textColumn,
																	  ertekColumn																	  
            });
        }

        public TableModel getTableModel()
        {
            TableModel tmpMod = new TableModel( new Row[] {});
            string tmpMegn = "";
            
            for (int i = _ScrollPos; i < lRendelesSor.Count; i++)
            {
                if (lRendelesSor[i]._LitKiszId > 0)
                {
                    tmpMegn = lRendelesSor[i]._Cikk.KISZ_MEGN +" " + lRendelesSor[i]._Cikk.MEGNEVEZES;
                }
                else
                {
                    tmpMegn = lRendelesSor[i]._Cikk.MEGNEVEZES;
                }
                tmpMod.Rows.Add(new Row(new Cell[] {new eCell(lRendelesSor[i]),
													//new Cell(lRendelesSor[i]._db),
                                                    new Cell(1),
													new Cell(tmpMegn),
													new Cell(lRendelesSor[i]._Ertek),
													new Cell(lRendelesSor[i]._datum)}));
            }
            
            return (tmpMod);





        }

        public TableModel getTableModelSum()
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            TableModel tmpMod = new TableModel(new Row[] { });
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT case when isnull(l.LIT_KISZ_ID,-1) = -1 then c.MEGNEVEZES else l.LIT_KISZ_NEV + ' ' + c.MEGNEVEZES END as MEGNEVEZES "+
                                " ,count(*)*1.0 as DB, sum(s.ERTEK) as ERTEK FROM RENDELES_SOR s " +
                                " inner join CIKK c on s.CIKK_Id = c.CIKK_ID " +
                                " left join LIT_KISZ l on s.LIT_KISZ_ID = l.LIT_KISZ_ID " +
                                " WHERE DELETED = 0 AND isnull(FIZETVE,0) = 0 AND RENDELES_ID =" + this.fRENDELES_ID.ToString() +" " +
                                " group by case when isnull(l.LIT_KISZ_ID,-1) = -1 then c.MEGNEVEZES else l.LIT_KISZ_NEV + ' ' + c.MEGNEVEZES END";
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {


                tmpMod.Rows.Add(new Row(new Cell[] {new Cell((decimal)rdr["DB"]),
													new Cell((string)rdr["MEGNEVEZES"]),
													new Cell((double)rdr["ERTEK"]),
													}));
            }
            sc.Close();
            return (tmpMod);





        }

        #endregion

        public List<RendelesSor> lRendelesSor = new List<RendelesSor>();


        public Rendeles(int pAsztalID, int pRendeles_id)
        {
            
            
            _AsztalId = pAsztalID;
            setColumnModel();
            setColumnModelSum();
            _ScrollPos = 0;
            fRENDELES_ID = pRendeles_id;
            fDATUM = DateTime.Now;
            fFIZETVE = false;
            fASZTAL_ID = pAsztalID;
            fKEDVEZMENY = 0;

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
           
            if (pRendeles_id != -1)
            {
                // meglevő rendelés be kell tölteni az ID-ra a rendelést.
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sc;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT ASZTAL_ID, isnull(PARTNER_ID,-1) PARTNER_ID, DATUM, FIZETVE, isnull(KEDVEZMENY,0) as KEDVEZMENY FROM RENDELES_FEJ WHERE RENDELES_ID =" + pRendeles_id.ToString();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    fASZTAL_ID = (int)rdr["ASZTAL_ID"];
                    fPARTNER_ID = (int)rdr["PARTNER_ID"];
                    fDATUM = (DateTime)rdr["DATUM"];
                    fFIZETVE = (1 == (int)rdr["FIZETVE"]);
                    fKEDVEZMENY = (double)rdr["KEDVEZMENY"];
                }
                rdr.Close();



                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT SOR_ID FROM RENDELES_SOR WHERE isnull(DELETED,0) = 0 AND isnull(FIZETVE,0) = 0 AND RENDELES_ID =" + pRendeles_id.ToString();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lRendelesSor.Add(new RendelesSor((int)rdr["SOR_ID"], new SqlConnection(DEFS.ConSTR), false));

                }
                rdr.Close();
                

            }
            sc.Close();

        }

        #region Összesítők
        private double fKEDVEZMENY;
        public double KEDVEZMENY
        {
            get
            {

                double iTmpSum = 0;

                var ret_cikk =
                    from c in lRendelesSor
                    select c;
                ret_cikk.Each(c => iTmpSum += c.KEDVEZMENY);


                return (iTmpSum);

            }
        }

        public double OSSZESEN
        {
            get { 
            
            double iTmpSum = 0;

            var ret_cikk =
                from c in lRendelesSor
                select c;
            ret_cikk.Each(c => iTmpSum += c._Ertek);


            return (iTmpSum);
            
            }
            
        }

        public double FIZETENDO
        {
            get
            {

                return (OSSZESEN-KEDVEZMENY);

            }

        }

        #endregion


        public void addKedvezmSzaz(double k)
        {
            foreach (var s in lRendelesSor)
            {
                s.addKedvezmSzaz(k);
            }
        }

        public void addKedvezmFt(double k)
        {
            foreach (var s in lRendelesSor)
            {
                s.addKedvezmFt((s._Ertek*k)/OSSZESEN);
            }
        }

        #region Lista funkciók

        public void addTetel(Cikk pCikk)
        {

            lRendelesSor.Add(new RendelesSor(pCikk, pCikk.KISZ_MENNY, Math.Round( pCikk.NETTO_AR,2), DateTime.Now, pCikk.LIT_KISZ_ID));
        }
        public void addTetel(Cikk pCikk, int pRakt)
        {

            lRendelesSor.Add(new RendelesSor(pCikk, pCikk.KISZ_MENNY, Math.Round(pCikk.NETTO_AR, 2), DateTime.Now, pRakt, pCikk.LIT_KISZ_ID));
        }

        #endregion

        #region Mentés / módosítás / törlés / beolvasás
        public void SaveRendeles()
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;

            switch (fRENDELES_ID)
            {
                case -1: {
                    //új rekord!!
                    cmd.CommandText = "INSERT INTO RENDELES_FEJ " +
                                        "(ASZTAL_ID "+
                                        ",DATUM " +
                                        ",PARTNER_ID " +
                                        ",USER_ID " +
                                        ",EV " +
                                        ",HO " +
                                        ",NAP " +
                                        ",FIZETVE "+
                                        ",KEDVEZMENY) " +
                                    "VALUES " +
                                        "(@ASZTAL_ID  " +
                                        ",@DATUM  " +
                                        ",@PARTNER_ID " +
                                        ",@USER_ID " +
                                        ",@EV " +
                                        ",@HO " +
                                        ",@NAP " +
                                        ",@FIZETVE " +
                                        ",@KEDVEZMENY)";

                    break;}
                default:{
                    cmd.CommandText = "UPDATE RENDELES_FEJ SET ASZTAL_ID = @ASZTAL_ID, " +
                                                   " DATUM = @DATUM, " +
                                                   " PARTNER_ID = @PARTNER_ID, "+
                                                   " USER_ID = @USER_ID, "+
                                                   " EV = @EV, "+
                                                   " HO = @HO, "+
                                                   " NAP = @NAP, "+
                                                   " FIZETVE = @FIZETVE, "+
                                                   " KEDVEZMENY = @KEDVEZMENY "+
                                       "WHERE RENDELES_ID = @RENDELES_ID";
                    cmd.Parameters.Add(new SqlParameter("RENDELES_ID", SqlDbType.Int));
                    cmd.Parameters["RENDELES_ID"].Value = fRENDELES_ID;
                    break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("ASZTAL_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("DATUM", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("FIZETVE", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("KEDVEZMENY", SqlDbType.Float));

            cmd.Parameters.Add(new SqlParameter("USER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("HO", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("NAP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("EV", SqlDbType.Int));


            cmd.Parameters["ASZTAL_ID"].Value = fASZTAL_ID;
            cmd.Parameters["DATUM"].Value = fDATUM;
            cmd.Parameters["PARTNER_ID"].Value = fPARTNER_ID;
            cmd.Parameters["FIZETVE"].Value = 0;
            cmd.Parameters["KEDVEZMENY"].Value = fKEDVEZMENY;
            

            cmd.Parameters["USER_ID"].Value = DEFS.LogInUser.USER_ID;
            cmd.Parameters["HO"].Value = DEFS.NyitNap_HO;
            cmd.Parameters["NAP"].Value = DEFS.NyitNap_NAP;
            cmd.Parameters["EV"].Value = DEFS.NyitNap_EV;
            
            
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "";
            if (fRENDELES_ID == -1)
            {
                cmd.CommandText = "SELECT max(RENDELES_ID) as RENDELES_ID FROM RENDELES_FEJ WHERE ASZTAL_ID = @ASZTAL_ID AND FIZETVE = 0 ";
                cmd.Parameters.Add(new SqlParameter("ASZTAL_ID", SqlDbType.Int));
                cmd.Parameters["ASZTAL_ID"].Value = fASZTAL_ID;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    fRENDELES_ID = (int)rdr["RENDELES_ID"];

                }
                rdr.Close();
            }

            if (fRENDELES_ID != -1)
            {
                //Sorok mentése
                foreach (var sor in lRendelesSor)
                {
                    sor.SaveSor(fRENDELES_ID);
                }
            }
            sc.Close();
        }

        public void InitRendeles(int pRendeles_id)
        {
            lRendelesSor.Clear(); 
            SqlCommand cmd = new SqlCommand();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            cmd.Connection = c;


            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT SOR_ID FROM RENDELES_SOR WHERE isnull(DELETED,0) = 0 AND isnull(FIZETVE,0) = 0  AND RENDELES_ID =" + pRendeles_id.ToString();
            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                lRendelesSor.Add(new RendelesSor((int)rdr["SOR_ID"], new SqlConnection(DEFS.ConSTR),false));

            }
            rdr.Close();
            c.Close();
        }
        
        #endregion
    }


    public class RendelesSor
    {
        public int _SOR_ID;
        public Cikk _Cikk;
        public double _db;
        public double _Ertek;
        public double _Netto_Ertek;
        public double _Afa_Ertek;

        public DateTime _datum;
        public int _RaktarId;
        public int _LitKiszId;

        private double fKEDVEZMENY;
        public double KEDVEZMENY
        {
            get { return (fKEDVEZMENY); }
            set { fKEDVEZMENY = value; }
        }

        public RendelesSor(Cikk pCikk, double pDb, double pErtek, DateTime pDatum, int litkisz)
        {

            _Cikk = pCikk;
            _datum = pDatum;
            _LitKiszId = litkisz;
            if (pDb == 0)
            {
                _db = 1;
            }
            else
            {
                _db = pDb;
            }
            _Netto_Ertek = pErtek;
            _SOR_ID = -1;
            fKEDVEZMENY = 0;
            _RaktarId = pCikk.ALAP_RAKTAR;
        }

        public RendelesSor(Cikk pCikk, double pDb, double pErtek, DateTime pDatum, int pRaktar, int litkisz)
        {

            _Cikk = pCikk;
            _datum = pDatum;
            _LitKiszId = litkisz;
            if (pDb == 0)
            {
                _db = 1;
            }
            else
            {
                _db = pDb;
            }
            _Netto_Ertek = pErtek;
            _SOR_ID = -1;
            fKEDVEZMENY = 0;
            _RaktarId = pRaktar;
        }

        public RendelesSor(int pRendelesSorID, SqlConnection c, bool pSzamla)
        {
            SqlCommand cmd2 = new SqlCommand();
            c.Open();
            
            cmd2.Connection = c;

            cmd2.CommandType = CommandType.Text;

            if (pSzamla)
            {
                cmd2.CommandText = "SELECT SOR_ID, CIKK_ID, DB, DATUM, ERTEK as ERTEK, isnull(NETTO_ERTEK,0) as NETTO_ERTEK, isnull(AFA_ERTEK,0) as AFA_ERTEK  , isnull(RAKTAR_ID,-1) as RAKTAR_ID, isnull(LIT_KISZ_ID,-1) as  LIT_KISZ_ID, " +
                                   "isnull(KEDVEZMENY,0) as KEDVEZMENY FROM RENDELES_SOR WHERE SOR_ID =" + pRendelesSorID.ToString();
            } else
            {
                cmd2.CommandText = "SELECT SOR_ID, CIKK_ID, DB, DATUM, ERTEK as ERTEK, isnull(NETTO_ERTEK,0) as NETTO_ERTEK, isnull(AFA_ERTEK,0) as AFA_ERTEK  , isnull(RAKTAR_ID,-1) as RAKTAR_ID, isnull(LIT_KISZ_ID,-1) as  LIT_KISZ_ID, " +
                                    "isnull(KEDVEZMENY,0) as KEDVEZMENY  FROM RENDELES_SOR WHERE isnull(DELETED,0) = 0 AND isnull(FIZETVE,0) = 0 AND SOR_ID =" + pRendelesSorID.ToString();
            }
            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                _SOR_ID = (int)rdr2["SOR_ID"];
                _datum = (DateTime)rdr2["DATUM"];
                _Ertek = Convert.ToDouble(rdr2["ERTEK"].ToString());
                _Netto_Ertek = Convert.ToDouble(rdr2["NETTO_ERTEK"].ToString());
                _Afa_Ertek = Convert.ToDouble(rdr2["AFA_ERTEK"].ToString());
                _db = (double)rdr2["DB"];
                _RaktarId = (int)rdr2["RAKTAR_ID"];
                _LitKiszId = (int)rdr2["LIT_KISZ_ID"];
                fKEDVEZMENY = (double)rdr2["KEDVEZMENY"];
                _Cikk = new Cikk((int)rdr2["CIKK_ID"], new SqlConnection(DEFS.ConSTR), (int)rdr2["LIT_KISZ_ID"]);

            }
            rdr2.Close();
            c.Close();

        }

        public void SaveSor(int pRendelesId)
        {

            int new_p_id = _SOR_ID;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;

           

            switch (_SOR_ID)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO RENDELES_SOR " +
                                            "(RENDELES_ID " +
                                            ",CIKK_ID " +
                                            ",DB " +
                                            ",DATUM "+
                                            ",RAKTAR_ID " +
                                            ",MODIFIED_USER " +
                                            ",AFA_ERTEK " +
                                            ",ERTEK " +
                                            ",NETTO_ERTEK " +
                                            ",LIT_KISZ_ID "+
                                            ",KEDVEZMENY) " +
                                        "VALUES " +
                                            "(@RENDELES_ID " +
                                            ",@CIKK_ID " +
                                            ",@DB " +
                                            ",@DATUM " +
                                            ",@RAKTAR_ID " +
                                            ",@MODIFIED_USER " +
                                            ",@AFA_ERTEK " +
                                            ",@ERTEK " +
                                            ",@NETTO_ERTEK " +
                                            ",@LIT_KISZ_ID "+
                                            ",@KEDVEZMENY) SET @newid = SCOPE_IDENTITY()";
                        cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                        cmd.Parameters["newid"].Direction = ParameterDirection.Output;

                        break;
                    }
                default:
                    {
                        cmd.CommandText = "UPDATE RENDELES_SOR SET RENDELES_ID = @RENDELES_ID, " +
                                                       " CIKK_ID = @CIKK_ID, " +
                                                       " DB = @DB, " +
                                                       " DATUM = @DATUM, " +
                                                       " RAKTAR_ID = @RAKTAR_ID, " +
                                                       " MODIFIED_USER = @MODIFIED_USER, " +
                                                       " NETTO_ERTEK = @NETTO_ERTEK, " +
                                                       " LIT_KISZ_ID = @LIT_KISZ_ID, " +
                                                       " KEDVEZMENY = @KEDVEZMENY " +
                                           "WHERE SOR_ID = @SOR_ID";
                        cmd.Parameters.Add(new SqlParameter("SOR_ID", SqlDbType.Int));
                        cmd.Parameters["SOR_ID"].Value = _SOR_ID;
                        break;
                    }
            }
            cmd.Parameters.Add(new SqlParameter("RENDELES_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("DATUM", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("DB", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("NETTO_ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("AFA_ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("KEDVEZMENY", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("RAKTAR_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("MODIFIED_USER", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("LIT_KISZ_ID", SqlDbType.Int));

            cmd.Parameters["RENDELES_ID"].Value = pRendelesId;
            cmd.Parameters["CIKK_ID"].Value = _Cikk.CIKK_ID;
            cmd.Parameters["DB"].Value = _db;
            cmd.Parameters["DATUM"].Value = _datum;
            cmd.Parameters["RAKTAR_ID"].Value = _RaktarId;
            cmd.Parameters["MODIFIED_USER"].Value = DEFS.LogInUser.USER_ID;
            cmd.Parameters["NETTO_ERTEK"].Value = _Netto_Ertek;
            cmd.Parameters["ERTEK"].Value = Math.Round(_Netto_Ertek * (1+(_Cikk.AFA_SZAZ/100)),2);
            cmd.Parameters["AFA_ERTEK"].Value = Math.Round(_Netto_Ertek * (_Cikk.AFA_SZAZ / 100), 2);
            cmd.Parameters["LIT_KISZ_ID"].Value = _LitKiszId;
            cmd.Parameters["KEDVEZMENY"].Value = fKEDVEZMENY;
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.SendSaveErrMessage("Hiba a rendelés sorok mentése közben!" + _SOR_ID.ToString() + e.Message + "\n" + e.StackTrace) ;
            }

            if (_SOR_ID == -1)
            {
                new_p_id = (int)cmd.Parameters["newid"].Value;
                _SOR_ID = new_p_id;
            }

            c.Close();


        }

        public void DeleteSor()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "UPDATE RENDELES_SOR SET DELETED = 1 WHERE SOR_ID =" + _SOR_ID.ToString();




            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.SendSaveErrMessage("Hiba a rendelés sorok törlése közben!" + _SOR_ID.ToString() + e.Message + "\n" + e.StackTrace);
            }
            c.Close();

        }

        public void StornoSor()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "UPDATE RENDELES_SOR SET CANCELED = 1, FIZETVE = 1 WHERE SOR_ID =" + _SOR_ID.ToString();




            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.SendSaveErrMessage("Hiba a rendelés sorok sztornózása közben!" + _SOR_ID.ToString() + e.Message + "\n" + e.StackTrace);
            }
            c.Close();

        }

        public void addKedvezmSzaz(double k)
        {
            KEDVEZMENY = _Ertek * (k/100);

        }

        public void addKedvezmFt(double k)
        {
            KEDVEZMENY = k;

        }

    }

}
