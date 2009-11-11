namespace e_Cafe.Reports
{
    partial class xtraMegrendeles
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.megrendeleS_FEJAdapter1 = new e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_FEJAdapter();
            this.cikkTableAdapter = new e_Cafe.dsMegrendelesTableAdapters.CIKKTableAdapter();
            this.partnerTableAdapter = new e_Cafe.dsMegrendelesTableAdapters.PARTNERTableAdapter();
            this.dsMegrendeles1 = new e_Cafe.dsMegrendeles();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.mEGRENDELES_SORTableAdapter = new e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_SORTableAdapter();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel1,
            this.xrLabel2});
            this.Detail.Height = 50;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.Location = new System.Drawing.Point(6, 3);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(638, 2);
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_SOR.MENNYISEG", "")});
            this.xrLabel1.Location = new System.Drawing.Point(233, 8);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(250, 25);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.DATUM", "")});
            this.xrLabel3.Location = new System.Drawing.Point(25, 0);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Size = new System.Drawing.Size(167, 18);
            this.xrLabel3.StyleName = "DataField";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.SORSZAM", "")});
            this.xrLabel4.Location = new System.Drawing.Point(242, 0);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Size = new System.Drawing.Size(308, 18);
            this.xrLabel4.StyleName = "DataField";
            // 
            // megrendeleS_FEJAdapter1
            // 
            this.megrendeleS_FEJAdapter1.ClearBeforeFill = true;
            // 
            // cikkTableAdapter
            // 
            this.cikkTableAdapter.ClearBeforeFill = true;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // dsMegrendeles1
            // 
            this.dsMegrendeles1.DataSetName = "dsMegrendeles";
            this.dsMegrendeles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.BorderColor = System.Drawing.SystemColors.ControlText;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.White;
            this.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.White;
            this.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.White;
            this.DataField.BorderColor = System.Drawing.SystemColors.ControlText;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.pageFooterBand1.Height = 33;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Location = new System.Drawing.Point(6, 6);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.Size = new System.Drawing.Size(313, 23);
            this.xrPageInfo1.StyleName = "PageInfo";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "Page {0} of {1}";
            this.xrPageInfo2.Location = new System.Drawing.Point(331, 6);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Size = new System.Drawing.Size(313, 23);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
            this.reportHeaderBand1.Height = 58;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Location = new System.Drawing.Point(58, 25);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Size = new System.Drawing.Size(227, 33);
            this.xrLabel5.StyleName = "Title";
            this.xrLabel5.Text = "Megrendelés";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel6});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("MEGRENDELES_FEJ_ID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.Height = 36;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PARTNER.P_NEV", "")});
            this.xrLabel6.Location = new System.Drawing.Point(575, 8);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.Size = new System.Drawing.Size(100, 25);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // mEGRENDELES_SORTableAdapter
            // 
            this.mEGRENDELES_SORTableAdapter.ClearBeforeFill = true;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CIKK.MEGNEVEZES", "")});
            this.xrLabel2.Location = new System.Drawing.Point(50, 17);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.Size = new System.Drawing.Size(100, 25);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xtraMegrendeles
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.GroupHeader1});
            this.DataAdapter = this.megrendeleS_FEJAdapter1;
            this.DataSource = this.dsMegrendeles1;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "9.2";
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_FEJAdapter megrendeleS_FEJAdapter1;
        private dsMegrendeles dsMegrendeles1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_SORTableAdapter mEGRENDELES_SORTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private e_Cafe.dsMegrendelesTableAdapters.CIKKTableAdapter cikkTableAdapter;
        private e_Cafe.dsMegrendelesTableAdapters.PARTNERTableAdapter partnerTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;

    }
}
