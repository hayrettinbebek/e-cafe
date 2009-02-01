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

namespace e_Cafe.Torzsek
{
    public partial class frmSzallito : Form
    {
        public frmSzallito()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            Partner_list szall = new Partner_list(new SqlConnection(DEFS.ConSTR));
            szallitoBindingSource.Clear();

            foreach (var c in szall.lSzallitok)
            {
                szallitoBindingSource.Add(c);
            }



        }


        private void loadSzallData(Szallito sz)
        {

            partnercimBindingSource.Clear();

            foreach (var cm in sz.lCimek)
            {
                partnercimBindingSource.Add(cm);
            }

            partnertelBindingSource.Clear();

            foreach (var tl in sz.lTelefon)
            {
                partnertelBindingSource.Add(tl);
            }

        }

        private void szallitoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (szallitoBindingSource.Current != null)
            {
                loadSzallData((Szallito)szallitoBindingSource.Current);
            }
        }

        private void partnertelBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Partner_tel(((Szallito)szallitoBindingSource.Current).PARTNER_ID);
        }

        private void partnercimBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Partner_cim(((Szallito)szallitoBindingSource.Current).PARTNER_ID);
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            szallitoBindingSource.AddNew();
        }

        private void szallitoBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Szallito();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            foreach (var k in szallitoBindingSource.List)
            {
                ((Szallito)k).Save();
            }

            foreach (var k in partnertelBindingSource.List)
            {
                ((Partner_tel)k).Save();
            }

            foreach (var k in partnercimBindingSource.List)
            {
                ((Partner_cim)k).Save();
            }
            foreach (var k in partnerbszBindingSource.List)
            {
                ((Partner_bsz)k).Save();
            }
        }

        private void partnerbszBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Partner_bsz(((Szallito)szallitoBindingSource.Current).PARTNER_ID);
        }
    }
}
