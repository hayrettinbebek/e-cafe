using System;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.Admin;
using e_Cafe.Keszlet;
using e_Cafe.Torzsek;

namespace e_Cafe
{
    public partial class AdminTools : Form
    {
        
        public AdminTools()
        {
            InitializeComponent();
        }

        //public AdminTools(TBLObj bl)
        //{
        //    InitializeComponent();
        //    //admBlObj = bl;
        //}


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
            frmCikk ck = new frmCikk();
            ck.recept = 0;
            ck.aktiv = 1;
            ck.MdiParent = this;
            ck.Show();
        }

        private void asztalokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsztalSetup ck = new AsztalSetup();
            ck.MdiParent = this;
            ck.Show();
        }

        private void ttBevetelezes_Click(object sender, EventArgs e)
        {
            Bevetelezes f = new Bevetelezes();
            f.MdiParent = this;
            f.Show();
        }

        private void cikkcsoportokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áfaKódokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAFA f = new frmAFA();
            f.MdiParent = this;
            f.Show();
        }

        private void cikkcsoportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCikkcsoport f = new frmCikkcsoport();
            f.MdiParent = this;
            f.Show();
        }

        private void alcsoportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOtherFilter f = new frmOtherFilter();
            f.MdiParent = this;
            f.Show();
        }

        private void AdminTools_Load(object sender, EventArgs e)
        {

        }

        private void helyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelyek f = new frmHelyek();
            f.MdiParent = this;
            f.Show();
        }

        private void mmRaktar_Click(object sender, EventArgs e)
        {
            frmRaktar f = new frmRaktar();
            f.MdiParent = this;
            f.Show();
        }

        private void mmSzallitok_Click(object sender, EventArgs e)
        {
            frmSzallito f = new frmSzallito();
            f.MdiParent = this;
            f.Show();
        }

        private void adatbázisFrissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Egyeléőre csak kézzel lehet az update.bat paranccsal");
        }

        private void logokKüldéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] s = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory+ @"log");
            EmailSending x = new EmailSending();
            x.sendLogs(s);

            System.IO.Directory.Move(AppDomain.CurrentDomain.BaseDirectory + @"log", AppDomain.CurrentDomain.BaseDirectory + @"old_log"+ DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" +
                                                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second);


        }

        private void mmBevetel2_Click(object sender, EventArgs e)
        {
            frmBevetel f = new frmBevetel();
            f.MdiParent = this;
            f.Show();
        }

        private void mennyiségiEgységekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelyek f = new frmHelyek();
            f.MdiParent = this;
            f.Show();
        }

        private void felhasználókToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUser fu = new frmUser();
            fu.MdiParent = this;
            fu.Show();
        }

        private void készletÁtvezetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtvezetes fa = new frmAtvezetes();
            fa.MdiParent = this;
            fa.Show();
        }

        private void rendszerparaméterekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSyspar fa = new frmSyspar();
            fa.MdiParent = this;
            fa.Show();
        }

        private void mmNapiZaras_Click(object sender, EventArgs e)
        {
            frmNapiZaras nz = new frmNapiZaras();
            //nz.MdiParent = this;
            nz.ShowDialog();
            
        }

        private void blokkokVisszakereséseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmKimentBlokkok nz = new frmKimentBlokkok();
            nz.MdiParent = this;
            nz.Show();
        }

        private void receptekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCikk ck = new frmCikk();
            ck.recept = 1;
            ck.aktiv = 1;
            ck.MdiParent = this;
            ck.Show();
        }

        private void partnerTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartnerDelete pd = new frmPartnerDelete();
            pd.del = 1;
            pd.MdiParent = this;
            pd.Show();
        }

        private void töröltPartnerVisszaállításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartnerDelete pd = new frmPartnerDelete();
            pd.del = 0;
            pd.MdiParent = this;
            pd.Show();
        }

        private void inaktívCikkekKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCikk ck = new frmCikk();
            ck.recept = 0;
            ck.aktiv = 0;
            ck.MdiParent = this;
            ck.Show();
        }

        private void jogosultságokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRights rg = new frmRights();
            rg.MdiParent = this;
            rg.Show();
        }

        private void mmOsszevontLista_Click(object sender, EventArgs e)
        {
            frmOsszevontLista rg = new frmOsszevontLista();
            rg.MdiParent = this;
            rg.Show();
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

        private void készletkartonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selejtezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelejtez fa = new frmSelejtez();
            fa.MdiParent = this;
            fa.Show();
        }

        private void régiZárásokÁttekintéseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void újLeltárívToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeltarozas fl = new frmLeltarozas();
            fl.MdiParent = this;
            fl.Show();

        }

        private void meglévőLeltárFolytatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeltarSelect ls = new frmLeltarSelect();
            ls.MdiParent = this;
            ls.Show();
        }

        private void újMegrendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMegrendelesKeszites mr = new frmMegrendelesKeszites();
            mr.MdiParent = this;
            mr.Show();
        }





        private void archivumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMegrendelesArchivum fa = new frmMegrendelesArchivum();
            fa.LoadType = LoadTypes.archive;
            fa.ShowDialog();
        }

        private void selejtezésekVisszanézéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelejtezesInfo si = new frmSelejtezesInfo();
            si.ShowDialog();
        }

        private void mmMegrendelBeerkez_Click(object sender, EventArgs e)
        {
            frmMegrendelesArchivum fa = new frmMegrendelesArchivum();
            fa.LoadType = LoadTypes.select;
            fa.ShowDialog();
        }

        private void mmAltKedvezmeny_Click(object sender, EventArgs e)
        {
            frmAltKedvezm f = new frmAltKedvezm();
            f.MdiParent = this;
            f.Show();
        }




    }
}
