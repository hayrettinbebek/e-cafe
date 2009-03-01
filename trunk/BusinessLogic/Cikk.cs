﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using NSpring.Logging;

namespace BusinessLogic
{
    #region Cikk
    public class Cikk
    {
        public CikkKiszerelesList CIKK_KISZERELES;
        public String KISZ_MEGN;
        public double KISZ_MENNY;

        #region CIKK_ID
        private int fCIKK_ID;
        public int CIKK_ID
        {
            get { return (fCIKK_ID); }
            set { fCIKK_ID = value; }
        }
        #endregion

        
        #region MEGYS_ID
        private string fMEGYS_ID;
        public string MEGYS_ID
        {
            get { return (fMEGYS_ID); }
            set { fMEGYS_ID = value; }
        }

        public string MEGYS_MEGNEVEZES
        {
            get
            {
                Megys_list ml = new Megys_list(new SqlConnection(DEFS.ConSTR));
                
                return (ml.MegysById(MEGYS_ID).NEV);

            }
           
        }
        #endregion
        
        #region CIKK_TIPUS
        private int fCIKK_TIPUS;
        public bool OSSZETETT
        {
            get { return (fCIKK_TIPUS == 1); }
            set { if (value) {fCIKK_TIPUS = 1;}
            else { fCIKK_TIPUS = 0; }
            }
        }
        #endregion

        #region készlet
        public List<CikkKeszlet> lKESZLET = new List<CikkKeszlet>();
        public double fKESZLET
        {
            get
            {
            double iTmpRet = 0;

            var ret_cikk =
                from c in lKESZLET
                where c.fRAKTAR_ID == fDEFAULT_RAKTAR
                select c;
            ret_cikk.Each(c => iTmpRet = c.fKESZLET );

            return (iTmpRet);
            }
        }
        public double fKESZLET_ALL
        {
            get
            {
                double iTmpRet = 0;

                var ret_cikk =
                    from c in lKESZLET
                    //where c.fRAKTAR_ID == fDEFAULT_RAKTAR
                    select c;
                ret_cikk.Each(c => iTmpRet += c.fKESZLET);

                return (iTmpRet);

            }
        }
        #endregion

        #region Alcsoport
        private int fOTHER_FILTER_ID;
        public int ALCSOPORT
        {
            get { return (fOTHER_FILTER_ID); }
            set { fOTHER_FILTER_ID = value; }
        }
        #endregion

        #region MEGNEVEZES
        //megnevezés
        private string fMEGNEVEZES;
        public string MEGNEVEZES
        {
            get { return(fMEGNEVEZES);}
            set { fMEGNEVEZES = value; }
        }
        #endregion

        #region MEGJEGYZES
        //megnevezés
        private string fMEGJEGYZES;
        public string MEGJEGYZES
        {
            get { return (fMEGJEGYZES); }
            set { fMEGJEGYZES = value; }
        }
        #endregion
        
        #region CIKKSZAM
        //megnevezés
        private string fCIKKSZAM;
        public string CIKKSZAM
        {
            get { return (fCIKKSZAM); }
            set { fCIKKSZAM = value; }
        }
        #endregion

        #region GYORSKOD
        //megnevezés
        private string fGYORSKOD;
        public string GYORSKOD
        {
            get { return (fGYORSKOD); }
            set { fGYORSKOD = value; }
        }
        #endregion

        #region EAN
        //megnevezés
        private string fEAN;
        public string EAN
        {
            get { return (fEAN); }
            set { fEAN = value; }
        }
        #endregion

        #region MINIMUM_KESZLET
        //megnevezés
        private double fMINIMUM_KESZLET;
        public double MINIMUM_KESZLET
        {
            get { return (fMINIMUM_KESZLET); }
            set { fMINIMUM_KESZLET = value; }
        }
        #endregion

        #region OPTIMALIS_KESZLET
        //megnevezés
        private double fOPTIMALIS_KESZLET;
        public double OPTIMALIS_KESZLET
        {
            get { return (fOPTIMALIS_KESZLET); }
            set { fOPTIMALIS_KESZLET = value; }
        }
        #endregion

