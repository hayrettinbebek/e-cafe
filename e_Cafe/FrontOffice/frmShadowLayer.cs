using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BusinessLogic;
using System.Windows.Forms;
using e_Cafe.FrontOffice;

namespace e_Cafe
{
    public enum UsingForms
    {
        PartnerInsert,
        KedvezmenyValaszt,
        MediaPlayer
    }
    public partial class frmShadowLayer : Form
    {
        public int param;
        public string s_PARAM;
        private UsingForms mode;
        public KedvezmenyErtek ke = null;

        public frmShadowLayer(UsingForms u)
        {
            InitializeComponent();
            param = 0;
            mode = u;
        }

        private void frmShadowLayer_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case UsingForms.PartnerInsert:
                    {
                        if (param == 0) { Close(); }
                        frmPartnerInsert p = new frmPartnerInsert(param, s_PARAM);
                        
                        p.ShowDialog();
                        Close();
                        break;
                    }
                case UsingForms.KedvezmenyValaszt:
                    {
                        frmKedevemenyChoice kc = new frmKedevemenyChoice();
                        kc.ShowDialog();
                        if (kc.DialogResult == DialogResult.OK)
                        {
                            ke = kc.tmpKe;
                        }
                        Close();
                        break;
                    }
                case UsingForms.MediaPlayer:
                    {
                        frmMediaPlayer mp = new frmMediaPlayer();
                        mp.ShowDialog();
                        
                        Close();
                        break;
                    }
                default:
                    {
                        Close();
                        break;
                    }
            }



        }
    }
}
