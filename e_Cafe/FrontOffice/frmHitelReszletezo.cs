using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XPTable;
using XPTable.Models;
using XPTable.Renderers;

using BusinessLogic;

namespace e_Cafe.FrontOffice
{
    public partial class frmHitelReszletezo : Form
    {
        private PartnerHitel _aktPH;
        public int pPartner;
        public frmHitelReszletezo()
        {
            InitializeComponent();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHitelReszletezo_Load(object sender, EventArgs e)
        {
            _aktPH = new PartnerHitel(pPartner);
            tblHitelek.ColumnModel = _aktPH.getColumnModel();
            tblHitelek.HeaderRenderer = new GradientHeaderRenderer();
            tblHitelek.TableModel = _aktPH.getTableModel();
            tblHitelek.Font = DEFS.f2;
            tblHitelek.TableModel.RowHeight = 40;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int szamla_fej_id = DEFS.GenerateSzamlaFej(pPartner, -101, (int)Fizmond.Keszpenz);
            
            if (szamla_fej_id != -1)
            {
                foreach (var r in tblHitelek.SelectedItems)
                {
                    DEFS.AddSzlaTetel(szamla_fej_id, ((HitelCell)r.Cells[0]).hSor._SOR_ID);
                }

                frmReporting rep = new frmReporting();
                rep.Szla_id = szamla_fej_id;
                rep.ShowDialog();

                DEFS.DebugLog("Hitelek fizetve");

            }
        }

        private void tblHitelek_CellClick(object sender, XPTable.Events.CellMouseEventArgs e)
        {
            if (tblHitelek.TableModel.Selections.IsRowSelected(e.Row))
            {
                tblHitelek.TableModel.Selections.RemoveCell(e.Row, 0);
            }
            else
            {
                tblHitelek.TableModel.Selections.AddCell(e.Row, 0);
            }
        }

        private void tblHitelek_SelectionChanged(object sender, XPTable.Events.SelectionEventArgs e)
        {
            for (int i = 0; i < tblHitelek.TableModel.Rows.Count; i++)
            {
                tblHitelek.TableModel.Rows[i].Cells[0].Image = global::GUI.Properties.Resources.pipaoff;
            }



            foreach (var r in tblHitelek.SelectedItems)
            {
                r.Cells[0].Image = global::GUI.Properties.Resources.pipaon;
            }
        }
    }
}
