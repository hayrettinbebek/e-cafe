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
    public partial class frmNegkeszletInfo : Form
    {
        Cikk_list cl = new Cikk_list(CikkListContructType.FullCikk);

        public frmNegkeszletInfo()
        {
            InitializeComponent();
            cikkBindingSource.Clear();
            foreach (var c in cl.CikkListByNegKeszlet())
            {
                cikkBindingSource.Add(c);
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