        #region ELADASI_AR
        //megnevezés
        private double fELADASI_AR;
        public double ELADASI_AR
        {
            get { return (fELADASI_AR); }
            set { fELADASI_AR = value; }
        }
        #endregion

        #region SZJ
        //megnevezés
        private string fSZJ;
        public string SZJ
        {
            get { return (fSZJ); }
            set { fSZJ = value; }
        }
        #endregion

        #region Cikkcsoport
        private int fCIKKCSOPORT_ID;
        public int CIKKCSOPORT_ID
        {
            get { return (fCIKKCSOPORT_ID); }
            set { fCIKKCSOPORT_ID = value; }
        }
        #endregion

        #region alap raktár
        private int fDEFAULT_RAKTAR;
        public int ALAP_RAKTAR
        {
            get { return (fDEFAULT_RAKTAR); }
            set { fDEFAULT_RAKTAR = value; }
        }
        #endregion

        //megnevezés
        private string fERT_TIP;
        public string ERTEKESITES_TIPUSA
        {
            get { return (fERT_TIP); }
            set { fERT_TIP = value; }
        }

        public Cikk(int pCIKK_ID,
                    string pMEGNEVEZES,
                    int pCIKK_TIPUS,
                    int pCIKKCSOPORT_ID
                    )
        {

                fCIKK_ID = pCIKK_ID;
                fMEGNEVEZES = pMEGNEVEZES;
                fCIKK_TIPUS = pCIKK_TIPUS;
                fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;
                CIKK_KISZERELES = new CikkKiszerelesList(fCIKK_ID, new SqlConnection(DEFS.ConSTR));

        }

        public Cikk()
        {

            fCIKK_ID = -1;
            
        }

        public void getKeszlet()
        {
            lKESZLET.Clear();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("select * from GetKeszlet(@EV,@HO,@NAP,@cikk_id,@raktar_id)", c);
            gk.CommandType = CommandType.Text;
            gk.Parameters.Add("@EV", SqlDbType.Int);
            gk.Parameters["@EV"].Direction = ParameterDirection.Input;
            gk.Parameters["@EV"].Value = DEFS.NyitNap_EV;

            gk.Parameters.Add("@HO", SqlDbType.Int);
            gk.Parameters["@HO"].Direction = ParameterDirection.Input;
            gk.Parameters["@HO"].Value = DEFS.NyitNap_HO;

            gk.Parameters.Add("@NAP", SqlDbType.Int);
            gk.Parameters["@NAP"].Direction = ParameterDirection.Input;
            gk.Parameters["@NAP"].Value = DEFS.NyitNap_NAP;

            gk.Parameters.Add("@cikk_id", SqlDbType.Int);
            gk.Parameters["@cikk_id"].Direction = ParameterDirection.Input;
            gk.Parameters["@cikk_id"].Value = fCIKK_ID;

            gk.Parameters.Add("@raktar_id", SqlDbType.Int);
            gk.Parameters["@raktar_id"].Direction = ParameterDirection.Input;
            gk.Parameters["@raktar_id"].Value = -1;

            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                lKESZLET.Add(new CikkKeszlet((int)rdr["RAKTAR_ID"], (string)rdr["RAKTAR_NEV"], (double)rdr["KESZLET"], (double)rdr["KESZLET_ERTEK"], (double)rdr["ATLAGAR"]));
                DEFS.log(Level.Debug, "Keszlet:" + "-->" + rdr["RAKTAR_ID"] + "-->" + rdr["RAKTAR_NEV"] + "-->" + rdr["KESZLET"] + "-->" + rdr["KESZLET_ERTEK"]);

            }
            c.Close();
        }

