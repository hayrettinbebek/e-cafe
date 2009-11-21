using System;
using e_Cafe;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace e_Cafe.Reports
{
    public partial class xtraMegrendeles : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraMegrendeles()
        {
            InitializeComponent();


            
        }

        private void xtraMegrendeles_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

        }

        private void xtraMegrendeles_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            megrendeleS_FEJAdapter1.Fill(dsMegrendeles1.MEGRENDELES_FEJ, Convert.ToInt16(Parameters["id"].Value));
            partnerTableAdapter.Fill(dsMegrendeles1.PARTNER);
            mEGRENDELES_SORTableAdapter.Fill(dsMegrendeles1.MEGRENDELES_SOR);
            cikkTableAdapter.Fill(dsMegrendeles1.CIKK);
            //megysTableAdapter.Fill(dsMegrendeles1.MEGYS);
        }

        private void xtraMegrendeles_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {

        }

        private void xtraMegrendeles_PrintProgress(object sender, DevExpress.XtraPrinting.PrintProgressEventArgs e)
        {

        }

    }
}
