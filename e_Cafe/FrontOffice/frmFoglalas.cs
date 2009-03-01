using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.FrontOffice
{
    public partial class frmFoglalas : Form
    {
        public Asztal aFoglal;

        public frmFoglalas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFoglalas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFOGLALAS.FOGLALAS' table. You can move, or remove it, as needed.
            this.fOGLALASTableAdapter.Fill(this.dsFOGLALAS.FOGLALAS,aFoglal.fASZTAL_ID);
            lblAsztal.Text = aFoglal.fASZTAL_SZAM + " " + "\n" + "ASZTAL";

            

        }

        private void txtTolM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTolM_Click(object sender, EventArgs e)
        {
            ctMinSelector.Show(txtTolM, new Point(10, 10));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ctMinSelector.SourceControl.Text = "00";
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ctMinSelector.SourceControl.Text = "15";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ctMinSelector.SourceControl.Text = "30";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ctMinSelector.SourceControl.Text = "45";
        }

        private void txtIgM_Click(object sender, EventArgs e)
        {
            ctMinSelector.Show(txtIgM, new Point(10, 10));
        }

        private void txtKeyb_Enter(object sender, EventArgs e)
        {
            keyb21.txtRet.Text = ((TextBox)sender).Text;
            keyb21.OutTxtBox = (TextBox)sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (txtTolH.Text == "") { ok = false; }
            if (txtTolM.Text == "") { ok = false; }
            if (txtIgH.Text == "") { ok = false; }
            if (txtIgM.Text == "") { ok = false; }
            if (txtMegj.Text == "") { ok = false; }
            if (txtNev.Text == "") { ok = false; }
            if (txtTel.Text == "") { ok = false; }


            if (ok)
            {
                fOGLALASTableAdapter.Insert(aFoglal.fASZTAL_ID,
                                            new DateTime(mcDatum.SelectionStart.Year, mcDatum.SelectionStart.Month, mcDatum.SelectionStart.Day, Convert.ToInt16(txtTolH.Text), Convert.ToInt16(txtTolM.Text), 0),
                                            new DateTime(mcDatum.SelectionStart.Year, mcDatum.SelectionStart.Month, mcDatum.SelectionStart.Day, Convert.ToInt16(txtIgH.Text), Convert.ToInt16(txtIgM.Text), 0),
                                            -1,
                                            txtMegj.Text, txtNev.Text, txtTel.Text);
            }
            else
            {
                DEFS.SendInfoMessage("Hiányosan kitöltött foglalás!");

            }
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.IndexOf(clDelete))
            {
                fOGLALASTableAdapter.Delete((int)((DataRowView)fOGLALASBindingSource.Current)["FOGLALAS_ID"]);
                this.fOGLALASTableAdapter.Fill(this.dsFOGLALAS.FOGLALAS, aFoglal.fASZTAL_ID);


            }
        }

        private void frmFoglalas_LocationChanged(object sender, EventArgs e)
        {

        }

        private void toolStripHour_Click(object sender, EventArgs e)
        {
            cmHourSelector.SourceControl.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void txtTolH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTolH_Click(object sender, EventArgs e)
        {
            cmHourSelector.Show(txtTolH, new Point(10, 10));
        }

        private void txtIgH_Click(object sender, EventArgs e)
        {
            cmHourSelector.Show(txtIgH, new Point(10, 10));
        }


    }
}
