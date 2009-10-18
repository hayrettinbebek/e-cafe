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
    public enum Fizmond : int
    {
        Keszpenz = 1,
        Bankkartya = 2,
        Utalvany = 3,
        egyeb = 4
    }
}
