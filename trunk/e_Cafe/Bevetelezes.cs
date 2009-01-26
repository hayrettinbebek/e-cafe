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
    public partial class Bevetelezes : Form
    {
        public Bevetelezes()
        {
            InitializeComponent();
        }

        private void bevetelfejBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Bevetel_fej();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (var k in bevetelfejBindingSource.List)
            {
                if (((Bevetel_fej)k).isModified) { ((Bevetel_fej)k).Save(); }
            }

            loadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bevetelfejBindingSource.AddNew();
        }

        private void loadData()
        {
            BevetelFList l = new BevetelFList(new SqlConnection(DEFS.ConSTR));
            bevetelfejBindingSource.Clear();

            foreach (var c in l.lBevFej)
            {
                bevetelfejBindingSource.Add(c);
            }

        }

        private void Bevetelezes_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
