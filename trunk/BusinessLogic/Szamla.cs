using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using NSpring.Logging;

namespace BusinessLogic
{
    public class Szamla
    {
        private int fFEJ_ID;
        private string fSZAMLA_SORSZAM;
        private int fPARTNER_ID;
        private int fRENDELES_ID;
        private double fKEDVEZMENY;
        private int fFIZETESI_MOD;
        private DateTime fSZAMLA_DATUMA;
        private int fEV;
        private int fHO;
        private int fNAP;
        private int fUSER_ID;
    
        public List<Szamla_tetel> lTETELEK = new List<Szamla_tetel>();
     
        public Szamla(int pSzlaid)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SZAMLA_FEJ_ID " +
                              ",SZAMLA_SORSZAM " +
                              ",PARTNER_ID " +
                              ",RENDELES_ID " +
                              ",OSSZESEN_NETTO " +
                              ",OSSZESEN_BRUTTO " +
                              ",OSSZESEN_AFA " +
                              ",KEDVEZMENY " +
                              ",FIZETETT_OSSZEG " +
                              ",FIZETESI_MOD " +
                              ",SZAMLA_DATUMA " +
                              ",EV " +
                              ",HO " +
                              ",NAP " +
                              ",USER_ID " +
                          "FROM SZAMLA_FEJ WHERE SZAMLA_FEJ_ID = @fid";

