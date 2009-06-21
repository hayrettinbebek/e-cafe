using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GUI.billentyu;
using BusinessLogic;
using e_Cafe.FrontOffice;


namespace e_Cafe
{
    public partial class frmPartnerInsert : Form
    {
        int partner_id = -1;
        Vevo v;

        public frmPartnerInsert(int pId)
        {
            partner_id = pId;
            InitializeComponent();
            loadPartner();

            dynComboBindingSource.Add(new DynCombo("Vevő", "V"));
            dynComboBindingSource.Add(new DynCombo("Törzsvendég", "T"));
            dynComboBindingSource.Add(new DynCombo("Dolgozó", "D"));

            NemSource.Add(new DynCombo("Férfi", "F"));
            NemSource.Add(new DynCombo("Nő", "N"));
            //keyb21.txtRet.Visible = false;
            
        }

        private void loadPartner()
        {
            vevoBindingSource.Clear();
            if (partner_id == -1)
            {
                vevoBindingSource.Add(new Vevo());

            }
            else
            {
                v = new Vevo(partner_id);

                vevoBindingSource.Add(v);
                if (v.PartnerNormalCim().Count > 0)
                {
                    partnercimBindingSource.Add(v.PartnerNormalCim()[0]);
                }
                else
                {
                    Partner_cim pc = new Partner_cim(partner_id);
                    pc.CIM_TIPUS = 1;
                    v.lCimek.Add(pc);
                    partnercimBindingSource.Add(pc);
                }
                if (v.PartnerSzallCim().Count > 0)
                {
                    partnercimBindingSource1.Add(v.PartnerSzallCim()[0]);
                }
                else
                {
                    Partner_cim pc2 = new Partner_cim(partner_id);
                    pc2.CIM_TIPUS = 2;
                    v.lCimek.Add(pc2);
                    partnercimBindingSource1.Add(pc2);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool ok = true;
            bool ok2;
            foreach (var k in vevoBindingSource.List)
            {
                
                partner_id = ((Vevo)k).Save(out ok2);
                txtNormalCimPartnerId.Text = partner_id.ToString();
                txtNormalCimPartnerId2.Text = partner_id.ToString();
                ((Vevo)k).Save(out ok2);
                ok = ok && ok2;
            }

            if (ok) { Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_to_keyboard_Click(object sender, EventArgs e)
        {
            keyb21.txtRet.Text = ((TextBox)sender).Text;
            keyb21.OutTxtBox = (TextBox)sender;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmHitelReszletezo hr = new frmHitelReszletezo();
            hr.pPartner = partner_id;
            hr.ShowDialog();

            loadPartner();

        }
    }
}
