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
    public partial class AsztalSetup : Form
    {
        TBLObj asBlObj;
        Asztalok a;

        public AsztalSetup()
        {
            InitializeComponent();
        }

        public AsztalSetup(TBLObj bl)
        {
            InitializeComponent();
            asBlObj = bl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAsztalHelyek.Controls.Clear();
            a = new Asztalok(pnlAsztalHelyek, asBlObj, true);
            a.RefreshAsztalok(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.aList.lASZTAL.Count; i++)
            {
                a.aList.SaveList();

            }
            
        }
    }
}
