using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic;
using e_Cafe.Reports;

namespace e_Cafe.Admin
{
    public partial class frmOsszevontLista : Form
    {
        public frmOsszevontLista()
        {
            InitializeComponent();
        }

        private void frmOsszevontLista_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < DEFS.lNYITOTT_NAPOK.Count; i++)
            {
                openDayComboBindingSource.Add(new OpenDayCombo(DEFS.lNYITOTT_NAPOK[i].EV.ToString()+"."+DEFS.lNYITOTT_NAPOK[i].HO.ToString()+"."+DEFS.lNYITOTT_NAPOK[i].NAP.ToString(),
                    DEFS.lNYITOTT_NAPOK[i].EV.ToString()+"."+DEFS.lNYITOTT_NAPOK[i].HO.ToString()+"."+DEFS.lNYITOTT_NAPOK[i].NAP.ToString(),
                    new OpenDay(DEFS.lNYITOTT_NAPOK[i].EV,DEFS.lNYITOTT_NAPOK[i].HO,DEFS.lNYITOTT_NAPOK[i].NAP)));
                
            } 
            


        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            doPrinting dp = new doPrinting();
            if ((string)Syspar2.GetValue(ParamCodes.OSSZ_REPORT_FORMAT) == "L")
            {
                dp.setReportMaker(new OsszesitoReport(((OpenDay)listBox1.SelectedValue).EV
                                                        , ((OpenDay)listBox1.SelectedValue).HO,
                                                        ((OpenDay)listBox1.SelectedValue).NAP));
            }
            else
            {
                dp.setReportMaker(new OsszesitoReportSmall(((OpenDay)listBox1.SelectedValue).EV
                                                                        , ((OpenDay)listBox1.SelectedValue).HO,
                                                                        ((OpenDay)listBox1.SelectedValue).NAP));
            }
            dp.doPrint();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<OpenDay> lTMP_NYITNAPOK = new List<OpenDay>();
            openDayComboBindingSource.Clear();
            var ret_cikk =
                from c in DEFS.lNYITOTT_NAPOK
                where ((txtEV.Text) == "" ||(c.EV == Convert.ToInt16(txtEV.Text)))
                        && ((txtHO.Text) == "" || (c.HO == Convert.ToInt16(txtHO.Text)))
                        && ((txtNAP.Text) == "" ||(c.NAP == Convert.ToInt16(txtNAP.Text)))
                select c;
            ret_cikk.Each(c => lTMP_NYITNAPOK.Add(c));

            for (int i = 0; i < lTMP_NYITNAPOK.Count; i++)
            {
                openDayComboBindingSource.Add(new OpenDayCombo(lTMP_NYITNAPOK[i].EV.ToString()+"."+lTMP_NYITNAPOK[i].HO.ToString()+"."+lTMP_NYITNAPOK[i].NAP.ToString(),
                    lTMP_NYITNAPOK[i].EV.ToString()+"."+lTMP_NYITNAPOK[i].HO.ToString()+"."+lTMP_NYITNAPOK[i].NAP.ToString(),
                    new OpenDay(lTMP_NYITNAPOK[i].EV,lTMP_NYITNAPOK[i].HO,lTMP_NYITNAPOK[i].NAP)));
                
            }
        }
    }
}
