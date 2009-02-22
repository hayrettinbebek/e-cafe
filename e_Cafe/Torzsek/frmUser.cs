using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Torzsek
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initDataset()
        {
            UserLista ul = new UserLista();
            userBindingSource.Clear();

            foreach (var k in ul.lUser)
            {
                userBindingSource.Add(k);
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            initDataset();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUjUser fu = new frmUjUser();
            fu.uid = -1;
            fu.ShowDialog();
            if (fu.DialogResult == DialogResult.OK)
            {
                initDataset();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current != null)
            {
                frmUjUser fu = new frmUjUser();
                fu.uid = ((_User)userBindingSource.Current).USER_ID;
                fu.ShowDialog();
            }
        }
    }
}
