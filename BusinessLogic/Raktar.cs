using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    #region Raktár
    public class Raktar
    {
        private int _RaktarID;
        public int ID
        {
            get { return (_RaktarID); }
            set { _RaktarID = value; }
        }

        private string _RaktarKod;
        public string KOD
        {
            get { return (_RaktarKod); }
            set { _RaktarKod = value; }
        }

        private string _RaktarLeiras;
        public string LEIRAS
        {
            get { return (_RaktarLeiras); }
            set { _RaktarLeiras = value; }
        }


        public Raktar(int pID, string pKoD, string pLEIRAS)
        {

            _RaktarID = pID;
            _RaktarKod = pKoD;
            _RaktarLeiras = pLEIRAS;



        }
    }

    public class RaktarLista
    {


        public List<Raktar> lRAKTAR = new List<Raktar>();


        public RaktarLista(SqlConnection sc)
        {

            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT RAKTAR_ID, RAKTAR_KOD, isnull(RAKTAR_LEIRAS,'') as RAKTAR_LEIRAS  FROM RAKTAR";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Raktar t = new Raktar((int)rdr["RAKTAR_ID"],
                                  (string)rdr["RAKTAR_KOD"], 
                                  (string)rdr["RAKTAR_LEIRAS"]);
                
                lRAKTAR.Add(t);
            }
            rdr.Close();
        }

        public Raktar RaktarByID(int pRaktarID)
        {
            Raktar iTmpRet = null;

            var ret_rakt =
                from c in lRAKTAR
                where c.ID == pRaktarID
                select c;
            ret_rakt.Each(c => iTmpRet =c);


            return (iTmpRet);
        }
    }
    #endregion
}
