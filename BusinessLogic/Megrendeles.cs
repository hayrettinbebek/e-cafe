using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace BusinessLogic
{

    public class Megrendeles
    {
        #region Properties

        public bool isModified;

        private int _MEGRENDELES_FEJ_ID;
        public int MEGRENDELES_FEJ_ID
        {
            get { return (_MEGRENDELES_FEJ_ID); }
            set
            {
                if (_MEGRENDELES_FEJ_ID != value) { isModified = true; }
                _MEGRENDELES_FEJ_ID = value;
            }
        }

        private DateTime _DATUM;
         public DateTime DATUM
        {
            get { return (_DATUM); }
            set
            {
                if (_DATUM != value) { isModified = true; }
                _DATUM = value;
            }
        }

        private int _SZALLITO_ID;
        public int SZALLITO_ID
        {
            get { return (_SZALLITO_ID); }
            set { if (_SZALLITO_ID != value) { isModified = true; } _SZALLITO_ID = value; }
        }

        private string _SORSZAM;
        public string SORSZAM
        {
            get { return (_SORSZAM); }
            set { if (_SORSZAM != value) { isModified = true; } _SORSZAM = value; }
        }

        private int _LEZART;
        public bool LEZART
        {
            get { return (_LEZART == 1); }
            set
            {
                if (value) { _LEZART = 1; }
                else { _LEZART = 0; }
            }
        }

       

        #endregion

        public Megrendeles(int pSzallito)
        {

            _MEGRENDELES_FEJ_ID = -1;
            _SZALLITO_ID = pSzallito;
            _SORSZAM = "";
            _LEZART = 0;
            _DATUM = DateTime.Now;

        }


        public Megrendeles(int pM_FejId, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT MEGRENDELES_FEJ_ID ,DATUM ,SZALLITO_ID ,SORSZAM ,LEZART FROM  MEGRENDELES_FEJ WHERE MEGRENDELES_FEJ_ID =" + pM_FejId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                _MEGRENDELES_FEJ_ID = (int)rdr["MEGRENDELES_FEJ_ID"];

                if (!DBNull.Value.Equals(rdr["DATUM"])) { _DATUM = (DateTime)rdr["DATUM"]; }
                else { _DATUM = DateTime.Now; }

                if (!DBNull.Value.Equals(rdr["SZALLITO_ID"])) { _SZALLITO_ID= (int)rdr["SZALLITO_ID"]; }
                else { _SZALLITO_ID = -1; }

                if (!DBNull.Value.Equals(rdr["SORSZAM"])) { _SORSZAM= (string)rdr["SORSZAM"]; }
                else { _SORSZAM = ""; }

                if (!DBNull.Value.Equals(rdr["LEZART"])) { _LEZART = (int)rdr["LEZART"]; }
                else { _LEZART = 0; }

            }
            rdr.Close();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SOR_ID FROM BEVETEL_SOR WHERE BEVETEL_FEJ_ID =" + pBevFej_id.ToString();

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lBevetelSorok.Add(new BevetelSor((int)rdr["SOR_ID"], new SqlConnection(DEFS.ConSTR)));

            }
            rdr.Close();


            c.Close();
            isModified = false;



        }

        public int Save()
        {
            int new_p_id = _BEVETEL_FEJ_ID;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (_BEVETEL_FEJ_ID)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO BEVETEL_FEJ " +
                           " (DATUM " +
                           " ,PARTNER_ID " +
                           " ,SZALLITOLEVEL_SZAM " +
                           " ,KONYVELT " +
                            " ,BIZONYLATSZAM  " +
                           " ,SZAMLA_SZAM   " +
                           " ,SZAMLA_OSSZESEN   " +
                           " ,SZAMLA_OSSZ_BRUTTO) " +
                           " VALUES " +
                           " (@DATUM " +
                           " ,@PARTNER_ID " +
                           " ,@SZALLITOLEVEL_SZAM " +
                           " ,@KONYVELT " +
                           " ,@BIZONYLATSZAM, @SZAMLA_SZAM, @SZAMLA_OSSZESEN, @SZAMLA_OSSZ_BRUTTO)  SET @newid = SCOPE_IDENTITY()";
                        cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                        cmd.Parameters["newid"].Direction = ParameterDirection.Output;
                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE BEVETEL_FEJ " +
                                          " SET DATUM = @DATUM " +
                                          "    ,PARTNER_ID = @PARTNER_ID " +
                                          "    ,SZALLITOLEVEL_SZAM = @SZALLITOLEVEL_SZAM " +
                                          "    ,BIZONYLATSZAM = @BIZONYLATSZAM " +
                                          "    ,KONYVELT = @KONYVELT " +
                                          "    ,SZAMLA_SZAM = @SZAMLA_SZAM " +
                                          "    ,SZAMLA_OSSZESEN = @SZAMLA_OSSZESEN " +
                                          "    ,SZAMLA_OSSZ_BRUTTO = @SZAMLA_OSSZ_BRUTTO " +
                                          " WHERE BEVETEL_FEJ_ID= @BEVETEL_FEJ";
                        cmd.Parameters.Add(new SqlParameter("BEVETEL_FEJ", SqlDbType.Int));
                        cmd.Parameters["BEVETEL_FEJ"].Value = _BEVETEL_FEJ_ID;
                        break;
                    }
            }
            cmd.Parameters.Add(new SqlParameter("DATUM", SqlDbType.DateTime));

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("KONYVELT", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("SZALLITOLEVEL_SZAM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("BIZONYLATSZAM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("SZAMLA_SZAM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("SZAMLA_OSSZESEN", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("SZAMLA_OSSZ_BRUTTO", SqlDbType.Float));


            cmd.Parameters["DATUM"].Value = _DATUM;
            cmd.Parameters["PARTNER_ID"].Value = _PARTNER_ID;
            cmd.Parameters["KONYVELT"].Value = _KONYVELT;
            cmd.Parameters["SZALLITOLEVEL_SZAM"].Value = _SZALLITOLEVEL_SZAM;
            cmd.Parameters["BIZONYLATSZAM"].Value = _BISZ_SZAM;
            cmd.Parameters["SZAMLA_SZAM"].Value = SZAMLASZAM;
            cmd.Parameters["SZAMLA_OSSZESEN"].Value = SZAMLA_OSSZESEN;
            cmd.Parameters["SZAMLA_OSSZ_BRUTTO"].Value = SZAMLA_OSSZ_BRUTTO;

            //try
            //{
            cmd.ExecuteNonQuery();

            if (_BEVETEL_FEJ_ID == -1)
            {
                new_p_id = (int)cmd.Parameters["newid"].Value;
            }
            //DEFS.SendSaveErrMessage(new_p_id.ToString() +" : Sikertelen bevlételezés mentés");

            _BEVETEL_FEJ_ID = new_p_id;
            c.Close();
            return (new_p_id);
        }

        public List<BevetelSor> lBevetelSorok = new List<BevetelSor>();

        public void addTetel(int pSor)
        {

            lBevetelSorok.Add(new BevetelSor(pSor, new SqlConnection(DEFS.ConSTR)));
        }

        public void addTetel()
        {
            lBevetelSorok.Add(new BevetelSor());
        }

    }
    public class BevetelFList
    {

        public List<Bevetel_fej> lBevFej = new List<Bevetel_fej>();


        public BevetelFList(SqlConnection sc)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT BEVETEL_FEJ_ID FROM BEVETEL_FEJ";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Bevetel_fej t = new Bevetel_fej((int)rdr["BEVETEL_FEJ_ID"], new SqlConnection(DEFS.ConSTR));


                lBevFej.Add(t);
            }
            rdr.Close();
            sc.Close();
        }

        //public List<Cikk> CikkListByCsoport(int iCsoportId)
        //{
        //    List<Cikk> iTmpRet = new List<Cikk>();

        //    var ret_cikk =
        //        from c in lCIKK
        //        where c.CIKKCSOPORT_ID == iCsoportId
        //        select c;
        //    ret_cikk.Each(c => iTmpRet.Add(c));


        //    return (iTmpRet);
        //}

        //public List<Cikk> CikkListByAlcsoport(int iCsoportId, int iAlcsoportId)
        //{
        //    List<Cikk> iTmpRet = new List<Cikk>();

        //    var ret_cikk =
        //        from c in lCIKK
        //        where (c.CIKKCSOPORT_ID == iCsoportId) && (c.ALCSOPORT == iAlcsoportId)
        //        select c;
        //    ret_cikk.Each(c => iTmpRet.Add(c));


        //    return (iTmpRet);
        //}

    }

    #endregion

    public class BevetelSor
    {
        #region Properties

        public bool isModified;

        #region SOR_ID
        //id
        private int _BEVETEL_SOR_ID;
        public int SOR_ID
        {
            get { return (_BEVETEL_SOR_ID); }
            set
            {
                if (_BEVETEL_SOR_ID != value) { isModified = true; }
                _BEVETEL_SOR_ID = value;
            }
        }
        #endregion

        #region BEVETEL_FEJ_ID
        //bevétel fej id
        private int _BEVETEL_FEJ_ID;
        public int BEVETEL_FEJ_ID
        {
            get { return (_BEVETEL_FEJ_ID); }
            set
            {
                if (_BEVETEL_FEJ_ID != value) { isModified = true; }
                _BEVETEL_FEJ_ID = value;
            }
        }
        #endregion

        #region CIKK_ID
        //cikk
        private int _CIKK_ID;
        public int CIKK_ID
        {
            get { return (_CIKK_ID); }
            set
            {
                if (_CIKK_ID != value) { isModified = true; }
                _CIKK_ID = value;

            }
        }
        #endregion

        #region CIKK_NEV
        //Szállítólevél száma
        private string _CIKK_NEV;
        public string CIKK_NEV
        {
            get
            {
                Cikk c = new Cikk(_CIKK_ID, true, new SqlConnection(DEFS.ConSTR));
                return (c.MEGNEVEZES);
            }

        }
        #endregion


        #region MENNY
        private double _MENNY;
        public double MENNY
        {
            get { return (_MENNY); }
            set { if (_MENNY != value) { isModified = true; } _MENNY = value; }
        }
        #endregion

        #region BESZ_AR
        private double _BESZ_AR;
        public double BESZ_AR
        {
            get { return (_BESZ_AR); }
            set { if (_BESZ_AR != value) { isModified = true; } _BESZ_AR = value; }
        }
        #endregion

        #region NETTO_ERTEK
        private double _NETTO_ERTEK;
        public double NETTO_ERTEK
        {
            get { return (_NETTO_ERTEK); }
            set { if (_NETTO_ERTEK != value) { isModified = true; } _NETTO_ERTEK = value; }
        }
        #endregion

        #region AFA_ERTEK
        private double _AFA_ERTEK;
        public double AFA_ERTEK
        {
            get { return (_AFA_ERTEK); }
            set { if (_AFA_ERTEK != value) { isModified = true; } _AFA_ERTEK = value; }
        }
        #endregion

        #region BRUTTO_ERTEK
        private double _BRUTTO_ERTEK;
        public double BRUTTO_ERTEK
        {
            get { return (_BRUTTO_ERTEK); }
            set { if (_BRUTTO_ERTEK != value) { isModified = true; } _BRUTTO_ERTEK = value; }
        }
        #endregion

        #region RAKTAR_ID
        //cikk
        private int _RAKTAR_ID;
        public int RAKTAR_ID
        {
            get { return (_RAKTAR_ID); }
            set
            {
                if (_RAKTAR_ID != value) { isModified = true; }
                _RAKTAR_ID = value;
            }
        }
        #endregion

        #region RAKTAR_NEV
        //Szállítólevél száma
        private string _RAKTAR_NEV;
        public string RAKTAR_NEV
        {
            get
            {
                RaktarLista r = new RaktarLista(new System.Data.SqlClient.SqlConnection(DEFS.ConSTR));
                return ((r.RaktarByID(_RAKTAR_ID)).KOD);
            }

        }
        #endregion


        #region FELADVA
        //cikk
        private int _FELADVA;
        public int FELADVA
        {
            get { return (_FELADVA); }
            set { if (_FELADVA != value) { isModified = true; } _FELADVA = value; }
        }
        #endregion

        #region MEGJEGYZES
        //Szállítólevél száma
        private string _MEGJEGYZES;
        public string MEGJEGYZES
        {
            get { return (_MEGJEGYZES); }
            set { if (_MEGJEGYZES != value) { isModified = true; } _MEGJEGYZES = value; }
        }
        #endregion


        #endregion



        public BevetelSor()
        {

            _BEVETEL_SOR_ID = -1;
            isModified = false;
            _MEGJEGYZES = "";
        }


        public BevetelSor(int pBevSor_id, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SOR_ID, BEVETEL_FEJ_ID, CIKK_ID, MENNY, BESZ_AR, NETTO_ERTEK, AFA_ERTEK, BRUTTO_ERTEK, RAKTAR_ID, FELADVA, MEGJEGYZES " +
                            " FROM BEVETEL_SOR WHERE SOR_ID =" + pBevSor_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                _BEVETEL_SOR_ID = (int)rdr["SOR_ID"];
                _BEVETEL_FEJ_ID = (int)rdr["BEVETEL_FEJ_ID"];
                _CIKK_ID = (int)rdr["CIKK_ID"];

                _MENNY = (double)rdr["MENNY"];
                _BESZ_AR = (double)rdr["BESZ_AR"];
                _NETTO_ERTEK = (double)rdr["NETTO_ERTEK"];
                _AFA_ERTEK = (double)rdr["AFA_ERTEK"];
                _BRUTTO_ERTEK = (double)rdr["BRUTTO_ERTEK"];
                _RAKTAR_ID = (int)rdr["RAKTAR_ID"];
                _FELADVA = (int)rdr["FELADVA"];
                _MEGJEGYZES = (string)rdr["MEGJEGYZES"];
            }
            c.Close();
            isModified = false;

        }

        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;

            int new_p_id = _BEVETEL_SOR_ID;

            switch (_BEVETEL_SOR_ID)
            {
                case -1:
                    {
                        //új rekord!!


                        cmd.CommandText = "INSERT INTO BEVETEL_SOR " +
                                               "(BEVETEL_FEJ_ID " +
                                               ",CIKK_ID " +
                                               ",MENNY " +
                                               ",BESZ_AR " +
                                               ",NETTO_ERTEK " +
                                               ",AFA_ERTEK " +
                                               ",RAKTAR_ID " +
                                               ",FELADVA " +
                                               ",MEGJEGYZES " +
                                               ",BRUTTO_ERTEK) " +
                                         "VALUES " +
                                               "(@BEVETEL_FEJ_ID " +
                                               ",@CIKK_ID " +
                                               ",@MENNY " +
                                               ",@BESZ_AR " +
                                               ",@NETTO_ERTEK " +
                                               ",@AFA_ERTEK " +
                                               ",@RAKTAR_ID " +
                                               ",@FELADVA " +
                                               ",@MEGJEGYZES " +
                                               ",@BRUTTO_ERTEK) SET @newid = SCOPE_IDENTITY()";
                        cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                        cmd.Parameters["newid"].Direction = ParameterDirection.Output;

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE BEVETEL_SOR " +
                                           "SET BEVETEL_FEJ_ID = @BEVETEL_FEJ_ID " +
                                           "   ,CIKK_ID = @CIKK_ID " +
                                           "   ,MENNY = @MENNY " +
                                           "   ,BESZ_AR = @BESZ_AR " +
                                           "   ,NETTO_ERTEK = @NETTO_ERTEK " +
                                           "   ,AFA_ERTEK = @AFA_ERTEK " +
                                           "   ,BRUTTO_ERTEK = @BRUTTO_ERTEK " +
                                           "   ,RAKTAR_ID = @RAKTAR_ID " +
                                           "   ,FELADVA = @FELADVA " +
                                           "   ,MEGJEGYZES = @MEGJEGYZES " +
                                         "WHERE  SOR_ID= @SOR_ID";
                        cmd.Parameters.Add(new SqlParameter("SOR_ID", SqlDbType.Int));
                        cmd.Parameters["SOR_ID"].Value = _BEVETEL_SOR_ID;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("BEVETEL_FEJ_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("MENNY", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("BESZ_AR", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("NETTO_ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("AFA_ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("BRUTTO_ERTEK", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("RAKTAR_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("FELADVA", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("MEGJEGYZES", SqlDbType.VarChar));

            cmd.Parameters["BEVETEL_FEJ_ID"].Value = _BEVETEL_FEJ_ID;
            cmd.Parameters["CIKK_ID"].Value = _CIKK_ID;
            cmd.Parameters["MENNY"].Value = _MENNY;
            cmd.Parameters["BESZ_AR"].Value = _BESZ_AR;
            cmd.Parameters["NETTO_ERTEK"].Value = _NETTO_ERTEK;
            cmd.Parameters["AFA_ERTEK"].Value = _AFA_ERTEK;
            cmd.Parameters["BRUTTO_ERTEK"].Value = _BRUTTO_ERTEK;
            cmd.Parameters["RAKTAR_ID"].Value = RAKTAR_ID;
            cmd.Parameters["FELADVA"].Value = FELADVA;
            cmd.Parameters["MEGJEGYZES"].Value = MEGJEGYZES;

            //try
            //{
            cmd.ExecuteNonQuery();


            if (_BEVETEL_SOR_ID == -1)
            {
                new_p_id = (int)cmd.Parameters["newid"].Value;
            }
            //DEFS.SendSaveErrMessage(new_p_id.ToString() +" : Sikertelen bevlételezés mentés");

            _BEVETEL_FEJ_ID = new_p_id;

            c.Close();
        }
    }

}
