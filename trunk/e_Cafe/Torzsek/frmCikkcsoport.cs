using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogic;
using DevExpress.XtraGrid.Views.Grid;
using e_Cafe.UserControls;


namespace e_Cafe
{
    public partial class frmCikkcsoport : UserForm
    {
        public frmCikkcsoport()
        {
            InitializeComponent();
            
            
        }
        GridView currentGrid;

        

        private void frmCikkcsoport_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'eCAFEDataSetAFA.AFA' table. You can move, or remove it, as needed.
            this.aFATableAdapter.Fill(this.eCAFEDataSetAFA.AFA);
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKKCSOPORT' table. You can move, or remove it, as needed.
            cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);
            // TODO: This line of code loads data into the 'eCAFEDataSet.CIKCSOP_OTHER_FILTER' table. You can move, or remove it, as needed.
            this.cIKCSOP_OTHER_FILTERTableAdapter.FillAlcsop(this.eCAFEDataSet.CIKCSOP_OTHER_FILTER);


        }

        public override void Save()
        {
            base.Save();
            //   eCAFEDataSet.AcceptChanges();
            
            cIKKCSOPORTBindingSource.EndEdit();
            cIKKCSOPORTBindingSource.MoveFirst();
            try
            {
                cIKKCSOPORTTableAdapter.Update(eCAFEDataSet);
                cIKCSOP_OTHER_FILTERTableAdapter.Update(eCAFEDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                DEFS.SendSaveErrMessage("A cikkcsoport használatban van kérem előbb törölje a hozzá tartozó cikkekből!");
                cIKKCSOPORTTableAdapter.Fill(this.eCAFEDataSet.CIKKCSOPORT);
                DEFS.ExLog(ex.StackTrace);
            }
        }

        private void cIKKCSOPORTBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DEFS.SendValidatingMessage("Megnevezés vagy Áfa", "A mező értéke nem lehet üres"+e.Exception.Message);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        public override void AddNew()
        {
            base.AddNew();
            if (currentGrid != null)
                currentGrid.AddNewRow();
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            currentGrid = gridView1;
        }

        private void gridView3_GotFocus(object sender, EventArgs e)
        {
            currentGrid = gridView3;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridView3.AddNewRow();
        }
    }
}
