using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Design;
using BusinessLogic;


namespace GUI
{

    public partial class ucMemo : UserControl
    {
        public ucMemo()
        {
            InitializeComponent();
        }
    }

    //public class TransparentTextBox : TextBox
    //{
    //    PictureBox pictureBox = new PictureBox();

    //    public TransparentTextBox()
    //    {
    //        pictureBox.Dock = DockStyle.Fill;
    //        this.Controls.Add(pictureBox);
    //    }
    //    protected override void WndProc(ref Message m)
    //    {
    //        base.WndProc(ref m);
    //        switch (m.Msg)
    //        {
    //            case Win32.WM_PAINT:

    //                Bitmap bmpCaptured =
    //                  new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
    //                Bitmap bmpResult =
    //                  new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
    //                Rectangle r =
    //                  new Rectangle(0, 0, this.ClientRectangle.Width,
    //                  this.ClientRectangle.Height);

    //                CaptureWindow(this, ref bmpCaptured);
    //                this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    //                this.BackColor = Color.Transparent;

    //                ImageAttributes imgAttrib = new ImageAttributes();

    //                ColorMap[] colorMap = new ColorMap[1];

    //                colorMap[0] = new ColorMap();

    //                colorMap[0].OldColor = Color.White;

    //                colorMap[0].NewColor = Color.Transparent;

    //                imgAttrib.SetRemapTable(colorMap);

    //                Graphics g = Graphics.FromImage(bmpResult);

    //                g.DrawImage(bmpCaptured, r, 0, 0, this.ClientRectangle.Width,
    //                    this.ClientRectangle.Height, GraphicsUnit.Pixel, imgAttrib);

    //                g.Dispose();

    //                pictureBox.Image = (Image)bmpResult.Clone();
    //                break;


    //            case Win32.WM_HSCROLL:

    //            case Win32.WM_VSCROLL:

    //                this.Invalidate(); // repaint

    //                // if you use scrolling then add these two case statements


    //                break;
    //        }
    //    }

    //    private static void CaptureWindow(Control control, ref Bitmap bitmap)
    //    {
    //        Graphics g = Graphics.FromImage(bitmap);
    //        int i = (int)(Win32.PRF_CLIENT | Win32.PRF_ERASEBKGND);
    //        IntPtr iPtr = new IntPtr(14);
    //        IntPtr hdc = g.GetHdc();
    //        Win32.SendMessage(control.Handle, Win32.WM_PRINT, hdc, iPtr);
    //        g.ReleaseHdc(hdc);
    //        g.Dispose();
    //    }
    //}

    class TransparentControl : Control
    {
        public TransparentControl()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }

    class TransparentRichTextBox : RichTextBox
    {
        public TransparentRichTextBox()
        {
            base.ScrollBars = RichTextBoxScrollBars.None;
        }

        override protected CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        override protected void OnPaintBackground(PaintEventArgs e)
        {
        }
    }
}
