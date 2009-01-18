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

                tmpMod.Rows.Add(new Row(new Cell[] {new Cell(),
													new Cell(lRendelesSor[i]._db),
													new Cell(lRendelesSor[i]._Cikk.fMEGNEVEZES),
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

                cmd.CommandText = "SELECT SOR_ID FROM RENDELES_SOR WHERE RENDELES_ID =" + pRendeles_id.ToString();

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

            lRendelesSor.Add(new RendelesSor(pCikk,1,250,DateTime.Now));
        }

        #endregion


        public void SaveRendeles()
        {

        }



    }


    public class RendelesSor
    {
        private int _SOR_ID;
        public Cikk _Cikk;
        public int _db;
        public double _Ertek;
        public DateTime _datum;

        public RendelesSor(Cikk pCikk, int pDb, double pErtek, DateTime pDatum)
        {

            _Cikk = pCikk;
            _datum = pDatum;
            _db = pDb;
            _Ertek = pErtek;
            _SOR_ID = -1;
        }

        public RendelesSor(int pRendelesSorID, SqlConnection c)
        {
            SqlCommand cmd2 = new SqlCommand();
            c.Open();

            cmd2.Connection = c;

            cmd2.CommandType = CommandType.Text;

            cmd2.CommandText = "SELECT SOR_ID, CIKK_ID, DB, DATUM, ERTEK as ERTEK FROM RENDELES_SOR WHERE SOR_ID =" + pRendelesSorID.ToString();
            
            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                _SOR_ID = (int)rdr2["SOR_ID"];
                _datum = (DateTime)rdr2["DATUM"];
                _Ertek = Convert.ToDouble(rdr2["ERTEK"].ToString());
                _db = (int)rdr2["DB"];

                _Cikk = new Cikk((int)rdr2["CIKK_ID"], new SqlConnection(DEFS.ConSTR));

            }
            rdr2.Close();

        }
    }

}
