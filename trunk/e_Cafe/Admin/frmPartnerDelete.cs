using System;
using System.Data;
using System.Windows.Forms;

namespace e_Cafe.Admin
{
    public partial class frmPartnerDelete : Form
    {
        public int del;

        public frmPartnerDelete()
        {
            InitializeComponent();
        }

        private void frmPartnerDelete_Load(object sender, EventArgs e)
        {

            if (del.Equals(1))
            {
                // TODO: This line of code loads data into the 'dsPartnerek.PARTNER' table. You can move, or remove it, as needed.
                this.pARTNERTableAdapter.Fill(this.dsPartnerek.PARTNER, 1);
                this.Text = "Partner törlés";
                tsbAction.Text = "törlés";
            }
            else
            {
                // TODO: This line of code loads data into the 'dsPartnerek.PARTNER' table. You can move, or remove it, as needed.
                this.pARTNERTableAdapter.Fill(this.dsPartnerek.PARTNER, 0);

                this.Text = "Partner visszaállíása";
                tsbAction.Text = "visszaállíás";
            }
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (del.Equals(1))
            {
                ((e_Cafe.SQL.DataSets.dsPartnerek.PARTNERRow)(((DataRowView)pARTNERBindingSource.Current).Row)).AKTIV = 0;
            }
            else
            {
                ((e_Cafe.SQL.DataSets.dsPartnerek.PARTNERRow)(((DataRowView)pARTNERBindingSource.Current).Row)).AKTIV = 1;
            }
            this.pARTNERTableAdapter.Update(this.dsPartnerek);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            pARTNERBindingSource.Filter = "P_NEV LIKE '" + tsNameFilter.Text + "%'";
        }
    }
}
