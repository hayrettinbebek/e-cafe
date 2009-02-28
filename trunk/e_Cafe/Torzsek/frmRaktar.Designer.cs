namespace e_Cafe.Torzsek
{
    partial class frmRaktar
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
            this.eCAFEDataSetRAKTAR = new e_Cafe.SQL.ECAFEDataSetRAKTAR();
            this.rAKTARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAKTARTableAdapter = new e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter();
            this.rAKTARIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAKTARKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAKTARLEIRASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAKTARIDDataGridViewTextBoxColumn,
            this.rAKTARKODDataGridViewTextBoxColumn,
            this.rAKTARLEIRASDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rAKTARBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // eCAFEDataSetRAKTAR
            // 
            this.eCAFEDataSetRAKTAR.DataSetName = "ECAFEDataSetRAKTAR";
            this.eCAFEDataSetRAKTAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAKTARBindingSource
            // 
            this.rAKTARBindingSource.DataMember = "RAKTAR";
            this.rAKTARBindingSource.DataSource = this.eCAFEDataSetRAKTAR;
            // 
            // rAKTARTableAdapter
            // 
            this.rAKTARTableAdapter.ClearBeforeFill = true;
            // 
            // rAKTARIDDataGridViewTextBoxColumn
            // 
            this.rAKTARIDDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_ID";
            this.rAKTARIDDataGridViewTextBoxColumn.HeaderText = "Id.";
            this.rAKTARIDDataGridViewTextBoxColumn.Name = "rAKTARIDDataGridViewTextBoxColumn";
            this.rAKTARIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // rAKTARKODDataGridViewTextBoxColumn
            // 
            this.rAKTARKODDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_KOD";
            this.rAKTARKODDataGridViewTextBoxColumn.HeaderText = "Raktár rövid neve";
            this.rAKTARKODDataGridViewTextBoxColumn.Name = "rAKTARKODDataGridViewTextBoxColumn";
            // 
            // rAKTARLEIRASDataGridViewTextBoxColumn
            // 
            this.rAKTARLEIRASDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_LEIRAS";
            this.rAKTARLEIRASDataGridViewTextBoxColumn.HeaderText = "Raktár leírás";
            this.rAKTARLEIRASDataGridViewTextBoxColumn.Name = "rAKTARLEIRASDataGridViewTextBoxColumn";
            this.rAKTARLEIRASDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmRaktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 210);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRaktar";
            this.Text = "frmRaktar";
            this.Load += new System.EventHandler(this.frmRaktar_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRaktar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.ECAFEDataSetRAKTAR eCAFEDataSetRAKTAR;
        private System.Windows.Forms.BindingSource rAKTARBindingSource;
        private e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter rAKTARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAKTARIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAKTARKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAKTARLEIRASDataGridViewTextBoxColumn;
    }
}