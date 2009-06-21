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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartnerDelete));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsNameFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAction = new System.Windows.Forms.ToolStripButton();
            this.pARTNERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPartnerek = new e_Cafe.SQL.DataSets.dsPartnerek();
            this.pARTNERTableAdapter = new e_Cafe.SQL.DataSets.dsPartnerekTableAdapters.PARTNERTableAdapter();
            this.pARTNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTIPUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEV2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEV3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKTIVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsNameFilter,
            this.tsbAction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(708, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // tsNameFilter
            // 
            this.tsNameFilter.BackColor = System.Drawing.Color.White;
            this.tsNameFilter.Name = "tsNameFilter";
            this.tsNameFilter.Size = new System.Drawing.Size(150, 25);
            this.tsNameFilter.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Kereső";
            // 
            // tsbAction
            // 
            this.tsbAction.Image = ((System.Drawing.Image)(resources.GetObject("tsbAction.Image")));
            this.tsbAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAction.Name = "tsbAction";
            this.tsbAction.Size = new System.Drawing.Size(55, 22);
            this.tsbAction.Text = "Töröl";
            this.tsbAction.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pARTNERBindingSource
            // 
            this.pARTNERBindingSource.AllowNew = false;
            this.pARTNERBindingSource.DataMember = "PARTNER";
            this.pARTNERBindingSource.DataSource = this.dsPartnerek;
            // 
            // dsPartnerek
            // 
            this.dsPartnerek.DataSetName = "dsPartnerek";
            this.dsPartnerek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.pARTNERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pTIPUSDataGridViewTextBoxColumn
            // 
            this.pTIPUSDataGridViewTextBoxColumn.DataPropertyName = "P_TIPUS";
            this.pTIPUSDataGridViewTextBoxColumn.HeaderText = "P_TIPUS";
            this.pTIPUSDataGridViewTextBoxColumn.Name = "pTIPUSDataGridViewTextBoxColumn";
            this.pTIPUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // pNEVDataGridViewTextBoxColumn
            // 
            this.pNEVDataGridViewTextBoxColumn.DataPropertyName = "P_NEV";
            this.pNEVDataGridViewTextBoxColumn.HeaderText = "Név";
            this.pNEVDataGridViewTextBoxColumn.Name = "pNEVDataGridViewTextBoxColumn";
            // 
            // pNEV2DataGridViewTextBoxColumn
            // 
            this.pNEV2DataGridViewTextBoxColumn.DataPropertyName = "P_NEV2";
            this.pNEV2DataGridViewTextBoxColumn.HeaderText = "";
            this.pNEV2DataGridViewTextBoxColumn.Name = "pNEV2DataGridViewTextBoxColumn";
            // 
            // pNEV3DataGridViewTextBoxColumn
            // 
            this.pNEV3DataGridViewTextBoxColumn.DataPropertyName = "P_NEV3";
            this.pNEV3DataGridViewTextBoxColumn.HeaderText = "";
            this.pNEV3DataGridViewTextBoxColumn.Name = "pNEV3DataGridViewTextBoxColumn";
            // 
            // aKTIVDataGridViewTextBoxColumn
            // 
            this.aKTIVDataGridViewTextBoxColumn.DataPropertyName = "AKTIV";
            this.aKTIVDataGridViewTextBoxColumn.HeaderText = "AKTIV";
            this.aKTIVDataGridViewTextBoxColumn.Name = "aKTIVDataGridViewTextBoxColumn";
            this.aKTIVDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aKTIVDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmPartnerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 215);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPartnerDelete";
            this.Text = "Partnerek törlése";
            this.Load += new System.EventHandler(this.frmPartnerDelete_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.DataSets.dsPartnerek dsPartnerek;
        private System.Windows.Forms.BindingSource pARTNERBindingSource;
        private e_Cafe.SQL.DataSets.dsPartnerekTableAdapters.PARTNERTableAdapter pARTNERTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsNameFilter;
        private System.Windows.Forms.ToolStripButton tsbAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTNERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTIPUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEV2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEV3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aKTIVDataGridViewTextBoxColumn;
    }
}