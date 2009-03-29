namespace e_Cafe.Admin
{
    partial class frmPartnerDelete
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsPartnerek = new e_Cafe.dsPartnerek();
            this.pARTNERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTNERTableAdapter = new e_Cafe.dsPartnerekTableAdapters.PARTNERTableAdapter();
            this.pARTNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTIPUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEV2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEV3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKTIVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pARTNERIDDataGridViewTextBoxColumn,
            this.pTIPUSDataGridViewTextBoxColumn,
            this.pNEVDataGridViewTextBoxColumn,
            this.pNEV2DataGridViewTextBoxColumn,
            this.pNEV3DataGridViewTextBoxColumn,
            this.aKTIVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pARTNERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // dsPartnerek
            // 
            this.dsPartnerek.DataSetName = "dsPartnerek";
            this.dsPartnerek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTNERBindingSource
            // 
            this.pARTNERBindingSource.DataMember = "PARTNER";
            this.pARTNERBindingSource.DataSource = this.dsPartnerek;
            // 
            // pARTNERTableAdapter
            // 
            this.pARTNERTableAdapter.ClearBeforeFill = true;
            // 
            // pARTNERIDDataGridViewTextBoxColumn
            // 
            this.pARTNERIDDataGridViewTextBoxColumn.DataPropertyName = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.HeaderText = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.Name = "pARTNERIDDataGridViewTextBoxColumn";
            this.pARTNERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pTIPUSDataGridViewTextBoxColumn
            // 
            this.pTIPUSDataGridViewTextBoxColumn.DataPropertyName = "P_TIPUS";
            this.pTIPUSDataGridViewTextBoxColumn.HeaderText = "P_TIPUS";
            this.pTIPUSDataGridViewTextBoxColumn.Name = "pTIPUSDataGridViewTextBoxColumn";
            // 
            // pNEVDataGridViewTextBoxColumn
            // 
            this.pNEVDataGridViewTextBoxColumn.DataPropertyName = "P_NEV";
            this.pNEVDataGridViewTextBoxColumn.HeaderText = "P_NEV";
            this.pNEVDataGridViewTextBoxColumn.Name = "pNEVDataGridViewTextBoxColumn";
            // 
            // pNEV2DataGridViewTextBoxColumn
            // 
            this.pNEV2DataGridViewTextBoxColumn.DataPropertyName = "P_NEV2";
            this.pNEV2DataGridViewTextBoxColumn.HeaderText = "P_NEV2";
            this.pNEV2DataGridViewTextBoxColumn.Name = "pNEV2DataGridViewTextBoxColumn";
            // 
            // pNEV3DataGridViewTextBoxColumn
            // 
            this.pNEV3DataGridViewTextBoxColumn.DataPropertyName = "P_NEV3";
            this.pNEV3DataGridViewTextBoxColumn.HeaderText = "P_NEV3";
            this.pNEV3DataGridViewTextBoxColumn.Name = "pNEV3DataGridViewTextBoxColumn";
            // 
            // aKTIVDataGridViewTextBoxColumn
            // 
            this.aKTIVDataGridViewTextBoxColumn.DataPropertyName = "AKTIV";
            this.aKTIVDataGridViewTextBoxColumn.HeaderText = "AKTIV";
            this.aKTIVDataGridViewTextBoxColumn.Name = "aKTIVDataGridViewTextBoxColumn";
            // 
            // frmPartnerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 215);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPartnerDelete";
            this.Text = "frmPartnerDelete";
            this.Load += new System.EventHandler(this.frmPartnerDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsPartnerek dsPartnerek;
        private System.Windows.Forms.BindingSource pARTNERBindingSource;
        private e_Cafe.dsPartnerekTableAdapters.PARTNERTableAdapter pARTNERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTNERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTIPUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEV2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEV3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKTIVDataGridViewTextBoxColumn;
    }
}