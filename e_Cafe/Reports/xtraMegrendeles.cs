using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace e_Cafe.Reports
{
    public partial class xtraMegrendeles : DevExpress.XtraReports.UI.XtraReport
    {
        public xtraMegrendeles(int megrID)
        {
            InitializeComponent();
            megrendeleS_FEJAdapter1.Fill(dsMegrendeles1.MEGRENDELES_FEJ, 1);
            
            mEGRENDELES_SORTableAdapter.Fill(dsMegrendeles1.MEGRENDELES_SOR);
            cikkTableAdapter.Fill(dsMegrendeles1.CIKK);
            partnerTableAdapter.Fill(dsMegrendeles1.PARTNER);
        }

    }
}
