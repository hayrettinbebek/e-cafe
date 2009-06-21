using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using BusinessLogic;

namespace e_Cafe
{
    public partial class frmUjCikk : Form
    {
        public Cikk newCikk;

        public int CikkID = 0;
 
        public frmUjCikk()
        {
            InitializeComponent();
        }

        private string ETrim(string t)
        {
            return (t.Trim());
        }

        private void frmUjCikk_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'eCAFEDataSetRAKTAR.RAKTAR' table. You can move, or remove it, as needed.
            this.rAKTARTableAdapter.Fill(this.eCAFEDataSetRAKTAR.RAKTAR);
            // TODO: This line of code loads data into the 'eCAFEDataSetMEGYS.MEGYS' table. You can move, or remove it, as needed.
            this.mEGYSTableAdapter.Fill(this.eCAFEDataSetMEGYS.MEGYS);
            // TODO: This line of code loads data into the 'eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKKCSOPORT' table. You can move, or remove it, as needed.
            this.cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);
            dynComboBindingSource.Add(new DynCombo("Darab", "D"));
            dynComboBindingSource.Add(new DynCombo("Folyó", "L"));
            if (CikkID > 0)
            {
                newCikk = new Cikk(CikkID,true,new System.Data.SqlClient.SqlConnection(DEFS.ConSTR));
            }
            else
            {
                newCikk = new Cikk();
            }
            FillForm();
        }

        private void FillForm()
        {
            this.cIKCSOP_OTHER_FILTERTableAdapter.Fill(this.eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER, Convert.ToInt16(cmdCikkcsop.SelectedValue));

            if (newCikk != null)
            {
                if (newCikk.CIKK_ID != -1)
                {
                    txtCikkszam.Text = newCikk.CIKKSZAM;
                    txtMegnevezes.Text = newCikk.MEGNEVEZES;
                    txtGyorskod.Text = newCikk.GYORSKOD;
                    txtEAN.Text = newCikk.EAN;
                    txtSZJ.Text = newCikk.SZJ;
                    cmdCikkcsop.SelectedValue = newCikk.CIKKCSOPORT_ID;
                    chkOsszetett.Checked = newCikk.OSSZETETT;
                    cmbOTF.SelectedValue = newCikk.ALCSOPORT;
                    cmbDefRakt.SelectedValue = newCikk.ALAP_RAKTAR;
                    cmbErtTip.SelectedValue = newCikk.ERTEKESITES_TIPUSA;
                    cmdMe.SelectedValue = newCikk.MEGYS_ID;
                    txtMinKeszl.Text = newCikk.MINIMUM_KESZLET.ToString();
                    txtOptKeszl.Text = newCikk.OPTIMALIS_KESZLET.ToString();
                    txtEladAr.Text = newCikk.ELADASI_AR.ToString();
                    txtEladArNet.Text = newCikk.NETTO_AR.ToString();
                    txtMegjegyzes.Text = newCikk.MEGJEGYZES;
                    chkMegKulZaras.Checked = newCikk.MEGKULONB_ZARAS;
                    chkAutoRendGen.Checked = newCikk.AUTO_MEGRENDELO;
                    chkVirtKeszl.Checked = (newCikk.VIRTUALIS == 1);
                    txtROVID_NEV.Text = newCikk.ROVID_NEV;
                    chkTOPCikk.Checked = newCikk.CIKK_TOP_LIST;
                    chkCikkcsopPrefer.Checked = newCikk.CIKKCSOP_PREFER;
                    
                }
            }


            this.aFATableAdapter.Fill(this.eCAFEDataSet.AFA, ((SQL.DataSets.ECAFEDataSet.CIKKCSOPORTRow)((DataRowView)cIKKCSOPORTBindingSource.Current).Row).AFA_KOD.ToString());
        }

        private void SaveCikk()
        {
            if (newCikk != null)
            {
                try
                {
                    newCikk.CIKKSZAM = txtCikkszam.Text;
                    newCikk.MEGNEVEZES = txtMegnevezes.Text;
                    newCikk.GYORSKOD = txtGyorskod.Text;
                    newCikk.EAN = txtEAN.Text;
                    newCikk.SZJ = txtSZJ.Text;
                    newCikk.CIKKCSOPORT_ID = Convert.ToInt16(cmdCikkcsop.SelectedValue);
                    newCikk.OSSZETETT = chkOsszetett.Checked;
                    newCikk.ALCSOPORT = Convert.ToInt16(cmbOTF.SelectedValue);
                    newCikk.ALAP_RAKTAR = Convert.ToInt16(cmbDefRakt.SelectedValue);
                    newCikk.ERTEKESITES_TIPUSA = cmbErtTip.SelectedValue.ToString();
                    newCikk.MEGYS_ID = Convert.ToString(cmdMe.SelectedValue);
                    if (txtMinKeszl.Text == "")
                    {
                        newCikk.MINIMUM_KESZLET = 0;
                    }
                    else
                    {
                        newCikk.MINIMUM_KESZLET = Convert.ToDouble(txtMinKeszl.Text);
                    }
                    if (txtOptKeszl.Text == "")
                    {
                        newCikk.OPTIMALIS_KESZLET = 0;
                    }
                    else
                    {
                        newCikk.OPTIMALIS_KESZLET = Convert.ToDouble(txtOptKeszl.Text);
                    }
                    newCikk.ELADASI_AR = Convert.ToDouble(txtEladAr.Text);
                    newCikk.NETTO_AR = Convert.ToDouble(txtEladArNet.Text);
                    newCikk.MEGKULONB_ZARAS = chkMegKulZaras.Checked;
                    newCikk.MEGJEGYZES = txtMegjegyzes.Text;
                    newCikk.AUTO_MEGRENDELO = chkAutoRendGen.Checked;
                    if (chkVirtKeszl.Checked)
                    {
                        newCikk.VIRTUALIS = 1;
                    }

                    else
                    {
                        newCikk.VIRTUALIS = 0;
                    }
                    newCikk.ROVID_NEV = txtROVID_NEV.Text;
                    newCikk.CIKK_TOP_LIST = chkTOPCikk.Checked;
                    newCikk.CIKKCSOP_PREFER =  chkCikkcsopPrefer.Checked;


                }
                catch (Exception e)
                {
                    DEFS.SendSaveErrMessage("Hiba a CIKK objektum feltöltése során!"+"\n"+e.Message+"\n"+e.StackTrace);
                }
                try
                {
                    newCikk.Save();
                }
                catch (Exception e)
                {
                    DEFS.SendSaveErrMessage("Hiba a CIKK objektum mentése során!" + "\n" + e.Message + "\n" + e.StackTrace);
                }
            }

        }

        private bool CheckForm()
        {
            bool r = true;

            if (newCikk != null)
            {
             
                if (ETrim(txtMegnevezes.Text) == "")
                {
                    r = false;
                    DEFS.SendSaveErrMessage("Megnevezés nem lehet üres!");
                }

                //if (ETrim(txtGyorskod.Text) == "")
                //{
                //    r = false;
                //    DEFS.SendSaveErrMessage("Gyorskód nem lehet üres!");
                //}

                if (cmdCikkcsop.SelectedValue == null)
                {
                    r = false;
                    DEFS.SendSaveErrMessage("Cikkcsoport nem lehet üres!");
                }

                if (cmbDefRakt.SelectedValue == null)
                {
                    r = false;
                    DEFS.SendSaveErrMessage("Alapértelmezett raktár nem lehet üres!");
                }

                if (cmbErtTip.SelectedValue == null)
                {
                    r = false;
                    DEFS.SendSaveErrMessage("Értékesítés típus nem lehet üres!");
                }

                if (cmdMe.SelectedValue == null)
                {
                    r = false;
                    DEFS.SendSaveErrMessage("Mennyiségi egység nem lehet üres!");
                }

                //if (ETrim(txtEladAr.Text) == "")
                //{
                //    r = false;
                //    DEFS.SendSaveErrMessage("Eladáis ár nem lehet üres!");
                //}

                //if (ETrim(txtEladArNet.Text) == "")
                //{
                //    r = false;
                //    DEFS.SendSaveErrMessage("Eladáis ár nem lehet üres!");
                //}

            }
            return (r);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                SaveCikk();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cmdCikkcsop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cIKCSOP_OTHER_FILTERTableAdapter.Fill(this.eCAFEDataSetOTHER_FILTER.CIKCSOP_OTHER_FILTER, Convert.ToInt16(cmdCikkcsop.SelectedValue));

            this.aFATableAdapter.Fill(this.eCAFEDataSet.AFA, ((SQL.DataSets.ECAFEDataSet.CIKKCSOPORTRow)((DataRowView)cIKKCSOPORTBindingSource.Current).Row).AFA_KOD.ToString());
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEladArNet.Text = DEFS.getNetto(Convert.ToDouble(txtEladAr.Text), (((SQL.DataSets.ECAFEDataSet.AFARow)((DataRowView)aFABindingSource.Current).Row).AFA_ERTEK)).ToString();
        }

        private void netToBrut_Click(object sender, EventArgs e)
        {
            txtEladAr.Text = DEFS.getBrutto(Convert.ToDouble(txtEladArNet.Text), (((SQL.DataSets.ECAFEDataSet.AFARow)((DataRowView)aFABindingSource.Current).Row).AFA_ERTEK)).ToString();
        }
    }
}
