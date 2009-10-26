namespace e_Cafe.Admin
{
    partial class frmKimentBlokkok
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.advBandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCIKK_MEGNEVEZES = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMENNYISEG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEGYSEGAR = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNETTO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAFA_KOD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAFA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBRUTTO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKALK_MENNYISEG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKEDVEZMENY1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.eCafeSzamlakorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSZLA = new e_Cafe.SQL.DataSets.eCafe_Szamlakor();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSZAMLA_SORSZAM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSZAMLA_DATUMA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colP_NEV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colP_NEV2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOSSZESEN_NETTO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOSSZESEN_BRUTTO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNAP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSZAMLA_FEJ_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.button6 = new System.Windows.Forms.Button();
            this.szfTA = new e_Cafe.SQL.DataSets.eCafe_SzamlakorTableAdapters.SZAMLA_FEJTableAdapter();
            this.sztTA = new e_Cafe.SQL.DataSets.eCafe_SzamlakorTableAdapters.SZAMLA_TETELTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCafeSzamlakorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSZLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // advBandedGridView2
            // 
            this.advBandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.advBandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colCIKK_MEGNEVEZES,
            this.colMENNYISEG,
            this.colEGYSEGAR,
            this.colNETTO,
            this.colAFA,
            this.colBRUTTO,
            this.colAFA_KOD,
            this.colKALK_MENNYISEG,
            this.colKEDVEZMENY1});
            this.advBandedGridView2.GridControl = this.gridControl1;
            this.advBandedGridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETTO", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BRUTTO", null, "")});
            this.advBandedGridView2.Name = "advBandedGridView2";
            this.advBandedGridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.advBandedGridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.advBandedGridView2.OptionsBehavior.Editable = false;
            this.advBandedGridView2.OptionsDetail.EnableDetailToolTip = true;
            this.advBandedGridView2.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.advBandedGridView2.OptionsView.ShowFooter = true;
            this.advBandedGridView2.ViewCaption = "Tételek";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Tételek";
            this.gridBand2.Columns.Add(this.colCIKK_MEGNEVEZES);
            this.gridBand2.Columns.Add(this.colMENNYISEG);
            this.gridBand2.Columns.Add(this.colEGYSEGAR);
            this.gridBand2.Columns.Add(this.colNETTO);
            this.gridBand2.Columns.Add(this.colAFA_KOD);
            this.gridBand2.Columns.Add(this.colAFA);
            this.gridBand2.Columns.Add(this.colBRUTTO);
            this.gridBand2.Columns.Add(this.colKALK_MENNYISEG);
            this.gridBand2.Columns.Add(this.colKEDVEZMENY1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 715;
            // 
            // colCIKK_MEGNEVEZES
            // 
            this.colCIKK_MEGNEVEZES.Caption = "Cikk megnevezés";
            this.colCIKK_MEGNEVEZES.FieldName = "CIKK_MEGNEVEZES";
            this.colCIKK_MEGNEVEZES.Name = "colCIKK_MEGNEVEZES";
            this.colCIKK_MEGNEVEZES.Visible = true;
            this.colCIKK_MEGNEVEZES.Width = 189;
            // 
            // colMENNYISEG
            // 
            this.colMENNYISEG.Caption = "Mennyiség";
            this.colMENNYISEG.DisplayFormat.FormatString = "# ###";
            this.colMENNYISEG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMENNYISEG.FieldName = "MENNYISEG";
            this.colMENNYISEG.Name = "colMENNYISEG";
            this.colMENNYISEG.Visible = true;
            this.colMENNYISEG.Width = 85;
            // 
            // colEGYSEGAR
            // 
            this.colEGYSEGAR.Caption = "Egységár";
            this.colEGYSEGAR.DisplayFormat.FormatString = "c";
            this.colEGYSEGAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEGYSEGAR.FieldName = "EGYSEGAR";
            this.colEGYSEGAR.Name = "colEGYSEGAR";
            this.colEGYSEGAR.Visible = true;
            this.colEGYSEGAR.Width = 87;
            // 
            // colNETTO
            // 
            this.colNETTO.Caption = "Nettó";
            this.colNETTO.DisplayFormat.FormatString = "c";
            this.colNETTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNETTO.FieldName = "NETTO";
            this.colNETTO.Name = "colNETTO";
            this.colNETTO.SummaryItem.DisplayFormat = "Nettó={c}";
            this.colNETTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNETTO.Visible = true;
            this.colNETTO.Width = 100;
            // 
            // colAFA_KOD
            // 
            this.colAFA_KOD.Caption = "Áfa kód";
            this.colAFA_KOD.FieldName = "AFA_KOD";
            this.colAFA_KOD.Name = "colAFA_KOD";
            this.colAFA_KOD.Visible = true;
            this.colAFA_KOD.Width = 50;
            // 
            // colAFA
            // 
            this.colAFA.Caption = "Áfa";
            this.colAFA.DisplayFormat.FormatString = "c";
            this.colAFA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAFA.FieldName = "AFA";
            this.colAFA.Name = "colAFA";
            this.colAFA.Visible = true;
            this.colAFA.Width = 94;
            // 
            // colBRUTTO
            // 
            this.colBRUTTO.Caption = "Bruttó";
            this.colBRUTTO.DisplayFormat.FormatString = "c";
            this.colBRUTTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRUTTO.FieldName = "BRUTTO";
            this.colBRUTTO.Name = "colBRUTTO";
            this.colBRUTTO.SummaryItem.DisplayFormat = "Bruttó={c}";
            this.colBRUTTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colBRUTTO.Visible = true;
            this.colBRUTTO.Width = 110;
            // 
            // colKALK_MENNYISEG
            // 
            this.colKALK_MENNYISEG.FieldName = "KALK_MENNYISEG";
            this.colKALK_MENNYISEG.Name = "colKALK_MENNYISEG";
            this.colKALK_MENNYISEG.Width = 93;
            // 
            // colKEDVEZMENY1
            // 
            this.colKEDVEZMENY1.FieldName = "KEDVEZMENY";
            this.colKEDVEZMENY1.Name = "colKEDVEZMENY1";
            this.colKEDVEZMENY1.Width = 93;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "SZAMLA_FEJ";
            this.gridControl1.DataSource = this.eCafeSzamlakorBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            gridLevelNode2.LevelTemplate = this.advBandedGridView2;
            gridLevelNode2.RelationName = "SZAMLA_FEJ_SZAMLA_TETEL";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(892, 513);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.advBandedGridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // eCafeSzamlakorBindingSource
            // 
            this.eCafeSzamlakorBindingSource.DataSource = this.eSZLA;
            this.eCafeSzamlakorBindingSource.Position = 0;
            this.eCafeSzamlakorBindingSource.CurrentChanged += new System.EventHandler(this.eCafeSzamlakorBindingSource_CurrentChanged);
            // 
            // eSZLA
            // 
            this.eSZLA.DataSetName = "eCafe_Szamlakor";
            this.eSZLA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSZAMLA_DATUMA,
            this.colSZAMLA_SORSZAM,
            this.bandedGridColumn1,
            this.colEV,
            this.colHO,
            this.colNAP,
            this.colP_NEV,
            this.colP_NEV2,
            this.colOSSZESEN_NETTO,
            this.colOSSZESEN_BRUTTO,
            this.colSZAMLA_FEJ_ID});
            this.advBandedGridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1304, 540, 223, 236);
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.GroupCount = 1;
            this.advBandedGridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OSSZESEN_NETTO", null, "Nettó={c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OSSZESEN_BRUTTO", null, "Nettó={c2}")});
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.advBandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.advBandedGridView1.OptionsDetail.EnableDetailToolTip = true;
            this.advBandedGridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.bandedGridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.advBandedGridView1.ViewCaption = "Számlák";
            this.advBandedGridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.advBandedGridView1_RowClick);
            this.advBandedGridView1.Click += new System.EventHandler(this.advBandedGridView1_Click);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Számlák";
            this.gridBand1.Columns.Add(this.colSZAMLA_SORSZAM);
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.colSZAMLA_DATUMA);
            this.gridBand1.Columns.Add(this.colP_NEV);
            this.gridBand1.Columns.Add(this.colP_NEV2);
            this.gridBand1.Columns.Add(this.colOSSZESEN_NETTO);
            this.gridBand1.Columns.Add(this.colOSSZESEN_BRUTTO);
            this.gridBand1.Columns.Add(this.colEV);
            this.gridBand1.Columns.Add(this.colHO);
            this.gridBand1.Columns.Add(this.colNAP);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 827;
            // 
            // colSZAMLA_SORSZAM
            // 
            this.colSZAMLA_SORSZAM.Caption = "Sorszám";
            this.colSZAMLA_SORSZAM.FieldName = "SZAMLA_SORSZAM";
            this.colSZAMLA_SORSZAM.Name = "colSZAMLA_SORSZAM";
            this.colSZAMLA_SORSZAM.SummaryItem.DisplayFormat = "db={0}";
            this.colSZAMLA_SORSZAM.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colSZAMLA_SORSZAM.Visible = true;
            this.colSZAMLA_SORSZAM.Width = 83;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Könyvelési időszak";
            this.bandedGridColumn1.FieldName = "bandedGridColumn1";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.UnboundExpression = "ToStr([EV])+ToStr([HO])+ToStr([NAP])";
            this.bandedGridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 130;
            // 
            // colSZAMLA_DATUMA
            // 
            this.colSZAMLA_DATUMA.Caption = "Számla dátuma";
            this.colSZAMLA_DATUMA.FieldName = "SZAMLA_DATUMA";
            this.colSZAMLA_DATUMA.Name = "colSZAMLA_DATUMA";
            this.colSZAMLA_DATUMA.Visible = true;
            this.colSZAMLA_DATUMA.Width = 105;
            // 
            // colP_NEV
            // 
            this.colP_NEV.Caption = "Partner neve";
            this.colP_NEV.FieldName = "P_NEV";
            this.colP_NEV.Name = "colP_NEV";
            this.colP_NEV.Visible = true;
            this.colP_NEV.Width = 110;
            // 
            // colP_NEV2
            // 
            this.colP_NEV2.Caption = " ";
            this.colP_NEV2.FieldName = "P_NEV2";
            this.colP_NEV2.Name = "colP_NEV2";
            this.colP_NEV2.Visible = true;
            this.colP_NEV2.Width = 97;
            // 
            // colOSSZESEN_NETTO
            // 
            this.colOSSZESEN_NETTO.Caption = "Nettó végősszeg";
            this.colOSSZESEN_NETTO.DisplayFormat.FormatString = "c";
            this.colOSSZESEN_NETTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOSSZESEN_NETTO.FieldName = "OSSZESEN_NETTO";
            this.colOSSZESEN_NETTO.GroupFormat.FormatString = "c";
            this.colOSSZESEN_NETTO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOSSZESEN_NETTO.Name = "colOSSZESEN_NETTO";
            this.colOSSZESEN_NETTO.SummaryItem.DisplayFormat = "Nettó={c2}";
            this.colOSSZESEN_NETTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOSSZESEN_NETTO.Visible = true;
            this.colOSSZESEN_NETTO.Width = 142;
            // 
            // colOSSZESEN_BRUTTO
            // 
            this.colOSSZESEN_BRUTTO.Caption = "Bruttó végösszeg";
            this.colOSSZESEN_BRUTTO.DisplayFormat.FormatString = "c";
            this.colOSSZESEN_BRUTTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOSSZESEN_BRUTTO.FieldName = "OSSZESEN_BRUTTO";
            this.colOSSZESEN_BRUTTO.GroupFormat.FormatString = "c";
            this.colOSSZESEN_BRUTTO.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOSSZESEN_BRUTTO.Name = "colOSSZESEN_BRUTTO";
            this.colOSSZESEN_BRUTTO.SummaryItem.DisplayFormat = "Brutto={c2}";
            this.colOSSZESEN_BRUTTO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOSSZESEN_BRUTTO.Visible = true;
            this.colOSSZESEN_BRUTTO.Width = 160;
            // 
            // colEV
            // 
            this.colEV.Caption = "Év";
            this.colEV.FieldName = "EV";
            this.colEV.Name = "colEV";
            this.colEV.Width = 71;
            // 
            // colHO
            // 
            this.colHO.Caption = "Hónap";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Width = 71;
            // 
            // colNAP
            // 
            this.colNAP.Caption = "Nap";
            this.colNAP.FieldName = "NAP";
            this.colNAP.Name = "colNAP";
            this.colNAP.Width = 71;
            // 
            // colSZAMLA_FEJ_ID
            // 
            this.colSZAMLA_FEJ_ID.FieldName = "SZAMLA_FEJ_ID";
            this.colSZAMLA_FEJ_ID.Name = "colSZAMLA_FEJ_ID";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::e_Cafe.Properties.Resources.Printer_64x64;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(925, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // szfTA
            // 
            this.szfTA.ClearBeforeFill = true;
            // 
            // sztTA
            // 
            this.sztTA.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(897, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "labelControl1";
            // 
            // frmKimentBlokkok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 513);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKimentBlokkok";
            this.Text = "Értékseítések listája";
            this.Load += new System.EventHandler(this.frmKimentBlokkok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCafeSzamlakorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSZLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource eCafeSzamlakorBindingSource;
        private e_Cafe.SQL.DataSets.eCafe_SzamlakorTableAdapters.SZAMLA_FEJTableAdapter szfTA;
        private e_Cafe.SQL.DataSets.eCafe_Szamlakor eSZLA;
        private e_Cafe.SQL.DataSets.eCafe_SzamlakorTableAdapters.SZAMLA_TETELTableAdapter sztTA;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSZAMLA_DATUMA;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNAP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colP_NEV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colP_NEV2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSZAMLA_SORSZAM;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOSSZESEN_NETTO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOSSZESEN_BRUTTO;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCIKK_MEGNEVEZES;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAFA_KOD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKALK_MENNYISEG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKEDVEZMENY1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMENNYISEG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEGYSEGAR;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNETTO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAFA;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBRUTTO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSZAMLA_FEJ_ID;
    }
}