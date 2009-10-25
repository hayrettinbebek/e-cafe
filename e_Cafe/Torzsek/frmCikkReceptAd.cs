using System;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe.Torzsek
{
    public partial class frmCikkReceptAd : Form
    {
        public int Parent_cikk_id = -1;
        public int load_cikk_id = -1;

        public int new_cikk_id = -1;

        public decimal new_menny = -1;

        private Cikk ac;

        private Megys_list ml = new Megys_list();



        public frmCikkReceptAd()
        {
            InitializeComponent();
        }

        private void frmCikkReceptAd_Load(object sender, EventArgs e)
        {
            if (Parent_cikk_id == -1) { this.Close(); }
            // TODO: This line of code loads data into the 'receptMentes.RECEPT' table. You can move, or remove it, as needed.
            if (load_cikk_id != -1)
            {
                this.rECEPTTableAdapter.Fill(this.receptMentes.RECEPT,Parent_cikk_id,load_cikk_id);

                ac = new Cikk(load_cikk_id, true);
                lblCikk.Text = ac.MEGNEVEZES;

                lblMert.Text = ac.MEGYS_MEGNEVEZES;
                new_cikk_id = ac.CIKK_ID;
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUjCikk fc = new frmUjCikk();
            fc.ShowDialog();

            if (fc.DialogResult == DialogResult.OK)
            {
                new_cikk_id = fc.newCikk.CIKK_ID;
                
                lblCikk.Text = fc.newCikk.MEGNEVEZES;
                
                lblMert.Text = fc.newCikk.MEGYS_MEGNEVEZES;
                

            }
        }

        private void btnCikk_Click(object sender, EventArgs e)
        {
            CikkSelector fc = new CikkSelector();
            //fc.Parent = this;
            fc.ShowDialog();

            if (fc.DialogResult == DialogResult.OK)
            {

                new_cikk_id = fc.CIKK_ID;

                lblCikk.Text = fc.CIKK_NEV;

                Megys m = ml.MegysById(fc.c.MEGYS_ID);
                lblMert.Text = m.NEV;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = true;
            try
            {
                new_menny = Convert.ToDecimal(txtMenny.Text);
            }
            catch (Exception x)
            {
                DEFS.SendValidatingMessage("Mennyiség", "Hibás érték");
                DEFS.ExLog(x.Message + "-->" + x.StackTrace);
                ok = false;
            }

            if (ok && (load_cikk_id != -1))
            {
                rECEPTTableAdapter.Delete(Parent_cikk_id, new_cikk_id);
                rECEPTTableAdapter.Insert(Parent_cikk_id, new_cikk_id, new_menny);
                DialogResult = DialogResult.OK;
                this.Close();
            } else 
            if (ok && (new_cikk_id != -1))
            {
                rECEPTTableAdapter.Insert(Parent_cikk_id, new_cikk_id, new_menny);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
