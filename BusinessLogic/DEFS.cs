using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;

namespace BusinessLogic
{
    
    public abstract class DEFS
    {
        public static string ConSTR = @"server=ERNIE-HOME\SQLEXPRESS;database=ECAFE;uid=sa;password=x";
        public static Color  Asztal_hatter = System.Drawing.Color.Gray;// FromArgb( 70,128,64);
        public static Color Selected_Color = System.Drawing.Color.DarkGray; //FromArgb(126, 187, 121);
        public static Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
    }

   
}
