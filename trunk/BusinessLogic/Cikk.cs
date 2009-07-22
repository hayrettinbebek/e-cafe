using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using NSpring.Logging;
using Microsoft.VisualBasic;

namespace BusinessLogic
{
    public enum CikkListContructType
    {
        CikkSelector,
        CikkselectorKeszlet,
        FullCikk,
        ForRendeles
    }

    public enum CikkcsoportContructType
    {
        Full,
        Visible
    }

    public enum CikkConstructorType
    {
        Rendeles,
        Kiszereles
    }


    public enum CikkTipus
    {
        Normal = 0,
        Osszetett = 1,
        Egyedi = 2
    }
    #region Cikk
    public class Cikk
    {
        public CikkKiszerelesList CIKK_KISZERELES;
        public String KISZ_MEGN;
        public double KISZ_MENNY;

        #region internal paramteres
        private int fCIKK_ID;
        private int fLIT_KISZ_ID;
        private string fMEGYS_ID;
        public int fCIKK_TIPUS;
        private int fMEGKULONB_ZARAS;
        private int fAUTO_MEGRENDELO;
        private int fOTHER_FILTER_ID;
        private string fMEGNEVEZES;
        private string fMEGJEGYZES;
        private string fCIKKSZAM;
        private string fGYORSKOD;
        private string fEAN;
        private double fMINIMUM_KESZLET;
        private double fOPTIMALIS_KESZLET;
        private double fELADASI_AR;
        private double fELADASI_AR_NETTO;
        private double fAFA_SZAZ;
        private string fSZJ;
        private int fCIKKCSOPORT_ID;
        private int fDEFAULT_RAKTAR;
        private string fERT_TIP;
        private int fAKTIV;
        private int fVIRTUAL;
        private int fCIKK_TOP_LIST;
        private int fCIKKCSOP_PREFER;
        private string fROVID_NEV;
        #endregion

        public List<CikkKeszlet> lKESZLET = new List<CikkKeszlet>();

        public List<CikkBeszallito> lBESZALLITOK = new List<CikkBeszallito>();
        #region PROPERTIES

