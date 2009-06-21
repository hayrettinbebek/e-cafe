using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace BusinessLogic
{
    public class LeltarSor
    {
        public LeltarSor()
        {

        }
        private int _sor_id;
        public int SOR_ID
        {
            get { return (_sor_id); }
            set { _sor_id = value; }
        }

        private Cikk _Cikk;
        public Cikk P_CIKK
        {
            get { return (_Cikk); }
            set { _Cikk = value; }
        }

        public string P_CIKK_NEV
        {
            get
            {
                if (_Cikk != null)
                {
                    return (_Cikk.MEGNEVEZES);
                }
                else
                {
                    return ("");
                }
            }

        }

        private double _akt_keszlet;
        public double AKT_KESZLET_MENNY
        {
            get { return (_akt_keszlet); }
            set { _akt_keszlet = value; }
        }

        private double _szamolt1;
        public double SZAMOLT_MENNYISEG1
        {
            get { return (_szamolt1); }
            set { _szamolt1 = value; }
        }

        private double _szamolt2;
        public double SZAMOLT_MENNYISEG2
        {
            get { return (_szamolt2); }
            set { _szamolt2 = value; }
        }

        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("UPDATE leltar_sor SET SZAMOLT_MENNYISEG1 = @sz1, SZAMOLT_MENNYISEG2 = @sz2 where LELTAR_SOR_ID = @sor", c);

            gk.CommandType = CommandType.Text;


            gk.Parameters.Add("@sz1", SqlDbType.Float);
            gk.Parameters["@sz1"].Direction = ParameterDirection.Input;
            gk.Parameters["@sz1"].Value = _szamolt1;

            gk.Parameters.Add("@sz2", SqlDbType.Float);
            gk.Parameters["@sz2"].Direction = ParameterDirection.Input;
            gk.Parameters["@sz2"].Value = _szamolt2;

            gk.Parameters.Add("@sor", SqlDbType.Int);
            gk.Parameters["@sor"].Direction = ParameterDirection.Input;
            gk.Parameters["@sor"].Value = _sor_id;

            gk.ExecuteNonQuery();

            c.Close();

        }

    }


    public abstract class TemporaryLeltarSorok
    {
        public static void FillSorok(int _fej)
        {
            LeltarSorok.Clear();

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select LELTAR_SOR_ID, CIKK_ID, AKT_KESZLET_MENNY, SZAMOLT_MENNYISEG1,SZAMOLT_MENNYISEG2 from leltar_sor where leltar_fej_id =" + _fej.ToString();
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                LeltarSor tmpLeltar = new LeltarSor();
                tmpLeltar.SOR_ID = (int)rdr["LELTAR_SOR_ID"];
                tmpLeltar.P_CIKK = new Cikk((int)rdr["CIKK_ID"], true);
                tmpLeltar.AKT_KESZLET_MENNY = (double)rdr["AKT_KESZLET_MENNY"];
                tmpLeltar.SZAMOLT_MENNYISEG1 = (double)rdr["SZAMOLT_MENNYISEG1"];
                tmpLeltar.SZAMOLT_MENNYISEG2 = (double)rdr["SZAMOLT_MENNYISEG2"];
                LeltarSorok.Add(tmpLeltar);
            }

            
        }


        public static List<LeltarSor> LeltarSorok = new List<LeltarSor>();

    }
}
