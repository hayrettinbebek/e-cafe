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
    public enum MobilTipus
    {
        [StringValue("Mobil")]
        mobil = 1,
        [StringValue("E-Mail")]
        email = 2,
        [StringValue("Vezetékes")]
        vezetekes = 3

    }
}
