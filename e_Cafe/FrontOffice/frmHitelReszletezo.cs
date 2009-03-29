using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;

using BusinessLogic;

namespace e_Cafe.FrontOffice
{
    public partial class frmHitelReszletezo : Form
    {
        private PartnerHitel _aktPH;
        public int pPartner;
        public frmHitelReszletezo()
        {
            InitializeComponent();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHitelReszletezo_Load(object sender, EventArgs e)
        {
            _aktPH = new PartnerHitel(pPartner);
            tblHitelek.ColumnModel = _aktPH.getColumnModel();
            tblHitelek.HeaderRenderer = new GradientHeaderRenderer();
            tblHitelek.TableModel = _aktPH.getTableModel();
            tblHitelek.Font = DEFS.f2;
            tblHitelek.TableModel.RowHeight = 40;
        }
    }
}
