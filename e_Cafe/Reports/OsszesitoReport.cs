using System;
using System.Collections.Generic;
using System.Drawing;
using ReportPrinting;
using System.Data;
using BusinessLogic;

namespace e_Cafe.Reports
{
    public class OsszesitoReport: IReportMaker
	{
        int _EV;
        int _HO;
        int _NAP;

        public OsszesitoReport(int pEV, int pHO, int pNAP)
        {
            _EV = pEV;
            _HO = pHO;
            _NAP = pNAP;
        }

		public void MakeDocument(ReportDocument reportDocument)
        {
            // Always reset the text styles if you have multiple methods that
            // set them
            TextStyle.ResetStyles();
            SectionBox box;
            LinearSections contents;
            //TextStyle.Normal.BackgroundBrush = Brushes.Beige;
            
            //Szamla iSzamla = new Szamla(_SzamlaId);

            // Create a ReportBuilder object that assists with building a report
            ReportBuilder builder = new ReportBuilder(reportDocument);
            
            builder.CurrentDocument.DocumentUnit = GraphicsUnit.Millimeter;
            // Before adding sections, a layout must be started.  
            // We are using a linear layout - vertically, which means
            // each new section starts below the last one.
            builder.CurrentDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", DEFS.MMtoInch(210), DEFS.MMtoInch(297));

            builder.CurrentDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(DEFS.MMtoInch(8), DEFS.MMtoInch(8), DEFS.MMtoInch(8), DEFS.MMtoInch(8));
            builder.HorizLineMargins = 0.2f;

            builder.StartLinearLayout(Direction.Vertical);



            builder.AddPageHeader("ALL-IN Cafe", String.Empty, DateTime.Now.ToLongDateString());

            #region fejlec
            builder.StartLayeredLayout(false,false);
            
            // Add various text sections in different headings

            box = new SectionBox();
            box.Width = 80;
            box.Height = 10;
            box.OffsetLeft = 0;
            box.OffsetTop = 0;

            //box.Border.
            //box.Background = Brushes.Ivory;
            contents = new LinearSections();
            contents.AddSection(new SectionText(DEFS.R_SYSPAR.GetStrValue("CEG_NEV"), TextStyle.Heading1));
            contents.AddSection(new SectionText(DEFS.R_SYSPAR.GetStrValue("CEG_CIM"), TextStyle.Normal));
            box.AddSection(contents);
            builder.AddSection(box);

            // Logo
            box = new SectionBox();
            box.Width = 40;
            box.Height = 10;
            box.OffsetLeft = 80;
            box.OffsetTop = 0;
            box.HorizontalAlignment = HorizontalAlignment.Center;
            // box.VerticalAlignment = VerticalAlignment.Bottom;
            //box.Border = reportDocument.NormalPen;
            SectionImage image = new SectionImage(global::GUI.Properties.Resources.logo);
            //image.Transparency = 50;
            //image.PreserveAspectRatio = false;
            box.AddSection(image);
            builder.AddSection(box);

            // Finish a layout that we started
            // builder.FinishLayeredLayout();
            // 
            builder.FinishLayeredLayout();
            #endregion

            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText("Napi összesített eladás statisztika");

            #region Összes eladás
            DataView dv = ReportData.GetOsszesEladas(DEFS.NyitNap_EV,DEFS.NyitNap_HO,DEFS.NyitNap_NAP);
            builder.DefaultTablePen = null;

            builder.AddTable(dv, true, 100);

            builder.Table.InnerPenHeaderBottom = reportDocument.NormalPen;
            builder.Table.InnerPenRow = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            builder.Table.OuterPenBottom = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            // 210 széles lehet.
            builder.AddColumn(dv.Table.Columns[0], "Összes eladás db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[1], "Összes eladás értéke", 40, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[2], "Hitelre írt db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[3], "Hitelre írás értéke", 40, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[4], "Kifizetett hitel db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[5], "Kifizetett hitelek értéke", 40, false, false, HorizontalAlignment.Right);


            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Left;

            #endregion

            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText("Cikkcsoportonkénti összesített napi statisztika");

            #region Cikkcsoportonkénti összesítő
            dv = ReportData.GetCikkcsopOsszesEladas(DEFS.NyitNap_EV, DEFS.NyitNap_HO, DEFS.NyitNap_NAP);
            builder.DefaultTablePen = null;

            builder.AddTable(dv, true, 100);

            builder.Table.InnerPenHeaderBottom = reportDocument.NormalPen;
            builder.Table.InnerPenRow = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            builder.Table.OuterPenBottom = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            // 210 széles lehet.
            builder.AddColumn(dv.Table.Columns[0], "Cikkcsoport", 30, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[1], "Összes eladás db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[2], "Összes eladás értéke", 30, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[3], "Hitelre írt db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[4], "Hitelre írás értéke", 30, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[5], "Kifizetett hitel db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[6], "Kifizetett hitelek értéke", 30, false, false, HorizontalAlignment.Right);


            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Left;


            #endregion
            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText("Speciális zárás statisztika");

            #region Speciális zárás összesítő
            dv = ReportData.GetSpecZarasEladas(DEFS.NyitNap_EV, DEFS.NyitNap_HO, DEFS.NyitNap_NAP);
            builder.DefaultTablePen = null;

            builder.AddTable(dv, true, 100);

            builder.Table.InnerPenHeaderBottom = reportDocument.NormalPen;
            builder.Table.InnerPenRow = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            builder.Table.OuterPenBottom = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            // 210 széles lehet.
            builder.AddColumn(dv.Table.Columns[0], "Cikkcsoport", 30, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[1], "Összes eladás db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[2], "Összes eladás értéke", 30, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[3], "Hitelre írt db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[4], "Hitelre írás értéke", 30, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[5], "Kifizetett hitel db", 20, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[6], "Kifizetett hitelek értéke", 30, false, false, HorizontalAlignment.Right);


            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Left;


            #endregion

            builder.AddText(" ");


            builder.FinishLinearLayout();

        }

        


    }

    public class LeltarIv : IReportMaker
    {
        int _fej;


        public LeltarIv(int lelt_fej_id)
        {
            _fej = lelt_fej_id;
        }

        public void MakeDocument(ReportDocument reportDocument)
        {
            // Always reset the text styles if you have multiple methods that
            // set them
            TextStyle.ResetStyles();
            SectionBox box;
            LinearSections contents;
            //TextStyle.Normal.BackgroundBrush = Brushes.Beige;

            //Szamla iSzamla = new Szamla(_SzamlaId);

            // Create a ReportBuilder object that assists with building a report
            ReportBuilder builder = new ReportBuilder(reportDocument);

            builder.CurrentDocument.DocumentUnit = GraphicsUnit.Millimeter;
            // Before adding sections, a layout must be started.  
            // We are using a linear layout - vertically, which means
            // each new section starts below the last one.
            builder.CurrentDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", DEFS.MMtoInch(210), DEFS.MMtoInch(297));

            builder.CurrentDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(DEFS.MMtoInch(8), DEFS.MMtoInch(8), DEFS.MMtoInch(8), DEFS.MMtoInch(8));
            builder.HorizLineMargins = 0.2f;

            builder.StartLinearLayout(Direction.Vertical);



            builder.AddPageHeader("ALL-IN Cafe", String.Empty, DateTime.Now.ToLongDateString());

            #region fejlec
            builder.StartLayeredLayout(false, false);

            // Add various text sections in different headings

            box = new SectionBox();
            box.Width = 80;
            box.Height = 10;
            box.OffsetLeft = 0;
            box.OffsetTop = 0;

            //box.Border.
            //box.Background = Brushes.Ivory;
            contents = new LinearSections();
            contents.AddSection(new SectionText(DEFS.R_SYSPAR.GetStrValue("CEG_NEV"), TextStyle.Heading1));
            contents.AddSection(new SectionText(DEFS.R_SYSPAR.GetStrValue("CEG_CIM"), TextStyle.Normal));
            box.AddSection(contents);
            builder.AddSection(box);

            // Logo
            box = new SectionBox();
            box.Width = 40;
            box.Height = 10;
            box.OffsetLeft = 80;
            box.OffsetTop = 0;
            box.HorizontalAlignment = HorizontalAlignment.Center;
            // box.VerticalAlignment = VerticalAlignment.Bottom;
            //box.Border = reportDocument.NormalPen;
            SectionImage image = new SectionImage(global::GUI.Properties.Resources.logo);
            //image.Transparency = 50;
            //image.PreserveAspectRatio = false;
            box.AddSection(image);
            builder.AddSection(box);

            // Finish a layout that we started
            // builder.FinishLayeredLayout();
            // 
            builder.FinishLayeredLayout();
            #endregion

            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText(" ");
            builder.AddText("Leltározási ív");

            #region Összes eladás
            DataView dv = ReportData.getLeltarIv(_fej);
            builder.DefaultTablePen = null;

            builder.AddTable(dv, true, 100);

            builder.Table.InnerPenHeaderBottom = reportDocument.NormalPen;
            builder.Table.InnerPenRow = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            
            builder.Table.OuterPenBottom = new Pen(Color.Gray, reportDocument.ThinPen.Width);
            builder.Table.DetailRowTextStyle.SizeDelta = 10;
            // 210 széles lehet.
            builder.AddColumn(dv.Table.Columns[0], "Cikk", 90, false, false, HorizontalAlignment.Left);
            builder.AddColumn(dv.Table.Columns[1], "Készlet mennyisége", 40, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv.Table.Columns[2], "Számolt mennyiség", 50, false, false, HorizontalAlignment.Right);
            


            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Left;

            #endregion



            builder.FinishLinearLayout();

        }




    }
}
