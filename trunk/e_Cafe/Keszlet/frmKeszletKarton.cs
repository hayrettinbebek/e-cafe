using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace e_Cafe.Keszlet
{
    public partial class frmKeszletKarton : Form
    {
        public frmKeszletKarton()
        {
            InitializeComponent();
        }

        private void frmKeszletKarton_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            keszletSorBindingSource.Clear();
            KeszletKarton kk = new KeszletKarton();

            foreach (var k in kk.getKarton())
            {
                keszletSorBindingSource.Add(k);
            }

            for (int i = 0; i < dgKarton.RowCount; i++)
            {
                if ((double)dgKarton.Rows[i].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[i].Cells[dgKarton.Columns["OPTIMALIS_KESZLET"].Index].Value)
                {
                    
                    dgKarton.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if ((double)dgKarton.Rows[i].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[i].Cells[dgKarton.Columns["MINIMUM_KESZLET"].Index].Value)
                {

                    dgKarton.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }


            }
            dgKarton.Refresh();


        }

 


        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgKarton_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
            //if ((double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["OPTIMALIS_KESZLET"].Index].Value)
            //{

            //    dgKarton.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            //}
            //if ((double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["MINIMUM_KESZLET"].Index].Value)
            //{

            //    dgKarton.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            //}
        }

        private void dgKarton_Paint(object sender, PaintEventArgs e)
        {
             
            //for (int i = 0; i < dgKarton.RowCount; i++)
            //{
            //    if ((double)dgKarton.Rows[i].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[i].Cells[dgKarton.Columns["OPTIMALIS_KESZLET"].Index].Value)
            //    {

            //        dgKarton.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //    }
            //    if ((double)dgKarton.Rows[i].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[i].Cells[dgKarton.Columns["MINIMUM_KESZLET"].Index].Value)
            //    {

            //        dgKarton.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //    }


            //}
        }

        private void dgKarton_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if ((e.RowIndex != -1) && (e.ColumnIndex == dgKarton.Columns["CIKK_ALL_KESZLET"].Index))
            //{
            //    if ((double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["OPTIMALIS_KESZLET"].Index].Value)
            //    {
            //        dgKarton.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
            //        //dgKarton.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            //    }
            //    if ((double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["CIKK_ALL_KESZLET"].Index].Value < (double)dgKarton.Rows[e.RowIndex].Cells[dgKarton.Columns["MINIMUM_KESZLET"].Index].Value)
            //    {
            //        dgKarton.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            //        //dgKarton.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            //    }
                
                
            //}
            if (this.dgKarton.Columns["CIKK_ALL_KESZLET"].Index ==
                   e.ColumnIndex && e.RowIndex >= 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X + 1,
                    e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                    e.CellBounds.Height - 4);

                using (
                    Brush gridBrush = new SolidBrush(this.dgKarton.GridColor),
                    backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // Draw the grid lines (only the right and bottom lines;
                        // DataGridView takes care of the others).
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                            e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                            e.CellBounds.Top, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom);

                        // Draw the inset highlight box.
                       // e.Graphics.DrawRectangle(Pens.Blue, newRect);

                        // Draw the text content of the cell, ignoring alignment.
                        if (e.Value != null)
                        {
                            e.Graphics.DrawString((String)e.Value.ToString(), e.CellStyle.Font,
                                Brushes.Crimson, e.CellBounds.X + 2,
                                e.CellBounds.Y + 2, StringFormat.GenericDefault);
                        }
                        e.Handled = true;
                    }
                }
            }



        }
    }
}
