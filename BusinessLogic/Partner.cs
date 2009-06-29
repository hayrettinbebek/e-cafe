﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

using NSpring.Logging;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;


namespace BusinessLogic
{
    

    public class Szallito : Partner
    {
        private int Uj;
        #region FIZMOD
        private string _fizm;
        public string FIZMOD
        {
            get { return (_fizm); }
            set { _fizm = value; }
        }
        #endregion

        #region ATUTALAS_NAPOK
        private int _at_napok;
        public int ATUTALAS_NAPOK
        {
            get { return (_at_napok); }
            set { _at_napok = value; }
        }
        #endregion

        #region ADOSZAM
        private string _adoszam;
        public string ADOSZAM
        {
            get { return (_adoszam); }
            set { _adoszam = value; }
        }
        #endregion

        #region KONTAKT_SZEMELY
        private string _kont_szem;
        public string KONTAKT_SZEMELY
        {
            get { return (_kont_szem); }
            set { _kont_szem = value; }
        }
        #endregion

        #region KONTAKT_ELERHET
        private string _kont_elerhet;
        public string KONTAKT_ELERHET
        {
            get { return (_kont_elerhet); }
            set { _kont_elerhet = value; }
        }
        #endregion

        public Szallito(): base ()
        {
            P_TIPUS = "S";
            Uj = -1;
            _fizm = "";
            _adoszam = "";
            _at_napok = 0;
            _kont_elerhet = "";
            _kont_szem = "";
            
        }

        public Szallito(int pPartner_id)
            : base(pPartner_id)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT FIZETESI_MOD " +
                              ",ATUTALAS_NAPOK " +
                              ",ADOSZAM " +
                              ",KONTAKT_SZEMELY " +
                              ",KONTAKT_ELERHET " +
                          "FROM PARTNER_SZALL WHERE PARTNER_ID=" + pPartner_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            _at_napok = -1;
            _fizm = "";
            _adoszam = "";
            _kont_szem = "";
            _kont_elerhet = "";
            Uj = -1;
            while (rdr.Read())
            {
                Uj = 0;
                if (!DBNull.Value.Equals(rdr["ATUTALAS_NAPOK"])) { _at_napok = (int)rdr["ATUTALAS_NAPOK"]; }
                else { _at_napok = -1; }


                if (!DBNull.Value.Equals(rdr["FIZETESI_MOD"])) { _fizm = (string)rdr["FIZETESI_MOD"]; }
                else { _fizm = ""; }

                if (!DBNull.Value.Equals(rdr["ADOSZAM"])) { _adoszam = (string)rdr["ADOSZAM"]; }
                else { _adoszam = ""; }

                if (!DBNull.Value.Equals(rdr["KONTAKT_SZEMELY"])) { _kont_szem = (string)rdr["KONTAKT_SZEMELY"]; }
                else { _kont_szem = ""; }

                if (!DBNull.Value.Equals(rdr["KONTAKT_ELERHET"])) { _kont_elerhet = (string)rdr["KONTAKT_ELERHET"]; }
                else { _kont_elerhet = ""; }

            }
            rdr.Close();
            c.Close();
        }

