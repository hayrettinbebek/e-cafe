using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
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
            // TODO: This line of code loads data into the 'dsSZAMLAZAS.SZAMLA_FEJ' table. You can move, or remove it, as needed.
            this.sZAMLA_FEJTableAdapter.Fill(this.dsSZAMLAZAS.SZAMLA_FEJ);
            // TODO: This line of code loads data into the 'dsSZAMLAZAS.SZAMLA_TETEL' table. You can move, or remove it, as needed.
            this.sZAMLA_TETELTableAdapter.Fill(this.dsSZAMLAZAS.SZAMLA_TETEL);

            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blokk1.FileName = DEFS.DefProgramLocation + @"\Reports\Blokk.rpt";
            Blokk1.SetDataSource(dsSZAMLAZAS);
            //oRpt.Load(DEFS.DefProgramLocation + @"\Reports\Blokk.rpt");
            //oRpt.SetDataSource(ds);
            //oRpt.SetDatabaseLogon();
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


    }
}
