using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace e_Cafe
{
    public partial class MainMenuBtn : TableLayoutPanel
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_TRANSPARENT = 0x20;

        public MainMenuBtn()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.AllPaintingInWmPaint
            //    | ControlStyles.ResizeRedraw
            //    , true);
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, false);
            this.BackColor = Color.Transparent;

            this.UpdateStyles();
            
            int exstyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            exstyle |= WS_EX_TRANSPARENT;
            SetWindowLong(this.Handle, GWL_EXSTYLE, exstyle);
        }


        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x20;

        //        return cp;
        //    }
        //}

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    //base.OnPaintBackground(e);
        //}



        //protected override void OnMove(EventArgs e)
        //{
        //    RecreateHandle();
        //}


    }
}
