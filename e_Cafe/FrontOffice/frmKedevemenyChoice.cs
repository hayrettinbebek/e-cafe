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

namespace e_Cafe.FrontOffice
{
    public partial class frmKedevemenyChoice : Form
    {
        public KedvezmenyErtek tmpKe;
        private int selKedvSzaz = 0;

        public frmKedevemenyChoice()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFoglalas_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSzazalek.Checked)
            {
                btnSzazalek.BackgroundImage = global::GUI.Properties.Resources.szazalek_on;
                btnErtek.BackgroundImage = global::GUI.Properties.Resources.ertek_off;
                splitContainer1.Panel2Collapsed = true;
                splitContainer1.Panel1Collapsed = false;
                getSzazalekok();
            }
            else
            {
                btnSzazalek.BackgroundImage = global::GUI.Properties.Resources.szazalek_off; 
                btnErtek.BackgroundImage = global::GUI.Properties.Resources.ertek_on;
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Panel1Collapsed = true;

            }
        }
        private void getSzazalekok()
        {
            flpKedvezmenyek.Controls.Clear();

            Kedvezmenyek kk = new Kedvezmenyek();

            for (int i = 0; i < kk.lKEDVEZMENY.Count; i++)
            {

                KedvezmenyButton kb = new KedvezmenyButton(kk.lKEDVEZMENY[i].SZAZALEK);

                //kb.Location = new Point(0, 0);

                //kb.TextAlign = ContentAlignment.BottomLeft;
                //kb.Location = new Point(0, 0);
                kb.Width = 85;
                kb.Height = 85;
                kb.BackgroundImage = global::GUI.Properties.Resources.uresGomb;
                kb.BackgroundImageLayout = ImageLayout.Stretch;
                kb.AutoSize = false;
                //kb.Dock = DockStyle.Fill;

                kb.Click += KedvezmenyClick;

                flpKedvezmenyek.Controls.Add(kb);
                
            }
            flpKedvezmenyek.Refresh();

        }

        private void KedvezmenyClick(object sender, EventArgs e)
        {
            selKedvSzaz = ((KedvezmenyButton)sender).KEDVEZEMNY;
            button1_Click(sender, e);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnErtek.Checked)
            {
                tmpKe = new KedvezmenyErtek(Convert.ToDouble(numericKeyboar1.txtRet.Text));
            }
            else
            {
                tmpKe = new KedvezmenyErtek(selKedvSzaz);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmKedevemenyChoice_Load(object sender, EventArgs e)
        {
            btnSzazalek.BackgroundImage = global::GUI.Properties.Resources.szazalek_on;
            btnErtek.BackgroundImage = global::GUI.Properties.Resources.ertek_off;
            btnSzazalek.Checked = true;
            splitContainer1.Panel2Collapsed = true;
            splitContainer1.Panel1Collapsed = false;
            getSzazalekok();
        }
    }
}
