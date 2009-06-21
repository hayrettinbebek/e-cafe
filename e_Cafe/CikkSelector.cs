using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


using BusinessLogic;

namespace e_Cafe
{
    public partial class CikkSelector : Form
    {
        public  int CIKK_ID;
        public  int DEF_RAKT;
        public  double AFA_SZAZ;
        public  string CIKK_NEV;
        public Cikk c;
        


        private Cikk_list l;

        public CikkSelector()
        {
            InitializeComponent();
            l = new Cikk_list(CikkListContructType.CikkselectorKeszlet);
            cikkBindingSource.Clear();

            foreach (var c in l.CikkFilter(""))
            {
                cikkBindingSource.Add(c);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectCikk();
        }

        public static Cikk SelectCikk(int _cikkId)
        {
            return (new Cikk(_cikkId, true));
            
        }

        private void SelectCikk()
        {
            if (cikkBindingSource.Current != null)
            {
                DEF_RAKT = ((Cikk)cikkBindingSource.Current).ALAP_RAKTAR;
                CIKK_ID = ((Cikk)cikkBindingSource.Current).CIKK_ID;
                CIKK_NEV = ((Cikk)cikkBindingSource.Current).MEGNEVEZES;
                AFA_SZAZ = ((Cikk)cikkBindingSource.Current).getAfaSzaz();
                c = ((Cikk)cikkBindingSource.Current);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter();

        }
        private void Filter()
        {
            cikkBindingSource.Clear();

            foreach (var c in l.CikkFilter(textBox1.Text))
            {
                if (chkNegKeszl.Checked)
                {
                    if (c.fKESZLET_ALL < 0)
                    {
                        cikkBindingSource.Add(c);
                    }
                }
                else
                {
                    cikkBindingSource.Add(c);
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectCikk();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }


    }
}
