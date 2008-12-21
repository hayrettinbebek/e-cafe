using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI;
using BusinessLogic;

namespace e_Cafe
{
    public partial class Asztalok : UserControl
    {
        protected TBLObj bl_object;
        protected bool _isAdmin;
        public Asztal_List aList;

        public Asztalok(Control p, TBLObj bl)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;
            bl_object = bl;
            _isAdmin = false;

        }
        public Asztalok(Control p, TBLObj bl, bool adminMode)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;
            bl_object = bl;
            _isAdmin = adminMode;

        }

        public void RefreshAsztalok()
        {
            aList = new Asztal_List(bl_object);
            
            for (int i = 0; i < aList.lASZTAL.Count; i++)
            {
                Asztal_Button ab = new Asztal_Button(aList.lASZTAL[i].fASZTAL_ID);

                ab.ImageList = AsztalType1List;
                ab.Location = new Point(aList.lASZTAL[i].fASZTAL_POS_X, aList.lASZTAL[i].fASZTAL_POS_Y);
                ab.Text = aList.lASZTAL[i].fASZTAL_SZAM;
                ab.Size = new System.Drawing.Size(75, 23);
                //ab.Click += this.Asztalok_Click;
                if (_isAdmin) { ab.MouseMove += this.Asztalok_MouseMove; }
                this.Controls.Add(ab);
            }

        }



        private void Asztalok_Click(object sender, EventArgs e)
        {
            // a felső szinten megoldva
            // ha egy asztalra klikkelünk
            try
            {
                Asztal_Button tmp_a = (Asztal_Button)sender;
                MessageBox.Show(Convert.ToString(tmp_a.Asztal_id));
            }
            catch { }
        }



        private void Asztalok_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    Asztal_Button tmp_a = (Asztal_Button)sender;
                    tmp_a.Location = new Point(tmp_a.Location.X + (e.X), tmp_a.Location.Y + (e.Y));
                    aList.lASZTAL[aList.GetItemIndex(tmp_a.Asztal_id)].fASZTAL_POS_X = tmp_a.Location.X;
                    aList.lASZTAL[aList.GetItemIndex(tmp_a.Asztal_id)].fASZTAL_POS_Y = tmp_a.Location.Y;

                    label1.Text = tmp_a.Asztal_id.ToString() + tmp_a.Location.ToString() + " egér:" + e.X.ToString() + "y:" + e.Y.ToString();
                }
                catch { }
            }
        }



    }
}
