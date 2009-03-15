using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;


using BusinessLogic;

namespace e_Cafe.FrontOffice
{
    public partial class frmReporting : Form
    {
        public int Szla_id;
       

        public frmReporting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRepSzamla.SZAMLA_FEJ' table. You can move, or remove it, as needed.
            this.sZAMLA_FEJTableAdapter.Fill(this.dsRepSzamla.SZAMLA_FEJ);
            
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ConnectionInfo ci = new Conn
            Blokk1.FileName = DEFS.DefProgramLocation + @"\Reports\Blokk.rpt";
            bLOKK_TETELTableAdapter.Fill(dsRepSzamla.BLOKK_TETEL, Szla_id);
            sZAMLA_FEJTableAdapter.Fill(dsRepSzamla.SZAMLA_FEJ);

            Blokk1.SetDataSource(dsRepSzamla);
            Blokk1.SetParameterValue("@szla_id", Szla_id);
            crystalReportViewer1.ReportSource = Blokk1;
            
            //oRpt.PrintToPrinter(1, false, 1, 99);
            //oRpt.Close();



  
        }

        private void Blokk2_InitReport(object sender, EventArgs e)
        {

        }

        private void Blokk1_InitReport(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            Szla_id = Convert.ToInt16(txtId.Text);
        }


    }
}
