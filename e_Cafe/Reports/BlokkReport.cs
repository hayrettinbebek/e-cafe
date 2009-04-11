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

		public void MakeDocument(ReportDocument reportDocument)
        {
            // Always reset the text styles if you have multiple methods that
            // set them
            TextStyle.ResetStyles();
            SectionBox box;
            LinearSections contents;

            // Create a ReportBuilder object that assists with building a report
            ReportBuilder builder = new ReportBuilder(reportDocument);
            builder.CurrentDocument.DocumentUnit = GraphicsUnit.Millimeter;
            // Before adding sections, a layout must be started.  
            // We are using a linear layout - vertically, which means
            // each new section starts below the last one.
            builder.CurrentDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", DEFS.MMtoInch(140), DEFS.MMtoInch(297));


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
            DataView dv = GetDataView();

            builder.AddTable(dv, true);
            builder.AddAllColumns(40.0f, true, true);
            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Center;
            builder.CurrentSection.MarginRight = 1.0f;
            builder.CurrentSection.MarginTop = 0.5f;
            builder.CurrentSection.MarginBottom = 0.2f;

            #endregion






            builder.FinishLinearLayout();

        }

        public static DataView GetDataView()
        {
            DataTable dt = new DataTable("People");
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Birthdate", typeof(DateTime));

            dt.Rows.Add(new Object[] { "Theodore", "Roosevelt", new DateTime(1858, 11, 27) });
            dt.Rows.Add(new Object[] { "Winston ", "Churchill", new DateTime(1874, 11, 30) });
            dt.Rows.Add(new Object[] { "Pablo", "Picasso", new DateTime(1881, 10, 25) });
            dt.Rows.Add(new Object[] { "Charlie", "Chaplin", new DateTime(1889, 4, 16) });
            dt.Rows.Add(new Object[] { "Steven", "Spielberg", new DateTime(1946, 12, 18) });
            dt.Rows.Add(new Object[] { "Bart", "Simpson", new DateTime(1987, 4, 19) });
            dt.Rows.Add(new Object[] { "Louis", "Armstrong", new DateTime(1901, 8, 4) });
            dt.Rows.Add(new Object[] { "Igor", "Stravinski", new DateTime(1882, 6, 17) });
            dt.Rows.Add(new Object[] { "Bill", "Gates", new DateTime(1955, 10, 28) });
            dt.Rows.Add(new Object[] { "Albert", "Einstein", new DateTime(1879, 3, 14) });
            dt.Rows.Add(new Object[] { "Marilyn", "Monroe", new DateTime(1927, 6, 1) });
            dt.Rows.Add(new Object[] { "Mother", "Teresa", new DateTime(1910, 8, 27) });

            DataView dv = dt.DefaultView;

            return dv;

        }


    }
}
