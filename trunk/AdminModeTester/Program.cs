using System;
using System.Windows.Forms;
using BusinessLogic;

namespace AdminModeTester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DEFS.ConSTR = e_Cafe.Properties.Settings.Default.ECAFEConnectionString; // e_Cafe.Properties.Settings.Default.cnSTR;
            DEFS.DefPrinter = e_Cafe.Properties.Settings.Default.PrinterName; // e_Cafe.Properties.Settings.Default.cnSTR;
            DEFS.DefProgramLocation = AppDomain.CurrentDomain.BaseDirectory;
            Application.Run(new e_Cafe.AdminTools());
        }
    }
}
