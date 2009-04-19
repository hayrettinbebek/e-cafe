using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe.Torzsek
{
    public partial class frmHelyek : Form
    {
        public frmHelyek()
        {
            InitializeComponent();
        }

        private void frmHelyek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetHELY.HELY' table. You can move, or remove it, as needed.
            refreshPage();

        }
        private void refreshPage()
        {
            if (chkInaktivak.Checked)
            {
                this.hELYTableAdapter.Fill(this.eCAFEDataSetHELY.HELY);
            }
            else
            {
                this.hELYTableAdapter.FillOnlyValid(this.eCAFEDataSetHELY.HELY);
            }
            //btnAktiv.Visible = chkInaktivak.Checked;
        }

        private void frmHelyek_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                hELYTableAdapter.Update(eCAFEDataSetHELY);
            }
            catch (Exception c)
            {
                EmailSending x = new EmailSending();
                x.send_mail(c);
            }
        }

 

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            hELYTableAdapter.Update(eCAFEDataSetHELY);
        }

       

        private void chkInaktivak_CheckedChanged(object sender, EventArgs e)
        {
            refreshPage();

        }
    }
}
