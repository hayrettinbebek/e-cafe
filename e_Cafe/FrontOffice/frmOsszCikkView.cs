using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Cafe.FrontOffice
{
    public partial class frmOsszCikkView : Form
    {
        private int AktCikkId;
        public frmOsszCikkView(int _cikkId)
        {
            AktCikkId = _cikkId;
            InitializeComponent();
            cIKKTableAdapter.Fill(dsReceptText.CIKK, AktCikkId);
        }
    }
}
