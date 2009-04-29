using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;

namespace GUI
{
   
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripCheckedBox : ToolStripControlHost
    {
        public ToolStripCheckedBox()
            : base(new CheckBox())
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CheckBox MyCheckBox
        {
            get { return (CheckBox)this.Control; }
        }
    }
}
