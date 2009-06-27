using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public abstract class ReportData
    {

        public static DataView GetOsszesEladas(int pEV, int pHO, int pNAP)
        {
            #region select
            String SQL_COMMAND = "select isnull(sum(ELADAS_DB),0) as ELADAS_DB, " +
                                " isnull(sum(ELADAS),0) as ELADAS, " +
                                " isnull(sum(HITEL_DB),0) as HITEL_DB, " +
                                " isnull(sum(HITEL),0) as HITEL, " +
                                " isnull(sum(HITEL_FIZETVE_DB),0) as HITEL_FIZETVE_DB, " +
                                " isnull(sum(HITEL_FIZETVE),0) as HITEL_FIZETVE, " +
                                " isnull(sum(STORNO_DB),0) as STORNO_DB,    " +
                                " isnull(sum(STORNO),0) as STORNO from ( " +
                                " SELECT c.CIKKCSOPORT_ID, c.MEGNEVEZES, c.SPEC_ZARAS, " +
                                " (select count(*)  from szamla_fej sf " +
                                " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                                " 	where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod <> 9 ) as ELADAS_DB, " +
                                " (select sum(st.BRUTTO)  from szamla_fej sf " +
                                " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                                " where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod <> 9 ) as ELADAS, " +
                                " (SELECT count(*) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP  " +
                                " and hs.FIZETVE = 0  " +
                                " ) as HITEL_DB, " +
                                " (SELECT sum(ERTEK) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP " +
                                " and hs.FIZETVE = 0  " +
                                " ) as HITEL, " +
                                " (SELECT count(*) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP  " +
                                " and hs.FIZETVE = 1  " +
                                " ) as HITEL_FIZETVE_DB, " +
                                " (SELECT sum(ERTEK) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP " +
                                " and hs.FIZETVE = 1 " +
                                " ) as HITEL_FIZETVE, " +
                                " (select count(*)  from szamla_fej sf    " +
                                "   inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id     " +
                                "   	where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod = 9 " +
                                " ) as STORNO_DB,     " +
                                "   (select sum(ABS(st.BRUTTO))/2  from szamla_fej sf     " +
                                "   inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id     " +
                                "   where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod = 9 " +
                                " ) as STORNO " +
                                " FROM CIKK c " +
                                " inner join keszlet_fej f on c.cikk_id = f.cikk_id " +
                                " WHERE f.EV = " + pEV.ToString() + " and f.HO = " + pHO.ToString() + " and f.NAP = " + pNAP.ToString() + " " +
                                " ) as S ";
            #endregion
            DataTable dt = new DataTable("OSSZES");
            dt.Columns.Add("Típus", typeof(string));
            dt.Columns.Add("Összes eladás db", typeof(int));
            dt.Columns.Add("Összes eladás értéke", typeof(double));

            //dt.Columns.Add("Hitelre írt db", typeof(int));
            //dt.Columns.Add("HItelre írás értéke", typeof(double));
            //dt.Columns.Add("Kifizetett hitel db", typeof(int));
            //dt.Columns.Add("Kifizetett hitelek értéke", typeof(double));

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = SQL_COMMAND;
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dt.Rows.Add(
                    new Object[] {  "Eladás:",
                                    (int)rdr["ELADAS_DB"], 
                                    Math.Round((double)rdr["ELADAS"])}
                    );
                dt.Rows.Add(
                    new Object[] {  "Hitelre írás:",
                                    (int)rdr["HITEL_DB"],
                                    Math.Round((double)rdr["HITEL"])}
                    );
                dt.Rows.Add(
                    new Object[] {  "Kifizetett hitel:",
                                    (int)rdr["HITEL_FIZETVE_DB"],
                                    Math.Round((double)rdr["HITEL_FIZETVE"])}
                    );
                dt.Rows.Add(
                    new Object[] {  "",
                                    "Stronózott:",
                                    (int)rdr["STORNO_DB"],
                                    Math.Round((double)rdr["STORNO"])}
                    );
            }

            DataView dv = dt.DefaultView;

            return (dv);
        }

        public static DataView GetCikkcsopOsszesEladas(int pEV, int pHO, int pNAP)
        {
            #region select
            String SQL_COMMAND = "select CIKKCSOPORT_NEV, sum(isnull(ELADAS_DB,0)) as ELADAS_DB, " +
                                " sum(isnull(ELADAS,0)) as ELADAS, " +
                                " sum(isnull(HITEL_DB,0)) as HITEL_DB, " +
                                " sum(isnull(HITEL,0)) as HITEL, " +
                                " sum(isnull(HITEL_FIZETVE_DB,0)) as HITEL_FIZETVE_DB, " +
                                " sum(isnull(HITEL_FIZETVE,0)) as HITEL_FIZETVE, " +
                                " isnull(sum(STORNO_DB),0) as STORNO_DB,    " +
                                " isnull(sum(STORNO),0) as STORNO  from ( " +
                                " SELECT cs.CIKKCSOPORT_NEV, " +
                                " (select count(*)  from szamla_fej sf " +
                                " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                                " 	where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id  and sf.fizetesi_mod <> 9 ) as ELADAS_DB, " +
                                " (select sum(st.BRUTTO)  from szamla_fej sf " +
                                " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                                " where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id  and sf.fizetesi_mod <> 9 ) as ELADAS, " +
                                " (SELECT count(*) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP  " +
                                " and hs.FIZETVE = 0  " +
                                " ) as HITEL_DB, " +
                                " (SELECT sum(ERTEK) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP " +
                                " and hs.FIZETVE = 0  " +
                                " ) as HITEL, " +
                                " (SELECT count(*) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP  " +
                                " and hs.FIZETVE = 1  " +
                                " ) as HITEL_FIZETVE_DB, " +
                                " (SELECT sum(ERTEK) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP " +
                                " and hs.FIZETVE = 1 " +
                                " ) as HITEL_FIZETVE, " +
                                " (select count(*)  from szamla_fej sf    " +
                                "   inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id     " +
                                "   	where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod = 9 " +
                                " ) as STORNO_DB,     " +
                                "   (select sum(ABS(st.BRUTTO))/2  from szamla_fej sf     " +
                                "   inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id     " +
                                "   where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod = 9 " +
                                " ) as STORNO " +
                                " FROM CIKK c " +
                                " inner join keszlet_fej f on c.cikk_id = f.cikk_id " +
                                " inner join cikkcsoport cs on c.cikkcsoport_id = cs.cikkcsoport_id " +
                                " WHERE f.EV = " + pEV.ToString() + " and f.HO = " + pHO.ToString() + " and f.NAP = " + pNAP.ToString() + " " +
                                " ) as S group by CIKKCSOPORT_NEV";
            #endregion
            DataTable dt = new DataTable("OSSZES");

            dt.Columns.Add("Cikkcsoport", typeof(String));
            dt.Columns.Add("Típus", typeof(String));
            dt.Columns.Add("Összes eladás db", typeof(int));
            dt.Columns.Add("Összes eladás értéke", typeof(double));

            //dt.Columns.Add("Hitelre írt db", typeof(int));
            //dt.Columns.Add("HItelre írás értéke", typeof(double));

            //dt.Columns.Add("Kifizetett hitel db", typeof(int));
            //dt.Columns.Add("Kifizetett hitelek értéke", typeof(double));

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = SQL_COMMAND;
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dt.Rows.Add(
                    new Object[] {  (string)rdr["CIKKCSOPORT_NEV"],
                                    "Eladás:",
                                    (int)rdr["ELADAS_DB"], 
                                    Math.Round((double)rdr["ELADAS"])}
                    );
                dt.Rows.Add(
                    new Object[] {  "",
                                    "Hitel:",
                                    (int)rdr["HITEL_DB"],
                                    Math.Round((double)rdr["HITEL"])}
                    );
                dt.Rows.Add(
                    new Object[] {  "",
                                    "Hitel fizetve:",
                                    (int)rdr["HITEL_FIZETVE_DB"],
                                    Math.Round((double)rdr["HITEL_FIZETVE"])}
                    );
                dt.Rows.Add(
                    new Object[] {  "",
                                    "Stronózott:",
                                    (int)rdr["STORNO_DB"],
                                    Math.Round((double)rdr["STORNO"])}
                    );
            }

            DataView dv = dt.DefaultView;

            return (dv);
        }

        public static DataView GetSpecZarasEladas(int pEV, int pHO, int pNAP)
        {
            #region select
            String SQL_COMMAND = "select CIKKCSOPORT_NEV, sum(isnull(ELADAS_DB,0)) as ELADAS_DB, " +
                                " sum(isnull(ELADAS,0)) as ELADAS, " +
                                " sum(isnull(HITEL_DB,0)) as HITEL_DB, " +
                                " sum(isnull(HITEL,0)) as HITEL, " +
                                " sum(isnull(HITEL_FIZETVE_DB,0)) as HITEL_FIZETVE_DB, " +
                                " sum(isnull(HITEL_FIZETVE,0)) as HITEL_FIZETVE, " +
                                " isnull(sum(STORNO_DB),0) as STORNO_DB,    " +
                                " isnull(sum(STORNO),0) as STORNO from ( " +
                                " SELECT cs.CIKKCSOPORT_NEV, " +
                                " (select count(*)  from szamla_fej sf " +
                                " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                                " 	where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod <> 9 ) as ELADAS_DB, " +
                                " (select sum(st.BRUTTO)  from szamla_fej sf " +
                                " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                                " where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod <> 9 ) as ELADAS, " +
                                " (SELECT count(*) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP  " +
                                " and hs.FIZETVE = 0  " +
                                " ) as HITEL_DB, " +
                                " (SELECT sum(ERTEK) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP " +
                                " and hs.FIZETVE = 0  " +
                                " ) as HITEL, " +
                                " (SELECT count(*) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP  " +
                                " and hs.FIZETVE = 1  " +
                                " ) as HITEL_FIZETVE_DB, " +
                                " (SELECT sum(ERTEK) from RENDELES_SOR rs  " +
                                " inner join HITEL_SOR hs on rs.sor_id = hs.rendeles_sor_id " +
                                " inner join RENDELES_FEJ rf on rs.RENDELES_ID = rf.RENDELES_ID " +
                                " where rs.cikk_id = c.cikk_id and rf.EV = f.EV and rf.HO = f.HO and rf.NAP = f.NAP " +
                                " and hs.FIZETVE = 1 " +
                                " ) as HITEL_FIZETVE, " +
                                " (select count(*)  from szamla_fej sf    " +
                                "   inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id     " +
                                "   	where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod = 9 " +
                                " ) as STORNO_DB,     " +
                                "   (select sum(ABS(st.BRUTTO))/2  from szamla_fej sf     " +
                                "   inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id     " +
                                "   where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id and sf.fizetesi_mod = 9 " +
                                " ) as STORNO " +
                                " FROM CIKK c " +
                                " inner join keszlet_fej f on c.cikk_id = f.cikk_id " +
                                " inner join cikkcsoport cs on c.cikkcsoport_id = cs.cikkcsoport_id " +
                                " WHERE c.SPEC_ZARAS = 1 and f.EV = " + pEV.ToString() + " and f.HO = " + pHO.ToString() + " and f.NAP = " + pNAP.ToString() + " " +
                                " ) as S group by CIKKCSOPORT_NEV";
            #endregion
            DataTable dt = new DataTable("OSSZES");
            dt.Columns.Add("Cikkcsoport", typeof(String));
            dt.Columns.Add("Összes eladás db", typeof(int));
            dt.Columns.Add("Összes eladás értéke", typeof(double));
            dt.Columns.Add("Hitelre írt db", typeof(int));
            dt.Columns.Add("HItelre írás értéke", typeof(double));
            dt.Columns.Add("Kifizetett hitel db", typeof(int));
            dt.Columns.Add("Kifizetett hitelek értéke", typeof(double));

            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = SQL_COMMAND;
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dt.Rows.Add(
                    new Object[] {  (string)rdr["CIKKCSOPORT_NEV"],
                                    (int)rdr["ELADAS_DB"], 
                                    Math.Round((double)rdr["ELADAS"]),
                                    (int)rdr["HITEL_DB"],
                                    Math.Round((double)rdr["HITEL"]),
                                    (int)rdr["HITEL_FIZETVE_DB"],
                                    Math.Round((double)rdr["HITEL_FIZETVE"])}
                    );
            }

            DataView dv = dt.DefaultView;

            return (dv);
        }


        public static DataView getLeltarIv(int _fej)
        {
            TemporaryLeltarSorok.FillSorok(_fej);

            DataTable dt = new DataTable("CIKK_LELTAR");
            
            dt.Columns.Add("Cikk", typeof(String));
            dt.Columns.Add("Készlet mennyisége", typeof(double));
            dt.Columns.Add("Számolt érték", typeof(String));
            //dt.Columns.Add("Hitelre írt db", typeof(int));
            //dt.Columns.Add("HItelre írás értéke", typeof(double));
            //dt.Columns.Add("Kifizetett hitel db", typeof(int));
            //dt.Columns.Add("Kifizetett hitelek értéke", typeof(double));


            foreach (var cc in TemporaryLeltarSorok.LeltarSorok)
            {
                
                dt.Rows.Add(
                    new Object[] {  ((LeltarSor)cc).P_CIKK_NEV,
                                    ((LeltarSor)cc).AKT_KESZLET_MENNY, 
                                    "________________________"
                                    }
                    );
            }

            DataView dv = dt.DefaultView;

            return (dv);

        }
    }
}
