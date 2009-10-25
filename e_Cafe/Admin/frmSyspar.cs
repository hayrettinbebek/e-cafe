using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace e_Cafe.Admin
{
    public partial class frmSyspar : Form
    {
        public frmSyspar()
        {
            InitializeComponent();
        }

        private void frmSyspar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSYSPAR.SYSPAR' table. You can move, or remove it, as needed.
            this.sYSPARTableAdapter.Fill(this.dsSYSPAR.SYSPAR);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sYSPARTableAdapter.Update(dsSYSPAR.SYSPAR);
            //DEFS.R_SYSPAR = new SysParList();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            FileStream fs;
            fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            //bytearray to read the image
            byte[] imgarr = new byte[fs.Length];
            fs.Read(imgarr, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();

            ((DataRowView)sYSPARBindingSource.Current)["PARAM_VALUE_IMAGE"] = imgarr;
             

            pbPreview.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void frmSyspar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DEFS.R_SYSPAR = new SysParList();
        }
    }

  
}
