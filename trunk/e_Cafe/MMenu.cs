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
        Asztalok a;

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
            goMainMenu();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(Convert.ToDateTime(DateTime.Now).Hour) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Minute) + ":" + Convert.ToString(Convert.ToDateTime(DateTime.Now).Second);
        }

        private void MMenu_Load(object sender, EventArgs e)
        {
            blObj = new TBLObj(-1, ConSTR, FieldInfo);
        }

        public void Asztal_click(object sender, EventArgs e)
        {
            // ha egy asztalra klikkelünk

                Asztal_Button tmp_a = (Asztal_Button)sender;

                a.aList.SelectAsztal(tmp_a.Asztal_id);
                tmp_a.vSelected = true;


                DebugMessage = tmp_a.Asztal_id.ToString() + tmp_a.vSelected.ToString();

                // Választó lista megjelenítése

                if (!a.aList.isUsed(tmp_a.Asztal_id))
                {
                    nr1.clear();
                    // ha szükség van előválaztóra!!
                    TableActionSelect preAsk = new TableActionSelect("Asztal " + a.aList.GetItem(tmp_a.Asztal_id).fASZTAL_SZAM.ToString() + ": Válasszon feladatok!");
                    preAsk.ShowDialog();
                    if (preAsk.DialogResult == DialogResult.OK)
                    {
                        if (preAsk.pChoice == "R")
                        {
                            panel3.Controls.Clear();
                            CikkValaszt cv = new CikkValaszt(panel3, blObj);
                            panel3.Controls.Add(cv);
                            cv.Dock = DockStyle.Fill;
                            cv.InitCikkValaszt();
                            
                        }
                            



                    }
                }
                else 
                { // A rendelések panel aktivizálása
                    nr1.rtHeader.Text = tmp_a.Asztal_id.ToString() + ". asztal rendelései:";


                }



                a.RefreshAsztalok(false); 


        }
        public void goMainMenu()
        {
            panel3.Controls.Clear();
            a = new Asztalok(panel3, blObj);
            a.Click += Asztal_click;
            a.RefreshAsztalok(true);
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
