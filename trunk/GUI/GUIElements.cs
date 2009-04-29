using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUI
{
    public class ToolStripCheckBox : System.Windows.Forms.ToolStripControlHost
    {
        public ToolStripCheckBox() : base(new System.Windows.Forms.CheckBox()) { }


        public CheckBox ToolStripCheckBoxControl
        {
            get
            {
                return Control as CheckBox;
            }
        }

        //expose checkbox.enabled as property
        public bool ToolStripCheckBoxEnabled
        {
            get
            {
                return ToolStripCheckBoxControl.Enabled;
            }
            set
            {
                ToolStripCheckBoxControl.Enabled = value;
            }
        }
        protected override void OnSubscribeControlEvents(Control c)
        {
            // Call the base method so the basic events are unsubscribed.
            base.OnSubscribeControlEvents(c);


            CheckBox ToolStripCheckBoxControl = (CheckBox)c;
            // Remove the event.
            ToolStripCheckBoxControl.CheckedChanged += new EventHandler(CheckedChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control c)
        {
            // Call the base method so the basic events are unsubscribed.
            base.OnUnsubscribeControlEvents(c);


            CheckBox ToolStripCheckBoxControl = (CheckBox)c;
            // Remove the event.
            ToolStripCheckBoxControl.CheckedChanged -= new EventHandler(CheckedChanged);
        }

        public event EventHandler CheckedChanged;

        private void OnCheckChanged(object sender, DateRangeEventArgs e)
        {
            if (CheckedChanged != null)
            {
                CheckedChanged(this, e);
            }
        }
    }

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
