using System;
using System.IO;
using System.Windows.Forms;
using BusinessLogic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using e_Cafe.Admin;
using e_Cafe.Keszlet;
using e_Cafe.Torzsek;
using e_Cafe.UserControls;



namespace e_Cafe
{
    public partial class AdminTools : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public AdminTools()
        {
            InitializeComponent();
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(Syspar2.GetValue(ParamCodes.SKIN_NAME).ToString());
        }

        UserForm CurrentForm
        {
            get
            {
                if (ActiveMdiChild == null) return null;
                try
                {
                    return ActiveMdiChild as UserForm;
                }
                catch { return null; }
            }
        }


        public void InitSpeedBar()
        {
            ShowHideDataCategory();
            if (CurrentForm != null)
            {
                iSave.Enabled = CurrentForm._isEditForm;
                iBigSave.Enabled = CurrentForm._isEditForm;

                iNew.Enabled = CurrentForm._InsertAndDelete;
                iBigNew.Enabled = CurrentForm._InsertAndDelete;
                iDelete.Enabled = CurrentForm._InsertAndDelete;
                iBigDelete.Enabled = CurrentForm._InsertAndDelete;
            }
            else
            {
                iSave.Enabled = false;
                iBigSave.Enabled = false;
                iNew.Enabled = false;
                iBigNew.Enabled = false;
                iDelete.Enabled = false;
                iBigDelete.Enabled = false;
            }
        }
        public void ShowHideDataCategory()
        {
            RibbonPageCategory selectionCategory = Ribbon.PageCategories[0] as RibbonPageCategory;
            if (selectionCategory == null) return;
            if (CurrentForm == null)
                selectionCategory.Visible = false;
            else if (CurrentForm._isEditForm)
                     selectionCategory.Visible = true;
                else selectionCategory.Visible = false;

            if (selectionCategory.Visible) Ribbon.SelectedPage = selectionCategory.Pages[0];
        }

        void SaveCurrentForm()
        {
             
            if (CurrentForm != null)
            {
                CurrentForm.Save();

            }
        }

        void AddNewItem()
        {

            if (CurrentForm != null)
            {
                CurrentForm.AddNew();
            }
        }

        void DeleteItem()
        {

            if (CurrentForm != null)
            {
                CurrentForm.DeleteRow();

            }
        }







        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array.ForEach(MdiChildren, childForm => childForm.Close());
        }



        private void logokKüldéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"log");
            (new EmailSending()).sendLogs(s);

            Directory.Move(AppDomain.CurrentDomain.BaseDirectory + @"log", AppDomain.CurrentDomain.BaseDirectory + @"old_log"+ DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" +
                                                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second);


        }


        private void mmNapiZaras_Click(object sender, EventArgs e)
        {

            
        }




        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmMegrendelesKeszites { MdiParent = this }).Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmMegrendelesArchivum { LoadType = LoadTypes.archive }).ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmBevetel { MdiParent = this }).Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new Bevetelezes { MdiParent = this }).Show();
        }

        private void barSubItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmMegrendelesArchivum { LoadType = LoadTypes.select }).ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmKeszletKarton { MdiParent = this }).Show();
        }

        private void barSubItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmSelejtezesInfo().ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmAtvezetes { MdiParent = this }).Show();
        }

        private void barSubItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmLeltarozas { MdiParent = this }).Show();
        }

        private void barSubItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmLeltarozas { MdiParent = this }).Show();
        }

        private void barSubItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmLeltarSelect { MdiParent = this }).Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmCikk { recept = 0, aktiv = 1, MdiParent = this }).Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmCikk { recept = 1, aktiv = 1, MdiParent = this }).Show();
        }

        private void barSubItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmCikkcsoport { MdiParent = this }).Show();
        }

        private void barSubItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmOtherFilter { MdiParent = this }).Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmCikk { recept = 0, aktiv = 0, MdiParent = this }).Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new AsztalSetup { MdiParent = this }).Show();
        }

        private void akciókToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmSzallito { MdiParent = this }).Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmPartnerDelete { del = 1, MdiParent = this }).Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmPartnerDelete { del = 0, MdiParent = this }).Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmAFA { MdiParent = this }).Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmHelyek { MdiParent = this }).Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmRaktar { MdiParent = this }).Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmAltKedvezm { MdiParent = this }).Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmUser { MdiParent = this }).Show();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {

            (new frmRights { MdiParent = this }).Show();
        }

        private void szövegelemekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmParams2 { MdiParent = this }).Show();

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {

            (new frmKimentBlokkok { MdiParent = this }).Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmOsszevontLista { MdiParent = this }).Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmAbout { MdiParent = this }).Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNapiZaras nz = new frmNapiZaras();
            //nz.MdiParent = this;
            nz.ShowDialog();
        }

        private void barSubItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new frmSelejtez { MdiParent = this }).Show();
        }

        private void AdminTools_MdiChildActivate(object sender, EventArgs e)
        {
            InitSpeedBar();
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveCurrentForm();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveCurrentForm();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddNewItem();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteItem();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddNewItem();
        }




    }
}
