namespace e_Cafe.Torzsek
{
    partial class frmHelyek
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
            this.eCAFEDataSetHELY = new e_Cafe.ECAFEDataSetHELY();
            this.hELYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hELYTableAdapter = new e_Cafe.ECAFEDataSetHELYTableAdapters.HELYTableAdapter();
            this.hELYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hELYNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hELYVANDESIGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetHELY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hELYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hELYIDDataGridViewTextBoxColumn,
            this.hELYNEVDataGridViewTextBoxColumn,
            this.hELYVANDESIGNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hELYBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // eCAFEDataSetHELY
            // 
            this.eCAFEDataSetHELY.DataSetName = "ECAFEDataSetHELY";
            this.eCAFEDataSetHELY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hELYBindingSource
            // 
            this.hELYBindingSource.DataMember = "HELY";
            this.hELYBindingSource.DataSource = this.eCAFEDataSetHELY;
            // 
            // hELYTableAdapter
            // 
            this.hELYTableAdapter.ClearBeforeFill = true;
            // 
            // hELYIDDataGridViewTextBoxColumn
            // 
            this.hELYIDDataGridViewTextBoxColumn.DataPropertyName = "HELY_ID";
            this.hELYIDDataGridViewTextBoxColumn.HeaderText = "HELY_ID";
            this.hELYIDDataGridViewTextBoxColumn.Name = "hELYIDDataGridViewTextBoxColumn";
            this.hELYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hELYIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hELYNEVDataGridViewTextBoxColumn
            // 
            this.hELYNEVDataGridViewTextBoxColumn.DataPropertyName = "HELY_NEV";
            this.hELYNEVDataGridViewTextBoxColumn.HeaderText = "Megnevezes";
            this.hELYNEVDataGridViewTextBoxColumn.Name = "hELYNEVDataGridViewTextBoxColumn";
            // 
            // hELYVANDESIGNDataGridViewTextBoxColumn
            // 
            this.hELYVANDESIGNDataGridViewTextBoxColumn.DataPropertyName = "HELY_VAN_DESIGN";
            this.hELYVANDESIGNDataGridViewTextBoxColumn.FalseValue = "0";
            this.hELYVANDESIGNDataGridViewTextBoxColumn.HeaderText = "Asztalok vannak-e";
            this.hELYVANDESIGNDataGridViewTextBoxColumn.Name = "hELYVANDESIGNDataGridViewTextBoxColumn";
            this.hELYVANDESIGNDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hELYVANDESIGNDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hELYVANDESIGNDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // frmHelyek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 203);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHelyek";
            this.Text = "frmHelyek";
            this.Load += new System.EventHandler(this.frmHelyek_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelyek_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetHELY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hELYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ECAFEDataSetHELY eCAFEDataSetHELY;
        private System.Windows.Forms.BindingSource hELYBindingSource;
        private e_Cafe.ECAFEDataSetHELYTableAdapters.HELYTableAdapter hELYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hELYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hELYNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hELYVANDESIGNDataGridViewTextBoxColumn;
    }
}