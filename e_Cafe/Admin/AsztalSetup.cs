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
        Asztal AktAsztal;

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
            a = new Asztalok(pnlAsztalHelyek, ((Hely)cmbHelyek.Items[cmbHelyek.SelectedIndex]).fHELY_ID, true);
            a.RefreshAsztalok(true);
            
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

        public void AsztalClick(object sender, EventArgs e)
        {
            AktAsztal = ((GUI.Asztal_Button)sender).aObj;
            txtAsztalSzam.Text = ((GUI.Asztal_Button)sender).aObj.fASZTAL_SZAM;
            txtAsztalTipus.Text = ((GUI.Asztal_Button)sender).aObj.fASZTAL_TIPUS.ToString();
            nrRot.Value = ((GUI.Asztal_Button)sender).aObj.fASZTAL_ROTATE;
            lblAktAsztalId.Text = AktAsztal.fASZTAL_ID.ToString() ;
        }

        private void txtAsztalTipus_TextChanged(object sender, EventArgs e)
        {
            a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_SZAM = txtAsztalSzam.Text;
            a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_TIPUS = Convert.ToInt16(txtAsztalTipus.Text);
            a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_ROTATE = Convert.ToInt16(nrRot.Value);

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
