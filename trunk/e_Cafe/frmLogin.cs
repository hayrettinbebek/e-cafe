using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogic;
using GUI;

namespace e_Cafe
{
    public partial class frmLogin : Form
    {
        public string _usr;
        public string _pw;

        private UserLista ul;

        public frmLogin()
        {
            InitializeComponent();
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            _pw = txtPw.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void keyb_Click(object sender, EventArgs e)
        {
            txtPw.Focus();
            SendKeys.Send(((Button)sender).Text);
        }

        private void User_Click(object sender, EventArgs e)
        {
            _usr = ((UserButton)sender).fUser.LOGIN_NAME;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ul = new UserLista();


            #region DebugUser
            _User nu = new _User();
            nu.NAME = "Administrator";
            nu.LOGIN_NAME = "x";
            UserButton ub = new UserButton();
            ub.fUser = nu;
            ub.Click += User_Click;


            flpUser.Controls.Add(ub);

            #endregion

            foreach (var u in ul.lUser)
            {
                UserButton ub2 = new UserButton();
                ub2.fUser = u;
                ub2.Click += User_Click;

                flpUser.Controls.Add(ub2);
   
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
