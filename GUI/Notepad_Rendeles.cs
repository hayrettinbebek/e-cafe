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
    public partial class Notepad_Rendeles : UserControl
    {
        private int _Asztal_id;
        public int Asztal_id
        {
            get { return _Asztal_id; }
            set { _Asztal_id = value; }
        }

        public Notepad_Rendeles()
        {
            InitializeComponent();
        }

        public void clear()
        {
            rtHeader.Clear();
            lbRendelesSor.Items.Clear();
            rtSum.Clear();
        }
    }
}
