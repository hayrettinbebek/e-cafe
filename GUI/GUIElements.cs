using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

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
