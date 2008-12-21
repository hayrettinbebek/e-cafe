using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe
{
    public partial class Cikkek : Form
    {

        private SqlConnection sc;
        private Cikk iCikk;



        public Cikkek()
        {
            InitializeComponent();
            sc = MMenu.blObj.sqlConnection;
        }

        private void Cikkek_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            //cmd.Connection = sc;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT *  FROM CIKK ";
            //SqlDataReader rdr = cmd.ExecuteReader();
            
            DataSet cikklista = GetData("SELECT *  FROM CIKK ");

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cikklista.Tables["CIKKEK"];
            bvCIKK.BindingSource = bindingSource;
            dataGridView1.DataSource = bindingSource;



        }

        DataSet GetData(String queryString)
        {

            // Retrieve the connection string stored in the Web.config file.
            
            DataSet ds = new DataSet();

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sc);
                // ide kell betenni az esetleges update/insert scriptjeit.
                // Fill the DataSet.
                adapter.Fill(ds, "CIKKEK");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               

            }
            
            return ds;

        }








    }
}
