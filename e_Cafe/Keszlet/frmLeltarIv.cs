using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.Reports;

namespace e_Cafe.Keszlet
{
    public partial class frmLeltarIv : Form
    {
        int _fej = -99;
        public frmLeltarIv(int fej_id)
        {
            _fej = fej_id;
            InitializeComponent();
            leltarSorBindingSource.Clear();
            TemporaryLeltarSorok.LeltarSorok.Clear();
            TemporaryLeltarSorok.FillSorok(fej_id);

            foreach (var cc in TemporaryLeltarSorok.LeltarSorok)
            {
                leltarSorBindingSource.Add(cc);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var cc in leltarSorBindingSource)
            {
                ((LeltarSor)cc).Save();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            doPrinting dp = new doPrinting();
            dp.setReportMaker(new LeltarIv(_fej));
            dp.doPreview();
        }
    }
}
