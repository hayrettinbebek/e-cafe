using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using BusinessLogic;

namespace e_Cafe.Admin
{
    public partial class frmSyspar : Form
    {
        public frmSyspar()
        {
            InitializeComponent();
        }

        private void frmSyspar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSYSPAR.SYSPAR' table. You can move, or remove it, as needed.
            this.sYSPARTableAdapter.Fill(this.dsSYSPAR.SYSPAR);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sYSPARTableAdapter.Update(dsSYSPAR.SYSPAR);
            DEFS.R_SYSPAR = new SysParList();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Image imageHeader = new Bitmap(50, 50);
            Graphics img = Graphics.FromImage(imageHeader);
            img.DrawEllipse(Pens.Black, 0, 0, 45, 45);
            img.DrawString("LOGO", this.Font, Brushes.Black, new PointF(7, 16));
            img.Dispose();
            string textDocument;
            textDocument = "";
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < i; j++)
                    textDocument += " ";
                textDocument += "The quick brown fox jumps over the lazy dog\n";
            }
            SimpleReportPrinter printDocument = new SimpleReportPrinter(imageHeader, textDocument, this.Font);
            printDocument.Print(false);
        }
    }

    public class TextDispenser
    {
        int _start = 0;
        string _text = null;
        Font _fnt;
        public TextDispenser(string text, Font fnt)
        {
            _start = 0;
            _text = text;
            _fnt = fnt;
        }
        public bool DrawText(Graphics target, Graphics measurer, RectangleF r, Brush brsh)
        {
            if (r.Height < _fnt.Height)
                throw new ArgumentException("The rectangle is not tall enough to fit a single line of text inside.");
            int charsFit = 0;
            int linesFit = 0;
            int cut = 0;
            string temp = _text.Substring(_start);
            StringFormat format = new StringFormat(StringFormatFlags.FitBlackBox | StringFormatFlags.LineLimit);
            //measure how much of the string we can fit into the rectangle
            measurer.MeasureString(temp, _fnt, r.Size, format, out charsFit, out linesFit);
            cut = BreakText(temp, charsFit);
            if (cut != charsFit)
                temp = temp.Substring(0, cut);
            bool h = true;
            h &= true;
            target.DrawString(temp.Trim(' '), _fnt, brsh, r, format);
            _start += cut;
            if (_start == _text.Length)
            {
                _start = 0; //reset the location so we can repeat the document
                return true; //finished printing
            }
            else
                return false;
        }
        private static int BreakText(string text, int approx)
        {
            if (approx == 0)
                throw new ArgumentException();
            if (approx < text.Length)
            {
                //are we in the middle of a word?
                if (char.IsLetterOrDigit(text[approx]) && char.IsLetterOrDigit(text[approx - 1]))
                {
                    int temp = text.LastIndexOf(' ', approx, approx + 1);
                    if (temp >= 0)
                        return temp;
                }
            }
            return approx;
        }

    }
    public class SimpleReportPrinter
    {
        Image _header = null;
        string _text = null;
        int _pageNumber = 0;
        PrintDocument _prtdoc = null;
        TextDispenser _textDisp = null;
        public SimpleReportPrinter(Image header, string text, Font fnt)
        {
            _header = (Image)(header.Clone());
            _text = text;
            _prtdoc = new PrintDocument();
            _prtdoc.PrintPage += new PrintPageEventHandler(_prtdoc_PrintPage);
            _textDisp = new TextDispenser(_text, fnt);
        }
        public void Print(bool hardcopy)
        {
            //create a PrintDialog based on the PrintDocument
            PrintDialog pdlg = new PrintDialog();
            pdlg.Document = _prtdoc;
            //show the PrintDialog
            if (pdlg.ShowDialog() == DialogResult.OK)
            {
                //create a PageSetupDialog based on the PrintDocument and PrintDialog
                PageSetupDialog psd = new PageSetupDialog();
                psd.EnableMetric = true; //Ensure all dialog measurements are in metric
                psd.Document = pdlg.Document;
                //show the PageSetupDialog
                if (psd.ShowDialog() == DialogResult.OK)
                {
                    //apply the settings of both dialogs
                    _prtdoc.DefaultPageSettings = psd.PageSettings;
                    //decide what action to take
                    if (hardcopy)
                    {
                        //actually print hardcopy
                        _prtdoc.Print();
                    }
                    else
                    {
                        //preview onscreen instead
                        PrintPreviewDialog prvw = new PrintPreviewDialog();
                        prvw.Document = _prtdoc;
                        prvw.ShowDialog();
                    }
                }
            }
        }
        private void _prtdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.Clip = new Region(e.MarginBounds);
            //this method does all our printing work
            Single x = e.MarginBounds.Left;
            Single y = e.MarginBounds.Top;
            //draw the header image
            if (_pageNumber++ == 0)
            {
                e.Graphics.DrawImage(_header, x, y);
                y += _header.Height + 30;
            }
            RectangleF mainTextArea = RectangleF.FromLTRB(x, y, e.MarginBounds.Right, e.MarginBounds.Bottom);
            //draw the main part of the report
            if (_textDisp.DrawText(e.Graphics, e.PageSettings.PrinterSettings.CreateMeasurementGraphics(), mainTextArea, Brushes.Black))
            {
                e.HasMorePages = false; //the end has been reached
                _pageNumber = 0;
            }
            else
                e.HasMorePages = true;
            //watermark
            e.Graphics.TranslateTransform(200, 200);
            e.Graphics.RotateTransform(e.PageSettings.Landscape ? 30 : 60);
          //  e.Graphics.DrawString("CONFIDENTIAL", new Font("Courier New", 75, FontStyle.Bold), new SolidBrush(Color.FromArgb(64, Color.Black)), 0, 0);
        }

    }
}