        public double getAfaSzaz()
        {
            double ret = 0;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("select isnull(a.AFA_ERTEK,0) as AFA_SZAZ from cikkcsoport cs " +
                                            " inner join cikk c on cs.cikkcsoport_id = c.cikkcsoport_id " +
                                            " inner join afa a on cs.AFA_KOD = a.AFA_KOD " +
                                            " WHERE c.CIKK_ID = @cikk_id", c);
            gk.CommandType = CommandType.Text;
            gk.Parameters.Add("@cikk_id", SqlDbType.Int);
            gk.Parameters["@cikk_id"].Direction = ParameterDirection.Input;
            gk.Parameters["@cikk_id"].Value = fCIKK_ID;
            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                ret = (double)rdr["AFA_SZAZ"];
                
            }
            c.Close();
            return (ret);
        }

        public Cikk(int pCikkId, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(CIKKSZAM,'') as CIKKSZAM, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID," +
                            " isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS, isnull(l.LIT_KISZ_NEV,'') as KISZ_NEV, isnull(l.LIT_KISZ_MENNY,'1') as KISZ_MENNY, " +
                            " isnull(GYORSKOD,'') as GYORSKOD , isnull(EAN_KOD,'') as EAN_KOD,isnull(SZJ_SZAM,'') as SZJ_SZAM , " +
                            " isnull(MINIMUM_KESZLET,0) as MINIMUM_KESZLET , isnull(OPTIMALIS_KESZLET,0) as OPTIMALIS_KESZLET , isnull(ELADASI_AR,0) as ELADASI_AR , isnull(MEGJEGYZES,'') as MEGJEGYZES ,isnull(MEGYS_ID,-1) as MEGYS_ID  " +
                            " FROM CIKK  c left join LIT_KISZ l on c.CIKK_ID = l.LIT_KISZ_CIKK_Id WHERE CIKK_ID =" + pCikkId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                fCIKK_ID = (int)rdr["CIKK_ID"];
                fMEGNEVEZES = (string)rdr["MEGNEVEZES"];
                fCIKK_TIPUS = (int)rdr["CIKK_TIPUS"];
                fCIKKCSOPORT_ID = (int)rdr["CIKKCSOPORT_ID"];
                fOTHER_FILTER_ID = (int)rdr["OTHER_FILTER_ID"];
                fDEFAULT_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                MEGYS_ID = (string)rdr["MEGYS_ID"];
                ERTEKESITES_TIPUSA = (string)rdr["ERT_TIPUS"];
                CIKKSZAM = (string)rdr["CIKKSZAM"];
                GYORSKOD = (string)rdr["GYORSKOD"];
                EAN = (string)rdr["EAN_KOD"];
                SZJ = (string)rdr["SZJ_SZAM"];
                MEGJEGYZES = (string)rdr["MEGJEGYZES"];
                KISZ_MEGN = (string)rdr["KISZ_NEV"];
                KISZ_MENNY = (double)rdr["KISZ_MENNY"];
                MINIMUM_KESZLET = (double)rdr["MINIMUM_KESZLET"];
                OPTIMALIS_KESZLET = (double)rdr["OPTIMALIS_KESZLET"];
                ELADASI_AR = (double)rdr["ELADASI_AR"];

                DEFS.log(Level.Debug, "CikK olvasása" + rdr["CIKK_ID"] + "#" + rdr["MEGNEVEZES"] + "#" + rdr["CIKK_TIPUS"] + "#" + rdr["CIKKCSOPORT_ID"] + "#" +
                        rdr["OTHER_FILTER_ID"] + "#" + rdr["DEFAULT_RAKTAR"] + "#" + rdr["ERT_TIPUS"] + "#" + rdr["KISZ_NEV"] + "#" + rdr["KISZ_MENNY"] + "#" + "#" + "#" + "#");

            }
            getKeszlet();
            CIKK_KISZERELES = new CikkKiszerelesList(fCIKK_ID, new SqlConnection(DEFS.ConSTR));
            c.Close();
            
        }

        public Cikk(int pCikkId, bool ForEdit, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(CIKKSZAM,'') as CIKKSZAM, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID," +
                            " isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS," +
                            " isnull(GYORSKOD,'') as GYORSKOD , isnull(EAN_KOD,'') as EAN_KOD,isnull(SZJ_SZAM,'') as SZJ_SZAM , "+
                            " isnull(MINIMUM_KESZLET,0) as MINIMUM_KESZLET , isnull(OPTIMALIS_KESZLET,0) as OPTIMALIS_KESZLET , isnull(ELADASI_AR,0) as ELADASI_AR , isnull(MEGJEGYZES,'') as MEGJEGYZES ,isnull(MEGYS_ID,-1) as MEGYS_ID  " +
                            " FROM CIKK  WHERE CIKK_ID =" + pCikkId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                fCIKK_ID = (int)rdr["CIKK_ID"];
                fMEGNEVEZES = (string)rdr["MEGNEVEZES"];
                fCIKK_TIPUS = (int)rdr["CIKK_TIPUS"];
                fCIKKCSOPORT_ID = (int)rdr["CIKKCSOPORT_ID"];
                fOTHER_FILTER_ID = (int)rdr["OTHER_FILTER_ID"];
                fDEFAULT_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                MEGYS_ID = (string)rdr["MEGYS_ID"];
                ERTEKESITES_TIPUSA = (string)rdr["ERT_TIPUS"];
                CIKKSZAM = (string)rdr["CIKKSZAM"];
                GYORSKOD = (string)rdr["GYORSKOD"];
                EAN = (string)rdr["EAN_KOD"];
                SZJ = (string)rdr["SZJ_SZAM"];
                MEGJEGYZES = (string)rdr["MEGJEGYZES"];
                MINIMUM_KESZLET = (double)rdr["MINIMUM_KESZLET"];
                OPTIMALIS_KESZLET = (double)rdr["OPTIMALIS_KESZLET"];
                ELADASI_AR = (double)rdr["ELADASI_AR"];

                DEFS.log(Level.Debug, "CikK olvasása" + rdr["CIKK_ID"] + "#" + rdr["MEGNEVEZES"] + "#" + rdr["CIKK_TIPUS"] + "#" + rdr["CIKKCSOPORT_ID"] + "#" +
                        rdr["OTHER_FILTER_ID"] + "#" + rdr["DEFAULT_RAKTAR"] + "#" + rdr["ERT_TIPUS"] + "#" + "#" + "#" + "#" + "#");

            }
            getKeszlet();
            CIKK_KISZERELES = new CikkKiszerelesList(fCIKK_ID, new SqlConnection(DEFS.ConSTR));
            c.Close();

        }


        public void Save()
        {
            int new_c_id;
            new_c_id = fCIKK_ID;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (fCIKK_ID)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO CIKK " +
                                            "(MEGNEVEZES " +
                                            ",CIKK_TIPUS " +
                                            ",CIKKCSOPORT_ID " +
                                            ",ERTEKESITES_TIPUSA " +
                                            ",OTHER_FILTER_ID " +
                                            ",CIKKSZAM " +
                                            ",GYORSKOD " +
                                            ",EAN_KOD " +
                                            ",SZJ_SZAM " +
                                            ",MINIMUM_KESZLET " +
                                            ",OPTIMALIS_KESZLET " +
                                            ",ELADASI_AR " +
                                            ",MEGJEGYZES " +
                                            ",MEGYS_ID " +
                                            ",DEFAULT_RAKTAR " +
                                            //",ERTEKESITES_TIPUSA " +
                                            " ) " +
                                        "VALUES " +
                                            "(@MEGNEVEZES " +
                                            ",@CIKK_TIPUS " +
                                            ",@CIKKCSOPORT_ID " +
                                            ",@ERTEKESITES_TIPUSA " +
                                            ",@OTHER_FILTER_ID " +
                                            ",@CIKKSZAM " +
                                            ",@GYORSKOD " +
                                            ",@EAN " +
                                            ",@SZJ " +
                                            ",@MINIMUM_KESZLET " +
                                            ",@OPTIMALIS_KESZLET " +
                                            ",@ELADASI_AR " +
                                            ",@MEGJEGYZES " +
                                            ",@MEGYS_ID " +
                                            ",@DEFAULT_RAKTAR) SET @newid = SCOPE_IDENTITY()";
                        cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                        cmd.Parameters["newid"].Direction = ParameterDirection.Output;
                        break;
                    }
                default:
                    {
                        cmd.CommandText = "UPDATE CIKK SET MEGNEVEZES = @MEGNEVEZES, " +
                                                       " CIKK_TIPUS = @CIKK_TIPUS, " +
                                                       " CIKKCSOPORT_ID = @CIKKCSOPORT_ID, " +
                                                       " ERTEKESITES_TIPUSA = @ERTEKESITES_TIPUSA, " +
                                                       " OTHER_FILTER_ID = @OTHER_FILTER_ID, " +
                                                       " DEFAULT_RAKTAR = @DEFAULT_RAKTAR, " +
                                                       " CIKKSZAM = @CIKKSZAM, " +
                                                       " GYORSKOD = @GYORSKOD, " +
                                                       " EAN_KOD = @EAN, " +
                                                       " SZJ_SZAM = @SZJ, " +
                                                       " MINIMUM_KESZLET = @MINIMUM_KESZLET, " +
                                                       " OPTIMALIS_KESZLET = @OPTIMALIS_KESZLET, " +
                                                       " ELADASI_AR = @ELADASI_AR, " +
                                                       " MEGJEGYZES = @MEGJEGYZES, " +
                                                       " MEGYS_ID = @MEGYS_ID " +

                                           "WHERE CIKK_ID = @CIKK_ID";
                        cmd.Parameters.Add(new SqlParameter("CIKK_ID", SqlDbType.Int));
                        cmd.Parameters["CIKK_ID"].Value = fCIKK_ID;
                        break;
                    }
            }
            cmd.Parameters.Add(new SqlParameter("MEGNEVEZES", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("CIKK_TIPUS", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKKCSOPORT_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ERTEKESITES_TIPUSA", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("OTHER_FILTER_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("DEFAULT_RAKTAR", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKKSZAM", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("GYORSKOD", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("EAN", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("SZJ", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("MINIMUM_KESZLET", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("OPTIMALIS_KESZLET", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("ELADASI_AR", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("MEGJEGYZES", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("MEGYS_ID", SqlDbType.VarChar));

            
            cmd.Parameters["MEGNEVEZES"].Value = MEGNEVEZES;
            cmd.Parameters["CIKK_TIPUS"].Value = fCIKK_TIPUS;
            cmd.Parameters["CIKKCSOPORT_ID"].Value = CIKKCSOPORT_ID;
            cmd.Parameters["ERTEKESITES_TIPUSA"].Value = ERTEKESITES_TIPUSA;
            cmd.Parameters["OTHER_FILTER_ID"].Value = ALCSOPORT;
            cmd.Parameters["DEFAULT_RAKTAR"].Value = ALAP_RAKTAR;
            cmd.Parameters["CIKKSZAM"].Value = CIKKSZAM;
            cmd.Parameters["GYORSKOD"].Value = GYORSKOD;
            cmd.Parameters["SZJ"].Value = SZJ;
            cmd.Parameters["EAN"].Value = EAN;
            cmd.Parameters["MINIMUM_KESZLET"].Value = MINIMUM_KESZLET;
            cmd.Parameters["OPTIMALIS_KESZLET"].Value = OPTIMALIS_KESZLET;
            cmd.Parameters["ELADASI_AR"].Value = ELADASI_AR;
            cmd.Parameters["MEGJEGYZES"].Value = MEGJEGYZES;
            cmd.Parameters["MEGYS_ID"].Value = MEGYS_ID;

            DEFS.log(Level.Debug, @"Cikk instert / update" + cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.log(Level.Info, "Hiba a Cikk mentése során:" + "/n" + e.Message + "/n" + e.StackTrace);
                
            }

            if (fCIKK_ID == -1)
            {
                new_c_id = (int)cmd.Parameters["newid"].Value;
                fCIKK_ID = new_c_id;
            }

            if (CIKK_KISZERELES != null)
            {
                foreach (var k in CIKK_KISZERELES.lCikkKiszereles)
                {
                    k.Save();
                }
            }
            c.Close();
        }


    }
    
   
    public class CikkKeszlet
    {
        #region Raktár id
        //megnevezés
        public int fRAKTAR_ID;
        public int RAKTAR_ID
        {
            get { return (fRAKTAR_ID); }
            set { fRAKTAR_ID = value; }
        }
        #endregion
        #region Raktár
        //megnevezés
        public string fNEV;
        public string RAKTAR
        {
            get { return (fNEV); }
            set { fNEV = value; }
        }
        #endregion

        #region KESZLET
        //megnevezés
        public double fKESZLET;
        public double KESZLET
        {
            get { return (fKESZLET); }
            set { fKESZLET = value; }
        }
        #endregion

        #region KESZLET_ERTEK
        //megnevezés
        public double fKESZLET_ERTEK;
        public double KESZLET_ERTEK
        {
            get { return (fKESZLET_ERTEK); }
            set { fKESZLET_ERTEK = value; }
        }
        #endregion

        #region ATLAGAR
        //megnevezés
        public double fATLAGAR;
        public double ATLAGAR
        {
            get { return (fATLAGAR); }
            set { fATLAGAR = value; }
        }
        #endregion


        
        
        
        public CikkKeszlet(int pRakt_id, string RaktarNev, double pKeszlet, double pKeszlet_ert, double pAtlagar)
        {
            fRAKTAR_ID = pRakt_id;
            fKESZLET = pKeszlet;
            fKESZLET_ERTEK = pKeszlet_ert;
            fNEV = RaktarNev;
            fATLAGAR = pAtlagar;
        }

    }
    

    
    public class Cikk_list
    {

        public List<Cikk> lCIKK = new List<Cikk>();
        

        public Cikk_list(SqlConnection sc)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID, isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, " +
                                " isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS, isnull(l.LIT_KISZ_NEV,'') as KISZ_NEV, isnull(l.LIT_KISZ_MENNY,'1') as KISZ_MENNY " +
                                " FROM CIKK c left join LIT_KISZ l on c.CIKK_ID = l.LIT_KISZ_CIKK_Id";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DEFS.log(Level.Debug, rdr["CIKK_ID"] + "#" + rdr["MEGNEVEZES"] + "#" + rdr["CIKK_TIPUS"] + "#" + rdr["CIKKCSOPORT_ID"] + "#" +
                        rdr["OTHER_FILTER_ID"] + "#" + rdr["DEFAULT_RAKTAR"] + "#" + rdr["ERT_TIPUS"] + "#" + rdr["KISZ_NEV"] + "#" + rdr["KISZ_MENNY"] + "#" + "#" + "#" + "#");

                try
                {
                    Cikk t = new Cikk((int)rdr["CIKK_ID"], true,new SqlConnection(DEFS.ConSTR));

                    //t.ALCSOPORT = (int)rdr["OTHER_FILTER_ID"];
                    //t.ALAP_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                    //t.ERTEKESITES_TIPUSA = (string)rdr["ERT_TIPUS"];
                    //t.KISZ_MEGN = (string)rdr["KISZ_NEV"];
                    //t.KISZ_MENNY = (double)rdr["KISZ_MENNY"];
                    t.getKeszlet();
                    lCIKK.Add(t);
                }
                catch (Exception e)
                {
                    DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                }
                
            }
            rdr.Close();
            sc.Close();
        }

        public List<Cikk> CikkListByCsoport(int iCsoportId)
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where c.CIKKCSOPORT_ID == iCsoportId
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Cikk> CikkListByAlcsoport(int iCsoportId, int iAlcsoportId)
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where (c.CIKKCSOPORT_ID == iCsoportId) && (c.ALCSOPORT == iAlcsoportId)
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public Cikk CikkByID(int iCikkId)
        {
           Cikk tc = null;

            var ret_cikk =
                from c in lCIKK
                where c.CIKK_ID == iCikkId
                select c;
            ret_cikk.Each(c => tc = c);


            return (tc);
        }

    }
    #endregion

    class Recept
    {
    }

    #region Kiszerelések
    public class CikkKiszereles
    {
//        LIT_KISZ_ID, LIT_KISZ_CIKK_ID, LIT_KISZ_NEV, LIT_KISZ_MENNY
        
        private int fLIT_KISZ_ID;
        public int LIT_KISZ_ID
        {
            get { return (fLIT_KISZ_ID); }
            set { fLIT_KISZ_ID = value; }
        }

        private int fLIT_KISZ_CIKK_ID;
        public int LIT_KISZ_CIKK_ID
        {
            get { return (fLIT_KISZ_CIKK_ID); }
            set { fLIT_KISZ_CIKK_ID = value; }
        }

        private string fLIT_KISZ_NEV;
        public string LIT_KISZ_NEV
        {
            get { return (fLIT_KISZ_NEV); }
            set { fLIT_KISZ_NEV = value; }
        }

        private double fLIT_KISZ_MENNY;
        public double LIT_KISZ_MENNY
        {
            get { return (fLIT_KISZ_MENNY); }
            set { fLIT_KISZ_MENNY = value; }
        }

        public CikkKiszereles(int pId, int pCikk, string pName, double pMenny)
        {

            fLIT_KISZ_ID = pId;
                fLIT_KISZ_CIKK_ID= pCikk;
                fLIT_KISZ_NEV = pName;
                    fLIT_KISZ_MENNY = pMenny;
        }

        public CikkKiszereles()
        {

            fLIT_KISZ_ID = -1;
        }

        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (fLIT_KISZ_ID)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO LIT_KISZ " +
                                            "(LIT_KISZ_CIKK_ID, LIT_KISZ_NEV, LIT_KISZ_MENNY " +
                            //",ERTEKESITES_TIPUSA " +
                                            " ) " +
                                        "VALUES " +
                                            "(@LIT_KISZ_CIKK_ID " +
                                            ",@LIT_KISZ_NEV " +
                                            ",@LIT_KISZ_MENNY " +
                                            " )";

                        break;
                    }
                default:
                    {
                        cmd.CommandText = "UPDATE LIT_KISZ SET LIT_KISZ_CIKK_ID = @LIT_KISZ_CIKK_ID, " +
                                                       " LIT_KISZ_NEV = @LIT_KISZ_NEV, " +
                                                       " LIT_KISZ_MENNY = @LIT_KISZ_MENNY " +

                                           "WHERE LIT_KISZ_ID = @LIT_KISZ_ID";
                        cmd.Parameters.Add(new SqlParameter("LIT_KISZ_ID", SqlDbType.Int));
                        cmd.Parameters["LIT_KISZ_ID"].Value = fLIT_KISZ_ID;
                        break;
                    }
            }
            DEFS.log(Level.Debug, "Kiszerelések:" + cmd.CommandText);

            cmd.Parameters.Add(new SqlParameter("LIT_KISZ_CIKK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("LIT_KISZ_NEV", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("LIT_KISZ_MENNY", SqlDbType.Float));


            cmd.Parameters["LIT_KISZ_CIKK_ID"].Value = fLIT_KISZ_CIKK_ID;
            cmd.Parameters["LIT_KISZ_NEV"].Value = fLIT_KISZ_NEV;
            cmd.Parameters["LIT_KISZ_MENNY"].Value = fLIT_KISZ_MENNY;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.log(Level.Info,"Hiba a rendelés sorok mentése közben!" + fLIT_KISZ_ID.ToString() + "/n" + e.Message + "/n" + e.StackTrace);
                
            }
            c.Close();
            
        }
    }

    public class CikkKiszerelesList
    {


        public List<CikkKiszereles> lCikkKiszereles = new List<CikkKiszereles>();


        public CikkKiszerelesList(int pCikkId, SqlConnection sc)
        {

            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT LIT_KISZ_ID, LIT_KISZ_CIKK_ID, LIT_KISZ_NEV, LIT_KISZ_MENNY FROM LIT_KISZ WHERE LIT_KISZ_CIKK_ID = " + pCikkId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                
                CikkKiszereles t = new CikkKiszereles((int)rdr["LIT_KISZ_ID"],
                                (int)rdr["LIT_KISZ_CIKK_ID"],
                                (string)rdr["LIT_KISZ_NEV"],
                                (double)rdr["LIT_KISZ_MENNY"]);
                lCikkKiszereles.Add(t);
            }
            rdr.Close();
            sc.Close();
        }

    }
    #endregion

    #region Other filter
    public class OTF
    {
        private int fOTF_ID;
        private int fCIKKCSOPORT_ID;
        private string fOTHER_NAME;

        public string ONEV
        {
            get { return (fOTHER_NAME); }
            set { fOTHER_NAME = value; }
        }

        public int OID
        {
            get { return (fOTF_ID); }
            set { fOTF_ID = value; }
        }
        public int CikkCsopID
        {
            get { return (fCIKKCSOPORT_ID); }
            set { fCIKKCSOPORT_ID = value; }
        }


        public OTF(int pOTF_ID,int pCIKKCSOPORT_ID, string pOTHER_NAME)
        {

            fOTF_ID = pOTF_ID;
            fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;
            fOTHER_NAME = pOTHER_NAME;
        }

        public OTF()
        {
            fOTF_ID = -1;
        }
    }

    public class OTF_list
    {
        

        public List<OTF> lOTF = new List<OTF>();
        

        public OTF_list(int pCIKKCSOP_ID, SqlConnection sc)
        {
            
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT OTHER_FILTER_ID ,CIKKCSOPORT_ID  ,isnull(OTHER_NAME,'') as OTHER_NAME FROM CIKCSOP_OTHER_FILTER WHERE CIKKCSOPORT_ID = " + pCIKKCSOP_ID.ToString();
            
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr["OTHER_FILTER_ID"] != DBNull.Value)
                {
                    OTF t = new OTF((int)rdr["OTHER_FILTER_ID"],
                                    (int)rdr["CIKKCSOPORT_ID"],
                                    (string)rdr["OTHER_NAME"]);
                    lOTF.Add(t);
                }
            }
            rdr.Close();
            sc.Close();
        }

    }
    #endregion

    #region Cikkcsoport
    public class Cikkcsoport
    {
        private int fCIKKCSOPORT_ID;
        private string fCIKKCSOPORT_NEV;
        private string fAFA_KOD;

        public string NEV
        {
            get { return (fCIKKCSOPORT_NEV); }
            set { fCIKKCSOPORT_NEV = value; }
        }

        public int ID
        {
            get { return (fCIKKCSOPORT_ID); }
            set { fCIKKCSOPORT_ID = value; }
        }

        public string AFA_KOD
        {
            get { return (fAFA_KOD); }
            set { fAFA_KOD = value; }
        }

        public Cikkcsoport(int pCIKKCSOPORT_ID, string pCIKKCSOPORT_NEV)
        {

            fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;
            fCIKKCSOPORT_NEV = pCIKKCSOPORT_NEV;



        }

        public Cikkcsoport()
        {
            fCIKKCSOPORT_ID = -1;
        }
    }

    public class Cikkcsoport_list
    {
       

        public List<Cikkcsoport> lCIKKCSOPORT = new List<Cikkcsoport>();
        

        public Cikkcsoport_list(SqlConnection sc)
        {
            
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKKCSOPORT_ID, CIKKCSOPORT_NEV, AFA_KOD  FROM CIKKCSOPORT";
            DEFS.log(Level.Debug, "Get Cikkcsoportok:");
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Cikkcsoport t = new Cikkcsoport((int)rdr["CIKKCSOPORT_ID"],
                                  (string)rdr["CIKKCSOPORT_NEV"]);
                t.AFA_KOD = (string)rdr["AFA_KOD"];
                lCIKKCSOPORT.Add(t);
                DEFS.log(Level.Debug, rdr["CIKKCSOPORT_ID"]+"-->"+rdr["CIKKCSOPORT_NEV"]+"-->"+rdr["AFA_KOD"]);

            }
            rdr.Close();
            sc.Close();
        }

    }


    #endregion

    #region Mértékegységek
    public class Megys
    {
        private string _id;
        public string ID
        {
            get { return (_id); }
            set { _id = value; }
        }

        private string _nev;
        public string NEV
        {
            get { return (_nev); }
            set { _nev = value; }
        }

        public Megys(string pId, string pNev)
        {
            _id = pId;
            _nev = pNev;
        }


    }

    public class Megys_list
    {


        public List<Megys> lMegys = new List<Megys>();


        public Megys_list(SqlConnection sc)
        {

            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT MEGYS_ID, MEGYS_MEGNEVEZES FROM MEGYS";
            DEFS.log(Level.Debug, "Get mértékegységek:");
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Megys t = new Megys((string)rdr["MEGYS_ID"],
                                  (string)rdr["MEGYS_MEGNEVEZES"]);

                lMegys.Add(t);
                DEFS.log(Level.Debug, rdr["MEGYS_ID"] + "-->" + rdr["MEGYS_MEGNEVEZES"]);

            }
            rdr.Close();
            sc.Close();
        }

        public Megys MegysById(string iId)
        {
            Megys tc = null;

            var ret_cikk =
                from c in lMegys
                where c.ID == iId
                select c;
            ret_cikk.Each(c => tc = c);


            return (tc);
        }

    }



    #endregion

}