        public int CIKK_ID
        {
            get { return (fCIKK_ID); }
            set { fCIKK_ID = value; }
        }
        public int LIT_KISZ_ID
        {
            get { return (fLIT_KISZ_ID); }
            set { fLIT_KISZ_ID = value; }
        }
        public string MEGYS_ID
        {
            get { return (fMEGYS_ID); }
            set { fMEGYS_ID = value; }
        }
        public string MEGYS_MEGNEVEZES
        {
            get
            {
                Megys_list ml = new Megys_list();

                return (ml.MegysById(MEGYS_ID).NEV);

            }

        }
        public bool OSSZETETT
        {
            get { return (fCIKK_TIPUS == 1); }
            set
            {
                if (value) { fCIKK_TIPUS = 1; }
                else { fCIKK_TIPUS = 0; }
            }
        }
        public bool MEGKULONB_ZARAS
        {
            get { return (fMEGKULONB_ZARAS == 1); }
            set
            {
                if (value) { fMEGKULONB_ZARAS = 1; }
                else { fMEGKULONB_ZARAS = 0; }
            }
        }
        public bool AUTO_MEGRENDELO
        {
            get { return (fAUTO_MEGRENDELO == 1); }
            set
            {
                if (value) { fAUTO_MEGRENDELO = 1; }
                else { fAUTO_MEGRENDELO = 0; }
            }
        }
        public double fKESZLET
        {
            get
            {
                double iTmpRet = 0;

                var ret_cikk =
                    from c in lKESZLET
                    where c.fRAKTAR_ID == fDEFAULT_RAKTAR
                    select c;
                ret_cikk.Each(c => iTmpRet = c.fKESZLET);

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
        public int ALCSOPORT
        {
            get { return (fOTHER_FILTER_ID); }
            set { fOTHER_FILTER_ID = value; }
        }
        public string MEGNEVEZES
        {
            get { return (fMEGNEVEZES); }
            set { fMEGNEVEZES = value; }
        }
        public string MEGJEGYZES
        {
            get { return (fMEGJEGYZES); }
            set { fMEGJEGYZES = value; }
        }
        public string CIKKSZAM
        {
            get { return (fCIKKSZAM); }
            set { fCIKKSZAM = value; }
        }
        public string GYORSKOD
        {
            get { return (fGYORSKOD); }
            set { fGYORSKOD = value; }
        }
        public string EAN
        {
            get { return (fEAN); }
            set { fEAN = value; }
        }
        public double MINIMUM_KESZLET
        {
            get { return (fMINIMUM_KESZLET); }
            set { fMINIMUM_KESZLET = value; }
        }
        public double OPTIMALIS_KESZLET
        {
            get { return (fOPTIMALIS_KESZLET); }
            set { fOPTIMALIS_KESZLET = value; }
        }
        public double ELADASI_AR
        {
            get { return (fELADASI_AR); }
            set { fELADASI_AR = value; }
        }
        public double ELADASI_AR_VALOS
        {
            //get { return (ELADASI_AR * KISZ_MENNY); }
            get { return (ELADASI_AR); }

        }
        public double NETTO_AR
        {
            get { return (fELADASI_AR_NETTO); }
            set { fELADASI_AR_NETTO = value; }
        }
        public double AFA_SZAZ
        {
            get { return (fAFA_SZAZ); }
            set { fAFA_SZAZ = value; }
        }
        public string BESZERZESI_AR_S
        {
            get { return (getBeszAr(CIKK_ID)); }

        }
        public double UTOLOS_BESZ_AR
        {
            get { return (getBeszArNet(CIKK_ID)); }

        }
        public string SZJ
        {
            get { return (fSZJ); }
            set { fSZJ = value; }
        }
        public int CIKKCSOPORT_ID
        {
            get { return (fCIKKCSOPORT_ID); }
            set { fCIKKCSOPORT_ID = value; }
        }
        public int ALAP_RAKTAR
        {
            get { return (fDEFAULT_RAKTAR); }
            set { fDEFAULT_RAKTAR = value; }
        }
        public string ERTEKESITES_TIPUSA
        {
            get { return (fERT_TIP); }
            set { fERT_TIP = value; }
        }
        public int AKTIV
        {
            get { return (fAKTIV); }
            set { fAKTIV = value; }
        }
        public int VIRTUALIS
        {
            get { return (fVIRTUAL); }
            set { fVIRTUAL = value; }
        }
        public bool CIKK_TOP_LIST
        {
            get { return (fCIKK_TOP_LIST == 1); }
            set
            {
                if (value) { fCIKK_TOP_LIST = 1; }
                else { fCIKK_TOP_LIST = 0; }
            }
        }
        public bool CIKKCSOP_PREFER
        {
            get { return (fCIKKCSOP_PREFER == 1); }
            set
            {
                if (value) { fCIKKCSOP_PREFER = 1; }
                else { fCIKKCSOP_PREFER = 0; }
            }
        }
        public string ROVID_NEV
        {
            get { return (fROVID_NEV); }
            set { fROVID_NEV = value; }
        }

        public List<CikkAr> CIKK_ARAK
        {
            get { return (getArak()); }
        }
        #endregion


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


        #region Constructor

        public Cikk(int pCIKK_ID, string pMEGNEVEZES, int pCIKK_TIPUS, int pCIKKCSOPORT_ID)
        {

            fCIKK_ID = pCIKK_ID;
            fMEGNEVEZES = pMEGNEVEZES;
            fCIKK_TIPUS = pCIKK_TIPUS;
            fCIKKCSOPORT_ID = pCIKKCSOPORT_ID;
            CIKK_KISZERELES = new CikkKiszerelesList();//fCIKK_ID, new SqlConnection(DEFS.ConSTR));
            fAKTIV = 1;
            fVIRTUAL = 0;
            fCIKKSZAM = "";
            fGYORSKOD = "";
            fERT_TIP = "D";
            fEAN = "";
            fSZJ = "";
            fMEGJEGYZES = "";
            fMEGYS_ID = "1";
            fROVID_NEV = "";
            
        }

        public Cikk()
        {

            fCIKK_ID = -1;
            fAKTIV = 1;
            fVIRTUAL = 0;

        }


        public Cikk(int pCikkId, int kisz_id)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(CIKKSZAM,'') as CIKKSZAM, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID," +
                            " isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS, isnull(l.LIT_KISZ_NEV,'') as KISZ_NEV, isnull(l.LIT_KISZ_MENNY,'1') as KISZ_MENNY, " +
                            " isnull(GYORSKOD,'') as GYORSKOD , isnull(EAN_KOD,'') as EAN_KOD,isnull(SZJ_SZAM,'') as SZJ_SZAM , " +
                            " isnull(MINIMUM_KESZLET,0) as MINIMUM_KESZLET , isnull(OPTIMALIS_KESZLET,0) as OPTIMALIS_KESZLET , isnull(ELADASI_AR,0) as ELADASI_AR , isnull(MEGJEGYZES,'') as MEGJEGYZES ,isnull(MEGYS_ID,-1) as MEGYS_ID,  " +
                            " isnull(ELADASI_AR_NETTO,0) as ELADASI_AR_NETTO, isnull(dbo.fn_get_AfaSzaz(cikk_id),20) as AFA_SZAZ, AKTIV, VIRTUAL,  " +
                            " isnull(CIKK_ROVID_NEV,'') as ROVID_NEV, CIKK_TOP_LIST, CIKKCSOP_PREFER, isnull(LIT_KISZ_ID,-1) as LIT_KISZ_ID  " +

                            " FROM CIKK  c left join LIT_KISZ l on c.CIKK_ID = l.LIT_KISZ_CIKK_Id WHERE CIKK_ID =" + pCikkId.ToString() + "  AND isnull(LIT_KISZ_ID,-1) = " + kisz_id.ToString();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                #region Fill Fields
                fCIKK_ID = (int)rdr["CIKK_ID"];
                fMEGNEVEZES = (string)rdr["MEGNEVEZES"];
                fCIKK_TIPUS = (int)rdr["CIKK_TIPUS"];
                fCIKKCSOPORT_ID = (int)rdr["CIKKCSOPORT_ID"];
                fOTHER_FILTER_ID = (int)rdr["OTHER_FILTER_ID"];

                fAKTIV = (int)rdr["AKTIV"];

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
                LIT_KISZ_ID = (int)rdr["LIT_KISZ_ID"];
                ELADASI_AR = (double)rdr["ELADASI_AR"];
                NETTO_AR = (double)rdr["ELADASI_AR_NETTO"];
                AFA_SZAZ = (double)rdr["AFA_SZAZ"];
                fVIRTUAL = (int)rdr["VIRTUAL"];
                fROVID_NEV = (string)rdr["ROVID_NEV"];
                fCIKK_TOP_LIST = (int)rdr["CIKK_TOP_LIST"];
                fCIKKCSOP_PREFER = (int)rdr["CIKKCSOP_PREFER"];
                #endregion

            }
            getKeszlet();
            getBeszallitok();
            CIKK_KISZERELES = new CikkKiszerelesList(fCIKK_ID, new SqlConnection(DEFS.ConSTR));
            c.Close();

        }

