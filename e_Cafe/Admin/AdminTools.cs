using System;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.Admin;
using e_Cafe.Keszlet;
using e_Cafe.Torzsek;
using e_Cafe.UserControls;
using System.IO;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;



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
                if (this.ActiveMdiChild == null) return null;
                try
                {
                    return this.ActiveMdiChild as UserForm;
                }
                catch { return null; }
            }
        }


        void InitSpeedBar()
        {
            ShowHideDataCategory();
            if (CurrentForm != null)
            {
                iSave.Enabled = CurrentForm.isEditForm;
                
            }
        }

        void SaveCurrentForm()
        {
             
            if (CurrentForm != null)
            {
                CurrentForm.Save();

            }
        }

        public void ShowHideDataCategory()
        {
            RibbonPageCategory selectionCategory = Ribbon.PageCategories[0] as RibbonPageCategory;
            if (selectionCategory == null) return;
            if (CurrentForm == null)
                selectionCategory.Visible = false;
            else if (CurrentForm.isEditForm)
                     selectionCategory.Visible = true;
                else selectionCategory.Visible = false;

            if (selectionCategory.Visible) Ribbon.SelectedPage = selectionCategory.Pages[0];
        }


        private void ShowNewForm(object sender, EventArgs e)
        {

        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
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
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cikkekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asztalokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cikkcsoportokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áfaKódokToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cikkcsoportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alcsoportToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AdminTools_Load(object sender, EventArgs e)
        {

        }

        private void helyekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mmRaktar_Click(object sender, EventArgs e)
        {

        }

        private void mmSzallitok_Click(object sender, EventArgs e)
        {

        }

        private void adatbázisFrissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Egyeléőre csak kézzel lehet az update.bat paranccsal");
        }

        private void logokKüldéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"log");
            (new EmailSending()).sendLogs(s);

            Directory.Move(AppDomain.CurrentDomain.BaseDirectory + @"log", AppDomain.CurrentDomain.BaseDirectory + @"old_log"+ DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" +
                                                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second);


        }

        private void mmBevetel2_Click(object sender, EventArgs e)
        {

        }

        private void mennyiségiEgységekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void felhasználókToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void készletÁtvezetésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rendszerparaméterekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mmNapiZaras_Click(object sender, EventArgs e)
        {

            
        }

        private void blokkokVisszakereséseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receptekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partnerTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void töröltPartnerVisszaállításaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inaktívCikkekKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jogosultságokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mmOsszevontLista_Click(object sender, EventArgs e)
        {

        }

        private void cikkListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");

        }

        private void beszerzésiListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");

        }

        private void fogyóKészletekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");

        }

        private void mmAltKedvezmeny_Click(object sender, EventArgs e)
        {

        }

        private void asztalokToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMegrendelesKeszites mr = new frmMegrendelesKeszites();
            mr.MdiParent = this;
            mr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMegrendelesArchivum fa = new frmMegrendelesArchivum();
            fa.LoadType = LoadTypes.archive;
            fa.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBevetel f = new frmBevetel();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bevetelezes f = new Bevetelezes();
            f.MdiParent = this;
            f.Show();
        }

        private void barSubItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMegrendelesArchivum fa = new frmMegrendelesArchivum();
            fa.LoadType = LoadTypes.select;
            fa.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKeszletKarton fa = new frmKeszletKarton();
            fa.MdiParent = this;
            fa.Show();
        }

        private void barSubItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barSubItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmSelejtezesInfo().ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAtvezetes fa = new frmAtvezetes { MdiParent = this };
            fa.Show();
        }

        private void barSubItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeltarozas fl = new frmLeltarozas();
            fl.MdiParent = this;
            fl.Show();
        }

        private void barSubItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeltarozas fl = new frmLeltarozas();
            fl.MdiParent = this;
            fl.Show();
        }

        private void barSubItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeltarSelect ls = new frmLeltarSelect();
            ls.MdiParent = this;
            ls.Show();
        }

        private void régiZárásokÁttekintéseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCikk ck = new frmCikk { recept = 0, aktiv = 1, MdiParent = this };
            ck.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCikk ck = new frmCikk { recept = 1, aktiv = 1, MdiParent = this };
            ck.Show();
        }

        private void barSubItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCikkcsoport f = new frmCikkcsoport();
            f.MdiParent = this;
            f.Show();
        }

        private void barSubItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOtherFilter f = new frmOtherFilter();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCikk ck = new frmCikk { recept = 0, aktiv = 0, MdiParent = this };
            ck.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AsztalSetup ck = new AsztalSetup { MdiParent = this };
            ck.Show();
        }

        private void akciókToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSzallito f = new frmSzallito();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPartnerDelete pd = new frmPartnerDelete();
            pd.del = 1;
            pd.MdiParent = this;
            pd.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmPartnerDelete { del = 0, MdiParent = this }).Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmAFA { MdiParent = this }).Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHelyek f = new frmHelyek { MdiParent = this };
            f.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmRaktar { MdiParent = this }).Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmAltKedvezm { MdiParent = this }).Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmUser { MdiParent = this }).Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            (new frmRights { MdiParent = this }).Show();
        }

        private void szövegelemekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmParams2 { MdiParent = this }).Show();

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            (new frmKimentBlokkok { MdiParent = this }).Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmOsszevontLista { MdiParent = this }).Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DEFS.SendInfoMessage("Nincs adat");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new frmAbout { MdiParent = this }).Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNapiZaras nz = new frmNapiZaras();
            //nz.MdiParent = this;
            nz.ShowDialog();
        }

        private void barSubItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSelejtez fa = new frmSelejtez();
            fa.MdiParent = this;
            fa.Show();
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




    }
}
