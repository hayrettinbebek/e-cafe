using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Cafe.Admin
{
    public partial class frmPartnerDelete : Form
    {
        public frmPartnerDelete()
        {
            InitializeComponent();
        }

        private void frmPartnerDelete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPartnerek.PARTNER' table. You can move, or remove it, as needed.
            this.pARTNERTableAdapter.Fill(this.dsPartnerek.PARTNER);

        }
    }
}
