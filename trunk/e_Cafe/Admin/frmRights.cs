using System;

namespace e_Cafe.Admin
{
    public partial class frmRights :  e_Cafe.UserControls.UserForm
    {
        public frmRights()
        {
            InitializeComponent();
            
        }

        private void frmRights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsJOG._JOG' table. You can move, or remove it, as needed.
            this._JOGTableAdapter.Fill(this.dsJOG._JOG);
            _isEdit = true;
        }

        public override void Save()
        {
            base.Save();
            _JOGTableAdapter.Update(dsJOG._JOG);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
