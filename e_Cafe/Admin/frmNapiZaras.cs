using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.Reports;

namespace e_Cafe.Admin
{
    public partial class frmNapiZaras : Form
    {
        NapZaras nz = new NapZaras();
        int maxEvents = 6;
        int processCounter = 0;
        public frmNapiZaras()
        {
            InitializeComponent();
            
        }

        private void frmNapiZaras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsOsszevontLista._JOG' table. You can move, or remove it, as needed.
            this._JOGTableAdapter.Fill(this.dsOsszevontLista._JOG);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (processCounter)
            {
                case 0:
                    {
                        #region Aktuális nyitot nap
                        lblHO.Text = DEFS.NyitNap_HO.ToString();
                        lblNAP.Text = DEFS.NyitNap_NAP.ToString();
                        lblNEV.Text = DEFS.NyitNap_EV.ToString();
                        processCounter++;
                        pbStatus.Value = pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0));
                        break;
                        #endregion
                       

                    }
                case 1:
                    {
                        #region nyitott nap ellenőrzése
                        if (nz.VaneNyitotNap())
                        {
                            pnlVanNyitottNap.BackgroundImage = global::GUI.Properties.Resources.OK_ICON;

                        }
                        else
                        {
                            pnlVanNyitottNap.BackgroundImage = global::GUI.Properties.Resources.ERROR_ICON;
                            button1.Enabled = false;
                        }
                        processCounter++;
                        pbStatus.Value = pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0));
                        break;
                        #endregion

                    }
                case 2:
                    {
                        #region nyitott rendelések ellenőrzése
                        if (DEFS.checkNyitottRendeles())
                        {
                            pnlNyitRendel.BackgroundImage = global::GUI.Properties.Resources.OK_ICON;
                            
                        }
                        else
                        {
                            pnlNyitRendel.BackgroundImage = global::GUI.Properties.Resources.ERROR_ICON;
                            button1.Enabled = false;
                            pnlNyitRendel.Click += NyitRendelInfo_Click;
                        }
                        processCounter++;
                        pbStatus.Value = pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0));
                        break;
                        #endregion

                    }
                case 3:
                    {
                        #region tartozások ellenőrzése
                        if (DEFS.checkTartozasok())
                        {
                            pnlNyitTartozas.BackgroundImage = global::GUI.Properties.Resources.OK_ICON;
                        }
                        else
                        {
                            pnlNyitTartozas.BackgroundImage = global::GUI.Properties.Resources.ERROR_ICON;
                            button1.Enabled = false;
                        }
                        processCounter++;
                        pbStatus.Value = pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0));
                        break;
                        #endregion

                    }
                case 4:
                    {
                        #region negatív raktárkészlet
                        if (DEFS.checkNegativKeszlet())
                        {
                            pnlNegRaktar.BackgroundImage = global::GUI.Properties.Resources.OK_ICON;
                        }
                        else
                        {
                            pnlNegRaktar.BackgroundImage = global::GUI.Properties.Resources.ERROR_ICON;
                            button1.Enabled = false;
                            pnlNegRaktar.Click += NegKeszletInfo_Click;
                        }
                        processCounter++;
                        pbStatus.Value = pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0));
                        break;
                        #endregion

                    }
                case 5:
                    {
                        #region adatbázis konzisztencia
                        if (DEFS.checkDatabaseKonsist())
                        {
                            pnlKonzisztencia.BackgroundImage = global::GUI.Properties.Resources.OK_ICON;
                        }
                        else
                        {
                            pnlKonzisztencia.BackgroundImage = global::GUI.Properties.Resources.ERROR_ICON;
                        }
                        processCounter++;
                        if ((pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0))) > 100)
                        {
                            pbStatus.Value = 100;
                        }
                        else
                        {
                            pbStatus.Value = pbStatus.Value + Convert.ToInt16(Math.Round((100.0 / maxEvents), 0));
                        }
                        break;
                        #endregion

                    }
                default:
                    {
                        timer1.Enabled = false;
                        break;

                    }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = DEFS.NyitNap_EV.ToString() + "." + DEFS.NyitNap_HO.ToString() + "." + DEFS.NyitNap_NAP.ToString();
            if (MessageBox.Show("Valóban szeretné lezárni a " + str + " napot?", "Nap zárás", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                nz.CloseDay();
                doPrinting dp = new doPrinting();
                if (DEFS.R_SYSPAR.GetStrValue("OSSZ_REPORT_FORMAT") == "L")
                {
                    dp.setReportMaker(new OsszesitoReport(DEFS.NyitNap_EV
                                                            , DEFS.NyitNap_HO,
                                                            DEFS.NyitNap_NAP));
                }
                else
                {
                    dp.setReportMaker(new OsszesitoReportSmall(DEFS.NyitNap_EV
                                                                            , DEFS.NyitNap_HO,
                                                                            DEFS.NyitNap_NAP));
                }
                dp.doPreview();
                Application.Exit();
            }
        }

        private void pnlNyitRendel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NyitRendelInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A főmenüben a sárga asztalokat kell lezárni a hiba elhárításához!");
        }

        private void NegKeszletInfo_Click(object sender, EventArgs e)
        {
            frmNegkeszletInfo n = new frmNegkeszletInfo();
            n.ShowDialog();

        } 
        
    }
}