        public Cikk(int pCikkId, bool ForEdit)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(CIKKSZAM,'') as CIKKSZAM, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID," +
                            " isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS," +
                            " isnull(GYORSKOD,'') as GYORSKOD , isnull(EAN_KOD,'') as EAN_KOD,isnull(SZJ_SZAM,'') as SZJ_SZAM , " +
                            " isnull(MINIMUM_KESZLET,0) as MINIMUM_KESZLET , isnull(OPTIMALIS_KESZLET,0) as OPTIMALIS_KESZLET , isnull(ELADASI_AR,0) as ELADASI_AR , isnull(MEGJEGYZES,'') as MEGJEGYZES ,isnull(MEGYS_ID,-1) as MEGYS_ID,  " +
                            " isnull(ELADASI_AR_NETTO,0) as ELADASI_AR_NETTO, isnull(dbo.fn_get_AfaSzaz(cikk_id),20) as AFA_SZAZ, " +
                            " isnull(SPEC_ZARAS,0) as SPEC_ZARAS, isnull(AUTO_MEGRENDELO,0) as AUTO_MEGRENDELO, AKTIV, VIRTUAL, " +
                            " isnull(CIKK_ROVID_NEV,'') as ROVID_NEV, CIKK_TOP_LIST, CIKKCSOP_PREFER " +
                            " FROM CIKK WHERE CIKK_ID =" + pCikkId.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                #region Fill Fields
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
                NETTO_AR = (double)rdr["ELADASI_AR_NETTO"];
                AFA_SZAZ = (double)rdr["AFA_SZAZ"];
                fMEGKULONB_ZARAS = (int)rdr["SPEC_ZARAS"];
                fAUTO_MEGRENDELO = (int)rdr["AUTO_MEGRENDELO"];
                fAKTIV = (int)rdr["AKTIV"];
                fVIRTUAL = (int)rdr["VIRTUAL"];
                fROVID_NEV = (string)rdr["ROVID_NEV"];
                fCIKK_TOP_LIST = (int)rdr["CIKK_TOP_LIST"];
                fCIKKCSOP_PREFER = (int)rdr["CIKKCSOP_PREFER"];
                #endregion

            }
            getKeszlet();
            getBeszallitok();
            CIKK_KISZERELES = new CikkKiszerelesList(fCIKK_ID, new SqlConnection(DEFS.ConSTR));
            c.Close();

        }

        #endregion

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
                        #region SQL
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
                                            ",ELADASI_AR_NETTO " +
                                            ",DEFAULT_RAKTAR " +
                                            ",SPEC_ZARAS " +
                                            ",AUTO_MEGRENDELO " +
                                            ",AKTIV " +
                                            ",VIRTUAL " +
                                            ",CIKK_ROVID_NEV " +
                                            ",CIKK_TOP_LIST " +
                                            ",CIKKCSOP_PREFER " +
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
                                            ",@ELADASI_AR_NETTO " +
                                            ",@DEFAULT_RAKTAR " +
                                            ",@SPEC_ZARAS " +
                                            ",@AUTO_MEGRENDELO " +
                                            ",@AKTIV " +
                                            ",@VIRTUAL " +
                                            ",@CIKK_ROVID_NEV " +
                                            ",@CIKK_TOP_LIST " +
                                            ",@CIKKCSOP_PREFER " +
                                            " ) SET @newid = SCOPE_IDENTITY()";
                        #endregion
                        cmd.Parameters.Add(new SqlParameter("newid", SqlDbType.Int));
                        cmd.Parameters["newid"].Direction = ParameterDirection.Output;
                        break;
                    }
                default:
                    {
                        #region SQL
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
                                                       " MEGYS_ID = @MEGYS_ID, " +
                                                       " ELADASI_AR_NETTO = @ELADASI_AR_NETTO, " +
                                                       " SPEC_ZARAS = @SPEC_ZARAS, " +
                                                       " AUTO_MEGRENDELO = @AUTO_MEGRENDELO, " +
                                                       " AKTIV = @AKTIV, " +
                                                       " VIRTUAL = @VIRTUAL, " +
                                                       " CIKK_ROVID_NEV = @CIKK_ROVID_NEV, " +
                                                       " CIKK_TOP_LIST = @CIKK_TOP_LIST, " +
                                                       " CIKKCSOP_PREFER = @CIKKCSOP_PREFER " +



                                           "WHERE CIKK_ID = @CIKK_ID";
                        #endregion
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
            cmd.Parameters.Add(new SqlParameter("ELADASI_AR_NETTO", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("MEGJEGYZES", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("MEGYS_ID", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("SPEC_ZARAS", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("AUTO_MEGRENDELO", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("AKTIV", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("VIRTUAL", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKKCSOP_PREFER", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKK_TOP_LIST", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("CIKK_ROVID_NEV", SqlDbType.VarChar));


            cmd.Parameters["MEGNEVEZES"].Value = MEGNEVEZES;
            cmd.Parameters["CIKK_TIPUS"].Value = fCIKK_TIPUS;
            cmd.Parameters["CIKKCSOPORT_ID"].Value = CIKKCSOPORT_ID;
            if (ERTEKESITES_TIPUSA == "")
            {
                cmd.Parameters["ERTEKESITES_TIPUSA"].Value = "D";
            }
            else
            {
                cmd.Parameters["ERTEKESITES_TIPUSA"].Value = ERTEKESITES_TIPUSA;
            }
            cmd.Parameters["OTHER_FILTER_ID"].Value = ALCSOPORT;
            cmd.Parameters["DEFAULT_RAKTAR"].Value = ALAP_RAKTAR;

            cmd.Parameters["CIKKSZAM"].Value = CIKKSZAM;
            cmd.Parameters["GYORSKOD"].Value = GYORSKOD;
            cmd.Parameters["SZJ"].Value = SZJ;
            cmd.Parameters["EAN"].Value = EAN;
            cmd.Parameters["MINIMUM_KESZLET"].Value = MINIMUM_KESZLET;
            cmd.Parameters["OPTIMALIS_KESZLET"].Value = OPTIMALIS_KESZLET;
            cmd.Parameters["ELADASI_AR"].Value = ELADASI_AR;
            cmd.Parameters["ELADASI_AR_NETTO"].Value = NETTO_AR;
            cmd.Parameters["MEGJEGYZES"].Value = MEGJEGYZES;
            cmd.Parameters["MEGYS_ID"].Value = MEGYS_ID;
            cmd.Parameters["SPEC_ZARAS"].Value = fMEGKULONB_ZARAS;
            cmd.Parameters["AUTO_MEGRENDELO"].Value = fAUTO_MEGRENDELO;
            cmd.Parameters["AKTIV"].Value = AKTIV;
            cmd.Parameters["VIRTUAL"].Value = VIRTUALIS;
            cmd.Parameters["CIKK_ROVID_NEV"].Value = ROVID_NEV;
            cmd.Parameters["CIKK_TOP_LIST"].Value = fCIKK_TOP_LIST;
            cmd.Parameters["CIKKCSOP_PREFER"].Value = fCIKKCSOP_PREFER;

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

        public static string getBeszAr(int pCikk)
        {
            string ret;
            double net = 0;
            double br = 0;

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("select TOP 1 NETTO_ERTEK / MENNY as NETTO_AR, " +
                                           " BRUTTO_ERTEK / MENNY as BRUTTO_AR " +
                                           " from bevetel_sor " +
                                           " where CIKK_ID = " + pCikk.ToString() + " order by SOR_ID DESC ", c);
            gk.CommandType = CommandType.Text;
            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                net = (double)rdr["NETTO_AR"];
                br = (double)rdr["BRUTTO_AR"];

            }

            c.Close();
            ret = br.ToString("#.00") + " / " + net.ToString("#.00");
            return (ret);

        }

        public static double getBeszArNet(int pCikk)
        {

            double net = 0;
            double br = 0;

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("select TOP 1 case when MENNY = 0 THEN 0 else NETTO_ERTEK / MENNY end as NETTO_AR, " +
                                           " case when MENNY = 0 THEN 0 else  BRUTTO_ERTEK / MENNY end as BRUTTO_AR " +
                                           " from bevetel_sor " +
                                           " where CIKK_ID = " + pCikk.ToString() + " order by SOR_ID DESC ", c);
            gk.CommandType = CommandType.Text;
            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                net = (double)rdr["NETTO_AR"];
                br = (double)rdr["BRUTTO_AR"];

            }

            c.Close();

            return (net);

        }

        private List<CikkAr> getArak()
        {
            List<CikkAr> tmpLCikkArak = new List<CikkAr>();

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("SELECT CIKK_ARAK_ID FROM CIKK_ARAK WHERE CIKK_ID = " + CIKK_ID.ToString(), c);
            gk.CommandType = CommandType.Text;
            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                tmpLCikkArak.Add(new CikkAr((int)rdr["CIKK_ARAK_ID"]));
            }
            c.Close();
            return tmpLCikkArak;
        }

        private void getBeszallitok()
        {
            lBESZALLITOK.Clear();

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand gk = new SqlCommand("SELECT PARTNER_ID, BESZ_AR, isnull(KISZ_MENNY,0) as KISZ_MENNY FROM cikk_beszallitok WHERE CIKK_ID = " + CIKK_ID.ToString(), c);
            gk.CommandType = CommandType.Text;
            SqlDataReader rdr = gk.ExecuteReader();
            while (rdr.Read())
            {
                lBESZALLITOK.Add(new CikkBeszallito(new Szallito((int)rdr["PARTNER_ID"]),  this, (double)rdr["BESZ_AR"], (double)rdr["KISZ_MENNY"]));
            }
            c.Close();
            
        }

        public CikkBeszallito getCurrentBeszallito(int sz_id)
        {
            CikkBeszallito tmpCikkBesz = null;
            var curr_besz =
                from c in lBESZALLITOK
                where c.SZALLITO.PARTNER_ID == sz_id
                select c;
            curr_besz.Each(c => tmpCikkBesz = c);
            return tmpCikkBesz;
        }
        public void AddCikkAr(DateTime ar_from, DateTime ar_to, double ar)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " INSERT INTO CIKK_ARAK (CIKK_ID,ERVENYES_TOL,ERVENYES_IG,ELADASI_AR_N) " +
                                            "VALUES (@CIKK_ID ,@ERVENYES_TOL ,@ERVENYES_IG ,@ELADASI_AR_N )";

            cmd.Parameters.Add(new SqlParameter("CIKK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ERVENYES_TOL", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("ERVENYES_IG", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("ELADASI_AR_N", SqlDbType.Float));

            cmd.Parameters["CIKK_ID"].Value = CIKK_ID;
            cmd.Parameters["ERVENYES_TOL"].Value = ar_from;
            cmd.Parameters["ERVENYES_IG"].Value = ar_to;
            cmd.Parameters["ELADASI_AR_N"].Value = ar;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.log(Level.Info, "Hiba a Cikk eladási árak mentése:" + "/n" + e.Message + "/n" + e.StackTrace);

            }
            c.Close();
        }


        public bool AddReceptTetel(int r_cikk, double menny)
        {
            bool rt;
            List<CikkAr> tmpLCikkArak = new List<CikkAr>();

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO  RECEPT (OSSZ_CIKK_ID ,OSSZ_CIKK_TARTOZEK_ID,TARTOZEK_MENNY) " +
                            "VALUES (@CIKK_ID, @R_CIKK, @MENNY)", c);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("CIKK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("R_CIKK", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("MENNY", SqlDbType.Float));

            cmd.Parameters["CIKK_ID"].Value = CIKK_ID;
            cmd.Parameters["R_CIKK"].Value = r_cikk;
            cmd.Parameters["MENNY"].Value = menny;

            try
            {
                cmd.ExecuteNonQuery();
                rt = true;
            }
            catch
            {
                rt = false;
            }

            c.Close();

            return rt;
        }
    }

    public class CikkFilter
    {
        
        public CikkFilter()
        {
            _nev = "";
            _cikkcsop = "";
        }
        private string _nev = "";
        private string _rovid_nev = "";
        private string _cikkcsop = "";
        private string _alcsop = "";

        public string FILTER_NEV
        {
            get { return (_nev); }
            set
            {
                _nev = value;
                
            }
        }

        public string FILTER_ROVID_NEV
        {
            get { return (_rovid_nev); }
            set
            {
                _rovid_nev = value;

            }
        }

        public string FILTER_CIKKCSOP
        {
            get { return (_cikkcsop); }
            set
            {
                _cikkcsop = value;
                
            }

        }

        public string FILTER_ALCSOPORT
        {
            get { return (_alcsop); }
            set
            {
                _alcsop = value;

            }

        }



        public string  getResult()
        {
            
            string res_str = "";

                res_str += "(MEGNEVEZES like '" + _nev + "%')";


                res_str += " and ( CIKKCSOPORT  like '" + _cikkcsop + "%')";

                res_str += " and ( CIKK_ROVID_NEV  like '" + _rovid_nev + "%')";
           
                if (_alcsop == "")
                {
                    //res_str += " and ( ALCSOPORT  like '" + _alcsop + "%')";
                }
                else
                {
                    res_str += " and ( ALCSOPORT  like '" + _alcsop + "%')";
                }
            return (res_str);
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

        #region Constructor
 

        public Cikk_list(Partner p)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CIKK_ID from cikk_beszallitok WHERE PARTNER_ID = " + p.PARTNER_ID.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                try
                {
                    Cikk t = new Cikk((int)rdr["CIKK_ID"], true );
                    t.getKeszlet();
                    lCIKK.Add(t);
                }
                catch (Exception e)
                {
                    DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                    DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                }
            }
            rdr.Close();
            sc.Close();
        }


        public Cikk_list(CikkListContructType loadType)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;
            switch (loadType)
            {
                case CikkListContructType.CikkSelector:
                    {
                        #region CikkListContructType.CikkSelector
                        cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, MEGYS_ID, isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR FROM CIKK c WHERE AKTIV = 1 and CIKK_TIPUS = 0";
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            try
                            {
                                Cikk t = new Cikk((int)rdr["CIKK_ID"], (string)rdr["MEGNEVEZES"], (int)rdr["CIKK_TIPUS"], (int)rdr["CIKKCSOPORT_ID"]);
                                t.MEGYS_ID = (string)rdr["MEGYS_ID"];
                                t.ALAP_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                                lCIKK.Add(t);
                            }
                            catch (Exception e)
                            {
                                DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                                DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                            }

                        }
                        rdr.Close();
                        break;
                        #endregion
                    }
                case CikkListContructType.CikkselectorKeszlet:
                    {
                        #region CikkListContructType.CikkselectorKeszlet
                        cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, MEGYS_ID, isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR FROM CIKK c WHERE AKTIV = 1 and CIKK_TIPUS = 0 ";
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            try
                            {
                                Cikk t = new Cikk((int)rdr["CIKK_ID"], (string)rdr["MEGNEVEZES"], (int)rdr["CIKK_TIPUS"], (int)rdr["CIKKCSOPORT_ID"]);
                                t.MEGYS_ID = (string)rdr["MEGYS_ID"];
                                t.ALAP_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                                t.getKeszlet();
                                lCIKK.Add(t);
                            }
                            catch (Exception e)
                            {
                                DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                                DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                            }

                        }
                        rdr.Close();
                        break;
                        #endregion
                    }
                case CikkListContructType.FullCikk:
                    {
                        #region CikkListContructType.FullCikk
                        cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID, isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, " +
                                    " isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS " + //, isnull(l.LIT_KISZ_NEV,'') as KISZ_NEV, isnull(l.LIT_KISZ_MENNY,'1') as KISZ_MENNY " +
                                    " FROM CIKK c WHERE CIKK_TIPUS != 2";

                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            try
                            {
                                Cikk t = new Cikk((int)rdr["CIKK_ID"], true );
                                t.getKeszlet();
                                lCIKK.Add(t);
                            }
                            catch (Exception e)
                            {
                                DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                                DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                            }

                        }
                        rdr.Close();
                        break;
                        #endregion
                    }
                case CikkListContructType.ForRendeles:
                    {
                        #region CikkListContructType.ForRendeles
                        cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(CIKKSZAM,'') as CIKKSZAM, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID," +
                                        " isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS, isnull(l.LIT_KISZ_NEV,'') as KISZ_NEV, isnull(l.LIT_KISZ_MENNY,'1') as KISZ_MENNY, " +
                                        " isnull(GYORSKOD,'') as GYORSKOD , isnull(EAN_KOD,'') as EAN_KOD,isnull(SZJ_SZAM,'') as SZJ_SZAM , " +
                                        " isnull(MINIMUM_KESZLET,0) as MINIMUM_KESZLET , isnull(OPTIMALIS_KESZLET,0) as OPTIMALIS_KESZLET , isnull(ELADASI_AR,0) as ELADASI_AR , isnull(MEGJEGYZES,'') as MEGJEGYZES ,isnull(MEGYS_ID,-1) as MEGYS_ID,  " +
                                        " isnull(ELADASI_AR_NETTO,0) as ELADASI_AR_NETTO, isnull(dbo.fn_get_AfaSzaz(cikk_id),20) as AFA_SZAZ,  " +
                                        " isnull(LIT_KISZ_AR,0) as KISZ_ELADASI_AR, isnull(CIKK_ROVID_NEV,'') as ROVID_NEV, CIKK_TOP_LIST, CIKKCSOP_PREFER, isnull(LIT_KISZ_ID,-1) as LIT_KISZ_ID " +
                                " FROM CIKK c left hash join LIT_KISZ l on c.CIKK_ID = l.LIT_KISZ_CIKK_Id WHERE AKTIV = 1 and CIKK_TIPUS != 2 ORDER BY isnull(CIKK_ROVID_NEV,'') ";

                        SqlDataReader rdr = cmd.ExecuteReader();

                        Cikk t;

                        while (rdr.Read())
                        {

                            try
                            {
                                t = new Cikk((int)rdr["CIKK_ID"], (string)rdr["MEGNEVEZES"], (int)rdr["CIKK_TIPUS"], (int)rdr["CIKKCSOPORT_ID"]);

                                t.CIKK_ID = (int)rdr["CIKK_ID"];
                                t.MEGNEVEZES = (string)rdr["MEGNEVEZES"];
                                t.fCIKK_TIPUS = (int)rdr["CIKK_TIPUS"];
                                t.CIKKCSOPORT_ID = (int)rdr["CIKKCSOPORT_ID"];
                                t.ALCSOPORT = (int)rdr["OTHER_FILTER_ID"];
                                t.ALAP_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                                t.MEGYS_ID = (string)rdr["MEGYS_ID"];
                                t.ERTEKESITES_TIPUSA = (string)rdr["ERT_TIPUS"];
                                t.CIKKSZAM = (string)rdr["CIKKSZAM"];
                                t.GYORSKOD = (string)rdr["GYORSKOD"];
                                t.EAN = (string)rdr["EAN_KOD"];
                                t.SZJ = (string)rdr["SZJ_SZAM"];
                                t.MEGJEGYZES = (string)rdr["MEGJEGYZES"];
                                t.KISZ_MEGN = (string)rdr["KISZ_NEV"];
                                t.KISZ_MENNY = (double)rdr["KISZ_MENNY"];
                                t.LIT_KISZ_ID = (int)rdr["LIT_KISZ_ID"];
                                t.MINIMUM_KESZLET = (double)rdr["MINIMUM_KESZLET"];
                                t.OPTIMALIS_KESZLET = (double)rdr["OPTIMALIS_KESZLET"];
                                t.ROVID_NEV = (string)rdr["ROVID_NEV"];
                                t.CIKK_TOP_LIST = (int)rdr["CIKK_TOP_LIST"] == 1;
                                t.CIKKCSOP_PREFER = (int)rdr["CIKKCSOP_PREFER"] == 1;
                                //if ((double)rdr["ELADASI_AR"] == 0)
                                if ((string)rdr["ERT_TIPUS"] == "L")
                                {
                                    t.ELADASI_AR = (double)rdr["KISZ_ELADASI_AR"];
                                    t.NETTO_AR = DEFS.getNetto((double)rdr["KISZ_ELADASI_AR"], (double)rdr["AFA_SZAZ"]);
                                }
                                else
                                {
                                    t.ELADASI_AR = (double)rdr["ELADASI_AR"];
                                    t.NETTO_AR = (double)rdr["ELADASI_AR_NETTO"];
                                }

                                t.AFA_SZAZ = (double)rdr["AFA_SZAZ"];
                                t.getKeszlet();
                                lCIKK.Add(t);

                            }
                            catch (Exception e)
                            {
                                DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                                DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                            }

                        }
                        rdr.Close();
                        break;
                        #endregion
                    }
                default:
                    break;
            }

            
            sc.Close();
        }

        public Cikk_list(SqlConnection sc, int _CikkCsop, bool forRendeles)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ID, MEGNEVEZES, CIKK_TIPUS, CIKKCSOPORT_ID, isnull(OTHER_FILTER_ID,-1) as OTHER_FILTER_ID, isnull(DEFAULT_RAKTAR,-1) as DEFAULT_RAKTAR, " +
                                " isnull(ERTEKESITES_TIPUSA,'D') as ERT_TIPUS, isnull(l.LIT_KISZ_NEV,'') as KISZ_NEV, isnull(l.LIT_KISZ_MENNY,'1') as KISZ_MENNY, isnull(LIT_KISZ_ID,-1) as LIT_KISZ_ID  " +
                                " FROM CIKK c left join LIT_KISZ l on c.CIKK_ID = l.LIT_KISZ_CIKK_Id "+
                                " WHERE AKTIV = 1 and c.CIKKCSOPORT_ID = " + _CikkCsop;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                try
                {
                    Cikk t = new Cikk((int)rdr["CIKK_ID"], (int)rdr["LIT_KISZ_ID"]);

                    t.ALCSOPORT = (int)rdr["OTHER_FILTER_ID"];
                    t.ALAP_RAKTAR = (int)rdr["DEFAULT_RAKTAR"];
                    t.ERTEKESITES_TIPUSA = (string)rdr["ERT_TIPUS"];
                    t.KISZ_MEGN = (string)rdr["KISZ_NEV"];
                    t.KISZ_MENNY = (double)rdr["KISZ_MENNY"];
                    t.LIT_KISZ_ID = (int)rdr["LIT_KISZ_ID"];
                    t.getKeszlet();
                    lCIKK.Add(t);
                }
                catch (Exception e)
                {
                    DEFS.log(Level.Exception, "Sikertelen betöltés, <null> érték az adatbázisban");
                    DEFS.ExLog(e.Message + "--->" + e.StackTrace);
                }

            }
            rdr.Close();
            sc.Close();
        }

        
        #endregion


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

        public List<Cikk> CikkListByTOP()
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where c.CIKK_TOP_LIST == true
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Cikk> CikkListByCsoportTOP(int iCsoportId)
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where (c.CIKKCSOPORT_ID == iCsoportId) && (c.CIKKCSOP_PREFER == true)
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Cikk> CikkListByNegKeszlet()
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where (c.fKESZLET_ALL < 0)
                select c;
            ret_cikk.Each(c => iTmpRet.Add(c));


            return (iTmpRet);
        }

        public List<Cikk> CikkFilter(string iCikkNev)
        {
            List<Cikk> iTmpRet = new List<Cikk>();

            var ret_cikk =
                from c in lCIKK
                where c.MEGNEVEZES.ToUpper().Contains(iCikkNev.ToUpper())
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

    public class CikkAr
    {
        // Fields
        private DateTime fERVENYES_TOL;
        private DateTime fERVENYES_IG;
        private int fCIKK_ARAK_ID;
        private double fELADASI_AR_N;

        //Properties
        public double ELADASI_AR_N
        {
            get { return (fELADASI_AR_N); }
            set { fELADASI_AR_N = value; }
        }
        public int CIKK_ARAK_ID
        {
            get { return (fCIKK_ARAK_ID); }
            set
            {
                fCIKK_ARAK_ID = value;
            }
        }
       
        public DateTime ERVENYES_IG
        {
            get { return (fERVENYES_IG); }
            set { fERVENYES_IG = value; }
        }
        public DateTime ERVENYES_TOL
        {
            get { return (fERVENYES_TOL); }
            set { fERVENYES_TOL = value; }
        }

        public CikkAr(int c_ar_id)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT CIKK_ARAK_ID, CIKK_ID, ERVENYES_TOL, isnull(ERVENYES_IG,'2099.12.31') as ERVENYES_IG, ELADASI_AR_N FROM  CIKK_ARAK WHERE CIKK_ARAK_ID = " + c_ar_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                CIKK_ARAK_ID = (int)rdr["CIKK_ARAK_ID"];
                ELADASI_AR_N = (double)rdr["ELADASI_AR_N"];
                ERVENYES_IG = (DateTime)rdr["ERVENYES_IG"];
                ERVENYES_TOL = (DateTime)rdr["ERVENYES_TOL"];

            }
            rdr.Close();
            sc.Close();

            
        }
         
        public void Save() {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " UPDATE  CIKK_ARAK " +
                              " SET ERVENYES_TOL = @ERVENYES_TOL  " +
                              " ,ERVENYES_IG = @ERVENYES_IG  " +
                              " ,ELADASI_AR_N = @ELADASI_AR_N  " +
                              " WHERE CIKK_ARAK_ID = @CIKK_ARAK_ID";

            
            cmd.Parameters.Add(new SqlParameter("CIKK_ARAK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("ERVENYES_TOL", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("ERVENYES_IG", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("ELADASI_AR_N", SqlDbType.Float));

            

            cmd.Parameters["CIKK_ARAK_ID"].Value = CIKK_ARAK_ID;
             
            cmd.Parameters["ERVENYES_TOL"].Value = ERVENYES_TOL;
            cmd.Parameters["ERVENYES_IG"].Value = ERVENYES_IG;
            cmd.Parameters["ELADASI_AR_N"].Value = ELADASI_AR_N;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.log(Level.Info, "Hiba a Cikk eladási árak frissítése közben:" + "/n" + e.Message + "/n" + e.StackTrace);

            }
            c.Close();
        }
    }

    public class CikkBeszallito
    {
        private Szallito _szall;
        private Cikk _cikk;
        private double _besz_ar;
        private double _kisz_menny;

        public Szallito SZALLITO
        {
            get { return (_szall); }
            set { _szall = value; }
        }

        public string SZALLITO_NEV
        {
            get { return (_szall.P_NEV); }
        }
        public Cikk CIKK
        {
            get { return (_cikk); }
            set { _cikk = value; }
        }
        public string CIKK_NEV
        {
            get { return (_cikk.MEGNEVEZES); }
        }
        public string KISZERELES_MEGYS_NEV
        {
            get { return (_cikk.MEGYS_MEGNEVEZES); }
        }
        public double BESZ_AR
        {
            get { return (_besz_ar); }
            set { _besz_ar = value; }
        }


        public double KISZ_MENNY
        {
            get { return (_kisz_menny); }
            set { _kisz_menny = value; }
        }

        public CikkBeszallito(Szallito pSz, Cikk pC, double pBesz_ar, double pKisz_menny)
        {
            _szall = pSz;
            _cikk = pC;
            _besz_ar = pBesz_ar;
            _kisz_menny = pKisz_menny;
        }

        public void Save() 
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " UPDATE  cikk_beszallitok " +
                              " SET KISZ_MENNY = @KISZ_MENNY  " +
                              " WHERE CIKK_ID = @CIKK_ID and PARTNER_ID = @SZALL_ID";

            
            cmd.Parameters.Add(new SqlParameter("KISZ_MENNY", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("CIKK_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("SZALL_ID", SqlDbType.Int));

            cmd.Parameters["KISZ_MENNY"].Value = KISZ_MENNY;
            cmd.Parameters["CIKK_ID"].Value = CIKK.CIKK_ID;
            cmd.Parameters["SZALL_ID"].Value = SZALLITO.PARTNER_ID;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DEFS.log(Level.Info, "Hiba a Cikk szállítóinak mennyiségi kiszerelésének frissítése közben:" + "/n" + e.Message + "/n" + e.StackTrace);

            }
            c.Close();


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
                c.Close();
                
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
        public CikkKiszerelesList()
        {
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
        

        public Cikkcsoport_list(CikkcsoportContructType csct)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            if (csct == CikkcsoportContructType.Full)
            {
                cmd.CommandText = "SELECT CIKKCSOPORT_ID, CIKKCSOPORT_NEV, AFA_KOD  FROM CIKKCSOPORT";
            }
            else
            {
                cmd.CommandText = "SELECT CIKKCSOPORT_ID, CIKKCSOPORT_NEV, AFA_KOD  FROM CIKKCSOPORT WHERE isnull(NEM_ELADO,0)=0";
            }
            DEFS.log(Level.Debug, "Get Cikkcsoportok:");
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Cikkcsoport t = new Cikkcsoport((int)rdr["CIKKCSOPORT_ID"],
                                  (string)rdr["CIKKCSOPORT_NEV"]);
                t.AFA_KOD = (string)rdr["AFA_KOD"];
                lCIKKCSOPORT.Add(t);
                

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


        public Megys_list()
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
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
