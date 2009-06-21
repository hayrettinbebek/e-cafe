using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucVolumeControl : UserControl
    {
        private int fVOLUME;
        public int VOLUME
        {
            get { return (fVOLUME); }
            set
            {
                setVolume(value); 
            }
        }
        private void setVolume(int vol)
        {
            fVOLUME = vol;
            if (VOLUME >= 10)
            { pnl1.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl1.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 20)
            { pnl2.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl2.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 30)
            { pnl3.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl3.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 40)
            { pnl4.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl4.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 50)
            { pnl5.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl5.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 60)
            { pnl6.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl6.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 70)
            { pnl7.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl7.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 80)
            { pnl8.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl8.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 90)
            { pnl9.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl9.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 100)
            { pnl10.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl10.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 110)
            { pnl11.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl11.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 120)
            { pnl12.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl12.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 130)
            { pnl13.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl13.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 140)
            { pnl14.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl14.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 150)
            { pnl15.BackgroundImage = global::GUI.Properties.Resources.zold; }
            else
            {
                pnl15.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            //sárga
            if (VOLUME >= 195)
            { pnl19.BackgroundImage = global::GUI.Properties.Resources.sarga; }
            else
            {
                pnl19.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 205)
            { pnl20.BackgroundImage = global::GUI.Properties.Resources.sarga; }
            else
            {
                pnl20.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 215)
            { pnl21.BackgroundImage = global::GUI.Properties.Resources.sarga; }
            else
            {
                pnl21.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 225)
            { pnl22.BackgroundImage = global::GUI.Properties.Resources.sarga; }
            else
            {
                pnl22.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            //piros
            if (VOLUME >= 235)
            { pnl24.BackgroundImage = global::GUI.Properties.Resources.piros; }
            else
            {
                pnl24.BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            if (VOLUME >= 245)
            { pnl25.BackgroundImage = global::GUI.Properties.Resources.piros; }
            else
            {
                pnl25.BackgroundImage = null;
                BackColor = Color.Transparent;
            }

            //this.Refresh();

        }

        public ucVolumeControl()
        {
            InitializeComponent();
            setVolume(0);
        }
    }
}
