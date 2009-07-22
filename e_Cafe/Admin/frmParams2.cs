using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Admin
{
    public partial class frmParams2 : Form
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
            if ((int)Syspar2.GetValue(ParamCodes.AUTO_PRINT_BLOKK) == 1)
            {
                chkBlokkAutoNyomt.Checked = true;
            }
            else { chkBlokkAutoNyomt.Checked = false; }
            txtBlokkLogoPath.Text = Syspar2.GetValue(ParamCodes.BLOKK_LOGO_PATH).ToString();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAndInsertData();
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
