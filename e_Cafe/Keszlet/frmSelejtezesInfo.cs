using System;
using System.Windows.Forms;

namespace e_Cafe.Keszlet
{
    public partial class frmSelejtezesInfo : Form
    {
        public frmSelejtezesInfo()
        {
            InitializeComponent();
        }

        private void frmSelejtezesInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deSelejtezInfo._SORSZAM' table. You can move, or remove it, as needed.
            this.SELEJTEZESTableAdapter.Fill(this.deSelejtezInfo.SELEJTEZES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
