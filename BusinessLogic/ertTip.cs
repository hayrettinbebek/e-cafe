using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using NSpring.Logging;
using NSpring.Logging.EventFormatters;
using System.Drawing.Printing;

namespace BusinessLogic
{
    public class ertTip
    {
        private string _KOD;
        private string _NEV;

        public string KOD
        {
            get { return (_KOD); }
            set { _KOD = value; }
        }

        public string NEV
        {
            get { return (_NEV); }
            set { _NEV = value; }
        }
        public ertTip(string k, string n)
        {
            _KOD = k;
            _NEV = n;
        }
    }
}
