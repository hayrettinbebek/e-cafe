using System;
using System.Windows.Forms;
using BusinessLogic;
using XPTable.Renderers;


namespace e_Cafe.FrontOffice
{
    public partial class frmAsztalInfo : Form
    {
        private Asztal used_asztal;
        public frmAsztalInfo(Asztal aa)
        {
            InitializeComponent();
            used_asztal = aa;
            lblAsztalSzam.Text = aa.fASZTAL_SZAM + " . asztal";
            if (aa.fRENDELES_ID > 0)
            {
                Rendeles r = new Rendeles(aa.fASZTAL_ID, aa.fRENDELES_ID);
                tblRendelesek.ColumnModel = r.getColumnModelInfo();
                tblRendelesek.HeaderRenderer = new GradientHeaderRenderer();
                tblRendelesek.TableModel = r.getTableModelInfo();
                tblRendelesek.Font = DEFS.fRendelInfo;
                tblRendelesek.TableModel.RowHeight = 40;
            }
            else if (aa.lFOGLALAS_PARAM_IDON_BELUL.Count > 0)
            {
 
                tblRendelesek.ColumnModel = Foglalas.getColumnModelInfo();
                tblRendelesek.HeaderRenderer = new GradientHeaderRenderer();
                tblRendelesek.TableModel = Foglalas.getTableModelInfo(aa.lFOGLALAS_PARAM_IDON_BELUL);
                tblRendelesek.Font = DEFS.fFoglalasokInfo;
                if (aa.lFOGLALAS_PARAM_IDON_BELUL.Count > 1)
                {
                    tblRendelesek.TableModel.RowHeight = 10;
                }
                else
                {
                    tblRendelesek.TableModel.RowHeight = 20;
                }
                
            }

        }

        private void btnNem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
