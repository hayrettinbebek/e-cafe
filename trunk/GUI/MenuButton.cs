using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic;

namespace GUI
{
    public class CikkcsopButton : System.Windows.Forms.Button
    {
        public Cikkcsoport _Cikkcsoport;
        public CikkcsopButton(Cikkcsoport aCcs)
        {
            _Cikkcsoport = aCcs;
        }
    }

    public class OtherFButton : System.Windows.Forms.Button
    {
        public OTF _OTF;
        public OtherFButton(OTF aOtf)
        {
            _OTF = aOtf;
        }
    }
}
