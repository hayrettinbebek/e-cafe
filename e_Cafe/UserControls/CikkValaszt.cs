using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe
{
    public partial class CikkValaszt : UserControl
    {
        public Cikkcsoport_list cCS;
        protected TBLObj bl_object;
        MMenu mm;

        public CikkValaszt()
        {

            InitializeComponent();
        }

        public CikkValaszt(Control pPar, TBLObj bl)
        {
            bl_object = bl;
            mm = (MMenu)pPar.Parent;
            InitializeComponent();
        }

        public void InitCikkValaszt()
        {
            cCS = new Cikkcsoport_list(bl_object);

            var cikkcsoportok =
                from c in cCS.lCIKKCSOPORT
                where c.fCIKKCSOPORT_ID > 0
                select c;
            cikkcsoportok.Each(c => lstCikkcsoport.Items.Add(c.fCIKKCSOPORT_NEV));
        }


    }
}
