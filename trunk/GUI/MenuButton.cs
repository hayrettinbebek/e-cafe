using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BusinessLogic;

namespace GUI
{
    public class CikkcsopButton : System.Windows.Forms.Button
    {


        public Cikkcsoport _Cikkcsoport;
        
        public CikkcsopButton(Cikkcsoport aCcs)
        {
            _Cikkcsoport = aCcs;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }


     
    }

    public class HelyButton : System.Windows.Forms.Button
    {
        public Hely _Hely;
        public HelyButton(Hely aHely)
        {
            _Hely = aHely;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            //this.BackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            //Graphics g = e.Graphics;
            //Image ig = this.ImageList.Images[ImageIndex];


            ////// Initialize the rectangle where you want the Image
            ////Rectangle rimg = rect;
            //////rimg.X += rect.Right / 2 - 16;
            //////rimg.Y += rect.Bottom - 90;
            ////rimg.Width = ig.Width; //128;
            ////rimg.Height = ig.Height; //128

            ////this.Width = ig.Width; //128;
            ////this.Height = ig.Height; //128
            //// Draw the Image
            //g.DrawImage(ig, new Point(0, 0));
            ////Here you create your gradient brush
            ////LinearGradientBrush b = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.Red, LinearGradientMode.Vertical);
            ////g.FillRectangle(b, ClientRectangle);

        }

        

        //protected override void OnSizeChanged(EventArgs e)
        //{

        //    base.OnSizeChanged(e);
        //    Graphics g = CreateGraphics();
        //    //This line must be identical to the brush on OnPaint in terms of brush settings
        //    LinearGradientBrush b = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.Red, LinearGradientMode.Vertical);
        //    g.FillRectangle(b, this.ClientRectangle);
        //    for (int i = 0; i < Controls.Count; i++)
        //    {

        //        Controls[i].Refresh();

        //    }

        //}
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        protected override void OnMove(EventArgs e)
        {
            RecreateHandle();
        }
    }

    public class OtherFButton : System.Windows.Forms.Button
    {
        public OTF _OTF;
        public OtherFButton(OTF aOtf)
        {
            _OTF = aOtf;
        }
    }
}