            cmd.Parameters.Add(new SqlParameter("fid", SqlDbType.Int));
            cmd.Parameters["fid"].Value = pSzlaid;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                try
                {
                    fFEJ_ID = (int)rdr["SZAMLA_FEJ_ID"];
                    fSZAMLA_SORSZAM = (string)rdr["SZAMLA_FEJ_ID"];
                    fPARTNER_ID = (int)rdr["SZAMLA_FEJ_ID"];
                    fRENDELES_ID = (int)rdr["SZAMLA_FEJ_ID"];
                    fKEDVEZMENY = (double)rdr["SZAMLA_FEJ_ID"];
                    fFIZETESI_MOD = (int)rdr["SZAMLA_FEJ_ID"];
                    fSZAMLA_DATUMA = (DateTime)rdr["SZAMLA_FEJ_ID"];
                    fEV = (int)rdr["SZAMLA_FEJ_ID"];
                    fHO = (int)rdr["SZAMLA_FEJ_ID"];
                    fNAP = (int)rdr["SZAMLA_FEJ_ID"];
                    fUSER_ID = (int)rdr["SZAMLA_FEJ_ID"];

                }
                catch (Exception e)
                {
                    DEFS.log(Level.Exception, "Számla fej sikertelen betöltés, <null> érték az adatbázisban");
                }



                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TETEL_ID FROM SZAMLA_TETEL WHERE SZAMLA_FEJ_ID = @fid";
                cmd.Parameters.Add(new SqlParameter("fid", SqlDbType.Int));
                cmd.Parameters["fid"].Value = pSzlaid;

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lTETELEK.Add(new Szamla_tetel((int)rdr["TETEL_ID"]));

                }
                rdr.Close();
                
            }
            rdr.Close();
            sc.Close();
          


        }


        #region PROPERTIES
        public int FEJ_ID
        {
            get
            {
                return (fFEJ_ID);
            }
           
        }

        public string SZAMLA_SORSZAM
        {
            get
            {
                return (fSZAMLA_SORSZAM);
            }
 
        }

        public int PARTNER_ID
        {
            get
            {
                return (fPARTNER_ID);
            }
        }

        public int RENDELES_ID
        {
            get
            {
                return (fRENDELES_ID);
            }
        }

        public double KEDVEZMENY
        {
            get
            {
                return (fKEDVEZMENY);
            }
            
        }

        public int FIZETESI_MOD
        {
            get
            {
                return (fFIZETESI_MOD);
            }
            
        }

        public DateTime SZAMLA_DATUMA
        {
            get
            {
                return (fSZAMLA_DATUMA);
            }
            
        }

        public int EV
        {
            get
            {
                return (fEV);
            }
            
        }

        public int HO
        {
            get
            {
                return (fHO);
            }
           
        }

        public int NAP
        {
            get
            {
                return (fNAP);
            }
           
        }

        public int USER_ID
        {
            get
            {
                return (fUSER_ID);
            }

        }
        #endregion

    }

    public class Szamla_tetel
    {
        private double fAFA;
        private string fAFA_KOD;
        private double fBRUTTO;
        private Cikk fCIKK;
        private double fEGYSEGAR;
        private int fFEJ_ID;
        private string fMEGJEGYZES;
        private double fMENNYISEG;
        private double fNETTO;
        private int fTETEL_ID;
        private string fCIKK_MEGNEVEZES;
    
        public Szamla_tetel(int pSzla_Tetelid)
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT TETEL_ID " +
                                  ",RENDELES_SOR_ID " +
                                  ",CIKK_ID " +
                                  ",MENNYISEG " +
                                  ",EGYSEGAR " +
                                  ",NETTO " +
                                  ",AFA " +
                                  ",BRUTTO " +
                                  ",AFA_KOD " +
                                  ",MEGJEGYZES " +
                                  ",CIKK_MEGNEVEZES " +
                                  ",SZAMLA_FEJ_ID " +
                              "FROM SZAMLA_TETEL WHERE TETEL_ID = @tid";

            cmd.Parameters.Add(new SqlParameter("tid", SqlDbType.Int));
            cmd.Parameters["tid"].Value = pSzla_Tetelid;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                try
                {
                    fTETEL_ID = (int)rdr["TETEL_ID"];
                    fTETEL_ID = (int)rdr["RENDELES_SOR_ID"];
                    fCIKK = new Cikk((int)rdr["CIKK_ID"], new SqlConnection(DEFS.ConSTR));
                    fMENNYISEG = (double)rdr["MENNYISEG"];
                    fEGYSEGAR = (double)rdr["EGYSEGAR"];
                    fNETTO = (double)rdr["NETTO"];
                    fAFA = (double)rdr["AFA"];
                    fBRUTTO = (double)rdr["BRUTTO"];
                    fAFA_KOD = (string)rdr["AFA_KOD"];
                    fMEGJEGYZES = (string)rdr["MEGJEGYZES"];
                    fCIKK_MEGNEVEZES = (string)rdr["CIKK_MEGNEVEZES"];
                    fFEJ_ID = (int)rdr["SZAMLA_FEJ_ID"];
                }
                catch (Exception e)
                {
                    DEFS.log(Level.Exception, "Számla tétel sikertelen betöltés, <null> érték az adatbázisban");
                }
                
            }
            rdr.Close();
            sc.Close();

            
        }


        #region PROPERTIES
        public Cikk CIKK
        {
            get
            {
                return (fCIKK);
            }
            
        }

        public double MENNYISEG
        {
            get
            {
                return (fMENNYISEG);
            }
            
        }

        public double EGYSEGAR
        {
            get
            {
                return (fEGYSEGAR);
            }
            
        }

        public double NETTO
        {
            get
            {
                return (fNETTO);
            }
           
        }

        public double AFA
        {
            get
            {
                return (fAFA);
            }
        }

        public double BRUTTO
        {
            get
            {
                throw new System.NotImplementedException();
            }
            
        }

        public string AFA_KOD
        {
            get
            {
                throw new System.NotImplementedException();
            }

        }

        public string MEGJEGYZES
        {
            get
            {
                return (fMEGJEGYZES);
            }
            
        }

        public int FEJ_ID
        {
            get
            {
                return (fFEJ_ID);
            }

        }

        public int TETEL_ID
        {
            get
            {
                return (fTETEL_ID);
            }

        }

        public string CIKK_MEGNEVEZES
        {
            get
            {
                return (fCIKK_MEGNEVEZES);
            }

        }
        #endregion



    }
}
