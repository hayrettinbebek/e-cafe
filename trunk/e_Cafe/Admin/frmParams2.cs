using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTabbedMdi;

namespace e_Cafe.Admin
{
    public partial class frmParams2 : UserControls.UserForm
    {
        public frmParams2()
        {
            InitializeComponent();
        }

        private void loadAndFillData()
        {
            txtCegNev.Text = Syspar2.GetValue(ParamCodes.CEG_NEV).ToString();
            txtCegCim.Text = Syspar2.GetValue(ParamCodes.CEG_CIM).ToString();
            txtLablec1.Text = Syspar2.GetValue(ParamCodes.BLOKK_LABLEC1).ToString();
            txtLablec2.Text = Syspar2.GetValue(ParamCodes.BLOKK_LABLEC2).ToString();
            txtLablec3.Text = Syspar2.GetValue(ParamCodes.BLOKK_LABLEC3).ToString();
            nuSchowOrderBefore.Value = (int)Syspar2.GetValue(ParamCodes.SHOW_ORDER_BEFORE);
            foreach (DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins)
            {
                
                iSkinCombo.Properties.Items.Add(cnt.SkinName);
                
            }

            iSkinCombo.SelectedText = Syspar2.GetValue(ParamCodes.SKIN_NAME).ToString();

            if ((int)Syspar2.GetValue(ParamCodes.AUTO_PRINT_BLOKK) == 1)
            {
                chkBlokkAutoNyomt.Checked = true;
            }
            else { chkBlokkAutoNyomt.Checked = false; }
            txtBlokkLogoPath.Text = Syspar2.GetValue(ParamCodes.BLOKK_LOGO_PATH).ToString();
            rbOldal.Checked = Syspar2.GetValue(ParamCodes.CIKK_GORGET_MODE).ToString() == "O";
            rbSor.Checked = Syspar2.GetValue(ParamCodes.CIKK_GORGET_MODE).ToString() == "S";
        }

        private void SaveAndInsertData()
        {
            Syspar2.SetValues(ParamCodes.CEG_NEV, txtCegNev.Text);
            Syspar2.SetValues(ParamCodes.CEG_CIM, txtCegCim.Text);
            Syspar2.SetValues(ParamCodes.BLOKK_LABLEC1, txtLablec1.Text);
            Syspar2.SetValues(ParamCodes.BLOKK_LABLEC2, txtLablec2.Text);
            Syspar2.SetValues(ParamCodes.BLOKK_LABLEC3, txtLablec3.Text);
            Syspar2.SetValues(ParamCodes.CEG_NEV, txtCegNev.Text);
            Syspar2.SetValues(ParamCodes.SHOW_ORDER_BEFORE, nuSchowOrderBefore.Value);
            Syspar2.SetValues(ParamCodes.BLOKK_LOGO_PATH, txtBlokkLogoPath.Text);

            if (chkBlokkAutoNyomt.Checked)
            {
                Syspar2.SetValues(ParamCodes.AUTO_PRINT_BLOKK, 1);
            }
            else { Syspar2.SetValues(ParamCodes.AUTO_PRINT_BLOKK, 99); }

            if (rbOldal.Checked) { Syspar2.SetValues(ParamCodes.CIKK_GORGET_MODE, "O"); }
            if (rbSor.Checked) { Syspar2.SetValues(ParamCodes.CIKK_GORGET_MODE, "S"); }

            Syspar2.SetValues(ParamCodes.SKIN_NAME, iSkinCombo.SelectedText);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAndInsertData();
            ((AdminTools)MdiParent).defaultLookAndFeel1.LookAndFeel.SetSkinStyle(Syspar2.GetValue(ParamCodes.SKIN_NAME).ToString());
            this.Close();

        }

        private void frmParams2_Load(object sender, EventArgs e)
        {
            loadAndFillData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadAndFillData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBlokkLogoPath.Text != "")
            {
                openFileDialog1.InitialDirectory = txtBlokkLogoPath.Text;
            }
            else
            {
                openFileDialog1.InitialDirectory = @"..\";
            }
            openFileDialog1.ShowDialog();
            txtBlokkLogoPath.Text = openFileDialog1.FileName;
        }
    }
}
