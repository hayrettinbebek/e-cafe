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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
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
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.mEGRENDELES_SORTableAdapter = new e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_SORTableAdapter();
            this.id = new DevExpress.XtraReports.Parameters.Parameter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.besz_ertek = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.Height = 32;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.PrintOnEmptyDataSource = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.DATUM", "")});
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Location = new System.Drawing.Point(43, 84);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Size = new System.Drawing.Size(424, 46);
            this.xrLabel3.StyleName = "DataField";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.SORSZAM", "")});
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.xrLabel4.Location = new System.Drawing.Point(488, 0);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Size = new System.Drawing.Size(318, 84);
            this.xrLabel4.StyleName = "DataField";
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            this.dsMegrendeles1.EnforceConstraints = false;
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
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.pageFooterBand1.Dpi = 254F;
            this.pageFooterBand1.Height = 84;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 254F;
            this.xrPageInfo1.Location = new System.Drawing.Point(15, 15);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.Size = new System.Drawing.Size(795, 58);
            this.xrPageInfo1.StyleName = "PageInfo";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Dpi = 254F;
            this.xrPageInfo2.Format = "Page {0} of {1}";
            this.xrPageInfo2.Location = new System.Drawing.Point(841, 15);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Size = new System.Drawing.Size(795, 58);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Dpi = 254F;
            this.reportHeaderBand1.Height = 36;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Location = new System.Drawing.Point(43, 0);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Size = new System.Drawing.Size(444, 84);
            this.xrLabel5.StyleName = "Title";
            this.xrLabel5.Text = "Megrendelés";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel12,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel2,
            this.xrLabel9,
            this.xrLabel15,
            this.xrLabel17,
            this.xrLabel19,
            this.xrLine1});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("MEGRENDELES_FEJ_ID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeader1.Height = 572;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrLabel12
            // 
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_PARTNER.P_NEV", "")});
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Location = new System.Drawing.Point(1059, 0);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.Size = new System.Drawing.Size(528, 64);
            this.xrLabel12.Text = "xrLabel12";
            // 
            // xrLabel14
            // 
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_PARTNER.P_NEV3", "")});
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.Location = new System.Drawing.Point(1059, 127);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.Size = new System.Drawing.Size(528, 64);
            this.xrLabel14.Text = "xrLabel14";
            // 
            // xrLabel13
            // 
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_PARTNER.P_NEV2", "")});
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.Location = new System.Drawing.Point(1059, 64);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.Size = new System.Drawing.Size(528, 64);
            this.xrLabel13.Text = "xrLabel13";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_PARTNER.IRSZ", "")});
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Location = new System.Drawing.Point(1059, 211);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.Size = new System.Drawing.Size(147, 64);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_PARTNER.VAROS", "")});
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Location = new System.Drawing.Point(1227, 211);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.Size = new System.Drawing.Size(361, 64);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_PARTNER.CIM", "")});
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Location = new System.Drawing.Point(1059, 274);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.Size = new System.Drawing.Size(528, 64);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Location = new System.Drawing.Point(615, 488);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.Size = new System.Drawing.Size(190, 64);
            this.xrLabel2.Text = "Mennyiség";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Location = new System.Drawing.Point(20, 488);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.Size = new System.Drawing.Size(572, 64);
            this.xrLabel9.Text = "Termék";
            // 
            // xrLabel15
            // 
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.Location = new System.Drawing.Point(826, 488);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.Size = new System.Drawing.Size(170, 64);
            this.xrLabel15.Text = "Me.";
            // 
            // xrLabel17
            // 
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.Location = new System.Drawing.Point(1016, 488);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.Size = new System.Drawing.Size(297, 64);
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Beszerzési egységár";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.Location = new System.Drawing.Point(1377, 488);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.Size = new System.Drawing.Size(254, 64);
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Érték";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // mEGRENDELES_SORTableAdapter
            // 
            this.mEGRENDELES_SORTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32;
            this.id.Value = 0;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupFooter1,
            this.Detail1});
            this.DetailReport.DataMember = "MEGRENDELES_FEJ.MEGRENDELES_FEJ_MEGRENDELES_SOR";
            this.DetailReport.DataSource = this.dsMegrendeles1;
            this.DetailReport.Dpi = 254F;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel1,
            this.xrLabel18});
            this.Detail1.Dpi = 254F;
            this.Detail1.Height = 74;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_SOR.MEGRENDELES_SOR_CIKK.MEGNEVEZES", "")});
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Location = new System.Drawing.Point(21, 0);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.Size = new System.Drawing.Size(572, 64);
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel11
            // 
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_MEGRENDELES_SOR.BESZ_AR", "")});
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Location = new System.Drawing.Point(1058, 0);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.Size = new System.Drawing.Size(254, 64);
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_MEGRENDELES_SOR.MENNYISEG", "")});
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Location = new System.Drawing.Point(614, 0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.Size = new System.Drawing.Size(190, 64);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLine1
            // 
            this.xrLine1.Dpi = 254F;
            this.xrLine1.LineWidth = 3;
            this.xrLine1.Location = new System.Drawing.Point(21, 564);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(1621, 5);
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.Height = 119;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // besz_ertek
            // 
            this.besz_ertek.DataMember = "MEGRENDELES_FEJ.MEGRENDELES_FEJ_MEGRENDELES_SOR";
            this.besz_ertek.DataSource = this.dsMegrendeles1;
            this.besz_ertek.Expression = "[BESZ_AR] * [MENNYISEG]";
            this.besz_ertek.Name = "besz_ertek";
            // 
            // xrLabel18
            // 
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_MEGRENDELES_SOR.besz_ertek", "")});
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.Location = new System.Drawing.Point(1376, 0);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel18.Size = new System.Drawing.Size(254, 64);
            this.xrLabel18.Text = "xrLabel18";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "MEGRENDELES_FEJ";
            this.calculatedField1.DataSource = this.dsMegrendeles1;
            this.calculatedField1.Name = "calculatedField1";
            // 
            // xrLabel16
            // 
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MEGRENDELES_FEJ.MEGRENDELES_FEJ_MEGRENDELES_SOR.besz_ertek", "")});
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.Location = new System.Drawing.Point(1376, 0);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel16.Size = new System.Drawing.Size(254, 64);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel16.Summary = xrSummary1;
            this.xrLabel16.Text = "xrLabel16";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xtraMegrendeles
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.GroupHeader1,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.DetailReport});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.besz_ertek,
            this.calculatedField1});
            this.DataAdapter = this.megrendeleS_FEJAdapter1;
            this.DataMember = "MEGRENDELES_FEJ";
            this.DataSource = this.dsMegrendeles1;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.id});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "9.2";
            this.PrintProgress += new DevExpress.XtraPrinting.PrintProgressEventHandler(this.xtraMegrendeles_PrintProgress);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xtraMegrendeles_BeforePrint);
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.xtraMegrendeles_ParametersRequestBeforeShow);
            this.ParametersRequestValueChanged += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs>(this.xtraMegrendeles_ParametersRequestValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
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
        private e_Cafe.dsMegrendelesTableAdapters.CIKKTableAdapter cikkTableAdapter;
        private e_Cafe.dsMegrendelesTableAdapters.PARTNERTableAdapter partnerTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.Parameters.Parameter id;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.CalculatedField besz_ertek;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;

    }
}
