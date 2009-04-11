using System;
using System.Collections.Generic;
using System.Drawing;
using ReportPrinting;
using System.Data;
using BusinessLogic;

namespace e_Cafe.Reports
{
    public class BlokkReport: IReportMaker
	{
        int _SzamlaId;

        public BlokkReport(int SzamlaId)
        {
            _SzamlaId = SzamlaId;
        }

		public void MakeDocument(ReportDocument reportDocument)
        {
            // Always reset the text styles if you have multiple methods that
            // set them
            TextStyle.ResetStyles();
            SectionBox box;
            LinearSections contents;
            TextStyle.Normal.BackgroundBrush = Brushes.Beige;
            Szamla iSzamla = new Szamla(_SzamlaId);
            // Create a ReportBuilder object that assists with building a report
            ReportBuilder builder = new ReportBuilder(reportDocument);
            
            builder.CurrentDocument.DocumentUnit = GraphicsUnit.Millimeter;
            // Before adding sections, a layout must be started.  
            // We are using a linear layout - vertically, which means
            // each new section starts below the last one.
            builder.CurrentDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", DEFS.MMtoInch(140), DEFS.MMtoInch(297));
            builder.CurrentDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(DEFS.MMtoInch(8), DEFS.MMtoInch(8), DEFS.MMtoInch(8), DEFS.MMtoInch(8));
            builder.HorizLineMargins = 0.2f;

            builder.StartLinearLayout(Direction.Vertical);



            builder.AddPageHeader("ALL-IN Cafe", String.Empty, DateTime.Now.ToLongTimeString());
            #region fejlec
            builder.StartLayeredLayout(false,false);
            builder.AddText("This page uses a layered approach");
            // Add various text sections in different headings

            box = new SectionBox();
            box.Width = 80;
            box.Height = 10;
            box.OffsetLeft = 0;
            box.OffsetTop = 0;

            //box.Border.
            box.Background = Brushes.Ivory;
            contents = new LinearSections();
            contents.AddSection(new SectionText("ALL-IN Cafe", TextStyle.Heading1));
            contents.AddSection(new SectionText(@"2120 Dunakeszi Rév utca 1/B", TextStyle.Normal));
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

            builder.AddText("Blokk sorszáma:", TextStyle.Normal);

            #region sorok
            DataView dv = iSzamla.GetBlokkDataView();

            builder.AddTable(dv, true);
            builder.AddAllColumns(30.0f, true, true);
            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Left;
            builder.CurrentSection.MarginRight = 0.1f;
            builder.CurrentSection.MarginTop = 0.1f;
            builder.CurrentSection.MarginLeft = 0.1f;

            builder.CurrentSection.MarginBottom = 0.1f;

            
            #endregion






            builder.FinishLinearLayout();

        }

        


    }
}