        public override int Save(out bool ok)
        {
            int part_id = base.Save(out ok);
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (Uj)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO PARTNER_SZALL " +
                                           "(PARTNER_ID " +
                                           ",FIZETESI_MOD " +
                                           ",ATUTALAS_NAPOK " +
                                           ",ADOSZAM " +
                                           ",KONTAKT_SZEMELY " +
                                           ",KONTAKT_ELERHET) " +
                                     "VALUES " +
                                           "(@PARTNER_ID " +
                                           ",@FIZETESI_MOD " +
                                           ",@ATUTALAS_NAPOK " +
                                           ",@ADOSZAM " +
                                           ",@KONTAKT_SZEMELY " +
                                           ",@KONTAKT_ELERHET)";

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_SZALL " +
                                           "SET FIZETESI_MOD = @FIZETESI_MOD " +
                                           "   ,ATUTALAS_NAPOK = @ATUTALAS_NAPOK " +
                                           "   ,ADOSZAM = @ADOSZAM " +
                                           "   ,KONTAKT_SZEMELY = @KONTAKT_SZEMELY " +
                                           "   ,KONTAKT_ELERHET = @KONTAKT_ELERHET " +
                                           "WHERE PARTNER_ID= @PARTNER_ID";

                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));

            cmd.Parameters.Add(new SqlParameter("FIZETESI_MOD", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("ATUTALAS_NAPOK", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ADOSZAM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("KONTAKT_SZEMELY", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("KONTAKT_ELERHET", SqlDbType.VarChar));

            cmd.Parameters["PARTNER_ID"].Value = part_id;
            if (_fizm == null)
            { cmd.Parameters["FIZETESI_MOD"].Value = ""; }
            else
            {
                cmd.Parameters["FIZETESI_MOD"].Value = _fizm;
            }
            cmd.Parameters["ATUTALAS_NAPOK"].Value = _at_napok;
            if (_fizm == null)
            {
                cmd.Parameters["ADOSZAM"].Value = "";
            }
            else
            {
                cmd.Parameters["ADOSZAM"].Value = _adoszam;
            }
            cmd.Parameters["KONTAKT_SZEMELY"].Value = _kont_szem;
            cmd.Parameters["KONTAKT_ELERHET"].Value = _kont_elerhet;

            //try
            //{
            cmd.ExecuteNonQuery();

            return (part_id);
        }

    }

    public class Vevo : Partner
    {


        private int Uj
        {
            get
            {
                int uje = -1;



                SqlConnection c = new SqlConnection(DEFS.ConSTR);
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = c;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT Count(*) as DB FROM PARTNER_VEVO WHERE PARTNER_ID = " + PARTNER_ID.ToString();
                c.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if ((int)rdr["DB"] > 0) { uje = 0; }
                }

                return (uje);
            }

        }
        

        #region NEM
        private string _nem;
        public string NEM
        {
            get { return (_nem); }
            set { _nem = value; }
        }
        #endregion

        #region KOD
        private string _kod;
        public string KOD
        {
            get { return (_kod); }
            set { _kod = value; }
        }
        #endregion
        
        #region SZEMELYI
        private string _szig;
        public string SZEMELYI
        {
            get { return (_szig); }
            set { _szig = value; }
        }
        #endregion


        #region TORZSV
        
        public bool TORZSV
        {
            get { return (P_TIPUS == "T"); }
            set
            {
                switch (value)
                {
                    case true:
                        {
                            P_TIPUS = "T";
                            break;
                        }
                    case false:
                        {
                            P_TIPUS = "V";
                            break;
                        }

                }
            }
                
                
        }
        #endregion
                
        #region SZULETESNAP
        private DateTime _szuldat;
        public DateTime SZULETESNAP
        {
            get { return (_szuldat); }
            set { _szuldat = value; }
        }
        #endregion

        #region NEVNAP_HO
        private int _nevn_ho;
        public int NEVNAP_HO
        {
            get { return (_nevn_ho); }
            set { _nevn_ho = value; }
        }
        #endregion

        #region NEVNAP_nap
        private int _nevn_nap;
        public int NEVNAP_nap
        {
            get { return (_nevn_nap); }
            set { _nevn_nap = value; }
        }
        #endregion

        #region HITEL
        private double _hitel;
        public double HITEL
        {
            get { return (_hitel); }
            set { _hitel = value; }
        }
        #endregion

        #region MOBIL_SZAM
        
        public string MOBIL_SZAM
        {
            get {
                string ret_telszam = "";
                var ret_telefonszam =
                    from c in lTelefon
                    where c.TEL_TIPUS == 1
                    select c;
                ret_telefonszam.Each(c => ret_telszam = c.TELEFON);
                return (ret_telszam);
                }
            set { string NewTelszam = value;

                    var ret_telefonszam =
                            from c in lTelefon
                            where c.TEL_TIPUS == 1
                            select c;
                    if (ret_telefonszam.Count() > 0)
                    {
                        ret_telefonszam.Each(c => c.TELEFON = NewTelszam);
                    }
                    else
                    {
                        lTelefon.Add(new Partner_tel(PARTNER_ID, NewTelszam,1));
                    }
            }
        }
        #endregion

        #region VEVO_MAIL

        public string VEVO_MAIL
        {
            get
            {
                string ret_telszam = "";
                var ret_telefonszam =
                    from c in lTelefon
                    where c.TEL_TIPUS == 2
                    select c;
                ret_telefonszam.Each(c => ret_telszam = c.TELEFON);
                return (ret_telszam);
            }
            set
            {
                string NewTelszam = value;

                var ret_telefonszam =
                        from c in lTelefon
                        where c.TEL_TIPUS == 2
                        select c;
                if (ret_telefonszam.Count() > 0)
                {
                    ret_telefonszam.Each(c => c.TELEFON = NewTelszam);
                }
                else
                {
                    lTelefon.Add(new Partner_tel(PARTNER_ID, NewTelszam, 2));
                }
            }
        }
        #endregion

        #region BANK_SZLA

        public string BANK_SZLA
        {
            get
            {
                string ret_banksz = "";
                var ret_bankszamla =
                    from c in lBankszamlak
                    //where c. == 1
                    select c;
                ret_bankszamla.Each(c => ret_banksz = c.BANKSZAMLA);
                return (ret_banksz);
            }
            set
            {
                string NewBanksz = value;

                var ret_bankszamla =
                    from c in lBankszamlak
                    //where c. == 1
                    select c;
                if (ret_bankszamla.Count() > 0)
                {
                    ret_bankszamla.Each(c => c.BANKSZAMLA = NewBanksz);
                }
                else
                {
                    lBankszamlak.Add(new Partner_bsz(PARTNER_ID, NewBanksz));
                }
            }
        }
        #endregion

        #region KEDVEZEMNY_SZAZALEK
        private int _KEDVEZEMNY_SZAZALEK;
        public int KEDVEZEMNY_SZAZALEK
        {
            get { return (_KEDVEZEMNY_SZAZALEK); }
            set { _KEDVEZEMNY_SZAZALEK = value; }
        }
        #endregion
        

        public List<Partner_cim> PartnerNormalCim()
        {
            List<Partner_cim> iTmpRet = new List<Partner_cim>();

            var ret_cikk =
                from c in lCimek
                where c.CIM_TIPUS == 1
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Partner_cim> PartnerSzallCim()
        {
            List<Partner_cim> iTmpRet = new List<Partner_cim>();

            var ret_cikk =
                from c in lCimek
                where c.CIM_TIPUS == 2
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public Vevo()
            : base()
        {
            P_TIPUS = "V";
            

        }

        public Vevo(int pPartner_id)
            : base(pPartner_id)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT NEM " +
                              ",PARTNER_KOD " +
                              ",SZEMELYI_IG " +
                              ",SZULETESNAP " +
                              ",NEVNAP_HO " +
                              ",NEVNAP_NAP " +
                              ",HITEL_CREDIT " +
                              ",isnull(KEDVEZEMNY_SZAZALEK,0) as KEDVEZEMNY_SZAZALEK " +
                          "FROM PARTNER_VEVO WHERE PARTNER_ID=" + pPartner_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            _kod = "";
            _nem = "";
            _szig = "";
            _nevn_ho = 0;
            _nevn_nap = 0;
            _hitel = 0;
            _szuldat = DateTime.MinValue;
            
            while (rdr.Read())
            {
                
                if (!DBNull.Value.Equals(rdr["NEM"])) { _nem = (string)rdr["NEM"]; }
                else { _nem = ""; }

                if (!DBNull.Value.Equals(rdr["SZULETESNAP"])) { _szuldat = (DateTime)rdr["SZULETESNAP"]; }
                else { _szuldat = DateTime.MinValue; }

                if (!DBNull.Value.Equals(rdr["PARTNER_KOD"])) { _kod = (string)rdr["PARTNER_KOD"]; }
                else { _kod = ""; }


                if (!DBNull.Value.Equals(rdr["SZEMELYI_IG"])) { _szig = (string)rdr["SZEMELYI_IG"]; }
                else { _szig = ""; }

                if (!DBNull.Value.Equals(rdr["NEVNAP_HO"])) { _nevn_ho = (int)rdr["NEVNAP_HO"]; }
                else { _nevn_ho = 0; }

                if (!DBNull.Value.Equals(rdr["NEVNAP_NAP"])) { _nevn_nap = (int)rdr["NEVNAP_NAP"]; }
                else { _nevn_nap = 0; }

                if (!DBNull.Value.Equals(rdr["HITEL_CREDIT"])) { _hitel = (double)rdr["HITEL_CREDIT"]; }
                else { _hitel = 0; }

                if (!DBNull.Value.Equals(rdr["KEDVEZEMNY_SZAZALEK"])) { _KEDVEZEMNY_SZAZALEK = (int)rdr["KEDVEZEMNY_SZAZALEK"]; }
                else { _KEDVEZEMNY_SZAZALEK = 0; }



            }
            rdr.Close();
            c.Close();
        }

        
        public override int Save(out bool ok)
        {
            int part_id = base.Save(out ok);
            string msg;
            msg = "";
            ok = checkKitoltes(out msg);
            if (ok) {

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (Uj)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO PARTNER_VEVO " +
                                           "(PARTNER_ID " +
                                           ",PARTNER_KOD " +
                                           ",NEM " +
                                           ",SZEMELYI_IG " +
                                           ",SZULETESNAP " +
                                           ",NEVNAP_HO " +
                                           ",NEVNAP_NAP " +
                                           ",HITEL_CREDIT " +
                                           ",KEDVEZEMNY_SZAZALEK) " +
                                     "VALUES " +
                                           "(@PARTNER_ID " +
                                           ",@PARTNER_KOD " +
                                           ",@NEM " +
                                           ",@SZEMELYI_IG " +
                                           ",@SZULETESNAP " +
                                           ",@NEVNAP_HO " +
                                           ",@NEVNAP_NAP " +
                                           ",@HITEL_CREDIT " +
                                           ",@KEDVEZEMNY_SZAZALEK )";

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_VEVO " +
                                           "SET PARTNER_KOD = @PARTNER_KOD " +
                                           "   ,NEM = @NEM " +
                                           "   ,SZEMELYI_IG = @SZEMELYI_IG " +
                                           "   ,SZULETESNAP = @SZULETESNAP " +
                                           "   ,NEVNAP_HO = @NEVNAP_HO " +
                                           "   ,NEVNAP_NAP = @NEVNAP_NAP " +
                                           "   ,HITEL_CREDIT = @HITEL_CREDIT " +
                                           "   ,KEDVEZEMNY_SZAZALEK = @KEDVEZEMNY_SZAZALEK " +
                                         "WHERE PARTNER_ID= @PARTNER_ID";

                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));

            cmd.Parameters.Add(new SqlParameter("PARTNER_KOD", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("NEM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("SZEMELYI_IG", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("SZULETESNAP", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("NEVNAP_HO", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("NEVNAP_NAP", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("HITEL_CREDIT", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("KEDVEZEMNY_SZAZALEK", SqlDbType.Int));
                

            cmd.Parameters["PARTNER_ID"].Value = part_id;
                string tmp_KOD = "";
            if (_kod == null || _kod.Length < 1)
            {
                tmp_KOD = DEFS.GetSorszam("VEV","V",6);
                cmd.Parameters["PARTNER_KOD"].Value = tmp_KOD;
                _kod = tmp_KOD;
            }
            else
            {
                cmd.Parameters["PARTNER_KOD"].Value = _kod;
            }
            cmd.Parameters["NEM"].Value = _nem;
            cmd.Parameters["SZEMELYI_IG"].Value = _szig;
            
            
            cmd.Parameters["SZULETESNAP"].Value = _szuldat;
            
            cmd.Parameters["NEVNAP_HO"].Value = _nevn_ho;
            cmd.Parameters["NEVNAP_NAP"].Value = _nevn_nap;
            cmd.Parameters["HITEL_CREDIT"].Value = _hitel;
            cmd.Parameters["KEDVEZEMNY_SZAZALEK"].Value = _KEDVEZEMNY_SZAZALEK;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ok = false;
                DEFS.SendSaveErrMessage("Adatbázis hiba!! Logokat küldje be az adminisztrátornak!"+"\n" + e.Message+"\n"+"Trace: "+e.StackTrace);
            }

            } else {DEFS.SendSaveErrMessage(msg);}

            return (part_id);
        }

        protected override bool checkKitoltes(out string s)
        {
            bool ret = base.checkKitoltes(out s);

            //if (_kod == null)
            //{
            //    ret = false;
            //    s += "Partner kód  <null> értéket kapott!";
            //}
            if (_nem == null)
            {
                ret = false;
                s += "Partner neme  <null> értéket kapott!";
            }
            if (!((_nem == "N") | (_nem == "F")))
            {
                ret = false;
                s += "Partner neme  csak <F> Férfi és <N> Nő lehet!";
            }
            if (_szig == null)
            {
                _szig = "";
                DEFS.log(Level.Info, "Személyi igazolvány <null> érték üres stringre javítva");

            }
            if (_szuldat < new DateTime(1920,1,1,1,1,1,1))
            {
                _szuldat = new DateTime(1920, 1, 1, 1, 1, 1, 1);
                DEFS.log(Level.Info, "Születési dátum a kezdeti értékre javítva");

            }
            

            DEFS.log(Level.Info, s);
            return (ret);
        }
        
    }


    public class Partner
    {
        #region PARTNER_ID
        private int _partner_id;
        public int PARTNER_ID
        {
            get { return (_partner_id); }
            set { _partner_id = value; }
        }
        #endregion

        #region P_TIPUS
        private string _tipus;
        public string P_TIPUS
        {
            get { return (_tipus); }
            set { _tipus = value; }
        }
        #endregion

        #region P_NEV
        private string _nev1;
        public string P_NEV
        {
            get { if (_nev1 == null) { _nev1 = ""; } return (_nev1); }
            set { _nev1 = value; }
        }
        #endregion

        #region P_NEV2
        private string _nev2;
        public string P_NEV2
        {
            get { if (_nev2 == null) { _nev2 = ""; } return (_nev2); }
            set { _nev2 = value; }
        }
        #endregion

        #region P_NEV3
        private string _nev3;
        public string P_NEV3
        {
            get { if (_nev3 == null) {_nev3 = "";}
                    return (_nev3); }
            set { _nev3 = value; }
        }
        #endregion

        #region HITEL_SZABAD
        
        public double HITEL_SZABAD
        {
            get
            {
                
                    double tmpRet = 0;
                    SqlConnection c = new SqlConnection(DEFS.ConSTR);
                    c.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = c;

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "select isnull(v.HITEL_CREDIT,0)-isnull((select sum(r.db*r.ERTEK) as FELHASZNALT from hitel_sor s " +
                                        " inner join rendeles_sor r on s.rendeles_sor_id = r.sor_id " +
                                        " where s.FIZETVE = 0 and s.partner_id = v.partner_id),0) as SZABAD from partner_vevo v " +
                                        " where v.partner_id = " + PARTNER_ID.ToString();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        tmpRet = (double)rdr["SZABAD"];
                    }

                    double tmpTart = 0;
                    foreach (var t in TARTOZASOK)
                    {
                        tmpTart += t.OSSZEG;
                    }

                    double tmpBef = 0;
                    foreach (var b in BEFIZETESEK)
                    {
                        tmpBef += b.OSSZEG;
                    }
                    DEFS.DebugLog(" Tartozás: " + tmpTart.ToString());
                    DEFS.DebugLog(" Befizetés: " + tmpBef.ToString());
                    DEFS.DebugLog(" Egyenleg: " + tmpRet.ToString());
                    return (tmpRet - tmpTart + tmpBef);
                
            }
            
        }
        #endregion


        #region RENDELES_ID

        public int RENDELES_ID
        {
            get
            {

                int tmpRet = -1;
                SqlConnection c = new SqlConnection(DEFS.ConSTR);
                c.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = c;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select isnull(max(RENDELES_ID),-1) as RENDELES_ID from RENDELES_FEJ f where isnull(f.FIZETVE,0) = 0 and isnull(AKTIV,1) = 1  and ASZTAL_ID = -99 and PARTNER_ID = " + PARTNER_ID.ToString();
                

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpRet = (int)rdr["RENDELES_ID"];
                }

               
                return (tmpRet);

            }

        }
        #endregion

        public List<Partner_tel> lTelefon= new List<Partner_tel>();
        public List<Partner_cim> lCimek = new List<Partner_cim>();
        public List<Partner_bsz> lBankszamlak = new List<Partner_bsz>();

        public Partner()
        {
            _partner_id = -1;
        }

        public Partner(int pPartner_id)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);

            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT PARTNER_ID " +
                              ",P_TIPUS " +
                              ",P_NEV " +
                              ",P_NEV2 " +
                              ",P_NEV3 " +
                          "FROM PARTNER WHERE PARTNER_ID=" + pPartner_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!DBNull.Value.Equals(rdr["PARTNER_ID"])) { _partner_id = (int)rdr["PARTNER_ID"]; }
                else { _partner_id = -1; }


                if (!DBNull.Value.Equals(rdr["P_TIPUS"])) { _tipus = (string)rdr["P_TIPUS"]; }
                else { _tipus = ""; }

                if (!DBNull.Value.Equals(rdr["P_NEV"])) { _nev1 = (string)rdr["P_NEV"]; }
                else { _nev1 = ""; }

                if (!DBNull.Value.Equals(rdr["P_NEV2"])) { _nev2 = (string)rdr["P_NEV2"]; }
                else { _nev2 = ""; }

                if (!DBNull.Value.Equals(rdr["P_NEV3"])) { _nev3 = (string)rdr["P_NEV3"]; }
                else { _nev3 = ""; }

            }
            rdr.Close();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT TEL_ID FROM PARTNER_TEL WHERE PARTNER_ID =" + pPartner_id.ToString();
            

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lTelefon.Add(new Partner_tel((int)rdr["TEL_ID"], new SqlConnection(DEFS.ConSTR)));

            }
            rdr.Close();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIM_ID FROM PARTNER_CIM WHERE PARTNER_ID =" + pPartner_id.ToString();

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lCimek.Add(new Partner_cim((int)rdr["CIM_ID"], new SqlConnection(DEFS.ConSTR)));

            }
            rdr.Close();


            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT BSZ_ID FROM PARTNER_BSZ WHERE PARTNER_ID =" + pPartner_id.ToString();

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lBankszamlak.Add(new Partner_bsz((int)rdr["BSZ_ID"], new SqlConnection(DEFS.ConSTR)));

            }
            rdr.Close();

            c.Close();
        }



        protected virtual bool checkKitoltes(out string s)
        {
            bool ret = true;
            s = "";
            if (!((_tipus == "S") || (_tipus == "V") || (_tipus == "D") || (_tipus == "T"))) 
            { 
                ret = false; 
                s = "Partner tipus nem megfelelő"+ "\n";
                
                
            }

            if (_nev1 == null)
            {
                ret = false;
                s += "Partner megnevezése 1 <null> értéket kapott!";
            }
            if (_nev2 == null)
            {
                ret = false;
                s += "Partner megnevezése 2 <null> értéket kapott!";
            }
            if (_nev3 == null)
            {
                ret = false;
                s += "Partner megnevezése 3 <null> értéket kapott!";
            }

            
            return (ret);
        }

        public virtual int Save(out bool ok)
        {
            int new_p_id;
            new_p_id = _partner_id;

            string msg;
            ok = checkKitoltes(out msg);
            if (ok)
            {



                SqlConnection c = new SqlConnection(DEFS.ConSTR);
                c.Open();
                

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = c;
                cmd.CommandType = CommandType.Text;


                

                switch (_partner_id)
                {
                    case -1:
                        {
                            //új rekord!!
                            cmd.CommandText = "INSERT INTO PARTNER " +
                                               "(P_TIPUS " +
                                               ",P_NEV " +
                                               ",P_NEV2 " +
                                               ",P_NEV3) " +
                                         "VALUES " +
                                               "(@P_TIPUS " +
                                               ",@P_NEV " +
                                               ",@P_NEV2 " +
                                               ",@P_NEV3) SET @newid = SCOPE_IDENTITY()";
                            cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                            cmd.Parameters["newid"].Direction = ParameterDirection.Output;
                            break;
                        }
                    default:
                        {

                            cmd.CommandText = "UPDATE PARTNER " +
                                               "SET P_TIPUS = @P_TIPUS " +
                                                  ",P_NEV = @P_NEV " +
                                                  ",P_NEV2 = @P_NEV2 " +
                                                  ",P_NEV3 = @P_NEV3 " +
                                             "WHERE  PARTNER_ID= @PARTNER_ID";
                            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
                            cmd.Parameters["PARTNER_ID"].Value = _partner_id;
                            break;
                        }
                }


                cmd.Parameters.Add(new SqlParameter("P_TIPUS", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("P_NEV", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("P_NEV2", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("P_NEV3", SqlDbType.VarChar));

                cmd.Parameters["P_TIPUS"].Value = _tipus;
                cmd.Parameters["P_NEV"].Value = _nev1;
                cmd.Parameters["P_NEV2"].Value = _nev2;
                cmd.Parameters["P_NEV3"].Value = _nev3;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    ok = false;
                    DEFS.SendSaveErrMessage("Adatbázis hiba!! Logokat küldje be az adminisztrátornak!" + "\n" + e.Message + "\n" + "Trace: " + e.StackTrace);
                }

                if (_partner_id == -1)
                {
                    new_p_id = (int)cmd.Parameters["newid"].Value;
                    PARTNER_ID = new_p_id;
                }

                c.Close();
                foreach (var t in lTelefon)
                {
                    t.Save();
                }
                foreach (var cm in lCimek)
                {
                    cm.Save();
                }
                foreach (var b in lBankszamlak)
                {
                    b.Save();
                }

                return (new_p_id);
            }
            else { DEFS.SendSaveErrMessage(msg); }

            return (new_p_id);
        }


        #region tartozások kezelése
        private List<Partner_tartozas> getPartnerTartozasok()
        {
            List<Partner_tartozas> tmpList = new List<Partner_tartozas>();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);

            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SOR_ID FROM PARTNER_TARTOZASOK WHERE PARTNER_ID =" + _partner_id.ToString();
            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                tmpList.Add(new Partner_tartozas((int)rdr["SOR_ID"]));

            }
            rdr.Close();

            c.Close();
            return tmpList;
        }
        public List<Partner_tartozas> TARTOZASOK
        {
            get { return (getPartnerTartozasok()); }
        }

        private List<Partner_befizetes> getPartnerBefizetesek()
        {
            List<Partner_befizetes> tmpList = new List<Partner_befizetes>();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);

            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SOR_ID FROM PARTNER_BEFIZETESEK WHERE PARTNER_ID =" + _partner_id.ToString();
            SqlDataReader rdr = cmd.ExecuteReader();
             
            while (rdr.Read())
            {
                tmpList.Add(new Partner_befizetes((int)rdr["SOR_ID"]));

            }
            rdr.Close();

            c.Close();
            return tmpList;
        }
        public List<Partner_befizetes> BEFIZETESEK
        {
            get { return (getPartnerBefizetesek()); }
        }

        
        public ColumnModel getTartozasokColumnModel()
        {

            //1. oszlop
            ImageColumn imageColumn = new ImageColumn("", 30);
            imageColumn.Editable = false;

            TextColumn textColumn = new TextColumn("Jogcím", 140);
            textColumn.Editable = false;

            NumberColumn ertekColumn = new NumberColumn("Összeg", 70);
            ertekColumn.Editable = false;

            NumberColumn ertekMaradekColumn = new NumberColumn("Hátralék", 70);
            ertekMaradekColumn.Editable = false;

            return (new ColumnModel(new Column[] {imageColumn,
                                              textColumn,
											  ertekColumn,
											  ertekMaradekColumn
											  }));
        }

        public TableModel getTartozasokTableModel()
        {
            TableModel tmpMod = new TableModel(new Row[] { });

            for (int i = 0; i < TARTOZASOK.Count; i++)
            {
                if (TARTOZASOK[i].HATRALEK > 0)
                {
                    tmpMod.Rows.Add(new Row(new Cell[] {new PartnerTartozasCell(TARTOZASOK[i]),
													new Cell(TARTOZASOK[i].JOGCIM),
													new Cell(TARTOZASOK[i].OSSZEG),
													new Cell(TARTOZASOK[i].HATRALEK)
                                                    }
                                           )
                                   );
                }
            }

            return (tmpMod);

        }

        

        #endregion


    }

    public class Partner_list
    {
        public List<Szallito> lSzallitok = new List<Szallito>();
        public List<Vevo> lVevok = new List<Vevo>();
        
        public Partner_list(SqlConnection sc)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT PARTNER_ID, isnull(P_TIPUS,'') as P_TIPUS FROM PARTNER WHERE AKTIV = 1";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                switch ((string)rdr["P_TIPUS"])
                {
                    case "S":
                        {
                            Szallito t = new Szallito((int)rdr["PARTNER_ID"]);
                            lSzallitok.Add(t);
                            break;
                        }
                    case "V":
                        {
                            Vevo t = new Vevo((int)rdr["PARTNER_ID"]);
                            lVevok.Add(t);
                            break;
                        }
                    case "T":
                        {
                            Vevo t = new Vevo((int)rdr["PARTNER_ID"]);
                            lVevok.Add(t);
                            break;
                        }
                    case "":
                        {

                            break;
                        }
                    //default:
                }
                

            }
            rdr.Close();
            sc.Close();
            
        }

        public List<Szallito> SzallitoFilterByName(string iPArtnerNev)
        {
            List<Szallito> iTmpRet = new List<Szallito>();

            var ret_cikk =
                from c in lSzallitok
                where c.P_NEV.Contains(iPArtnerNev) 
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Vevo> VevoFilterByName(string iPArtnerNev)
        {
            List<Vevo> iTmpRet = new List<Vevo>();

            var ret_cikk =
                from c in lVevok
                where c.P_NEV.Contains(iPArtnerNev)
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }
    }

    public class Partner_tel
    {
        #region TEL_ID
        private int _tel_id;
        public int TEL_ID
        {
            get { return (_tel_id); }
            set { _tel_id = value; }
        }
        #endregion

        #region PARTNER_ID
        private int _partner_id;
        public int PARTNER_ID
        {
            get { return (_partner_id); }
            set { _partner_id = value; }
        }
        #endregion

        #region TEL_TIPUS
        /*
         * 1 - Mobil
         * 2 - E-mail
         * 3 - 
         * 
         
         */
        private int _tel_tipus;
        public int TEL_TIPUS
        {
            get { return (_tel_tipus); }
            set { _tel_tipus = value; }
        }
        #endregion

        #region TELEFON
        private string _telefon;
        public string TELEFON
        {
            get { return (_telefon); }
            set { _telefon = value; }
        }
        #endregion

        public Partner_tel(int pPartner)
        {
            _tel_id = -1;
            _partner_id = pPartner;
        }

        public Partner_tel(int pPartner, string pSzam, int ptype)
        {
            _tel_id = -1;
            _partner_id = pPartner;
            _telefon = pSzam;
            _tel_tipus = ptype;
        }

        public Partner_tel(int pTel_id, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT TEL_ID " +
                                ",PARTNER_ID " +
                                ",TEL_TIPUS " +
                                ",TELEFON " +
                                "FROM PARTNER_TEL WHERE TEL_ID=" + pTel_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!DBNull.Value.Equals(rdr["TEL_ID"])) { _tel_id = (int)rdr["TEL_ID"]; }
                else { _tel_id = -1;}

                if (!DBNull.Value.Equals(rdr["PARTNER_ID"])) { _partner_id = (int)rdr["PARTNER_ID"]; }
                else { _partner_id = -1; }

                if (!DBNull.Value.Equals(rdr["TEL_TIPUS"])) { _tel_tipus = (int)rdr["TEL_TIPUS"]; }
                else { _tel_tipus = -1; }

                if (!DBNull.Value.Equals(rdr["TELEFON"])) { _telefon = (string)rdr["TELEFON"]; }
                else { _telefon = ""; }
 

            }
            c.Close();
        }



        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (_tel_id)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO PARTNER_TEL " +
                                               "(PARTNER_ID " +
                                              ",TEL_TIPUS " +
                                               ",TELEFON) " +
                                         "VALUES " +
                                               "(@PARTNER_ID " +
                                               ",@TEL_TIPUS " +
	                                           ",@TELEFON)";

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_TEL " +
                                           "SET PARTNER_ID = @PARTNER_ID " +
                                           "   ,TEL_TIPUS = @TEL_TIPUS " +
                                           "   ,TELEFON = @TELEFON " +
                                         "WHERE TEL_ID= @TEL_ID";
                        cmd.Parameters.Add(new SqlParameter("TEL_ID", SqlDbType.Int));
                        cmd.Parameters["TEL_ID"].Value = _tel_id;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("TEL_TIPUS", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("TELEFON", SqlDbType.VarChar));


            cmd.Parameters["TEL_TIPUS"].Value = _tel_tipus;
            cmd.Parameters["PARTNER_ID"].Value = _partner_id;
            cmd.Parameters["TELEFON"].Value = _telefon;

            //try
            //{
            cmd.ExecuteNonQuery();
            //}
            //catch (Exception e)
            //{
            //    string s = "Hiba a rendelés sorok mentése közben!" + _BEVETEL_FEJ_ID.ToString()+ e.Data;
            //}

            c.Close();
        }

    }

    public class Partner_cim
    {
        #region CIM_ID
        private int _cim_id;
        public int CIM_ID
        {
            get { return (_cim_id); }
            set { _cim_id = value; }
        }
        #endregion

        #region PARTNER_ID
        private int _partner_id;
        public int PARTNER_ID
        {
            get { return (_partner_id); }
            set { _partner_id = value; }
        }
        #endregion

        #region CIM_TIPUS
        private int _cim_tipus;
        public int CIM_TIPUS
        {
            get { return (_cim_tipus); }
            set { _cim_tipus = value; }
        }
        #endregion

        #region IRSZ
        private string _irsz;
        public string IRSZ
        {
            get { return (_irsz); }
            set { _irsz = value; }
        }
        #endregion
                
        #region VAROS
        private string _varos;
        public string VAROS
        {
            get { return (_varos); }
            set { _varos = value; }
        }
        #endregion

        #region CIM
        private string _cim;
        public string CIM
        {
            get { return (_cim); }
            set { _cim = value; }
        }
        #endregion


        public Partner_cim(int pPartner)
        {
            _cim_id = -1;
            _partner_id = pPartner;
        }

        public Partner_cim(int pcim_id, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIM_ID " +
                              ",PARTNER_ID " +
                              ",CIM_TIPUS " +
                              ",IRSZ " +
                              ",VAROS " +
                              ",CIM " +
                         " FROM PARTNER_CIM WHERE CIM_ID=" + pcim_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!DBNull.Value.Equals(rdr["CIM_ID"])) { _cim_id = (int)rdr["CIM_ID"]; }
                else { _cim_id = -1; }

                if (!DBNull.Value.Equals(rdr["PARTNER_ID"])) { _partner_id = (int)rdr["PARTNER_ID"]; }
                else { _partner_id = -1; }

                if (!DBNull.Value.Equals(rdr["CIM_TIPUS"])) { _cim_tipus = (int)rdr["CIM_TIPUS"]; }
                else { _cim_tipus = -1; }

                if (!DBNull.Value.Equals(rdr["IRSZ"])) { _irsz = (string)rdr["IRSZ"]; }
                else { _irsz = ""; }

                if (!DBNull.Value.Equals(rdr["VAROS"])) { _varos = (string)rdr["VAROS"]; }
                else { _varos = ""; }

                if (!DBNull.Value.Equals(rdr["CIM"])) { _cim = (string)rdr["CIM"]; }
                else { _cim = ""; }


            }
            c.Close();
        }



        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (_cim_id)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO PARTNER_CIM " +
                                           "(PARTNER_ID " +
                                           ",CIM_TIPUS " +
                                           ",IRSZ " +
                                           ",VAROS " +
                                           ",CIM) " +
                                     "VALUES " +
                                           "(@PARTNER_ID " +
                                           ",@CIM_TIPUS " +
                                           ",@IRSZ " +
                                           ",@VAROS " +
                                           ",@CIM) SET @newid = SCOPE_IDENTITY()" ;
                            cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                            cmd.Parameters["newid"].Direction = ParameterDirection.Output;

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_CIM " +
                                           "SET PARTNER_ID = @PARTNER_ID " +
                                              ",CIM_TIPUS = @CIM_TIPUS " +
                                              ",IRSZ = @IRSZ " +
                                              ",VAROS = @VAROS " +
                                              ",CIM = @CIM " +
                                         "WHERE CIM_ID= @CIM_ID";
                        cmd.Parameters.Add(new SqlParameter("CIM_ID", SqlDbType.Int));
                        cmd.Parameters["CIM_ID"].Value = _cim_id;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIM_TIPUS", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("IRSZ", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("VAROS", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("CIM", SqlDbType.VarChar));
            if (_cim == null) { _cim = ""; }
            if (_varos == null) { _varos = ""; }
            if (_irsz == null) { _irsz = ""; }

            cmd.Parameters["CIM_TIPUS"].Value = _cim_tipus;
            cmd.Parameters["PARTNER_ID"].Value = _partner_id;
            cmd.Parameters["IRSZ"].Value = _irsz;
            cmd.Parameters["VAROS"].Value = _varos;
            
            cmd.Parameters["CIM"].Value = _cim;

            //try
            //{
            cmd.ExecuteNonQuery();

            if (_cim_id == -1)
                {
                    _cim_id = (int)cmd.Parameters["newid"].Value;
                    
                }

            c.Close();
        }

    }

    public class Partner_bsz
    {
        #region BSZ_ID
        private int _bsz_id;
        public int BSZ_ID
        {
            get { return (_bsz_id); }
            set { _bsz_id = value; }
        }
        #endregion

        #region PARTNER_ID
        private int _partner_id;
        public int PARTNER_ID
        {
            get { return (_partner_id); }
            set { _partner_id = value; }
        }
        #endregion

        #region BANK
        private string _bank;
        public string BANK
        {
            get { return (_bank); }
            set { _bank = value; }
        }
        #endregion

        #region BANKSZAMLA
        private string _bankszamla;
        public string BANKSZAMLA
        {
            get { return (_bankszamla); }
            set { _bankszamla = value; }
        }
        #endregion


        public Partner_bsz(int pPartner)
        {
            _bsz_id = -1;
            _partner_id = pPartner;
        }

        public Partner_bsz(int pPartner, string pBSZ)
        {
            _bsz_id = -1;
            _partner_id = pPartner;
            _bank = "";
            _bankszamla = pBSZ;
        }

        public Partner_bsz(int pbsz_id, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT BSZ_ID " +
                              ",PARTNER_ID " +
                              ",BANK " +
                              ",BANKSZAMLA "+
                         " FROM PARTNER_BSZ WHERE BSZ_ID=" + pbsz_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!DBNull.Value.Equals(rdr["BSZ_ID"])) { _bsz_id = (int)rdr["BSZ_ID"]; }
                else { _bsz_id = -1; }

                if (!DBNull.Value.Equals(rdr["PARTNER_ID"])) { _partner_id = (int)rdr["PARTNER_ID"]; }
                else { _partner_id = -1; }

                if (!DBNull.Value.Equals(rdr["BANK"])) { _bank = (string)rdr["BANK"]; }
                else { _bank = ""; }

                if (!DBNull.Value.Equals(rdr["BANKSZAMLA"])) { _bankszamla = (string)rdr["BANKSZAMLA"]; }
                else { _bankszamla = ""; }

            }
            c.Close();
        }



        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (_bsz_id)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO PARTNER_BSZ " +
                                           "(PARTNER_ID " +
                                           ",BANK " +
                                           ",BANKSZAMLA) " +
                                     "VALUES " +
                                           "(@PARTNER_ID " +
                                           ",@BANK " +
                                           ",@BANKSZAMLA)";

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_BSZ " +
                                           "SET PARTNER_ID = @PARTNER_ID " +
                                              ",BANK = @BANK " +
                                              ",BANKSZAMLA = @BANKSZAMLA " +
                                         "WHERE BSZ_ID= @BSZ_ID";
                        cmd.Parameters.Add(new SqlParameter("BSZ_ID", SqlDbType.Int));
                        cmd.Parameters["BSZ_ID"].Value = _bsz_id;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("BANK", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("BANKSZAMLA", SqlDbType.VarChar));


            cmd.Parameters["PARTNER_ID"].Value = _partner_id;
            cmd.Parameters["BANK"].Value = _bank;
            cmd.Parameters["BANKSZAMLA"].Value = _bankszamla;

            //try
            //{
            cmd.ExecuteNonQuery();
            //}
            //catch (Exception e)
            //{
            //    string s = "Hiba a rendelés sorok mentése közben!" + _BEVETEL_FEJ_ID.ToString()+ e.Data;
            //}

            c.Close();
        }

    }

    public class Partner_tartozas
    {

        private int _SOR_ID;
        private int _partner_id;
        private string _jogcim;
        private string _megjegyzes;
        private double _osszeg;
        private double _fizetve;

        #region PROPERTIES
        public int SOR_ID
        {
            get { return (_SOR_ID); }
            set { _SOR_ID = value; }
        }
        
        public int PARTNER_ID
        {
            get { return (_partner_id); }
            set { _partner_id = value; }
        }

        public string JOGCIM
        {
            get { return (_jogcim); }
            set { _jogcim = value; }
        }

        public string MEGJEGYZES
        {
            get { return (_megjegyzes); }
            set { _megjegyzes = value; }
        }

        public double OSSZEG
                    {
            get { return (_osszeg); }
            set { _osszeg = value; }
        }

        public double FIZETVE
        {
            get { return (_fizetve); }
            set { _fizetve = value; }
        }

        public bool LEZART
        {
            get { return ( (OSSZEG- FIZETVE) == 0); }
           
        }
        public double HATRALEK
        {
            get { return (OSSZEG - FIZETVE); }

        }

        #endregion

        public Partner_tartozas(int pPartner, double pOsszeg, string pJogcim)
        {
            _SOR_ID = -1;
            _partner_id = pPartner;
            _jogcim = pJogcim;
            _megjegyzes = "";
            _osszeg = pOsszeg;
        }

        public Partner_tartozas(int pSorId)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);

            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT  PARTNER_ID ,SOR_ID ,JOGCIM ,MEGJEGYZES ,OSSZEG, isnull(FIZETVE,0) as FIZETVE FROM  PARTNER_TARTOZASOK WHERE SOR_ID=" + pSorId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!DBNull.Value.Equals(rdr["SOR_ID"])) { _SOR_ID = (int)rdr["SOR_ID"]; }
                else { _SOR_ID = -1; }

                if (!DBNull.Value.Equals(rdr["PARTNER_ID"])) { _partner_id = (int)rdr["PARTNER_ID"]; }
                else { _partner_id = -1; }

                if (!DBNull.Value.Equals(rdr["JOGCIM"])) { _jogcim = (string)rdr["JOGCIM"]; }
                else { _jogcim = ""; }

                if (!DBNull.Value.Equals(rdr["MEGJEGYZES"])) { _megjegyzes = (string)rdr["MEGJEGYZES"]; }
                else { _megjegyzes = ""; }

                if (!DBNull.Value.Equals(rdr["OSSZEG"])) { _osszeg = (double)rdr["OSSZEG"]; }
                else
                { _osszeg = 0; }

                if (!DBNull.Value.Equals(rdr["FIZETVE"])) { _fizetve = (double)rdr["FIZETVE"]; }
                else
                { _fizetve = 0; }

            }
            c.Close();
        }

        public void Save()
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
                        cmd.CommandText = "INSERT INTO  PARTNER_TARTOZASOK " +
                                         " (PARTNER_ID " +
                                         " ,JOGCIM " +
                                         " ,MEGJEGYZES " +
                                         " ,OSSZEG " +
                                         " ,FIZETVE ) " +
                                         "     VALUES " +
                                         " (@PARTNER_ID " +
                                         " ,@JOGCIM " +
                                         " ,@MEGJEGYZES " +
                                         " ,@OSSZEG " +
                                         " ,@FIZETVE)";

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_TARTOZASOK " +
                                          "  SET PARTNER_ID = @PARTNER_ID " +
                                          "     ,JOGCIM = @JOGCIM " +
                                          "     ,MEGJEGYZES = @MEGJEGYZES " +
                                          "     ,OSSZEG = @OSSZEG " +
                                          "     ,FIZETVE = @FIZETVE " + 
                                          " WHERE  SOR_ID= @SOR_ID";
                        cmd.Parameters.Add(new SqlParameter("SOR_ID", SqlDbType.Int));
                        cmd.Parameters["SOR_ID"].Value = _SOR_ID;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("JOGCIM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("MEGJEGYZES", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("OSSZEG", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("FIZETVE", SqlDbType.Float));

            cmd.Parameters["PARTNER_ID"].Value = _partner_id;
            cmd.Parameters["JOGCIM"].Value = _jogcim;
            cmd.Parameters["MEGJEGYZES"].Value = _megjegyzes;
            cmd.Parameters["OSSZEG"].Value = _osszeg;
            cmd.Parameters["FIZETVE"].Value = _fizetve;


            cmd.ExecuteNonQuery();
            

            c.Close();
        }

    }

    public class Partner_befizetes
    {

        private int _SOR_ID;
        private int _partner_id;
        private string _jogcim;
        private string _megjegyzes;
        private double _osszeg;
        private double _kipontozva;

        #region PROPERTIES
        public int SOR_ID
        {
            get { return (_SOR_ID); }
            set { _SOR_ID = value; }
        }

        public int PARTNER_ID
        {
            get { return (_partner_id); }
            set { _partner_id = value; }
        }

        public string JOGCIM
        {
            get { return (_jogcim); }
            set { _jogcim = value; }
        }

        public string MEGJEGYZES
        {
            get { return (_megjegyzes); }
            set { _megjegyzes = value; }
        }

        public double OSSZEG
        {
            get { return (_osszeg); }
            set { _osszeg = value; }
        }

        public double KIPONTOZVA
        {
            get { return (_kipontozva); }
            set { _kipontozva = value; }
        }


        #endregion

        public Partner_befizetes(int pPartner, double pOsszeg, string pJogcim)
        {
            _SOR_ID = -1;
            _partner_id = pPartner;
            _jogcim = pJogcim;
            _megjegyzes = "";
            _osszeg = pOsszeg;
        }

        public Partner_befizetes(int pSorId)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);

            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT  PARTNER_ID ,SOR_ID ,JOGCIM ,MEGJEGYZES ,OSSZEG, isnull(KIPONTOZVA,0) as KIPONTOZVA FROM  PARTNER_BEFIZETESEK WHERE SOR_ID=" + pSorId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (!DBNull.Value.Equals(rdr["SOR_ID"])) { _SOR_ID = (int)rdr["SOR_ID"]; }
                else { _SOR_ID = -1; }

                if (!DBNull.Value.Equals(rdr["PARTNER_ID"])) { _partner_id = (int)rdr["PARTNER_ID"]; }
                else { _partner_id = -1; }

                if (!DBNull.Value.Equals(rdr["JOGCIM"])) { _jogcim = (string)rdr["JOGCIM"]; }
                else { _jogcim = ""; }

                if (!DBNull.Value.Equals(rdr["MEGJEGYZES"])) { _megjegyzes = (string)rdr["MEGJEGYZES"]; }
                else { _megjegyzes = ""; }

                if (!DBNull.Value.Equals(rdr["OSSZEG"])) { _osszeg = (double)rdr["OSSZEG"]; }
                else
                { _osszeg = 0; }

                if (!DBNull.Value.Equals(rdr["KIPONTOZVA"])) { _kipontozva = (double)rdr["KIPONTOZVA"]; }
                else
                { _kipontozva = 0; }

            }
            c.Close();
        }

        public int Save()
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
                        cmd.CommandText = "INSERT INTO  PARTNER_BEFIZETESEK " +
                                         " (PARTNER_ID " +
                                         " ,JOGCIM " +
                                         " ,MEGJEGYZES " +
                                         " ,OSSZEG " +
                                         " ,KIPONTOZVA ) " +
                                         "     VALUES " +
                                         " (@PARTNER_ID " +
                                         " ,@JOGCIM " +
                                         " ,@MEGJEGYZES " +
                                         " ,@OSSZEG " +
                                         " ,@KIPONTOZVA)  SET @newid = SCOPE_IDENTITY()";
                        cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                        cmd.Parameters["newid"].Direction = ParameterDirection.Output;
                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE PARTNER_BEFIZETESEK " +
                                          "  SET PARTNER_ID = @PARTNER_ID " +
                                          "     ,JOGCIM = @JOGCIM " +
                                          "     ,MEGJEGYZES = @MEGJEGYZES " +
                                          "     ,OSSZEG = @OSSZEG " +
                                          "     ,KIPONTOZVA = @KIPONTOZVA " +
                                          " WHERE  SOR_ID= @SOR_ID";
                        cmd.Parameters.Add(new SqlParameter("SOR_ID", SqlDbType.Int));
                        cmd.Parameters["SOR_ID"].Value = _SOR_ID;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("PARTNER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("JOGCIM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("MEGJEGYZES", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("OSSZEG", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("KIPONTOZVA", SqlDbType.Float));

            cmd.Parameters["PARTNER_ID"].Value = _partner_id;
            cmd.Parameters["JOGCIM"].Value = _jogcim;
            cmd.Parameters["MEGJEGYZES"].Value = _megjegyzes;
            cmd.Parameters["OSSZEG"].Value = _osszeg;
            cmd.Parameters["KIPONTOZVA"].Value = _kipontozva;


            cmd.ExecuteNonQuery();

            if (_SOR_ID == -1)
            {
                _SOR_ID = (int)cmd.Parameters["newid"].Value;
                
            }
            c.Close();
            return (_SOR_ID);
            
        }

        public void Delete()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            cmd.CommandText = "DELETE FROM  PARTNER_BEFIZETESEK " +
                              " WHERE  SOR_ID= @SOR_ID";
            cmd.Parameters.Add(new SqlParameter("SOR_ID", SqlDbType.Int));
            cmd.Parameters["SOR_ID"].Value = _SOR_ID;



            cmd.ExecuteNonQuery();



            c.Close();

        }
    }
}
