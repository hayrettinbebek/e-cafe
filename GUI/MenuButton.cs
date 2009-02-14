using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
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
        // Import the CreateRoundRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        // Import the SetWindowRgn function from the user32.DLL
        // From the Unmanaged Code
        [DllImport("user32.DLL", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(int hWnd, int hRgn, int bRedraw);

        int rg;
        int hdl;

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
            ImageAlign = ContentAlignment.MiddleCenter;
            BackColor = Color.Transparent;


        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
        }

        public void HInit()
        {

            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, 1, 1);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
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

        // Import the CreateRoundRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        // Import the SetWindowRgn function from the user32.DLL
        // From the Unmanaged Code
        [DllImport("user32.DLL", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(int hWnd, int hRgn, int bRedraw);

        Font f1 = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

        private Label lKeszlet;
        private Label lKeszletOther;
        private Label lMegnevezes;
        private Label lKiszereles;
        private Label lAr;


        public Cikk fCIKK
        {
            get { return (_Cikk); }
            set
            {
                _Cikk = value;
                lMegnevezes.Text = value.MEGNEVEZES;
                lKiszereles.Text = value.KISZ_MEGN;
                lKeszlet.Text = value.fKESZLET.ToString("0.00", CultureInfo.InvariantCulture);
                lKeszletOther.Text = value.fKESZLET_ALL.ToString("0.00", CultureInfo.InvariantCulture);
                lKeszletOther.Visible = ((value.fKESZLET == 0) && (value.fKESZLET_ALL != 0));
                lAr.Text = "250 .-";

                
            }
        }

        public void re_SetCikk()
        {
            lMegnevezes.Text = _Cikk.MEGNEVEZES;
            lKiszereles.Text = _Cikk.KISZ_MEGN;
            lKeszlet.Text = _Cikk.fKESZLET.ToString("0.00", CultureInfo.InvariantCulture);
            lKeszletOther.Text = _Cikk.fKESZLET_ALL.ToString("0.00", CultureInfo.InvariantCulture);
            lKeszletOther.Visible = ((_Cikk.fKESZLET == 0) && (_Cikk.fKESZLET_ALL != 0));
            lAr.Text = "250 .-";
        }

        protected void OnLabelClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }



        
        public CikkButton()
        {
            Width = 150;
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

            lKeszlet = new Label();
            lKeszlet.Width = 50;
            lKeszlet.Height = 20;
            lKeszlet.BackColor = Color.DarkRed;
            lKeszlet.Location = new Point(40, 0);
            lKeszlet.Click += this.OnLabelClick;
            this.Controls.Add(lKeszlet);

            lKeszletOther = new Label();
            lKeszletOther.Width = 50;
            lKeszletOther.Height = 20;
            lKeszletOther.BackColor = Color.DarkGreen;
            lKeszletOther.Location = new Point(90, 0);
            lKeszletOther.Click += this.OnLabelClick;
            this.Controls.Add(lKeszletOther);

            lMegnevezes = new Label();
            lMegnevezes.Width = 120;
            lMegnevezes.Height = 20;
            lMegnevezes.BackColor = Color.Transparent;
            lMegnevezes.Location = new Point(10, 20);
            lMegnevezes.Font = f2;
            lMegnevezes.Click += this.OnLabelClick;
            this.Controls.Add(lMegnevezes);

            lKiszereles = new Label();
            lKiszereles.Width = 70;
            lKiszereles.Height = 20;
            lKiszereles.BackColor = Color.Transparent;
            lKiszereles.Location = new Point(10, 45);
            lKiszereles.Font = f1;
            lKiszereles.Click += this.OnLabelClick;
            this.Controls.Add(lKiszereles);

            lAr = new Label();
            lAr.Width = 50;
            lAr.Height = 20;
            lAr.BackColor = Color.Transparent;
            lAr.Location = new Point(92, 45);
            lAr.Font = f1;
            lAr.Click += this.OnLabelClick;
            this.Controls.Add(lAr);
      
        }

       
    }

    public class PartnerButton : System.Windows.Forms.Button
    {
        int rg;
        int hdl;
        private Partner _Partner;

        // Import the CreateRoundRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        // Import the SetWindowRgn function from the user32.DLL
        // From the Unmanaged Code
        [DllImport("user32.DLL", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(int hWnd, int hRgn, int bRedraw);

        Font f1 = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

        private Image lImage;
        private Label lNAME;
        private Label lNAME2;



        public Partner fPARTNER
        {
            get { return (_Partner); }
            set
            {
                _Partner = value;
                lNAME.Text = _Partner.P_NEV;
                lNAME2.Text = _Partner.P_NEV2;


            }
        }

        protected void OnLabelClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }




        public PartnerButton()
        {
            Width = 150;
            Height = 75;
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, 10, 10);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;

            BackColor = Color.Gray;

            lNAME = new Label();
            lNAME.Width = 50;
            lNAME.Height = 20;
            lNAME.BackColor = Color.Transparent;
            lNAME.Location = new Point(90, 25);
            lNAME.Font = f1;
            lNAME.Click += this.OnLabelClick;
            this.Controls.Add(lNAME);


            lNAME2 = new Label();
            lNAME2.Width = 50;
            lNAME2.Height = 20;
            lNAME2.BackColor = Color.Transparent;
            lNAME2.Location = new Point(91, 45);
            lNAME2.Font = f1;
            lNAME2.Click += this.OnLabelClick;
            this.Controls.Add(lNAME2);

        }


    }

}
