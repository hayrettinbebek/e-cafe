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
        public int Szla_id = 5;
        private int j = 0;
       

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
            Blokk1.FileName = DEFS.DefProgramLocation + @"\Reports\Blokk.rpt";
            bLOKK_TETELTableAdapter.Fill(dsRepSzamla.BLOKK_TETEL, Szla_id);
            sZAMLA_FEJTableAdapter.Fill(dsRepSzamla.SZAMLA_FEJ);
            //Blokk1.SetDatabaseLogon("sa", "x", ,);
            Blokk1.SetDataSource(dsRepSzamla);
            
            CrystalDecisions.CrystalReports.Engine.Table t;
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;

            Blokk1.SetParameterValue("@szla_id", Szla_id);
            
            
            foreach (var tbl in Blokk1.Database.Tables)
            {
                t = (CrystalDecisions.CrystalReports.Engine.Table)tbl;
                //t = (CrystalDecisions.CrystalReports.Engine.Table)Blokk1.Database.Tables[0];
                tliCurrent = t.LogOnInfo;
                
                tliCurrent.ConnectionInfo.ServerName = @"ERNIE-NB\SQLEXPRESS";
                tliCurrent.ConnectionInfo.UserID = "sa";
                tliCurrent.ConnectionInfo.Password = "x";
                tliCurrent.ConnectionInfo.DatabaseName = "ECAFE_0303";
                DEFS.DebugLog(tliCurrent.ReportName + " --> REport: " + tliCurrent.TableName);
                DEFS.DebugLog("RAS::::"+Blokk1.ReportAppServer);
                t.ApplyLogOnInfo (tliCurrent);
                
                DEFS.DebugLog("Loginfo set TABLE:" + t.Name);
                bool test = t.TestConnectivity();
                if (test == false)
                {
                    DEFS.DebugLog("DB Connection not working");
                }
                else
                {
                    DEFS.DebugLog("DB Connection WORKING");
                }
                DEFS.DebugLog(tliCurrent.ReportName + " --> REport: " + tliCurrent.TableName);
                //t.Location = t.Name;
                DEFS.DebugLog("Location set TABLE:"+t.Location +" = "+ t.Name);
            }
            //Blokk1.ReportAppServer =

            DEFS.DebugLog("ReportViewer set");
            crystalReportViewer1.ReportSource = Blokk1;
            foreach (var c in Blokk1.DataSourceConnections)
            {
                DEFS.DebugLog(((IConnectionInfo)c).DatabaseName + ((IConnectionInfo)c).UserID);

            }
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ConnectionInfo ci = new Conn
            Blokk1.FileName = DEFS.DefProgramLocation + @"\Reports\Blokk.rpt";
            bLOKK_TETELTableAdapter.Fill(dsRepSzamla.BLOKK_TETEL, Szla_id);
            sZAMLA_FEJTableAdapter.Fill(dsRepSzamla.SZAMLA_FEJ);

            Blokk1.SetDatabaseLogon("sa", "x");
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = j++;

            if (j == 100)
            {
                timer1.Enabled = false;
                //this.Close();
            }
            
            
        }


    }
}
