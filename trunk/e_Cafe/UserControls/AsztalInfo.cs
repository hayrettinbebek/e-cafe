using System;
using System.Windows.Forms;

namespace e_Cafe
{
    public partial class AsztalInfo : UserControl
    {
        public AsztalInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
