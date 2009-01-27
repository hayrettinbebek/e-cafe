using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;

namespace BusinessLogic
{
    public class Rendeles
    {
        private int _AsztalId;
        public int _ScrollPos;
        TBLObj pBLObj;
        private SqlConnection sc;

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

        public TableModel getTableModel()
        {
            TableModel tmpMod = new TableModel( new Row[] {});
            
            for (int i = _ScrollPos; i < lRendelesSor.Count; i++)
            {

                tmpMod.Rows.Add(new Row(new Cell[] {new eCell(lRendelesSor[i]),
													new Cell(lRendelesSor[i]._db),
													new Cell(lRendelesSor[i]._Cikk.MEGNEVEZES),
													new Cell(lRendelesSor[i]._Ertek),
													new Cell(lRendelesSor[i]._datum)}));
            }
            
            return (tmpMod);





        }

        #endregion

        public List<RendelesSor> lRendelesSor = new List<RendelesSor>();


        public Rendeles(TBLObj bl, int pAsztalID, int pRendeles_id)
        {
            pBLObj = bl;
            
            _AsztalId = pAsztalID;
            setColumnModel();
            _ScrollPos = 0;
            fRENDELES_ID = pRendeles_id;
            fDATUM = DateTime.Now;
            fFIZETVE = false;
            fASZTAL_ID = pAsztalID;

            sc = pBLObj.sqlConnection;
           
            if (pRendeles_id != -1)
            {
                // meglevő rendelés be kell tölteni az ID-ra a rendelést.
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sc;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT ASZTAL_ID, isnull(PARTNER_ID,-1) PARTNER_ID, DATUM, FIZETVE FROM RENDELES_FEJ WHERE RENDELES_ID =" + pRendeles_id.ToString();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    fASZTAL_ID = (int)rdr["ASZTAL_ID"];
                    fPARTNER_ID = (int)rdr["PARTNER_ID"];
                    fDATUM = (DateTime)rdr["DATUM"];
                    fFIZETVE = (1 == (int)rdr["FIZETVE"]);
                }
                rdr.Close();



                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT SOR_ID FROM RENDELES_SOR WHERE DELETED = 0 AND RENDELES_ID =" + pRendeles_id.ToString();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lRendelesSor.Add(new RendelesSor((int)rdr["SOR_ID"], new SqlConnection(bl.strConnectionString)));

                }
                rdr.Close();
                

            }
            

        }

        #region Lista funkciók

        public void addTetel(Cikk pCikk)
        {

            lRendelesSor.Add(new RendelesSor(pCikk,pCikk.KISZ_MENNY,250,DateTime.Now));
        }
        public void addTetel(Cikk pCikk, int pRakt)
        {

            lRendelesSor.Add(new RendelesSor(pCikk, pCikk.KISZ_MENNY, 250, DateTime.Now,pRakt));
        }

        #endregion

        #region Mentés / módosítás / törlés / beolvasás
        public void SaveRendeles()
        {
            sc = pBLObj.sqlConnection;
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
                                        ",FIZETVE) " +
                                    "VALUES " +
                                        "(@ASZTAL_ID  " +
                                        ",@DATUM  " +
                                        ",@PARTNER_ID " +
                                        ",@FIZETVE)";

                    break;}
                default:{
                    cmd.CommandText = "UPDATE RENDELES_FEJ SET ASZTAL_ID = @ASZTAL_ID, " +
                                                   " DATUM = @DATUM, " +
                                                   " PARTNER_ID = @PARTNER_ID, "+
                                                   " FIZETVE = @FIZETVE "+
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


            cmd.Parameters["ASZTAL_ID"].Value = fASZTAL_ID;
            cmd.Parameters["DATUM"].Value = fDATUM;
            cmd.Parameters["PARTNER_ID"].Value = fPARTNER_ID;
            cmd.Parameters["FIZETVE"].Value = 0;
            
            
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
        }

        public void InitRendeles(int pRendeles_id)
        {
            lRendelesSor.Clear(); 
            SqlCommand cmd = new SqlCommand();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            cmd.Connection = c;


            cmd.CommandType = CommandType.Text;

            
            cmd.CommandText = "SELECT SOR_ID FROM RENDELES_SOR WHERE DELETED = 0 AND RENDELES_ID =" + pRendeles_id.ToString();
            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                lRendelesSor.Add(new RendelesSor((int)rdr["SOR_ID"], new SqlConnection(DEFS.ConSTR)));

            }
            rdr.Close();
            c.Close();
        }
        
        #endregion
    }


    public class RendelesSor
    {
        private int _SOR_ID;
        public Cikk _Cikk;
        public double _db;
        public double _Ertek;
        public DateTime _datum;
        public int _RaktarId;

        public RendelesSor(Cikk pCikk, double pDb, double pErtek, DateTime pDatum)
        {

            _Cikk = pCikk;
            _datum = pDatum;
            _db = pDb;
            _Ertek = pErtek;
            _SOR_ID = -1;
            _RaktarId = pCikk.ALAP_RAKTAR;
        }

        public RendelesSor(Cikk pCikk, double pDb, double pErtek, DateTime pDatum, int pRaktar)
        {

            _Cikk = pCikk;
            _datum = pDatum;
            _db = pDb;
            _Ertek = pErtek;
            _SOR_ID = -1;
            _RaktarId = pRaktar;
        }

        public RendelesSor(int pRendelesSorID, SqlConnection c)
        {
            SqlCommand cmd2 = new SqlCommand();
            c.Open();

            cmd2.Connection = c;

            cmd2.CommandType = CommandType.Text;

            cmd2.CommandText = "SELECT SOR_ID, CIKK_ID, DB, DATUM, ERTEK as ERTEK, isnull(RAKTAR_ID,-1) as RAKTAR_ID FROM RENDELES_SOR WHERE DELETED = 0 AND SOR_ID =" + pRendelesSorID.ToString();
            
            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                _SOR_ID = (int)rdr2["SOR_ID"];
                _datum = (DateTime)rdr2["DATUM"];
                _Ertek = Convert.ToDouble(rdr2["ERTEK"].ToString());
                _db = (double)rdr2["DB"];
                _RaktarId = (int)rdr2["RAKTAR_ID"];
                _Cikk = new Cikk((int)rdr2["CIKK_ID"], new SqlConnection(DEFS.ConSTR));

            }
            rdr2.Close();
            c.Close();

        }

        public void SaveSor(int pRendelesId)
        {
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
                                            ",ERTEK) " +
                                        "VALUES " +
                                            "(@RENDELES_ID " +
                                            ",@CIKK_ID " +
                                            ",@DB " +
                                            ",@DATUM " +
                                            ",@RAKTAR_ID " +
                                            ",@ERTEK)";

                        break;
                    }
                default:
                    {
                        cmd.CommandText = "UPDATE RENDELES_FEJ SET RENDELES_ID = @RENDELES_ID, " +
                                                       " CIKK_ID = @CIKK_ID, " +
                                                       " DB = @DB, " +
                                                       " DATUM = @DATUM, " +
                                                       " RAKTAR_ID = @RAKTAR_ID, " +
                                                       " ERTEK = @ERTEK, " +
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
            cmd.Parameters.Add(new SqlParameter("ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("RAKTAR_ID", SqlDbType.Int));

            cmd.Parameters["RENDELES_ID"].Value = pRendelesId;
            cmd.Parameters["CIKK_ID"].Value = _Cikk.CIKK_ID;
            cmd.Parameters["DB"].Value = _db;
            cmd.Parameters["DATUM"].Value = _datum;
            cmd.Parameters["RAKTAR_ID"].Value = _RaktarId;
            cmd.Parameters["ERTEK"].Value = _Ertek;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string s = "Hiba a rendelés sorok mentése közben!" + _SOR_ID.ToString() ;
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
                string s = "Hiba a rendelés sorok törlése közben!" + _SOR_ID.ToString();
            }
            c.Close();

        }

    }

}
