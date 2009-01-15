using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BusinessLogic;
using System.Runtime.InteropServices ;

namespace GUI
{
    public class CikkcsopButton : System.Windows.Forms.RadioButton
    {


        public Cikkcsoport _Cikkcsoport;
        
        public CikkcsopButton(Cikkcsoport aCcs)
        {
            _Cikkcsoport = aCcs;
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            ImageAlign = ContentAlignment.BottomRight;
            BackColor = Color.Transparent;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (ImageIndex == 1) { ImageIndex = 0; }
            else ImageIndex = 1;
            //base.OnCheckedChanged(e);

        }
     
    }

    public class HelyButton : System.Windows.Forms.RadioButton
    {
        public Hely _Hely;
        public HelyButton(Hely aHely)
        {
            _Hely = aHely;
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            ImageAlign = ContentAlignment.BottomRight;
            BackColor = Color.Transparent;


        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (ImageIndex == 1) { ImageIndex = 0; }
            else ImageIndex = 1;
            base.OnCheckedChanged(e);
            
        }

    }

    public class OtherFButton : System.Windows.Forms.RadioButton
    {
        public OTF _OTF;

        public OtherFButton(OTF aOtf)
        {
            _OTF = aOtf;
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            ImageAlign = ContentAlignment.BottomRight;
            BackColor = Color.Transparent;
        }
        protected override void OnCheckedChanged(EventArgs e)
        {
            if (ImageIndex == 1) { ImageIndex = 0; }
            else ImageIndex = 1;
            base.OnCheckedChanged(e);

        }
    }

    public class CikkButton : System.Windows.Forms.Button
    {
        int rg;
        int hdl;
        private Cikk _Cikk;




        public Cikk fCIKK
        {
            get { return (_Cikk); }
            set
            {
                _Cikk = value;
                this.Text = value.fMEGNEVEZES;
            }
        }

        // Import the CreateRoundRectRgn function from the GDI32.DLL 
		// From the Unmanaged Code
		[DllImport("GDI32.DLL",EntryPoint="CreateRoundRectRgn")]
		private static extern int CreateRoundRectRgn(int x1 , int y1 ,int x2 , int y2 , int x3 , int y3);

		// Import the SetWindowRgn function from the user32.DLL
		// From the Unmanaged Code
		[DllImport("user32.DLL",EntryPoint="SetWindowRgn")]
		private static extern int SetWindowRgn( int hWnd , int hRgn , int bRedraw ) ;


        
        public CikkButton()
        {
            Width = 100;
            Height = 75;
            // Get the dimension of the client rectangle 
			Rectangle rect = this.ClientRectangle  ;	
			// Invoke the unmanaged DLL function here to create the RoundRectangleRegion
			rg = CreateRoundRectRgn(rect.Left,rect.Top,rect.Right,rect.Bottom,10,10);
			// Get the handle to the window. 
			hdl = this.Handle.ToInt32() ;
			// Set the Window Region to a a Rectangle with rounded corners
			SetWindowRgn( hdl , rg , 1 ) ;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;

            BackColor = Color.Gray;

            Label l = new Label();
            l.Width = 30;
            l.Height = 30;
            l.BackColor = Color.Red;
            l.Text = "15";
            l.Location = new Point(70, 0);
            this.Controls.Add(l);

      
        }

       
    }
}
