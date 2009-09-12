using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
