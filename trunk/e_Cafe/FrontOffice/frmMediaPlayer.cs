using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinampFrontEndLib;

namespace e_Cafe.FrontOffice
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            WinampLib.VolumeUp();
            GetStatus();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            WinampLib.VolumeDown();
            GetStatus();
        }

        private void GetStatus()
        {

            
            psVolume.Value = WinampLib.GetVolume();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //1 = playing, 3 = paused, 0 = not playing
            if (WinampLib.GetState() == 1)
            {
                WinampLib.Pause();
            }
            else
            {
                WinampLib.Play();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WinampLib.Stop();
        }

        private void btnFW_Click(object sender, EventArgs e)
        {
            WinampLib.NextTrack();
        }

        private void btnRW_Click(object sender, EventArgs e)
        {
            WinampLib.PrevTrack();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
