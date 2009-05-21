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
            //TextStyle.Normal.BackgroundBrush = Brushes.Beige;
            Szamla iSzamla = new Szamla(_SzamlaId);
            // Create a ReportBuilder object that assists with building a report
            ReportBuilder builder = new ReportBuilder(reportDocument);
            
            builder.CurrentDocument.DocumentUnit = GraphicsUnit.Millimeter;
            // Before adding sections, a layout must be started.  
            // We are using a linear layout - vertically, which means
            // each new section starts below the last one.
            builder.CurrentDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", DEFS.MMtoInch(75), DEFS.MMtoInch(150));
            builder.CurrentDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(DEFS.MMtoInch(1), DEFS.MMtoInch(1), DEFS.MMtoInch(1), DEFS.MMtoInch(1));
            builder.HorizLineMargins = 0.2f;

            builder.StartLinearLayout(Direction.Vertical);



            builder.AddPageHeader("ALL-IN Cafe", String.Empty, iSzamla.SZAMLA_DATUMA.ToShortDateString() + " " + iSzamla.SZAMLA_DATUMA.ToLongTimeString());

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

            builder.AddText("Blokk sorszáma:", TextStyle.Normal);
            builder.AddText(" ");

            #region sorok
            DataView dv = iSzamla.GetBlokkDataView();
            builder.DefaultTablePen = null;

            builder.AddTable(dv, true,100);
            
            builder.Table.InnerPenHeaderBottom = reportDocument.NormalPen;
            builder.Table.InnerPenRow = new Pen (Color.Gray, reportDocument.ThinPen.Width);
            builder.Table.OuterPenBottom = new Pen (Color.Gray, reportDocument.ThinPen.Width);

            builder.AddColumn(dv.Table.Columns[0],"Db.",8,false,false,HorizontalAlignment.Left);
            builder.AddColumn(dv.Table.Columns[1],"Termék",35,false,false,HorizontalAlignment.Left);
            builder.AddColumn(dv.Table.Columns[2],"Összeg",30,false,false,HorizontalAlignment.Right);

            //dt.Columns.Add(, typeof(int));
            //dt.Columns.Add("Cikk", typeof(string));
            //dt.Columns.Add("Összeg", typeof(double));


           // builder.AddAllColumns(30.0f, true, true);
            
            builder.CurrentSection.HorizontalAlignment = HorizontalAlignment.Left;

            
            
            #endregion

            #region végösszesen
            DataView dv2 = iSzamla.GetBlokkOsszegDataView();
            builder.DefaultTablePen = null;
            builder.AddTable(dv2, true, 100);
            
            builder.AddColumn(dv2.Table.Columns[0], " ", 50, false, false, HorizontalAlignment.Right);
            builder.AddColumn(dv2.Table.Columns[1], " ", 30, false, false, HorizontalAlignment.Right);


            #endregion

            builder.AddText(" ");
            for (int i = 0; i < 6; i++)
            {
                builder.AddText(DEFS.R_SYSPAR.GetStrValueFilterInt("BLOKK_LABLEC", i), TextStyle.Normal);
            }
            
            


            builder.FinishLinearLayout();

        }

        


    }
}
