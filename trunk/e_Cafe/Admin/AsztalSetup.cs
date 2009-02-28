using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;


namespace e_Cafe
{
    public partial class AsztalSetup : Form
    {
        TBLObj asBlObj;
        Asztalok a;

        public AsztalSetup()
        {
            InitializeComponent();
        }

        public AsztalSetup(TBLObj bl)
        {
            InitializeComponent();
            asBlObj = bl;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.aList.lASZTAL.Count; i++)
            {
                a.aList.SaveList();

            }
            
        }

        private void AsztalSetup_Load(object sender, EventArgs e)
        {
            Helyek h = new Helyek();
            ArrayList arr = new ArrayList();
            
            cmbHelyek.ValueMember = "HELY_ID" ;
            cmbHelyek.DisplayMember = "HELY_NEV";

            foreach (Hely i in h.lHelyek)
            {
                arr.Add(i);
                cmbHelyek.Items.Add((Hely)i);
               
            }

        }

        private void cmbHelyek_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlAsztalHelyek.Controls.Clear();
            

            a = new Asztalok(pnlAsztalHelyek,  ((Hely)cmbHelyek.Items[cmbHelyek.SelectedIndex]).fHELY_ID, true);
            a.RefreshAsztalok(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
