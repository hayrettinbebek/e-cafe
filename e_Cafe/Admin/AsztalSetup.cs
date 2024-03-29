﻿using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogic;


namespace e_Cafe
{
    public partial class AsztalSetup : Form
    {
        //TBLObj asBlObj;
        Asztalok a;
        Asztal AktAsztal;

        public AsztalSetup()
        {
            InitializeComponent();
        }

        //public AsztalSetup(TBLObj bl)
        //{
        //    InitializeComponent();
        //    //asBlObj = bl;
        //}



        private void button2_Click(object sender, EventArgs e)       
        {
            if (a != null)
            {
                updateSettings();
                for (int i = 0; i < a.aList.lASZTAL.Count; i++)
                {
                    a.aList.SaveList();

                }
                pnlAsztalHelyek.Controls.Clear();
                a = new Asztalok(pnlAsztalHelyek, ((Hely)cmbHelyek.Items[cmbHelyek.SelectedIndex]).fHELY_ID, true);

                a.RefreshAsztalok(true);
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

            dynComboBindingSource.Add(new DynCombo("11","11"));
            dynComboBindingSource.Add(new DynCombo("12","12"));
            dynComboBindingSource.Add(new DynCombo("13","13"));
            dynComboBindingSource.Add(new DynCombo("14","14"));
            dynComboBindingSource.Add(new DynCombo("15","15"));
            dynComboBindingSource.Add(new DynCombo("16","16"));
            dynComboBindingSource.Add(new DynCombo("17","17"));
            dynComboBindingSource.Add(new DynCombo("18","18"));
            dynComboBindingSource.Add(new DynCombo("19","19"));
            
            dynComboBindingSource.Add(new DynCombo("20","20"));
            dynComboBindingSource.Add(new DynCombo("21","21"));
            dynComboBindingSource.Add(new DynCombo("97","97"));
            dynComboBindingSource.Add(new DynCombo("98","98"));
            dynComboBindingSource.Add(new DynCombo("99","99"));



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
            for (int i = 0; i < icmbTipus.Properties.Items.Count-1; i++)
            {
            	if ((int)icmbTipus.Properties.Items[i].Value == ((GUI.Asztal_Button)sender).aObj.fASZTAL_TIPUS)
                {
                    icmbTipus.SelectedIndex = i;
                }
            }

            //icmbTipus.SelectedIndex =  .SelectedValue = ((GUI.Asztal_Button)sender).aObj.fASZTAL_TIPUS.ToString();
            //txtAsztalTipus.Text = ((GUI.Asztal_Button)sender).aObj.fASZTAL_TIPUS.ToString();

            chkNameVis.Checked = DEFS.IntToBool(a.aList.GetItem(AktAsztal.fASZTAL_ID).fNAME_VISIBLE);
            chkRendelFel.Checked = DEFS.IntToBool(a.aList.GetItem(AktAsztal.fASZTAL_ID).fUSEABLE);
            
            switch (((GUI.Asztal_Button)sender).aObj.fASZTAL_ROTATE)
            {
                case 0:
                    {
                        rb0.Checked = true;
                        break;
                    }

                case 90:
                    {
                        rb90.Checked = true;
                        break;
                    }
                case 180:
                    {
                        rb180.Checked = true;
                        break;
                    }
                case 270:
                    {
                        rb270.Checked = true;
                        break;
                    }

                default:
                    break;
            }


            //nrRot.Value = ((GUI.Asztal_Button)sender).aObj.fASZTAL_ROTATE;


            lblAktAsztalId.Text = AktAsztal.fASZTAL_ID.ToString() ;
        }

        private void txtAsztal_TextChanged(object sender, EventArgs e)
        {
            if (a != null)
            {
                nrRot.Value = setRoatation();
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_SZAM = txtAsztalSzam.Text;
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_TIPUS = Convert.ToInt16((int)icmbTipus.Properties.Items[icmbTipus.SelectedIndex].Value);
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_ROTATE = Convert.ToInt16(nrRot.Value);
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fNAME_VISIBLE = DEFS.BoolToInt(chkNameVis.Checked);
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fUSEABLE = DEFS.BoolToInt(chkRendelFel.Checked);
            }
        }

        private void updateSettings()
        {
            if (a != null)
            {
                nrRot.Value = setRoatation();
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_SZAM = txtAsztalSzam.Text;
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_TIPUS = Convert.ToInt16((int)icmbTipus.Properties.Items[icmbTipus.SelectedIndex].Value);
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fASZTAL_ROTATE = Convert.ToInt16(nrRot.Value);
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fNAME_VISIBLE = DEFS.BoolToInt(chkNameVis.Checked);
                a.aList.GetItem(AktAsztal.fASZTAL_ID).fUSEABLE = DEFS.BoolToInt(chkRendelFel.Checked);
            }
        }

        private int setRoatation()
        {
            int retval = 0;
            if (rb0.Checked)
            {
                retval = 0;
            }
            if (rb90.Checked)
            {
                retval = 90;
            }
            if (rb180.Checked)
            {
                retval = 180;
            }
            if (rb270.Checked)
            {
                retval = 270;
            }
            return (retval);

            
        }

       


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbHelyek.SelectedIndex >= 0)
            {
                SqlConnection sc = new SqlConnection(DEFS.ConSTR);
                sc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sc;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("insert into ASZTAL (ASZTAL_SZAM,  ASZTAL_TIPUS_ID,  ASZTAL_POS_X,  ASZTAL_POS_Y,  HELY_ID,  ASZTAL_ROTATE)  SELECT (SELECT MAX(ASZTAL_SZAM)+1 FROM ASZTAL),  11,  20,  20,  {0},  0", ((Hely)cmbHelyek.Items[cmbHelyek.SelectedIndex]).fHELY_ID);

                cmd.ExecuteNonQuery();
                a.RefreshAsztalok(true);
                return;
            }
            DEFS.SendInfoMessage("Kérem válasszon helységet!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AktAsztal != null)
            {
                SqlConnection sc = new SqlConnection(DEFS.ConSTR);
                sc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sc;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("DELETE FROM ASZTAL WHERE ASZTAL_ID = {0}", AktAsztal.fASZTAL_ID);

                cmd.ExecuteNonQuery();
                a.RefreshAsztalok(true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
