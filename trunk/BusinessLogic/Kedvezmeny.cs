using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace BusinessLogic
{
    public class Kedvezmeny
    {
        private int fSZAZALEK;
        public int SZAZALEK
        {
            get { return (fSZAZALEK); }
            set { fSZAZALEK = value; }
        }

        private string fJOG;
        public string JOG
        {
            get { return (fJOG); }
            set { fJOG = value; }
        }

        public Kedvezmeny(int sz, string j)
        {
            fSZAZALEK = sz;
            fJOG = j;
        }

    }

    public class Kedvezmenyek
    {
        public List<Kedvezmeny> lKEDVEZMENY = new List<Kedvezmeny>();

        public Kedvezmenyek()
        {

            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select KEDEZMENY_SZAZAL, isnull(KEDEZMENY_JOG,'') as KEDEZMENY_JOG  from ALTALANOS_KEDVEZMENY ";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Kedvezmeny t = new Kedvezmeny((int)rdr["KEDEZMENY_SZAZAL"], (string)rdr["KEDEZMENY_JOG"]);
                lKEDVEZMENY.Add(t);
            }
            rdr.Close();
            sc.Close();
        }

    }

    public class KedvezmenyErtek
    {
        public int SZAZALEK;
        public double ERTEK;
        public Partner _Partner;
        public KedvezmenyErtek(int sz)
        {
            SZAZALEK = sz;
            ERTEK = 0;
        }

        public KedvezmenyErtek(double ert)
        {
            SZAZALEK = 0;
            ERTEK = ert;
        }

        public KedvezmenyErtek(Partner p)
        {
            
            ERTEK = 0;
            _Partner = p;
            try
            {
                if (p.P_TIPUS == "V")
                {
                    SZAZALEK = new Vevo(p.PARTNER_ID).KEDVEZEMNY_SZAZALEK;
                }
            }
            catch (Exception)
            {
                SZAZALEK = 0;
                throw;
            }
            
        }

    }
}
