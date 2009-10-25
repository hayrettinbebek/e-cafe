using System;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe.Keszlet
{
    public partial class frmLeltarozas : Form
    {
        private int _cikkcsop_id = -1;
        private int _raktar_id = -1;

        public frmLeltarozas()
        {
            InitializeComponent();
        }

        private void frmLeltarozas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetRAKTAR.RAKTAR' table. You can move, or remove it, as needed.
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKKCSOPORT' table. You can move, or remove it, as needed.
            this.cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private bool CheckForm()
        {

            bool ret = false;

            try
            {
                _raktar_id = (int)cmbRaktar.SelectedValue;
                _cikkcsop_id = (int)cmbCikkcsop.SelectedValue;

            }
            catch (Exception)
            {
                _raktar_id = -1;
                _cikkcsop_id = -1;
                throw;
            }

            if ((_raktar_id > 0) && (_cikkcsop_id > 0))
            {
                ret = true;
            }

            return (ret);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int new_fej_id = -1;
            if (CheckForm())
            {
                new_fej_id = DEFS.doCreateLeltarIv(_raktar_id, _cikkcsop_id);

                if (new_fej_id > 0)
                {
                    frmLeltarIv fiv = new frmLeltarIv(new_fej_id);
                    fiv.ShowDialog();


                }
                else
                {
                    if (new_fej_id == -1) { DEFS.SendInfoMessage("Hibás adatbevitel!"); }
                    else if (new_fej_id == -99) { DEFS.SendInfoMessage("A megadott paraméterekre már létezik leltár ív!"); }

                    else
                    {
                        DEFS.SendInfoMessage("Ismeretlen hiba!");
                    }

                }
            }
        }
    }
}
