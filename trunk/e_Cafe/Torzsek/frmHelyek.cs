using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogic;

namespace e_Cafe.Torzsek
{
    public partial class frmHelyek : Form
    {
        public frmHelyek()
        {
            InitializeComponent();
        }

        private void frmHelyek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCAFEDataSetHELY.HELY' table. You can move, or remove it, as needed.
            this.hELYTableAdapter.Fill(this.eCAFEDataSetHELY.HELY);

        }

        private void frmHelyek_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                hELYTableAdapter.Update(eCAFEDataSetHELY);
            }
            catch (Exception c)
            {
                EmailSending x = new EmailSending();
                x.send_mail(c);
            }
        }
    }
}
