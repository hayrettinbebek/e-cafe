using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;

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


        public Rendeles(int pAsztalID)
        {
            _AsztalId = pAsztalID;
            setColumnModel();
            _ScrollPos = 0;


        }

        #region Lista funkciók

        public void addTetel(Cikk pCikk)
        {

            lRendelesSor.Add(new RendelesSor(pCikk,1,250,DateTime.Now));
        }

        #endregion
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
    }

}
