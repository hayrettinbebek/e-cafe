using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLogic
{
#region Bevételezés fej adatok
    public class Bevetel_fej
    {
        #region Properties

        public bool isModified;

        //id
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

        //partner
        private int _PARTNER_ID;
        public int PARTNER_ID
        {
            get { return (_PARTNER_ID); }
            set { if (_PARTNER_ID != value) { isModified = true; } _PARTNER_ID = value; }
        }

        //Dátum
        private DateTime _DATUM;
        public DateTime DATUM
        {
            get { return (_DATUM); }
            set { if (_DATUM != value) { isModified = true; }
                _DATUM = value; 
                }
        }

        //Szállítólevél száma
        private string _SZALLITOLEVEL_SZAM;
        public string SZALLITOLEVEL_SZAM
        {
            get { return (_SZALLITOLEVEL_SZAM); }
            set { if (_SZALLITOLEVEL_SZAM != value) { isModified = true; } _SZALLITOLEVEL_SZAM = value; }
        }

        //Bizonylatszám
        private string _BISZ_SZAM;
        public string BIZONYLATSZAM
        {
            get { return (_BISZ_SZAM); }
            set { if (_BISZ_SZAM != value) { isModified = true; } _BISZ_SZAM = value; }
        }

                //Bizonylatszám
        private int _KONYVELT;
        public bool KONYVELT
        {
            get { return (_KONYVELT == 1); }
            set { if (value) {_KONYVELT = 1;}
                else { _KONYVELT = 0; } }
        }

        #endregion

 

            public Bevetel_fej()
            {

                _BEVETEL_FEJ_ID = -1;
                isModified = false;

            }


            public Bevetel_fej(int pBevFej_id, SqlConnection c)
            {
                if (c.State == ConnectionState.Closed) { c.Open(); }
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = c;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT BEVETEL_FEJ_ID, DATUM, PARTNER_ID, SZALLITOLEVEL_SZAM, BIZONYLATSZAM, KONYVELT " +
                                " FROM BEVETEL_FEJ WHERE BEVETEL_FEJ_ID =" + pBevFej_id.ToString();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    _BEVETEL_FEJ_ID = (int)rdr["BEVETEL_FEJ_ID"];
                    if (rdr["DATUM"] != null) {_DATUM = (DateTime)rdr["DATUM"];}
                    else {_DATUM = DateTime.Now;}
                    if (rdr["PARTNER_ID"] != null) {_PARTNER_ID = (int)rdr["PARTNER_ID"];}
                    else {_PARTNER_ID = -1;}
                    
                    if (rdr["SZALLITOLEVEL_SZAM"] != null) {_SZALLITOLEVEL_SZAM = (string)rdr["SZALLITOLEVEL_SZAM"];}
                    else {_SZALLITOLEVEL_SZAM = "";}

                    if (rdr["BIZONYLATSZAM"] != null) { _BISZ_SZAM = (string)rdr["BIZONYLATSZAM"]; }
                    else { _BISZ_SZAM = ""; }

                    if (rdr["KONYVELT"] != null) { _KONYVELT = (int)rdr["KONYVELT"]; }
                    else { _KONYVELT = 0; }
                    

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



                switch (_BEVETEL_FEJ_ID)
                {
                    case -1:
                        {
                            //új rekord!!
                            cmd.CommandText = "INSERT INTO BEVETEL_FEJ " +
                               " (DATUM " +
                               " ,PARTNER_ID " +
                               " ,SZALLITOLEVEL_SZAM "+
                               " ,KONYVELT "+
                                " ,BIZONYLATSZAM) " +
                               " VALUES " +
                               " (@DATUM " +
                               " ,@PARTNER_ID " +
                               " ,@SZALLITOLEVEL_SZAM "+
                               " ,@KONYVELT "+
                               " ,@BIZONYLATSZAM)";

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

                cmd.Parameters["DATUM"].Value = _DATUM;
                cmd.Parameters["PARTNER_ID"].Value = _PARTNER_ID;
                cmd.Parameters["KONYVELT"].Value = _KONYVELT;
                cmd.Parameters["SZALLITOLEVEL_SZAM"].Value = _SZALLITOLEVEL_SZAM;
                cmd.Parameters["BIZONYLATSZAM"].Value = _BISZ_SZAM;

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

       
        //cikk
        private int _CIKK_ID;
        public int CIKK_ID
        {
            get { return (_CIKK_ID); }
            set { if (_CIKK_ID != value) { isModified = true; } _CIKK_ID = value; }
        }
        
        
        private float _MENNY;
        public float MENNY
        {
            get { return (_MENNY); }
            set { if (_MENNY != value) { isModified = true; } _MENNY = value; }
        }

        private float _BESZ_AR;
        public float BESZ_AR
        {
            get { return (_BESZ_AR); }
            set { if (_BESZ_AR != value) { isModified = true; } _BESZ_AR = value; }
        }


        private float _NETTO_ERTEK;
        public float NETTO_ERTEK
        {
            get { return (_NETTO_ERTEK); }
            set { if (_NETTO_ERTEK != value) { isModified = true; } _NETTO_ERTEK = value; }
        }

        private float _AFA_ERTEK;
        public float AFA_ERTEK
        {
            get { return (_AFA_ERTEK); }
            set { if (_AFA_ERTEK != value) { isModified = true; } _AFA_ERTEK = value; }
        }

        private float _BRUTTO_ERTEK;
        public float BRUTTO_ERTEK
        {
            get { return (_BRUTTO_ERTEK); }
            set { if (_BRUTTO_ERTEK != value) { isModified = true; } _BRUTTO_ERTEK = value; }
        }





        #endregion



        public BevetelSor()
        {

            _BEVETEL_SOR_ID = -1;
            isModified = false;

        }


        public BevetelSor(int pBevSor_id, SqlConnection c)
        {
            if (c.State == ConnectionState.Closed) { c.Open(); }
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SOR_ID, BEVETEL_FEJ_ID, CIKK_ID, MENNY, BESZ_AR, NETTO_ERTEK, AFA_ERTEK, BRUTTO_ERTEK " +
                            " FROM BEVETEL_SOR WHERE BEVETEL_SOR_ID =" + pBevSor_id.ToString();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                _BEVETEL_SOR_ID = (int)rdr["SOR_ID"];
                _BEVETEL_FEJ_ID = (int)rdr["BEVETEL_FEJ_ID"];
                _CIKK_ID = (int)rdr["CIKK_ID"];

                _MENNY = (float)rdr["MENNY"];
                _BESZ_AR = (float)rdr["BESZ_AR"];
                _NETTO_ERTEK = (float)rdr["NETTO_ERTEK"];
                _AFA_ERTEK = (float)rdr["AFA_ERTEK"];
                _BRUTTO_ERTEK = (float)rdr["BRUTTO_ERTEK"];
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



            switch (_BEVETEL_FEJ_ID)
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
                                               ",BRUTTO_ERTEK) " +
                                         "VALUES " +
                                               "(@BEVETEL_FEJ_ID " +
                                               ",@CIKK_ID " +
                                               ",@MENNY " +
                                               ",@BESZ_AR " +
                                               ",@NETTO_ERTEK " +
                                               ",@AFA_ERTEK " +
                                               ",@BRUTTO_ERTEK)";

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

            cmd.Parameters["BEVETEL_FEJ_ID"].Value = _BEVETEL_FEJ_ID;
            cmd.Parameters["CIKK_ID"].Value = _CIKK_ID;
            cmd.Parameters["MENNY"].Value = _MENNY;
            cmd.Parameters["BESZ_AR"].Value = _BESZ_AR;
            cmd.Parameters["NETTO_ERTEK"].Value = _NETTO_ERTEK;
            cmd.Parameters["AFA_ERTEK"].Value = _AFA_ERTEK;
            cmd.Parameters["BRUTTO_ERTEK"].Value = _BRUTTO_ERTEK;
            
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

}
