using System;
using System.Drawing;
using System.Windows.Forms;

using BusinessLogic;
using GUI;

namespace e_Cafe
{
    public partial class frmLogin : Form
    {
        public string _usr = "";
        public string _pw;
        public int changeUser = 0;
        public _User selUser;
        public int needLogin;

        private UserLista ul;
        private LoggedInUsers loginUsers;

        public frmLogin()
        {
            InitializeComponent();
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_usr != "")
            {
                _pw = txtPw.Text;
                
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void keyb_Click(object sender, EventArgs e)
        {
            txtPw.Focus();
            SendKeys.Send((string)((Button)sender).Tag);
        }

        private void User_Click(object sender, EventArgs e)
        {
            _usr = ((UserButton)sender).fUser.LOGIN_NAME;
            selUser = ((UserButton)sender).fUser;
            if (loginUsers.IsLoggedIn(selUser.USER_ID))
            {
                needLogin = 0;
            }
            else
            {
                needLogin = 1;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loginUsers = new LoggedInUsers();
            ul = new UserLista();


            #region DebugUser
            _User nu = new _User(-666);
            //nu.NAME = "Administrator";
            //nu.USER_ID = -666;
            //nu.LOGIN_NAME = "x";
            UserButton ub = new UserButton();
            ub.fUser = nu;
            ub.Click += User_Click;
            ub.BackgroundImage = global::GUI.Properties.Resources.off_user;
            ub.BackgroundImageLayout = ImageLayout.Stretch;
            if (loginUsers.IsLoggedIn(-666))
            {
                ub.BackColor = Color.Green;
            }
            ub.Checked = true;

            flpUser.Controls.Add(ub);

            #endregion

            foreach (var u in ul.lUser)
            {
                UserButton ub2 = new UserButton();
                ub2.fUser = u;
                ub2.Click += User_Click;
                ub2.BackgroundImage = global::GUI.Properties.Resources.off_user;
                ub2.BackgroundImageLayout = ImageLayout.Stretch;
                if (loginUsers.IsLoggedIn(u.USER_ID))
                {
                    ub2.BackColor = Color.Green;
                }
                
                flpUser.Controls.Add(ub2);
   
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (changeUser == 0)
            {
                Application.Exit();
            }
            else { this.Close(); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtPw.Focus();
            SendKeys.Send("{BACKSPACE}");
        }
    }
}
