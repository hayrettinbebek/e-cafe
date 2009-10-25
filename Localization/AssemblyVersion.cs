#if DXCommon
public class AssemblyInfo {
#else
namespace DevExpress.Internal {
	internal class AssemblyInfo {
#endif
    public const string AssemblyCopyright = "Copyright (c) 2000-2009 Developer Express Inc.";
    public const string AssemblyCompany = "Developer Express Inc.";

    internal const int VersionId = 92;
    public const string VersionShort = "9.2";
    public const string Version = VersionShort + ".0.0";
    public const string FileVersion = Version;
    public const string MarketingVersion = "v2009 vol 2";
    public const string VirtDirSuffix = "_v9_2";

    public const string SatelliteContractVersion = VersionShort + ".0.0";
    public const string VSuffixWithoutSeparator = "v" + VersionShort;
    public const string VSuffix = "." + VSuffixWithoutSeparator;
    public const string VSuffixDesign = VSuffix + ".Design";
    public const string SRDocumentationLink = "ms-help://DevExpress.NET" + VSuffixWithoutSeparator + "/";
    public const string InstallationRegistryKey = "SOFTWARE\\DevExpress\\Components\\" + VSuffixWithoutSeparator;
    public const string InstallationRegistryRootPathValueName = "RootDirectory";
#if !SILVERLIGHT
    public const string
        SRAssemblyExpressAppWeb = "DevExpress.ExpressApp.Web" + VSuffix,
        SRAssemblyASPxThemes = "DevExpress.Web.ASPxThemes" + VSuffix,
        SRAssemblyASPxGridView = "DevExpress.Web.ASPxGridView" + VSuffix,
        SRAssemblyASPxPivotGrid = "DevExpress.Web.ASPxPivotGrid" + VSuffix,
        SRAssemblyData = "DevExpress.Data" + VSuffix,
        SRAssemblyUtils = "DevExpress.Utils" + VSuffix,
        SRAssemblyPrinting = "DevExpress.XtraPrinting" + VSuffix,
        SRAssemblyPrintingCore = "DevExpress.Printing" + VSuffix + ".Core",
        SRAssemblyPrintingDesign = "DevExpress.XtraPrinting" + VSuffixDesign,
        SRAssemblyEditors = "DevExpress.XtraEditors" + VSuffix,
        SRAssemblyEditorsDesign = "DevExpress.XtraEditors" + VSuffixDesign,
        SRAssemblyNavBar = "DevExpress.XtraNavBar" + VSuffix,
        SRAssemblyNavBarDesign = "DevExpress.XtraNavBar" + VSuffixDesign,
        SRAssemblyBars = "DevExpress.XtraBars" + VSuffix,
        SRAssemblyBarsDesign = "DevExpress.XtraBars" + VSuffixDesign,
        SRAssemblyGrid = "DevExpress.XtraGrid" + VSuffix,
        SRAssemblyGaugesCore = "DevExpress.XtraGauges" + VSuffix + ".Core",
        SRAssemblyGaugesPresets = "DevExpress.XtraGauges" + VSuffix + ".Presets",
        SRAssemblyGaugesWin = "DevExpress.XtraGauges" + VSuffix + ".Win",
        SRAssemblyASPxGauges = "DevExpress.Web.ASPxGauges" + VSuffix,
        SRAssemblyGaugesDesignWin = "DevExpress.XtraGauges" + VSuffixDesign + ".Win",
        SRAssemblyGridDesign = "DevExpress.XtraGrid" + VSuffixDesign,
        SRAssemblyPivotGrid = "DevExpress.XtraPivotGrid" + VSuffix,
        SRAssemblyPivotGridCore = "DevExpress.XtraPivotGrid" + VSuffix + ".Core",
        SRAssemblyPivotGridDesign = "DevExpress.XtraPivotGrid" + VSuffixDesign,
        SRAssemblyTreeList = "DevExpress.XtraTreeList" + VSuffix,
        SRAssemblyTreeListDesign = "DevExpress.XtraTreeList" + VSuffixDesign,
        SRAssemblyVertGrid = "DevExpress.XtraVerticalGrid" + VSuffix,
        SRAssemblyVertGridDesign = "DevExpress.XtraVerticalGrid" + VSuffixDesign,
        SRAssemblyReports = "DevExpress.XtraReports" + VSuffix,
        SRAssemblyReportsDesign = "DevExpress.XtraReports" + VSuffixDesign,
        SRAssemblyReportsImport = "DevExpress.XtraReports" + VSuffix + ".Import",
        SRAssemblyReportsWeb = "DevExpress.XtraReports" + VSuffix + ".Web",
        SRAssemblyReportsDesignDelphi8 = "DevExpress.XtraReports" + VSuffix + ".Design.Delphi8",
        SRAssemblyReportsDesignDelphi9 = "DevExpress.XtraReports" + VSuffix + ".Design.Delphi9",
        SRAssemblyReportsDesignDelphi10 = "DevExpress.XtraReports" + VSuffix + ".Design.Delphi10",
        SRAssemblyRichEdit = "DevExpress.XtraRichEdit" + VSuffix,
        SRAssemblyRichEditDesign = "DevExpress.XtraRichEdit" + VSuffixDesign,
        SRAssemblyRichEditExtensions = "DevExpress.XtraRichEdit" + VSuffix + ".Extensions",
        SRAssemblyRichEditPrinting = "DevExpress.XtraRichEdit" + VSuffix + ".Printing",
        SRAssemblyScheduler = "DevExpress.XtraScheduler" + VSuffix,
        SRAssemblySchedulerCore = "DevExpress.XtraScheduler" + VSuffix + ".Core",
        SRAssemblySchedulerDesign = "DevExpress.XtraScheduler" + VSuffixDesign,
        SRAssemblySchedulerWeb = "DevExpress.Web.ASPxScheduler" + VSuffix,
        SRAssemblySchedulerWebDesign = "DevExpress.Web.ASPxScheduler" + VSuffixDesign,
        SRAssemblySchedulerOutlookExchange = "DevExpress.XtraScheduler" + VSuffix + ".OutlookExchange",
        SRAssemblySchedulerVCalendarExchange = "DevExpress.XtraScheduler" + VSuffix + ".VCalendarExchange",
        SRAssemblyScheduleriCalendarExchange = "DevExpress.XtraScheduler" + VSuffix + ".iCalendarExchange",
        SRAssemblySchedulerExtensions = "DevExpress.XtraScheduler" + VSuffix + ".Extensions",
        SRAssemblySchedulerReporting = "DevExpress.XtraScheduler" + VSuffix + ".Reporting",
        SRAssemblyChartsCore = "DevExpress.Charts" + VSuffix + ".Core",
        SRAssemblyCharts = "DevExpress.XtraCharts" + VSuffix,
        SRAssemblyChartsDesign = "DevExpress.XtraCharts" + VSuffixDesign,
        SRAssemblyChartsWebDesign = "DevExpress.XtraCharts" + VSuffix + ".Web.Design",
        SRAssemblyChartsUI = "DevExpress.XtraCharts" + VSuffix + ".UI",
        SRAssemblyChartsWeb = "DevExpress.XtraCharts" + VSuffix + ".Web",
        SRAssemblyWizard = "DevExpress.XtraWizard" + VSuffix,
        SRAssemblyXpo = "DevExpress.Xpo" + VSuffix,
        SRAssemblyXpoDesign = "DevExpress.Xpo" + VSuffixDesign,
        SRAssemblyLayoutControl = "DevExpress.XtraLayout" + VSuffix,
        SRAssemblyLayoutControlDesign = "DevExpress.XtraLayout" + VSuffixDesign,
        SRAssemblySpellCheckerCore = "DevExpress.XtraSpellChecker" + VSuffix + ".Core",
        SRAssemblySpellChecker = "DevExpress.XtraSpellChecker" + VSuffix,
        SRAssemblySpellCheckerDesign = "DevExpress.XtraSpellChecker" + VSuffixDesign,
        SRAssemblySpellCheckerWeb = "DevExpress.Web.ASPxSpellChecker" + VSuffix,
        SRAssemblyWeb = "DevExpress.Web" + VSuffix,
        SRAssemblyHtmlEditorWeb = "DevExpress.Web.ASPxHtmlEditor" + VSuffix,
        SRAssemblyEditorsWeb = "DevExpress.Web.ASPxEditors" + VSuffix,
        SRAssemblyTreeListWeb = "DevExpress.Web.ASPxTreeList" + VSuffix,
        SRAssemblyDXCharts = "DevExpress.Wpf.Charts" + VSuffix,
        SRAssemblyWpfPrinting = "DevExpress.Wpf.Printing" + VSuffix;
    public const string
        DXTabComponents = "DX." + VersionShort + ": Components",
        DXTabNavigation = "DX." + VersionShort + ": Navigation & Layout",
        DXTabReporting = "DX." + VersionShort + ": Reporting",
        DXTabReportControls = "DX." + VersionShort + ": Report Controls",
        DXTabData = "DX." + VersionShort + ": Data",
        DXTabScheduling = "DX." + VersionShort + ": Scheduling",
        DXTabSchedulerReporting = "DX." + VersionShort + ": Scheduler Reporting",
        DXTabRichEdit = "DX." + VersionShort + ": Rich Text Editor",
        DXTabCommon = "DX." + VersionShort + ": Common Controls",

        DXTabWpfNavigation = "DX." + VersionShort + ".WPF" + ": Navigation & Layout",
        DXTabWpfReporting = "DX." + VersionShort + ".WPF" + ": Reporting",
        DXTabWpfData = "DX." + VersionShort + ".WPF" + ": Data",
        DXTabWpfCommon = "DX." + VersionShort + ".WPF" + ": Common Controls";
#endif
    }
#if !DXCommon
}
#endif