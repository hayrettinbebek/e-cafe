namespace e_Cafe.Keszlet
{
    partial class frmKeszletKarton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgKarton = new System.Windows.Forms.DataGridView();
            this.keszletSorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CIKK_NEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAKTARKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kESZLETNYITODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kESZLETERTEKNYITODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bESZERZESIARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIKK_ALL_KESZLET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MINIMUM_KESZLET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTIMALIS_KESZLET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgKarton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keszletSorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKarton
            // 
            this.dgKarton.AllowUserToAddRows = false;
            this.dgKarton.AllowUserToDeleteRows = false;
            this.dgKarton.AutoGenerateColumns = false;
            this.dgKarton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKarton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIKK_NEV,
            this.rAKTARKODDataGridViewTextBoxColumn,
            this.kESZLETNYITODataGridViewTextBoxColumn,
            this.kESZLETERTEKNYITODataGridViewTextBoxColumn,
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn,
            this.bESZERZESIARDataGridViewTextBoxColumn,
            this.CIKK_ALL_KESZLET,
            this.MINIMUM_KESZLET,
            this.OPTIMALIS_KESZLET,
            this.cIKKIDDataGridViewTextBoxColumn,
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn});
            this.dgKarton.DataSource = this.keszletSorBindingSource;
            this.dgKarton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKarton.Location = new System.Drawing.Point(0, 0);
            this.dgKarton.Name = "dgKarton";
            this.dgKarton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKarton.Size = new System.Drawing.Size(989, 449);
            this.dgKarton.TabIndex = 0;
            this.dgKarton.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgKarton_RowPrePaint);
            this.dgKarton.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgKarton_CellPainting);
            this.dgKarton.Paint += new System.Windows.Forms.PaintEventHandler(this.dgKarton_Paint);
            // 
            // keszletSorBindingSource
            // 
            this.keszletSorBindingSource.DataSource = typeof(BusinessLogic.KeszletSor);
            // 
            // CIKK_NEV
            // 
            this.CIKK_NEV.DataPropertyName = "CIKK_NEV";
            this.CIKK_NEV.HeaderText = "Cikk";
            this.CIKK_NEV.Name = "CIKK_NEV";
            this.CIKK_NEV.ReadOnly = true;
            // 
            // rAKTARKODDataGridViewTextBoxColumn
            // 
            this.rAKTARKODDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_KOD";
            this.rAKTARKODDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.rAKTARKODDataGridViewTextBoxColumn.Name = "rAKTARKODDataGridViewTextBoxColumn";
            // 
            // kESZLETNYITODataGridViewTextBoxColumn
            // 
            this.kESZLETNYITODataGridViewTextBoxColumn.DataPropertyName = "KESZLET_NYITO";
            this.kESZLETNYITODataGridViewTextBoxColumn.HeaderText = "Készlet mennyiség";
            this.kESZLETNYITODataGridViewTextBoxColumn.Name = "kESZLETNYITODataGridViewTextBoxColumn";
            this.kESZLETNYITODataGridViewTextBoxColumn.Width = 120;
            // 
            // kESZLETERTEKNYITODataGridViewTextBoxColumn
            // 
            this.kESZLETERTEKNYITODataGridViewTextBoxColumn.DataPropertyName = "KESZLET_ERTEK_NYITO";
            this.kESZLETERTEKNYITODataGridViewTextBoxColumn.HeaderText = "Készlet értéke";
            this.kESZLETERTEKNYITODataGridViewTextBoxColumn.Name = "kESZLETERTEKNYITODataGridViewTextBoxColumn";
            this.kESZLETERTEKNYITODataGridViewTextBoxColumn.Width = 120;
            // 
            // mEGYSMEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGYS_MEGNEVEZES";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "Mennyiségi egység";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGYSMEGNEVEZESDataGridViewTextBoxColumn";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.Width = 70;
            // 
            // bESZERZESIARDataGridViewTextBoxColumn
            // 
            this.bESZERZESIARDataGridViewTextBoxColumn.DataPropertyName = "BESZERZESI_AR";
            this.bESZERZESIARDataGridViewTextBoxColumn.HeaderText = "Beszerzési ár";
            this.bESZERZESIARDataGridViewTextBoxColumn.Name = "bESZERZESIARDataGridViewTextBoxColumn";
            // 
            // CIKK_ALL_KESZLET
            // 
            this.CIKK_ALL_KESZLET.DataPropertyName = "CIKK_ALL_KESZLET";
            this.CIKK_ALL_KESZLET.HeaderText = "Készlet összesen";
            this.CIKK_ALL_KESZLET.Name = "CIKK_ALL_KESZLET";
            this.CIKK_ALL_KESZLET.ReadOnly = true;
            // 
            // MINIMUM_KESZLET
            // 
            this.MINIMUM_KESZLET.DataPropertyName = "MINIMUM_KESZLET";
            this.MINIMUM_KESZLET.HeaderText = "Minimum készlet";
            this.MINIMUM_KESZLET.Name = "MINIMUM_KESZLET";
            // 
            // OPTIMALIS_KESZLET
            // 
            this.OPTIMALIS_KESZLET.DataPropertyName = "OPTIMALIS_KESZLET";
            this.OPTIMALIS_KESZLET.HeaderText = "Optimális készlet";
            this.OPTIMALIS_KESZLET.Name = "OPTIMALIS_KESZLET";
            // 
            // cIKKIDDataGridViewTextBoxColumn
            // 
            this.cIKKIDDataGridViewTextBoxColumn.DataPropertyName = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.HeaderText = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.Name = "cIKKIDDataGridViewTextBoxColumn";
            this.cIKKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIKKCSOPORTIDDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.HeaderText = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Name = "cIKKCSOPORTIDDataGridViewTextBoxColumn";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmKeszletKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 449);
            this.Controls.Add(this.dgKarton);
            this.Name = "frmKeszletKarton";
            this.Text = "Készletkarton";
            this.Load += new System.EventHandler(this.frmKeszletKarton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKarton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keszletSorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKarton;
        private System.Windows.Forms.BindingSource keszletSorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIKK_NEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAKTARKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kESZLETNYITODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kESZLETERTEKNYITODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGYSMEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bESZERZESIARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIKK_ALL_KESZLET;
        private System.Windows.Forms.DataGridViewTextBoxColumn MINIMUM_KESZLET;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTIMALIS_KESZLET;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKCSOPORTIDDataGridViewTextBoxColumn;


    }
}