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
            BackgroundImage = global::GUI.Properties.Resources.off_menuBtn;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Checked)
            {
                //ImageIndex = 0;
                BackgroundImage = global::GUI.Properties.Resources.on_menubtn;
            }
            else
            {
                //ImageIndex = 1;
                BackgroundImage = global::GUI.Properties.Resources.off_menuBtn;
            }
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
            BackgroundImage = global::GUI.Properties.Resources.al_off;
            TextAlign = ContentAlignment.TopCenter;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
        }

        public OtherFButton()
        {
            
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            ImageAlign = ContentAlignment.BottomRight;
            BackgroundImage = global::GUI.Properties.Resources.al_off;
            TextAlign = ContentAlignment.TopCenter;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Checked)
            {
                //ImageIndex = 0;
                BackgroundImage = global::GUI.Properties.Resources.al_aktiv;
            }
            else
            {
                //ImageIndex = 1;
                BackgroundImage = global::GUI.Properties.Resources.al_off;
            }
            //base.OnCheckedChanged(e);

        }
           

        
    }

    public class CikkButton : System.Windows.Forms.RadioButton
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
        Font f4 = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

       // private Label lKeszlet;
        private Label lKeszletOther;
        private Label lMegnevezes;
        private Label lKiszereles;
        private Label lAr;

        //public ImageList CIml
        //{
        //    get { return (ImageList); }
        //    set
        //    {
        //        ImageList = value;

        //        BackgroundImage = ImageList.Images[0];
        //        BackgroundImageLayout = ImageLayout.Stretch;


        //    }

        //}

        private void SetBackColor()
        {
            if (_Cikk.fKESZLET_ALL <= 0)// ha nincs készlete csak akkor piros! normál pedig egyéb estebn
            {
                BackgroundImage = global::GUI.Properties.Resources.piroson;
            }
            else if (_Cikk.fKESZLET_ALL <= _Cikk.MINIMUM_KESZLET)
            {
                BackgroundImage = global::GUI.Properties.Resources.zoldon;
            }
            else
            {
                BackgroundImage = global::GUI.Properties.Resources.zoldon;
            }
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
        }



        public Cikk fCIKK
        {
            get { return (_Cikk); }
            set
            {
                _Cikk = value;
                if (_Cikk.ROVID_NEV.Trim().Length == 0) { lMegnevezes.Text = _Cikk.MEGNEVEZES; }
                else
                {
                    lMegnevezes.Text = value.ROVID_NEV;
                }
                lKiszereles.Text = value.KISZ_MEGN;
                // lKeszlet.Text = value.fKESZLET.ToString("0.00", CultureInfo.InvariantCulture);
                //lKeszletOther.Text = (value.fKESZLET_ALL / value.KISZ_MENNY).ToString("0.00", CultureInfo.InvariantCulture);
                lKeszletOther.Text = (value.fKESZLET_ALL / value.KISZ_MENNY).ToString("0", CultureInfo.InvariantCulture);
                //lKeszletOther.Visible = ((value.fKESZLET == 0) && (value.fKESZLET_ALL != 0));
                lAr.Text = value.ELADASI_AR_VALOS.ToString("0.00", CultureInfo.InvariantCulture);
                SetBackColor();



            }
        }

        public void re_SetCikk()
        {
            if (_Cikk.ROVID_NEV.Trim().Length == 0) { lMegnevezes.Text = _Cikk.MEGNEVEZES; }
            else
            {
                lMegnevezes.Text = _Cikk.ROVID_NEV;
            }
            lKiszereles.Text = _Cikk.KISZ_MEGN;
            //lKeszlet.Text = _Cikk.fKESZLET.ToString("0.00", CultureInfo.InvariantCulture);
            //lKeszletOther.Text = (_Cikk.fKESZLET_ALL / _Cikk.KISZ_MENNY).ToString("0.00", CultureInfo.InvariantCulture);
            lKeszletOther.Text = (_Cikk.fKESZLET_ALL / _Cikk.KISZ_MENNY).ToString("0", CultureInfo.InvariantCulture);
            //lKeszletOther.Visible = ((_Cikk.fKESZLET == 0) && (_Cikk.fKESZLET_ALL != 0));
            lAr.Text = _Cikk.ELADASI_AR_VALOS.ToString("0.00", CultureInfo.InvariantCulture);
            SetBackColor();
        }

        protected void OnLabelClick(object sender, EventArgs e)
        {
            this.OnClick(e);
            
        }



        
        public CikkButton()
        {
            //Width = 350;
            //Height = 175;
            Size = DEFS.CIKK_BTN_SIZE;
            // Get the dimension of the client rectangle 
			Rectangle rect = this.ClientRectangle  ;	
			// Invoke the unmanaged DLL function here to create the RoundRectangleRegion
			rg = CreateRoundRectRgn(rect.Left,rect.Top,rect.Right,rect.Bottom,10,10);
			// Get the handle to the window. 
			hdl = this.Handle.ToInt32() ;
			// Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);

            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            
            FlatAppearance.BorderSize = 0;
            
            

            BackColor = Color.Gray;

            //lKeszlet = new Label();
            //lKeszlet.Width = 50;
            //lKeszlet.Height = 20;
            //lKeszlet.BackColor = Color.DarkRed;
            //lKeszlet.Location = new Point(40, 0);
            //lKeszlet.Click += this.OnLabelClick;
            //this.Controls.Add(lKeszlet);

            lKeszletOther = new Label();
            lKeszletOther.Width = 50;
            lKeszletOther.Height = 20;
            lKeszletOther.BackColor = Color.Transparent;
            lKeszletOther.Location = new Point(90, 7);
            lKeszletOther.Font = f4;
            lKeszletOther.TextAlign = ContentAlignment.MiddleCenter;
            lKeszletOther.Click += this.OnLabelClick;
            this.Controls.Add(lKeszletOther);

            lMegnevezes = new Label();
            lMegnevezes.Width = 180;
            lMegnevezes.Height = 20;
            lMegnevezes.BackColor = Color.Transparent;
            lMegnevezes.Location = new Point(10, 28);
            lMegnevezes.Font = f2;
            lMegnevezes.Click += this.OnLabelClick;
            this.Controls.Add(lMegnevezes);

            lKiszereles = new Label();
            lKiszereles.Width = 70;
            lKiszereles.Height = 20;
            lKiszereles.BackColor = Color.Transparent;
            lKiszereles.Location = new Point(10, 50);
            lKiszereles.Font = f1;
            lKiszereles.Click += this.OnLabelClick;
            this.Controls.Add(lKiszereles);

            lAr = new Label();
            lAr.Width = 50;
            lAr.Height = 20;
            lAr.BackColor = Color.Transparent;
            lAr.Location = new Point(92, 50);
            lAr.Font = f1;
            lAr.Click += this.OnLabelClick;
            this.Controls.Add(lAr);

            
      
        }

       
    }

    public class PartnerButton : System.Windows.Forms.RadioButton
    {
        int rg;
        int hdl;
        private Partner _Partner;


        
        private bool _van_rendel = false;
        public bool VAN_RENDEL
        {
            get { return (_van_rendel); }
            set
            {
                switch (value)
                {
                    case true:
                        {
                            
                            BackgroundImage = global::GUI.Properties.Resources.partner_rendel;
                            break;
                        }
                    case false:
                        {
                            if (Checked) { BackgroundImage = global::GUI.Properties.Resources.Partner_on; }
                            else { BackgroundImage = global::GUI.Properties.Resources.partner_off; }
                            break;
                        }

                }
                _van_rendel = value;
            }


        }
         

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

        //private Image lImage;
        private Label lNAME;
        private Label lNAME2;

        public Panel pnlEdit;
        public Panel pnlRendel;



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

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            if (Checked) { BackgroundImage = global::GUI.Properties.Resources.Partner_on; }
            else { BackgroundImage = global::GUI.Properties.Resources.partner_off; }

            if (VAN_RENDEL) { BackgroundImage = global::GUI.Properties.Resources.partner_rendel; }
        }


        public PartnerButton()
        {
            Width = 150;
            Height = 50;
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, 10, 10);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
            Appearance = Appearance.Button;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderColor = Color.Gray;
            FlatAppearance.BorderSize = 2;



            if (Checked) { BackgroundImage = global::GUI.Properties.Resources.Partner_on; }
            else { BackgroundImage = global::GUI.Properties.Resources.partner_off; }

            if (VAN_RENDEL) { BackgroundImage = global::GUI.Properties.Resources.partner_rendel; }

            BackgroundImageLayout = ImageLayout.Stretch;

            FlatStyle = FlatStyle.Flat;

            BackColor = Color.Transparent;

            pnlRendel = new Panel();
            pnlRendel.Width = 40;
            pnlRendel.Height = this.Height;
            pnlRendel.BackColor = Color.Transparent;
            pnlRendel.Dock = DockStyle.Right;
            pnlRendel.Font = f1;
            
            this.Controls.Add(pnlRendel);

            pnlEdit = new Panel();
            pnlEdit.Width = 110;
            pnlEdit.Height = this.Height;
            pnlEdit.BackColor = Color.Transparent;
            pnlEdit.Dock = DockStyle.Left;
            pnlEdit.Font = f1;
            pnlEdit.Click += this.OnLabelClick;
            this.Controls.Add(pnlEdit);

            lNAME = new Label();
            lNAME.Width = 50;
            lNAME.Height = 20;
            lNAME.BackColor = Color.Transparent;
            lNAME.Location = new Point(45, 10);
            lNAME.Font = f1;
            lNAME.Click += this.OnLabelClick;
            pnlEdit.Controls.Add(lNAME);


            lNAME2 = new Label();
            lNAME2.Width = 50;
            lNAME2.Height = 20;
            lNAME2.BackColor = Color.Transparent;
            lNAME2.Location = new Point(45, 30);
            lNAME2.Font = f1;
            lNAME2.Click += this.OnLabelClick;
            pnlEdit.Controls.Add(lNAME2);

        }


    }

    public class UserButton : System.Windows.Forms.RadioButton
    {
        int rg;
        int hdl;
        private _User _fUser;

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

        private PictureBox lImage;
        private Label lNAME;
        private Label lNAME2;


        public _User fUser
        {
            get { return (_fUser); }
            set
            {
                _fUser = value;
                lNAME.Text = _fUser.NAME;
                lNAME2.Text = _fUser.LOGIN_NAME;
            }
        }

        protected void OnLabelClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            if (Checked)
            {
                BackgroundImage = global::GUI.Properties.Resources.on_user;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                BackgroundImage = global::GUI.Properties.Resources.off_user;
                BackgroundImageLayout = ImageLayout.Stretch;
            }

        }


        public UserButton()
        {
            Width = 130;
            Height = 55;
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, 10, 10);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
            Appearance = Appearance.Button;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderColor = Color.Gray;
            FlatAppearance.BorderSize = 2;

            FlatStyle = FlatStyle.Flat;

            BackColor = Color.Transparent;

            lNAME = new Label();
            lNAME.Width = 65;
            lNAME.Height = 20;
            lNAME.BackColor = Color.Transparent;
            lNAME.Location = new Point(60, 15);
            lNAME.Font = f1;
            lNAME.ForeColor = Color.White;
            lNAME.Click += this.OnLabelClick;
            this.Controls.Add(lNAME);


            lNAME2 = new Label();
            lNAME2.Width = 65;
            lNAME2.Height = 20;
            lNAME2.BackColor = Color.Transparent;
            lNAME2.Location = new Point(60, 35);
            lNAME2.Font = f1;

            lNAME2.ForeColor = Color.White;
            lNAME2.Click += this.OnLabelClick;
            this.Controls.Add(lNAME2);

            lImage = new PictureBox();
            lImage.Width = 39;
            lImage.Height = 39;
            lImage.Location = new Point(15, 16);
            lImage.Click += this.OnLabelClick;

            this.Controls.Add(lImage);



        }


    }

    public class KedvezmenyButton : System.Windows.Forms.RadioButton
    {
        int rg;
        int hdl;
        int kedvSZ = 0;
       

        // Import the CreateRoundRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        // Import the SetWindowRgn function from the user32.DLL
        // From the Unmanaged Code
        [DllImport("user32.DLL", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(int hWnd, int hRgn, int bRedraw);

        Font f1 = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));


        public int KEDVEZEMNY
        {
            get { return (kedvSZ); }
            set
            {
                kedvSZ = value;
                this.Text = "-" + kedvSZ.ToString() + "%";
            }
        }

        protected void OnLabelClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);



        }

        public KedvezmenyButton()
        {
            Width = 85;
            Height = 85;
            AutoSize = false;

            KEDVEZEMNY = 0;
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, 0, 0);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
            Appearance = Appearance.Button;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderColor = Color.Gray;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.FromArgb(192, 0, 0);
            TextAlign = ContentAlignment.MiddleCenter;
            Font = f2;

            BackgroundImage = global::GUI.Properties.Resources.uresGomb;
            BackgroundImageLayout = ImageLayout.Stretch;

            FlatStyle = FlatStyle.Flat;

            BackColor = Color.Transparent;



        }
        public KedvezmenyButton(int k)
        {
            Width = 85;
            Height = 85;
            AutoSize = false;
            KEDVEZEMNY = k;
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, 0, 0);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
            Appearance = Appearance.Button;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.BorderColor = Color.Gray;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.FromArgb(192,0,0);
            TextAlign = ContentAlignment.MiddleCenter;
            Font = f2;
            BackgroundImage = global::GUI.Properties.Resources.uresGomb; 
            BackgroundImageLayout = ImageLayout.Stretch;

            FlatStyle = FlatStyle.Flat;

            BackColor = Color.Transparent;

            

        }


    }
}
