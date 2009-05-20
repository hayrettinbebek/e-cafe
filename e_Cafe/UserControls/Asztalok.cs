using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI;
using System.IO;
using BusinessLogic;

namespace e_Cafe
{


    public partial class Asztalok : UserControl
    {
        Asztal_Button tmp_m;

        
        protected bool _isAdmin;
        protected bool _selectMode;
        protected int _HelyId;
        public Asztal_List aList;
        MMenu mm;
        frmAsztalSelect fm;
        AsztalSetup asz;

        public Asztalok(Control p,  int pHelyId)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;
            
            _HelyId = pHelyId;
            _isAdmin = false;
            mm = (MMenu)Parent.Parent;

        }
        public Asztalok(Control p,  int pHelyId, bool adminMode)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;
            
            _HelyId = pHelyId;
            _isAdmin = adminMode;
            if (!adminMode) {mm = (MMenu)Parent.Parent;}
            if (adminMode) { asz = (AsztalSetup)Parent.Parent; }

        }

        public Asztalok(bool select, Control p, int pHelyId)
        {
            InitializeComponent();
            Parent = p;
            Dock = DockStyle.Fill;

            _HelyId = pHelyId;
            _selectMode = select;

            if (_selectMode) { fm = (frmAsztalSelect)Parent.Parent; }
            

        }

        public void RefreshAsztalok(bool DB_refresh)
        {
            if (DB_refresh) { aList = new Asztal_List(_HelyId); }
            this.Controls.Clear();
            for (int i = 0; i < aList.lASZTAL.Count; i++)
            {
                Asztal_Button ab = new Asztal_Button(aList.lASZTAL[i].fASZTAL_ID);

                ab.ImageList = GetimageList(aList.lASZTAL[i].fASZTAL_TIPUS, aList.lASZTAL[i].fASZTAL_ROTATE);
                ab.Location = new Point(aList.lASZTAL[i].fASZTAL_POS_X, aList.lASZTAL[i].fASZTAL_POS_Y);

                if (aList.lASZTAL[i].fNAME_VISIBLE == 1)
                {
                    ab.Text = aList.lASZTAL[i].fASZTAL_SZAM;// +". asztal";
                }
                ab.aObj = aList.lASZTAL[i];
                ab.Size = new System.Drawing.Size(300, 123);
                if (aList.lASZTAL[i].fUSEABLE == 1)
                {
                    if (fm != null)
                    {
                        if (_selectMode) { ab.Click += fm.Asztal_click; }// .Asztalok_Click;
                    }
                    if (mm != null)
                    {
                        if (!_isAdmin) { ab.Click += mm.Asztal_click; }// .Asztalok_Click;
                    }
                }
                ab.vSelected = aList.lASZTAL[i].vSelected;
                ab.Invalidate();
                if (_isAdmin)
                {
                    ab.MouseMove += this.Asztalok_MouseMove;
                    if (asz != null)
                    {
                        ab.Click += asz.AsztalClick; ;
                    }
                }
                if (!_isAdmin) { ab.MouseDown += this.Asztalok_MouseDown; }
                
                this.Controls.Add(ab);
            }

        }


        private void Asztal_Click(object sender, EventArgs e)
        {

        }

        private void reInit()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType() == typeof(Asztal_Button)) {this.Controls.RemoveAt(i);}
            }
        }


        private ImageList GetimageList(int iAsztalType, int iRotate)
        {
            ImageList ilTmp = new System.Windows.Forms.ImageList();;
            String tmpPath = @"..\asztal\";

            ilTmp.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;

            ilTmp.ImageSize = Image.FromFile(tmpPath + iAsztalType.ToString() + "\\"+iRotate.ToString()+"\\01_off.png").Size;

            ilTmp.Images.Add(Image.FromFile(tmpPath + iAsztalType.ToString() + "\\" + iRotate.ToString() + "\\01_off.png"));
            ilTmp.Images.Add(Image.FromFile(tmpPath + iAsztalType.ToString() + "\\" + iRotate.ToString() + "\\02_on.png"));
            ilTmp.Images.Add(Image.FromFile(tmpPath + iAsztalType.ToString() + "\\" + iRotate.ToString() + "\\03_res.png"));

            return (ilTmp);

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
                }
                catch { }
            }
        }


        private void Asztalok_MouseDown(object sender, MouseEventArgs e)
        {
            AsztalInfo ai = new AsztalInfo();
            Asztal_Button tmp_a = (Asztal_Button)sender;

            if (tmp_a.ClickTime < 700) {

                ai.Location = e.Location;
                ai.Show();
            }
               
        }


 



    }
}
