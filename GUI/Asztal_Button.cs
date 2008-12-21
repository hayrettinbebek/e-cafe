namespace GUI
{
    using System.Runtime.InteropServices;
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using BusinessLogic;

    public enum  Asztal_colors : int
    {
        Over = 1, // ha fölémegy az egér
        Selected = 2, // az éppen kiválasztottat mutatja
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
        private bool _Selected;
        private int _Free;
        private int _Over;

        public int Asztal_id
        {
            get { return _Asztal_id;}
            set { _Asztal_id = value; }
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
            _Over = 0;
            _Free = 1;
        }

        public Asztal_Button(int aId)
        {
            _Asztal_id = aId;
            _Selected = false;
            _Free = 1;
            _Over = 0;
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
            _Over = 0;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            // Override the MouseEnter function to set a new image
            // Display Image No 0 from ButtonImageList when mouse enters the button area
            ImageIndex = ImageIndex = (int)Asztal_colors.Over;
            _Over = 1;
            Invalidate();
        }

        public void Init()
        {
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left + 10, rect.Top + 10, rect.Right, rect.Bottom, 50, 50);
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
            else if (_Over == 1)
            {
                ImageIndex = (int)Asztal_colors.Over;
            }
            else if (_Free == 1)
            {
                ImageIndex = (int)Asztal_colors.Free;
            }


            // Paint the rectangle with the color you want
            //g.FillRectangle(new SolidBrush(Color.FromArgb(127, 255, 255, 255)), rect);
            g.FillRectangle(new SolidBrush(DEFS.Asztal_hatter), rect);
            
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
                    Image ig = this.ImageList.Images[ImageIndex];

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
