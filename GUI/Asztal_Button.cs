namespace GUI
{
    using System.Runtime.InteropServices;
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using BusinessLogic;

    public enum  Asztal_colors : int
    {
        Selected = 1, // az éppen kiválasztottat mutatja
        Free = 0, //szabad nincs hozzá foglalás és rendelés
        used = 3, // ülnek ott és van rendelésük
        reserved = 4 // foglalás vn az asztalra
    }

    public class Asztal_Button : System.Windows.Forms.ButtonBase
    {
        // Import the CreateRoundRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        // Import the CreateRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRectRgn")]
        private static extern int CreateRectRgn(int x1, int y1, int x2, int y2);

        // Import the SetWindowRgn function from the user32.DLL
        // From the Unmanaged Code
        [DllImport("user32.DLL", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(int hWnd, int hRgn, int bRedraw);


        Font f1 = new System.Drawing.Font("System", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f3 = new System.Drawing.Font("Courier", 10F, System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

        int rg;
        int hdl;

        private int _Asztal_id;
        private int _Asztal_type;
        private bool _Selected;
        private int _Free;
        private bool _MouseOver;

        public int Asztal_id
        {
            get { return _Asztal_id;}
            set { _Asztal_id = value; }
        }

        public int Asztal_type
        {
            get { return _Asztal_type; }
            set { _Asztal_type = value; }
        }
        public bool vSelected
        {
            get { return _Selected; }
            set { _Selected = value; }
        }

        public Asztal_Button()
        {
            _Asztal_id = -1;
            _Selected = false;
            _Free = 1;
            _MouseOver = false;
        }

        public Asztal_Button(int aId)
        {
            _Asztal_id = aId;
            _Selected = false;
            _Free = 1;
            _MouseOver = false;
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            // Override the MouseDown function to set a new image
            // Display Image No 1 from ButtonImageList when mouse is clicked on the button
            //_Selected = 1;
            //Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            // Override the MouseLeave function to set a new image
            // Display Image No 2 from ButtonImageList when mouse leaves the button

            Invalidate();
            _MouseOver = false;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            // Override the MouseEnter function to set a new image
            // Display Image No 0 from ButtonImageList when mouse enters the button area
            Invalidate();
            _MouseOver = true;
            
        }

        public void Init()
        {
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left + 10, rect.Top + 10, rect.Right, rect.Bottom, 50, 70);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Override this function, since we do not want the control
            // to paint the button. We want to do all the painting ourselves

            // Get the Graphics Object ( .aka. the CDC or the Device Context Object ) 
            Graphics g = e.Graphics;

            // Get the Bounding Rectnalge for the button
            Rectangle rect = e.ClipRectangle;

            if (_Selected ) { ImageIndex = (int)Asztal_colors.Selected; }
            else if (_Free == 1)
            {
                ImageIndex = (int)Asztal_colors.Free;
            }


            // Paint the rectangle with the color you want
            //g.FillRectangle(new SolidBrush(Color.FromArgb(127, 255, 255, 255)), rect);
            if (_MouseOver) { g.FillRectangle(new SolidBrush(DEFS.Selected_Color), rect); }
            else
            {
                g.FillRectangle(new SolidBrush(DEFS.Asztal_hatter), rect);
            }
            
           // rect.Inflate(5, 5);

            // Define a StringFormat Object to display the string in your custom format
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            // Get the current Image that we have set depending on the location of 
            // mouse on the contol.  Refer to the OnMouseDown,OnMouseEnter,OnMouseLeave events
            if (this.ImageList != null)
            {
                if (ImageIndex >= 0)
                {
                    Image ig = RotateImage(this.ImageList.Images[ImageIndex],0);


                    // Initialize the rectangle where you want the Image
                    Rectangle rimg = rect;
                    //rimg.X += rect.Right / 2 - 16;
                    //rimg.Y += rect.Bottom - 90;
                    rimg.Width = ig.Width; //128;
                    rimg.Height = ig.Height; //128

                    this.Width = ig.Width; //128;
                    this.Height = ig.Height; //128
                    // Draw the Image
                    g.DrawImage(ig, rimg, 0, 0, ig.Width, ig.Height, GraphicsUnit.Pixel);

                }
            }

            // Draw the String in the rectngle region you want
            //rect.Y = rect.Bottom - 75;
            g.DrawString(Text, f1, new SolidBrush(Color.Black), rect, sf);
            
        }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
    }

    public class e_TextBox : System.Windows.Forms.TextBox
    {
        private string _eFieldName;

        public string eFieldName
        {
            get { return _eFieldName; }
            set { _eFieldName = value; }
        }

        public e_TextBox()
        {
        }
    }
}
