

namespace e_Cafe
{
    partial class frmCikkcsoport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOTHER_FILTER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOTHER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKKCSOPORT_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKTIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cIKKCSOPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSet = new e_Cafe.SQL.DataSets.ECAFEDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCIKKCSOPORT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKKCSOPORT_NEV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFA_KOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.aFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetAFA = new e_Cafe.SQL.DataSets.ECAFEDataSetAFA();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNEM_ELADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.eCAFEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetAFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aFATableAdapter = new e_Cafe.SQL.DataSets.ECAFEDataSetAFATableAdapters.AFATableAdapter();
            this.cIKKCSOPORTTableAdapter = new e_Cafe.SQL.DataSets.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter();
            this.cIKCSOPOTHERFILTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIKCSOP_OTHER_FILTERTableAdapter = new e_Cafe.SQL.DataSets.ECAFEDataSetTableAdapters.CIKCSOP_OTHER_FILTERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKCSOPOTHERFILTERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOTHER_FILTER_ID,
            this.colOTHER_NAME,
            this.colCIKKCSOPORT_ID1,
            this.colAKTIV});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowViewCaption = true;
            this.gridView3.PreviewFieldName = "OTHER_NAME";
            this.gridView3.ViewCaption = "Alcsoportok";
            this.gridView3.GotFocus += new System.EventHandler(this.gridView3_GotFocus);
            // 
            // colOTHER_FILTER_ID
            // 
            this.colOTHER_FILTER_ID.FieldName = "OTHER_FILTER_ID";
            this.colOTHER_FILTER_ID.Name = "colOTHER_FILTER_ID";
            this.colOTHER_FILTER_ID.OptionsColumn.ReadOnly = true;
            this.colOTHER_FILTER_ID.Width = 60;
            // 
            // colOTHER_NAME
            // 
            this.colOTHER_NAME.Caption = "Alcsoport Név";
            this.colOTHER_NAME.FieldName = "OTHER_NAME";
            this.colOTHER_NAME.Name = "colOTHER_NAME";
            this.colOTHER_NAME.Visible = true;
            this.colOTHER_NAME.VisibleIndex = 0;
            this.colOTHER_NAME.Width = 441;
            // 
            // colCIKKCSOPORT_ID1
            // 
            this.colCIKKCSOPORT_ID1.FieldName = "CIKKCSOPORT_ID";
            this.colCIKKCSOPORT_ID1.Name = "colCIKKCSOPORT_ID1";
            this.colCIKKCSOPORT_ID1.Visible = true;
            this.colCIKKCSOPORT_ID1.VisibleIndex = 1;
            this.colCIKKCSOPORT_ID1.Width = 120;
            // 
            // colAKTIV
            // 
            this.colAKTIV.Caption = "Aktív";
            this.colAKTIV.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colAKTIV.FieldName = "AKTIV";
            this.colAKTIV.Name = "colAKTIV";
            this.colAKTIV.Visible = true;
            this.colAKTIV.VisibleIndex = 2;
            this.colAKTIV.Width = 80;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cIKKCSOPORTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode1.RelationName = "CIKKCSOPORT_CIKCSOP_OTHER_FILTER";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(1075, 528);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            // 
            // cIKKCSOPORTBindingSource
            // 
            this.cIKKCSOPORTBindingSource.DataMember = "CIKKCSOPORT";
            this.cIKKCSOPORTBindingSource.DataSource = this.eCAFEDataSet;
            this.cIKKCSOPORTBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.cIKKCSOPORTBindingSource_DataError);
            // 
            // eCAFEDataSet
            // 
            this.eCAFEDataSet.DataSetName = "ECAFEDataSet";
            this.eCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCIKKCSOPORT_ID,
            this.colCIKKCSOPORT_NEV,
            this.colAFA_KOD,
            this.colNEM_ELADO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.GotFocus += new System.EventHandler(this.gridView1_GotFocus);
            // 
            // colCIKKCSOPORT_ID
            // 
            this.colCIKKCSOPORT_ID.FieldName = "CIKKCSOPORT_ID";
            this.colCIKKCSOPORT_ID.Name = "colCIKKCSOPORT_ID";
            this.colCIKKCSOPORT_ID.OptionsColumn.ReadOnly = true;
            // 
            // colCIKKCSOPORT_NEV
            // 
            this.colCIKKCSOPORT_NEV.Caption = "Cikkcsoport név";
            this.colCIKKCSOPORT_NEV.FieldName = "CIKKCSOPORT_NEV";
            this.colCIKKCSOPORT_NEV.Name = "colCIKKCSOPORT_NEV";
            this.colCIKKCSOPORT_NEV.Visible = true;
            this.colCIKKCSOPORT_NEV.VisibleIndex = 0;
            this.colCIKKCSOPORT_NEV.Width = 483;
            // 
            // colAFA_KOD
            // 
            this.colAFA_KOD.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colAFA_KOD.FieldName = "AFA_KOD";
            this.colAFA_KOD.Name = "colAFA_KOD";
            this.colAFA_KOD.Visible = true;
            this.colAFA_KOD.VisibleIndex = 1;
            this.colAFA_KOD.Width = 161;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.aFABindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "AFA_NEV";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "AFA_KOD";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // aFABindingSource
            // 
            this.aFABindingSource.DataMember = "AFA";
            this.aFABindingSource.DataSource = this.eCAFEDataSetAFA;
            // 
            // eCAFEDataSetAFA
            // 
            this.eCAFEDataSetAFA.DataSetName = "ECAFEDataSetAFA";
            this.eCAFEDataSetAFA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNEM_ELADO
            // 
            this.colNEM_ELADO.Caption = "Alapanyag";
            this.colNEM_ELADO.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colNEM_ELADO.FieldName = "NEM_ELADO";
            this.colNEM_ELADO.Name = "colNEM_ELADO";
            this.colNEM_ELADO.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNEM_ELADO.Visible = true;
            this.colNEM_ELADO.VisibleIndex = 2;
            this.colNEM_ELADO.Width = 80;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // eCAFEDataSetBindingSource
            // 
            this.eCAFEDataSetBindingSource.AllowNew = true;
            this.eCAFEDataSetBindingSource.DataSource = this.eCAFEDataSet;
            this.eCAFEDataSetBindingSource.Position = 0;
            // 
            // eCAFEDataSetAFABindingSource
            // 
            this.eCAFEDataSetAFABindingSource.DataSource = this.eCAFEDataSetAFA;
            this.eCAFEDataSetAFABindingSource.Position = 0;
            // 
            // aFATableAdapter
            // 
            this.aFATableAdapter.ClearBeforeFill = true;
            // 
            // cIKKCSOPORTTableAdapter
            // 
            this.cIKKCSOPORTTableAdapter.ClearBeforeFill = true;
            // 
            // cIKCSOPOTHERFILTERBindingSource
            // 
            this.cIKCSOPOTHERFILTERBindingSource.DataMember = "CIKCSOP_OTHER_FILTER";
            this.cIKCSOPOTHERFILTERBindingSource.DataSource = this.eCAFEDataSet;
            // 
            // cIKCSOP_OTHER_FILTERTableAdapter
            // 
            this.cIKCSOP_OTHER_FILTERTableAdapter.ClearBeforeFill = true;
            // 
            // frmCikkcsoport
            // 
            this._isEditForm = true;
            this._isInsertAndDelete = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 528);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmCikkcsoport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cikkcsoportok";
            this.Load += new System.EventHandler(this.frmCikkcsoport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKCSOPOTHERFILTERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private e_Cafe.SQL.DataSets.ECAFEDataSet eCAFEDataSet;
        private System.Windows.Forms.BindingSource cIKKCSOPORTBindingSource;
        private e_Cafe.SQL.DataSets.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter cIKKCSOPORTTableAdapter;
        private e_Cafe.SQL.DataSets.ECAFEDataSetAFA eCAFEDataSetAFA;
        private System.Windows.Forms.BindingSource eCAFEDataSetAFABindingSource;
        private System.Windows.Forms.BindingSource aFABindingSource;
        private e_Cafe.SQL.DataSets.ECAFEDataSetAFATableAdapters.AFATableAdapter aFATableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource eCAFEDataSetBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKKCSOPORT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKKCSOPORT_NEV;
        private DevExpress.XtraGrid.Columns.GridColumn colAFA_KOD;
        private DevExpress.XtraGrid.Columns.GridColumn colNEM_ELADO;
        private System.Windows.Forms.BindingSource cIKCSOPOTHERFILTERBindingSource;
        private e_Cafe.SQL.DataSets.ECAFEDataSetTableAdapters.CIKCSOP_OTHER_FILTERTableAdapter cIKCSOP_OTHER_FILTERTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colOTHER_FILTER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOTHER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKKCSOPORT_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colAKTIV;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}