using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using NSpring.Logging;



namespace BusinessLogic
{
    public class Uzenet
    {
        
        private int _uID;
        public int UZENET_ID
        {
            get { return (_uID); }
            set { _uID = value; }
        }

        private DateTime _mikor;
        public DateTime MIKOR
        {
            get { return (_mikor); }
            set { _mikor = value; }
        }

        private int _felado;
        public int FELADO
        {
            get { return (_felado); }
            set { _felado = value; }
        }

        private string _szoveg;
        public string SZOVEG
        {
            get { return (_szoveg); }
            set { _szoveg = value; }
        }

        private int _olvasva;
        public int OLVASVA
        {
            get { return (_olvasva); }
            set { _olvasva = value; }
        }

        private int _pos_x;
        public int POS_X
        {
            get { return (_pos_x); }
            set { _pos_x = value; }
        }

        private int _pos_y;
        public int POS_Y
        {
            get { return (_pos_y); }
            set { _pos_y = value; }
        }

        public Uzenet(int _id, DateTime _m, int _felad, string _szov, int _olv, int _x, int _Y)
        {
            _uID = _id;
            _mikor = _m;
            _felado = _felad;
            _szoveg = _szov;
            _olvasva = _olv;
            _pos_x = _x;
            _pos_y = _Y;

        }
        public Uzenet( DateTime _m, int _felad, string _szov, int _olv, int _x, int _Y)
        {
            _uID = -1;
            _mikor = _m;
            _felado = _felad;
            _szoveg = _szov;
            _olvasva = _olv;
            _pos_x = _x;
            _pos_y = _Y;

        }


        public void SaveUzenet()
        {
            SqlConnection sc = new SqlConnection(DEFS.ConSTR);
            sc.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;

            switch (_uID)
            {
                case -1:
                    {
                        //új rekord!!
                        cmd.CommandText = "INSERT INTO _UZENETEK " +
                                            "(MIKOR " +
                                            ",FELADO " +
                                            ",SZOVEG " +
                                            ",OLVASVA " +
                                            ",POS_X " +
                                            ",POS_Y) " +
                                        "VALUES " +
                                            "(@MIKOR  " +
                                            ",@FELADO  " +
                                            ",@SZOVEG " +
                                            ",@OLVASVA " +
                                            ",@POS_X " +
                                            ",@POS_Y) ";

                        break;
                    }
                default:
                    {
                        cmd.CommandText = "UPDATE _UZENETEK SET MIKOR = @MIKOR, " +
                                                       " FELADO = @FELADO, " +
                                                       " SZOVEG = @SZOVEG, " +
                                                       " OLVASVA = @OLVASVA, " +
                                                       " POS_X = @POS_X, " +
                                                       " POS_Y = @POS_Y " +
                                           "WHERE UZENET_ID = @UZENET_ID";
                        cmd.Parameters.Add(new SqlParameter("UZENET_ID", SqlDbType.Int));
                        cmd.Parameters["UZENET_ID"].Value = _uID;
                        break;
                    }
            }

            cmd.Parameters.Add(new SqlParameter("MIKOR", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("FELADO", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("SZOVEG", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("OLVASVA", SqlDbType.Int));

            cmd.Parameters.Add(new SqlParameter("POS_X", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("POS_Y", SqlDbType.Int));


            cmd.Parameters["MIKOR"].Value = _mikor;
            cmd.Parameters["FELADO"].Value = _felado;
            cmd.Parameters["SZOVEG"].Value = _szoveg;
            cmd.Parameters["OLVASVA"].Value = _olvasva;

            cmd.Parameters["POS_X"].Value = _pos_x;
            cmd.Parameters["POS_Y"].Value = _pos_y;


            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "";
            if (_uID == -1)
            {
                
            }

            
            sc.Close();
        }

    }


    public class Uzenet_list
    {


        public List<Uzenet> lUzenet = new List<Uzenet>();


        public Uzenet_list(SqlConnection sc)
        {

            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sc;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT UZENET_ID, MIKOR, FELADO, SZOVEG, isnull(OLVASVA,0) as OLVASVA, POS_X, POS_Y FROM _UZENETEK";
            DEFS.log(Level.Debug, "Get üzenetek:");
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Uzenet t = new Uzenet((DateTime)rdr["MIKOR"],
                                  (int)rdr["FELADO"],
                                  (string)rdr["SZOVEG"],
                                  (int)rdr["OLVASVA"],
                                  (int)rdr["POS_X"],
                                  (int)rdr["POS_Y"]);

                lUzenet.Add(t);
                DEFS.log(Level.Debug, rdr["MEGYS_ID"] + "-->" + rdr["MEGYS_MEGNEVEZES"]);

            }
            rdr.Close();
            sc.Close();
        }

    }

}
