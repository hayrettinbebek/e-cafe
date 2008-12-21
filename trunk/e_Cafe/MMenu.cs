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
    public partial class MMenu : Form
    {
        string ConSTR = @"server=ERNIE-HOME\SQLEXPRESS;database=ECAFE;uid=sa;password=x";
        clFIELDINFO_LIST FieldInfo;
        public static TBLObj blObj;

        public string DebugMessage
        {
            set { label1.Text = value; }
        }


        public MMenu()
        {
            InitializeComponent();
            FieldInfo = new clFIELDINFO_LIST(ConSTR);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Asztalok a = new Asztalok(panel3, blObj);
            a.Click += Asztal_click;
            a.RefreshAsztalok(true);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(Convert.ToDateTime(DateTime.Now).Hour) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Minute) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Second);
        }

        private void MMenu_Load(object sender, EventArgs e)
        {
            blObj = new TBLObj(-1, ConSTR, FieldInfo);
        }

        private void Asztal_click(object sender, EventArgs e)
        {
            // ha egy asztalra klikkelünk
            try
            {
                Asztal_Button tmp_a = (Asztal_Button)sender;
                MessageBox.Show(Convert.ToString(tmp_a.Asztal_id));
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminTools adm = new AdminTools(blObj);
            adm.ShowDialog();// = true;
            //adm.Show();
        }

        public void DoAsztalSelect(int iASZTAL_ID)
        {

        }

        private void notepad_Rendeles1_Load(object sender, EventArgs e)
        {

        }
    }
}
