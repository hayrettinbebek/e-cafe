using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e_Cafe.Reports;
using XPTable;
using XPTable.Models;
using XPTable.Renderers;
using GUI;

using BusinessLogic;

namespace e_Cafe.FrontOffice
{
    public partial class frmHitelReszletezo : Form
    {
        private PartnerHitel _aktPH;
        private Partner _aktPartner;
        public int pPartner;
        Size NOT_SELECTED_SIZE = new Size(125,30);
        Size SELECTED_SIZE = new Size(130,40);
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
            refreshReszletesList();

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (rbReszletek.Checked == true)
            {
                if (tblHitelek.SelectedItems.Count() == 0)
                {
                    DEFS.SendInfoMessage("Nincs fizetendő kiválasztva!");

                }
                else
                {
                    int szamla_fej_id = DEFS.GenerateSzamlaFej(pPartner, -101, (int)Fizmond.Keszpenz);

                    if (szamla_fej_id != -1)
                    {
                        foreach (var r in tblHitelek.SelectedItems)
                        {
                            DEFS.AddSzlaTetel(szamla_fej_id, ((HitelCell)r.Cells[0]).hSor._SOR_ID);
                            ((HitelCell)r.Cells[0]).hSor.SetFizetve();
                        }

                        doPrinting dp = new doPrinting();
                        dp.setReportMaker(new BlokkReport(szamla_fej_id));
                        dp.doPrint();

                        DEFS.DebugLog("Hitelek fizetve");

                    }
                    refreshReszletesList();
                }
            }
            if (rbNemNevesitett.Checked == true) {
                if (tblHitelek.SelectedItems.Count() == 0)
                {
                    DEFS.SendInfoMessage("Nincs fizetendő kiválasztva!");

                }
                else
                {
                    int szamla_fej_id = DEFS.GenerateSzamlaFej(pPartner, -101, (int)Fizmond.Keszpenz);

                    if (szamla_fej_id != -1)
                    {
                        
                        foreach (var r in tblHitelek.SelectedItems)
                        {
                            Partner_befizetes pb = new Partner_befizetes(pPartner, ((PartnerTartozasCell)r.Cells[0]).tartSor.OSSZEG, ((PartnerTartozasCell)r.Cells[0]).tartSor.JOGCIM);
                            try
                            {
                                DEFS.AddEgyebSzlaTetel(szamla_fej_id,
                                                                    pb.Save());
                                ((PartnerTartozasCell)r.Cells[0]).tartSor.FIZETVE = ((PartnerTartozasCell)r.Cells[0]).tartSor.OSSZEG;
                                ((PartnerTartozasCell)r.Cells[0]).tartSor.Save();
                            }
                            catch (Exception)
                            {
                                pb.Delete();
                                throw;
                            }
                            


                        }
                        
                        doPrinting dp = new doPrinting();
                        dp.setReportMaker(new BlokkReport(szamla_fej_id));
                        dp.doPrint();

                        DEFS.DebugLog("Hitelek fizetve");

                    }
                    refreshReszletesList();
                }

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


        private void button8_Click(object sender, EventArgs e)
        {
            tblHitelek.TableModel.Selections.Clear();

            for (int i = 0; i < tblHitelek.TableModel.Rows.Count; i++)
            {

                tblHitelek.TableModel.Selections.AddCell(i, 0);
            }
        }

        #region Grid cuccok
        private void refreshReszletesList()
        {

            _aktPH = new PartnerHitel(pPartner);
            tblHitelek.ColumnModel = _aktPH.getColumnModel();
            tblHitelek.HeaderRenderer = new GradientHeaderRenderer();
            tblHitelek.TableModel = _aktPH.getTableModel();
            tblHitelek.Font = DEFS.f2;
            tblHitelek.TableModel.RowHeight = 40;
            pnltartozas.Visible = false;
           
        }


        private void refreshEgyebList()
        {


            _aktPartner = new Partner(pPartner);
            tblHitelek.ColumnModel = _aktPartner.getTartozasokColumnModel();
            tblHitelek.HeaderRenderer = new GradientHeaderRenderer();
            tblHitelek.TableModel = _aktPartner.getTartozasokTableModel();
            tblHitelek.Font = DEFS.f2;
            tblHitelek.TableModel.RowHeight = 40;

            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNemNevesitett.Checked == true)
            {
                refreshEgyebList();

            }

            if (rbOsszesitett.Checked == true)
            {
                refreshReszletesList();

            }

            if (rbReszletek.Checked == true)
            {
                refreshReszletesList();

            }
        }
        #endregion

        private void btnAddTartozas_Click(object sender, EventArgs e)
        {
            pnltartozas.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Partner_tartozas(pPartner, Convert.ToDouble(txtTartBefOsszeg.Text), txtTartBefJogcim.Text)).Save();
            refreshEgyebList();

            pnltartozas.Visible = false;
        }

        private void txtTartBefJogcim_Click(object sender, EventArgs e)
        {

            txtTartBefJogcim.Text = InputText.getString(true);

         
        }

        private void txtTartBefOsszeg_Click(object sender, EventArgs e)
        {

                txtTartBefOsszeg.Text = InputText.getInt(true).ToString();

        }

    }
}
