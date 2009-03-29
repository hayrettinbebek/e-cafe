using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;

namespace BusinessLogic
{
    public class PartnerHitel
    {
        public List<HitelSor> lHitelSor = new List<HitelSor>();

        public PartnerHitel(int pPArtnerId)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd2 = new SqlCommand();
            c.Open();
            cmd2.Connection = c;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select s.DATUM,c.MEGNEVEZES, isnull(s.ERTEK,0) as OSSZEG, s.RENDELES_ID, " +
                                " s.SOR_ID from hitel_sor h " +
                                " inner join rendeles_sor s on h.rendeles_sor_id = s.sor_id " +
                                " inner join cikk c on s.cikk_id = c.cikk_id " +
                                " WHERE h.partner_id = " + pPArtnerId.ToString();
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                HitelSor hs = new HitelSor();
                hs._SOR_ID = (int)rdr2["SOR_ID"];
                hs._FEJ_ID = (int)rdr2["RENDELES_ID"];

                hs._datum = (DateTime)rdr2["DATUM"];
                hs._Ertek = Convert.ToDouble(rdr2["OSSZEG"].ToString());
                hs._CikkNev = (string)rdr2["MEGNEVEZES"];
                lHitelSor.Add(hs);

            }
            rdr2.Close();
            c.Close();

        }



        
        public ColumnModel getColumnModel()
        {

            //1. oszlop
            ImageColumn imageColumn = new ImageColumn("", 30);
            imageColumn.Editable = false;

            TextColumn textColumn = new TextColumn("név", 110);
            textColumn.Editable = false;

            NumberColumn ertekColumn = new NumberColumn("érték", 50);
            ertekColumn.Editable = false;


            DateTimeColumn datetimeColumn = new DateTimeColumn("idő", 70);
            datetimeColumn.DateTimeFormat = DateTimePickerFormat.Time;
            datetimeColumn.Editable = false;
            datetimeColumn.ShowDropDownButton = false;


            return(new ColumnModel(new Column[] {imageColumn,
                                              datetimeColumn,
											  textColumn,
											  ertekColumn
											  }));
        }

        public TableModel getTableModel()
        {
            TableModel tmpMod = new TableModel(new Row[] { });

            for (int i = 0; i < lHitelSor.Count; i++)
            {

                tmpMod.Rows.Add(new Row(new Cell[] {new HitelCell(lHitelSor[i]),
													new Cell(lHitelSor[i]._datum),
													new Cell(lHitelSor[i]._CikkNev),
													new Cell(lHitelSor[i]._Ertek)
                                                    }
                                       )
                               );
            }

            return (tmpMod);

        }

    }

    public class HitelSor
    {
        public int _SOR_ID;
        public int _FEJ_ID;
        public double _Ertek;
        public DateTime _datum;
        public string _CikkNev;

        public HitelSor()
        {
          
        }

    }

}
