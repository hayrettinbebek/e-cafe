using System;
using System.Data;
using System.Windows.Forms;

namespace e_Cafe.Admin
{
    public partial class frmUserJogok : Form

    {

        public int _UserId;

        public frmUserJogok()
        {
            InitializeComponent();
        }

        private void frmUserJogok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUserJog._USER_JOG' table. You can move, or remove it, as needed.
            this._USER_JOGTableAdapter.Fill(this.dsUserJog._USER_JOG);
            // TODO: This line of code loads data into the 'dsJOG._JOG' table. You can move, or remove it, as needed.
            this._JOGTableAdapter.FillByUser(this.dsJOG._JOG, _UserId);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _USER_JOGTableAdapter.Insert(_UserId, (string)lbJogok.SelectedValue);
            _USER_JOGTableAdapter.Update(dsUserJog._USER_JOG);
            this._JOGTableAdapter.FillByUser(this.dsJOG._JOG, _UserId);
            this._USER_JOGTableAdapter.Fill(this.dsUserJog._USER_JOG);
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _USER_JOGTableAdapter.Update(dsUserJog._USER_JOG);
            this._JOGTableAdapter.FillByUser(this.dsJOG._JOG, _UserId);
            this._USER_JOGTableAdapter.Fill(this.dsUserJog._USER_JOG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _USER_JOGTableAdapter.Delete(_UserId, (string)((DataRowView)uSERJOGBindingSource.Current)["_JOG_ID"]);
            _USER_JOGTableAdapter.Update(dsUserJog._USER_JOG);
            this._JOGTableAdapter.FillByUser(this.dsJOG._JOG, _UserId);
            this._USER_JOGTableAdapter.Fill(this.dsUserJog._USER_JOG);
        }
    }
}
