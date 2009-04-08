using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;


using XPTable;
using XPTable.Models;
using XPTable.Renderers;

namespace e_Cafe
{
    public partial class ChooseKeszletek : Form
    {
        ColumnModel _ColumnModel;
        List<CikkKeszlet> lKESZLET;

        DateTime t1; DateTime t2;

        public int retRaktID;
        public double retMenny;
        public double needMenny;


        public ChooseKeszletek(List<CikkKeszlet> l)
        {
            InitializeComponent();
            lKESZLET = l;
        }

        private void ChooseKeszletek_Load(object sender, EventArgs e)
        {
            //1. oszlop

            ImageColumn imageColumn = new ImageColumn("", 1);
            imageColumn.Editable = false;

            TextColumn textColumn = new TextColumn("Raktár", 110);
            textColumn.Editable = false;

            NumberColumn ertekColumn = new NumberColumn("Mennyiség", 50);
            ertekColumn.Editable = false;



            _ColumnModel = new ColumnModel(new Column[] {imageColumn, textColumn,
																	  ertekColumn});
            tblKeszletek.ColumnModel = _ColumnModel;
            tblKeszletek.TableModel = getTableModel();

            tblKeszletek.Font = DEFS.f2;
            tblKeszletek.TableModel.RowHeight = 40;

            txtAthozMenny.Text = needMenny.ToString();


        }

        public TableModel getTableModel()
        {
            TableModel tmpMod = new TableModel(new Row[] { });

            for (int i = 0; i < lKESZLET.Count; i++)
            {

                tmpMod.Rows.Add(new Row(new Cell[] {new RaktCell(lKESZLET[i]), new Cell(lKESZLET[i].fNEV),
													new Cell(lKESZLET[i].fKESZLET)}));
            }

            return (tmpMod);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void tblKeszletek_DoubleClick(object sender, EventArgs e)
        {
            foreach (var s in tblKeszletek.SelectedItems)
            {
                retRaktID = ((RaktCell)s.Cells[0]).rK.fRAKTAR_ID;
            }
            if (retRaktID > 0)
            {

                //DialogResult = DialogResult.OK;
                //this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retMenny = Convert.ToDouble(txtAthozMenny.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }





    }
}
