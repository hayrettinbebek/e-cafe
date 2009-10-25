using System;
using System.Windows.Forms;
using BusinessLogic;


namespace e_Cafe.Admin
{
    public partial class frmUjUser : Form
    {
        public _User aktU;
        public int uid;

        public frmUjUser()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            txtNEV.Text = aktU.NAME;
            txtUSER_NAME.Text = aktU.LOGIN_NAME;
            txtPW.Text = aktU.PW;

            chkAdmin.Checked = aktU.SUPER;
            chkAktiv.Checked = aktU.AKTIV;



        }

        public void saveData()
        {
            aktU.NAME = txtNEV.Text;
            aktU.LOGIN_NAME =txtUSER_NAME.Text;
            aktU.PW = ECafeLogin.Md5AddSecret(txtPW.Text);
            
            aktU.SUPER = chkAdmin.Checked;
                
            aktU.AKTIV = chkAktiv.Checked;

            aktU.LOCKED_DATE = new DateTime(1970, 1, 1);
            aktU.LOCKED = "N";

            aktU.Save();


        }

        public bool checkData()
        {
            bool r = true;

            if ( txtNEV.Text == "" ) {r = false;}
            if ( txtPW.Text == "" ) {r = false;}
            if ( txtUSER_NAME.Text == "" ) {r = false;}


            return (r);
        }
        private void frmUjUser_Load(object sender, EventArgs e)
        {
            if (uid > -1)
            {
                aktU = new _User(uid);
            }
            else { aktU = new _User(); }

            loadData();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                DialogResult = DialogResult.OK;
                saveData();
            }
            else
            {
                DEFS.SendInfoMessage("Hibás adatok!");

            }

        }

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
              
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (!DEFS.isOnlyNumber(e.KeyCode)) { e.SuppressKeyPress = true; lblWarning.Visible = true; }
            else { lblWarning.Visible = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
