using System;
using System.Windows.Forms;

namespace e_Cafe.Reports
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer(Object report)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = report;
        }
    }
}
