using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Admin
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Version vrs = new Version(Application.ProductVersion);

            //lblBuild.Text = vrs.Major + "(" + vrs.MajorRevision + ")." + vrs.Minor + "(" + vrs.MinorRevision + ")." + vrs.Build + "." + vrs.Revision;
            lblBuild.Text = asm.GetName().Version.ToString();
            lblVer.Text = DEFS.GetDBVER().ToString();
        }
        /*
        public bool GetVersion(string fileName)
        {
            Assembly asm = null;

            if (asm != null)
            {
                this._info = new AssemblyInformation();
                this._info.Name = asm.GetName().Name;
                this._info.Version = asm.GetName().Version.ToString();
                this._info.FullName = asm.GetName().ToString();
            }
            else
            {
                this._errMsg = "Invalid assembly";
                return false;
            }

            return GetReferenceAssembly(asm);
        }
        
          */
    }
}
