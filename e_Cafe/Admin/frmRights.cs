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
    public partial class frmRights : Form
    {
        public frmRights()
        {
            InitializeComponent();
        }

        private void frmRights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsJOG._JOG' table. You can move, or remove it, as needed.
            this._JOGTableAdapter.Fill(this.dsJOG._JOG);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _JOGTableAdapter.Update(dsJOG._JOG);
        }
    }
}
