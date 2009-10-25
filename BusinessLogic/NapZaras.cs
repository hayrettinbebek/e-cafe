using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class NapZaras
    {
        private bool Tiltott = false;

        public NapZaras()
        {

        }

        public bool VaneNyitotNap()
        {
            Tiltott = true;
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select count(*) as NAPOK from NAP_NYITAS where LEZART = 0";
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((int)rdr["NAPOK"] > 0)
                {
                    Tiltott = false;
                }
                else
                {
                    Tiltott = true;
                }
            }

            return (!Tiltott);

        }

        public void CloseDay()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = c;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE NAP_NYITAS SET LEZART = 1, ZARAS_DATUMA = getdate() where LEZART = 0";
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }
    }
}
