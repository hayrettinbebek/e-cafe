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
        Asztal_Button tmp_m;

        protected TBLObj bl_object;
        protected bool _isAdmin;
        public Asztal_List aList;
        MMenu mm;

        public Asztalok(Control p, TBLObj bl)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;
            bl_object = bl;
            _isAdmin = false;
            mm = (MMenu)Parent.Parent;

        }
        public Asztalok(Control p, TBLObj bl, bool adminMode)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;
            bl_object = bl;
            _isAdmin = adminMode;
            if (!adminMode) {mm = (MMenu)Parent.Parent;}

        }

        public void RefreshAsztalok(bool DB_refresh)
        {
            if (DB_refresh) { aList = new Asztal_List(bl_object); }
            this.Controls.Clear();
            for (int i = 0; i < aList.lASZTAL.Count; i++)
            {
                Asztal_Button ab = new Asztal_Button(aList.lASZTAL[i].fASZTAL_ID);

                ab.ImageList = GetimageList(aList.lASZTAL[i].fASZTAL_TIPUS);
                ab.Location = new Point(aList.lASZTAL[i].fASZTAL_POS_X, aList.lASZTAL[i].fASZTAL_POS_Y);
                ab.Text = aList.lASZTAL[i].fASZTAL_SZAM + ". asztal";
                ab.Size = new System.Drawing.Size(300, 123);
                if (!_isAdmin) { ab.Click += mm.Asztal_click; }// .Asztalok_Click;
                ab.vSelected = aList.lASZTAL[i].vSelected;
                ab.Invalidate();
                if (_isAdmin) { ab.MouseMove += this.Asztalok_MouseMove; }
                this.Controls.Add(ab);
            }

        }


        private void reInit()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType() == typeof(Asztal_Button)) {this.Controls.RemoveAt(i);}
            }
        }


        private ImageList GetimageList(int iAsztalType)
        {
            switch (iAsztalType) 
	        {
                case 11: return(imageListA); break;
                case 12: return(imageListB);break;
                case 13: return(imageListC);break;
                case 14: return(imageListD);break;
                case 15: return(imageListE);break;
                case 16: return(imageListF);break;
                case 17: return(imageListG);break;
                case 18: return(imageListH);break;
                case 19: return(imageListI);break;
                case 20: return(imageListJ);break;
                case 21: return (imageListK); break;

                default: return(AsztalType1List);break;
	        }
        }

        private void Asztalok_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    tmp_m = (Asztal_Button)sender;
                    tmp_m.Location = new Point(tmp_m.Location.X + (e.X), tmp_m.Location.Y + (e.Y));
                    aList.lASZTAL[aList.GetItemIndex(tmp_m.Asztal_id)].fASZTAL_POS_X = tmp_m.Location.X;
                    aList.lASZTAL[aList.GetItemIndex(tmp_m.Asztal_id)].fASZTAL_POS_Y = tmp_m.Location.Y;


                    mm.DebugMessage = tmp_m.Asztal_id.ToString() + tmp_m.Location.ToString() + " egér:" + e.X.ToString() + "y:" + e.Y.ToString();
                }
                catch { }
            }
        }

 



    }
}
