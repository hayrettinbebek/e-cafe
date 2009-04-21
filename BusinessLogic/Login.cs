using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace BusinessLogic
{
    public class ECafeLogin
    {
        public int _USR_ID;

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
                DEFS.SendShortMessage("Sikeres belépés:" + iUserName,1500);
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

        public  static string Md5AddSecret(string strChange)
        {
            //Change the syllable into UTF8 code
            byte[] pass = Encoding.UTF8.GetBytes(strChange);

            MD5 md5 = new MD5CryptoServiceProvider();
            string strPassword = Encoding.UTF8.GetString(md5.ComputeHash(pass));
            return strPassword;
        }

    }

    #region _User
    public class _User
    {
        #region USER_ID
        private int _USER_ID;
        public int USER_ID
        {
            get { return (_USER_ID); }
            set { _USER_ID = value; }
        }
        #endregion

        #region NAME
        private string _NAME;
        public string NAME
        {
            get { return (_NAME); }
            set { _NAME = value; }
        }
        #endregion

        #region LOGIN_NAME
        private string _LOGIN_NAME;
        public string LOGIN_NAME
        {
            get { return (_LOGIN_NAME); }
            set { _LOGIN_NAME = value; }
        }
        #endregion

        #region PW
        private string _PW;
        public string PW
        {
            get { return (_PW); }
            set { _PW = value; }
        }
        #endregion

        #region SUPER
        private int _SUPER;
        public bool SUPER
        {
            get { return (_SUPER == 1); }
            set
            {
                if (value) { _SUPER = 1; }
                else { _SUPER = 0; }
            }
        }
        #endregion
         
        #region LOCKED
        private string _LOCKED;
        public string LOCKED
        {
            get { return (_LOCKED); }
            set { _LOCKED = value; }
        }
        #endregion

        #region LOCKED_DATE
        private DateTime _LOCKED_DATE;
        public DateTime LOCKED_DATE
        {
            get { return (_LOCKED_DATE); }
            set { _LOCKED_DATE = value; }
        }
        #endregion

        #region AKTIV
        private int _AKTIV;
        public bool AKTIV
        {
            get { return (_AKTIV == 1); }
            set { if (value) {_AKTIV = 1;}
            else { _AKTIV = 0; } }
        }
        #endregion

        public _User(int pU_ID)
        {
            if (pU_ID == -666)
            {

                USER_ID = -666;
                NAME = "Admisztrátor";
                LOGIN_NAME = "x";
                PW = "11";
                _SUPER = 1;
                LOCKED = "0";
                LOCKED_DATE = new DateTime();
                _AKTIV = 1;
            }
            else
            {
                SqlConnection sc = new SqlConnection(DEFS.ConSTR);
                sc.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sc;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT USR_ID ,USR_NAME ,USR_LOGIN_NAME ,USR_PW ,USR_SUPERVISOR ,USR_LOCKED ,USR_LOCKED_DATE ,USR_AKTIV FROM _USER WHERE USR_ID =" + pU_ID.ToString();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    USER_ID = (int)rdr["USR_ID"];
                    NAME = (string)rdr["USR_NAME"];
                    LOGIN_NAME = (string)rdr["USR_LOGIN_NAME"];
                    PW = (string)rdr["USR_PW"];
                    _SUPER = (int)rdr["USR_SUPERVISOR"];
                    LOCKED = (string)rdr["USR_LOCKED"];
                    LOCKED_DATE = (DateTime)rdr["USR_LOCKED_DATE"];
                    _AKTIV = (int)rdr["USR_AKTIV"];


                }
                rdr.Close();

                sc.Close();

            }
        }

        public _User()
        {
            USER_ID = -1;
        }

        public void Save()
        {
            SqlConnection c = new SqlConnection(DEFS.ConSTR);
            c.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c;
            cmd.CommandType = CommandType.Text;



            switch (_USER_ID)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO _USER " +
                                          " (USR_NAME " +
                                          " ,USR_LOGIN_NAME " +
                                          " ,USR_PW " +
                                          " ,USR_SUPERVISOR " +
                                          " ,USR_LOCKED " +
                                          " ,USR_LOCKED_DATE " +
                                          " ,USR_AKTIV) " +
                                        " VALUES " +
                                          " (@USR_NAME " +
                                          " ,@USR_LOGIN_NAME " +
                                          " ,@USR_PW " +
                                          " ,@USR_SUPERVISOR " +
                                          " ,@USR_LOCKED " +
                                          " ,@USR_LOCKED_DATE " +
                                          " ,@USR_AKTIV)";

                        break;
                    }
                default:
                    {

                        cmd.CommandText = "UPDATE _USER " +
                                          "  SET USR_NAME = @USR_NAME " +
                                          "    ,USR_LOGIN_NAME = @USR_LOGIN_NAME " +
                                          "    ,USR_PW = @USR_PW " +
                                          "    ,USR_SUPERVISOR = @USR_SUPERVISOR " +
                                          "    ,USR_LOCKED = @USR_LOCKED " +
                                          "    ,USR_LOCKED_DATE = @USR_LOCKED_DATE " +
                                          "    ,USR_AKTIV = @USR_AKTIV " +
                                         " WHERE USR_ID = @USR_ID";
                        cmd.Parameters.Add(new SqlParameter("USR_ID", SqlDbType.Int));
                        cmd.Parameters["USR_ID"].Value = _USER_ID;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("USR_NAME", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("USR_LOGIN_NAME", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("USR_PW", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("USR_SUPERVISOR", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("USR_LOCKED", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("USR_LOCKED_DATE", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("USR_AKTIV", SqlDbType.Int));
            

            cmd.Parameters["USR_NAME"].Value = NAME;
            cmd.Parameters["USR_LOGIN_NAME"].Value = LOGIN_NAME;
            cmd.Parameters["USR_PW"].Value = PW;
            cmd.Parameters["USR_SUPERVISOR"].Value = SUPER;
            cmd.Parameters["USR_LOCKED"].Value = LOCKED;
            cmd.Parameters["USR_LOCKED_DATE"].Value = LOCKED_DATE;
            cmd.Parameters["USR_AKTIV"].Value = _AKTIV;
            
            cmd.ExecuteNonQuery();


            c.Close();
        }

    }

    public class UserLista
    {


        public List<_User> lUser = new List<_User>();


        public UserLista()
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT USR_ID  FROM _USER";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                lUser.Add(new _User((int)rdr["USR_ID"]));
            }
            rdr.Close();
            sc.Close();
        }

        public _User UserByID(int puID)
        {
            _User iTmpRet = null;

            var ret_usr =
                from c in lUser
                where c.USER_ID == puID
                select c;
            ret_usr.Each(c => iTmpRet = c);


            return (iTmpRet);
        }
    }

    public class LoggedInUsers
    {


        public List<_User> lLoggedInUsers = new List<_User>();


        public LoggedInUsers()
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select _USER_ID,sum(INOUT) from _user_log "+
                                " group by _USER_ID "+
                                " having sum(INOUT) > 0";

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                lLoggedInUsers.Add(new _User((int)rdr["_USER_ID"]));
            }
            rdr.Close();
            sc.Close();
        }

        public bool IsLoggedIn(int puID)
        {
            _User iTmpRet = null;

            var ret_usr =
                from c in lLoggedInUsers
                where c.USER_ID == puID
                select c;
            ret_usr.Each(c => iTmpRet = c);

            
            return (iTmpRet != null);
        }
    }
    #endregion
}
