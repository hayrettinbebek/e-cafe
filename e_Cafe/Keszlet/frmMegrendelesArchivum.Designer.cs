namespace e_Cafe.Keszlet
{
    partial class frmMegrendelesArchivum
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORSZAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGRENDELESFEJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMegrendeles = new e_Cafe.SQL.dsMegrendeles();
            this.mEGRENDELES_FEJTableAdapter = new e_Cafe.SQL.dsMegrendelesTableAdapters.MEGRENDELES_FEJTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENNYISEGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bESZARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGRENDELESFEJMEGRENDELESSORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEGRENDELES_SORTableAdapter = new e_Cafe.SQL.dsMegrendelesTableAdapters.MEGRENDELES_SORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJMEGRENDELESSORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATUMDataGridViewTextBoxColumn,
            this.pNEVDataGridViewTextBoxColumn,
            this.sORSZAMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEGRENDELESFEJBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 125);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            this.dATUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNEVDataGridViewTextBoxColumn
            // 
            this.pNEVDataGridViewTextBoxColumn.DataPropertyName = "P_NEV";
            this.pNEVDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.pNEVDataGridViewTextBoxColumn.Name = "pNEVDataGridViewTextBoxColumn";
            this.pNEVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sORSZAMDataGridViewTextBoxColumn
            // 
            this.sORSZAMDataGridViewTextBoxColumn.DataPropertyName = "SORSZAM";
            this.sORSZAMDataGridViewTextBoxColumn.HeaderText = "Sorszám";
            this.sORSZAMDataGridViewTextBoxColumn.Name = "sORSZAMDataGridViewTextBoxColumn";
            this.sORSZAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mEGRENDELESFEJBindingSource
            // 
            this.mEGRENDELESFEJBindingSource.DataMember = "MEGRENDELES_FEJ";
            this.mEGRENDELESFEJBindingSource.DataSource = this.dsMegrendeles;
            // 
            // dsMegrendeles
            // 
            this.dsMegrendeles.DataSetName = "dsMegrendeles";
            this.dsMegrendeles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEGRENDELES_FEJTableAdapter
            // 
            this.mEGRENDELES_FEJTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEGNEVEZESDataGridViewTextBoxColumn,
            this.mENNYISEGDataGridViewTextBoxColumn,
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn,
            this.bESZARDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mEGRENDELESFEJMEGRENDELESSORBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(736, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // mEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGNEVEZES";
            this.mEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "Cikk";
            this.mEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGNEVEZESDataGridViewTextBoxColumn";
            this.mEGNEVEZESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mENNYISEGDataGridViewTextBoxColumn
            // 
            this.mENNYISEGDataGridViewTextBoxColumn.DataPropertyName = "MENNYISEG";
            this.mENNYISEGDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mENNYISEGDataGridViewTextBoxColumn.Name = "mENNYISEGDataGridViewTextBoxColumn";
            this.mENNYISEGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mEGYSMEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGYS_MEGNEVEZES";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "Me.";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGYSMEGNEVEZESDataGridViewTextBoxColumn";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.ReadOnly = true;
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.Width = 50;
            // 
            // bESZARDataGridViewTextBoxColumn
            // 
            this.bESZARDataGridViewTextBoxColumn.DataPropertyName = "BESZ_AR";
            this.bESZARDataGridViewTextBoxColumn.HeaderText = "Beszerzési ár";
            this.bESZARDataGridViewTextBoxColumn.Name = "bESZARDataGridViewTextBoxColumn";
            this.bESZARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mEGRENDELESFEJMEGRENDELESSORBindingSource
            // 
            this.mEGRENDELESFEJMEGRENDELESSORBindingSource.DataMember = "MEGRENDELES_FEJ_MEGRENDELES_SOR";
            this.mEGRENDELESFEJMEGRENDELESSORBindingSource.DataSource = this.mEGRENDELESFEJBindingSource;
            // 
            // mEGRENDELES_SORTableAdapter
            // 
            this.mEGRENDELES_SORTableAdapter.ClearBeforeFill = true;
            // 
            // frmMegrendelesArchivum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 293);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMegrendelesArchivum";
            this.Text = "Megrendelések";
            this.Load += new System.EventHandler(this.frmMegrendelesArchivum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJMEGRENDELESSORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.dsMegrendeles dsMegrendeles;
        private System.Windows.Forms.BindingSource mEGRENDELESFEJBindingSource;
        private e_Cafe.SQL.dsMegrendelesTableAdapters.MEGRENDELES_FEJTableAdapter mEGRENDELES_FEJTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource mEGRENDELESFEJMEGRENDELESSORBindingSource;
        private e_Cafe.SQL.dsMegrendelesTableAdapters.MEGRENDELES_SORTableAdapter mEGRENDELES_SORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORSZAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENNYISEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGYSMEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bESZARDataGridViewTextBoxColumn;
    }
}