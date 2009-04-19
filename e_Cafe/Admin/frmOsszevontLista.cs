using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Admin
{
    public partial class frmOsszevontLista : Form
    {
        public frmOsszevontLista()
        {
            InitializeComponent();
        }

        private void frmOsszevontLista_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand("select CIKKCSOPORT_ID, MEGNEVEZES, SPEC_ZARAS, " +
                    " sum(ELADAS_DB) as ELADAS_DB," +
                    " sum(ELADAS) as ELADAS, " +
                    " sum(HITEL_DB) as HITEL_DB,  " +
                    " sum(HITEL) as HITEL, " +
                    " sum(HITEL_FIZETVE_DB) as HITEL_FIZETVE_DB, " +
                    " sum(HITEL_FIZETVE) as HITEL_FIZETVE from ( " +
                    " SELECT c.CIKKCSOPORT_ID, c.MEGNEVEZES, c.SPEC_ZARAS, " +
                    " (select count(*)  from szamla_fej sf " +
                        " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                        " where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id) as ELADAS_DB, " +
                    " (select sum(st.BRUTTO)  from szamla_fej sf " +
                        " inner join szamla_tetel st on sf.szamla_fej_id = st.szamla_fej_id " +
                        " where sf.EV = f.EV and sf.HO = f.HO and sf.NAP = f.NAP and st.cikk_id = c.cikk_id) as ELADAS, " +
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
                    " ) as HITEL_FIZETVE " +
                    " FROM CIKK c " +
                    " inner join keszlet_fej f on c.cikk_id = f.cikk_id " +
                    " ) as S " +
                    " group by CIKKCSOPORT_ID, MEGNEVEZES, SPEC_ZARAS ", c);

            



        }
    }
}
