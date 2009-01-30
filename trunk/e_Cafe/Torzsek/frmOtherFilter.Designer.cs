namespace e_Cafe.Torzsek
{
    partial class frmOtherFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtherFilter));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eCAFEDataSetOTHER_FILTER = new e_Cafe.ECAFEDataSetOTHER_FILTER();
            this.cIKCSOPOTHERFILTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIKCSOP_OTHER_FILTERTableAdapter = new e_Cafe.ECAFEDataSetOTHER_FILTERTableAdapters.CIKCSOP_OTHER_FILTERTableAdapter();
            this.eCAFEDataSet = new e_Cafe.ECAFEDataSet();
            this.cIKKCSOPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIKKCSOPORTTableAdapter = new e_Cafe.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter();
            this.oTHERFILTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oTHERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetOTHER_FILTER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKCSOPOTHERFILTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(402, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Mentés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oTHERFILTERIDDataGridViewTextBoxColumn,
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn,
            this.oTHERNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cIKCSOPOTHERFILTERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 156);
            this.dataGridView1.TabIndex = 1;
            // 
            // eCAFEDataSetOTHER_FILTER
            // 
            this.eCAFEDataSetOTHER_FILTER.DataSetName = "ECAFEDataSetOTHER_FILTER";
            this.eCAFEDataSetOTHER_FILTER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIKCSOPOTHERFILTERBindingSource
            // 
            this.cIKCSOPOTHERFILTERBindingSource.DataMember = "CIKCSOP_OTHER_FILTER";
            this.cIKCSOPOTHERFILTERBindingSource.DataSource = this.eCAFEDataSetOTHER_FILTER;
            // 
            // cIKCSOP_OTHER_FILTERTableAdapter
            // 
            this.cIKCSOP_OTHER_FILTERTableAdapter.ClearBeforeFill = true;
            // 
            // eCAFEDataSet
            // 
            this.eCAFEDataSet.DataSetName = "ECAFEDataSet";
            this.eCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIKKCSOPORTBindingSource
            // 
            this.cIKKCSOPORTBindingSource.DataMember = "CIKKCSOPORT";
            this.cIKKCSOPORTBindingSource.DataSource = this.eCAFEDataSet;
            // 
            // cIKKCSOPORTTableAdapter
            // 
            this.cIKKCSOPORTTableAdapter.ClearBeforeFill = true;
            // 
            // oTHERFILTERIDDataGridViewTextBoxColumn
            // 
            this.oTHERFILTERIDDataGridViewTextBoxColumn.DataPropertyName = "OTHER_FILTER_ID";
            this.oTHERFILTERIDDataGridViewTextBoxColumn.HeaderText = "OTHER_FILTER_ID";
            this.oTHERFILTERIDDataGridViewTextBoxColumn.Name = "oTHERFILTERIDDataGridViewTextBoxColumn";
            this.oTHERFILTERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIKKCSOPORTIDDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DataSource = this.cIKKCSOPORTBindingSource;
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DisplayMember = "CIKKCSOPORT_NEV";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.HeaderText = "Cikkcsoport";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Name = "cIKKCSOPORTIDDataGridViewTextBoxColumn";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.ValueMember = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // oTHERNAMEDataGridViewTextBoxColumn
            // 
            this.oTHERNAMEDataGridViewTextBoxColumn.DataPropertyName = "OTHER_NAME";
            this.oTHERNAMEDataGridViewTextBoxColumn.HeaderText = "Alcsoport megnevezés";
            this.oTHERNAMEDataGridViewTextBoxColumn.Name = "oTHERNAMEDataGridViewTextBoxColumn";
            this.oTHERNAMEDataGridViewTextBoxColumn.Width = 190;
            // 
            // frmOtherFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 181);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOtherFilter";
            this.Text = "Alcsoportok";
            this.Load += new System.EventHandler(this.frmOtherFilter_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetOTHER_FILTER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKCSOPOTHERFILTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ECAFEDataSetOTHER_FILTER eCAFEDataSetOTHER_FILTER;
        private System.Windows.Forms.BindingSource cIKCSOPOTHERFILTERBindingSource;
        private e_Cafe.ECAFEDataSetOTHER_FILTERTableAdapters.CIKCSOP_OTHER_FILTERTableAdapter cIKCSOP_OTHER_FILTERTableAdapter;
        private ECAFEDataSet eCAFEDataSet;
        private System.Windows.Forms.BindingSource cIKKCSOPORTBindingSource;
        private e_Cafe.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter cIKKCSOPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHERFILTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cIKKCSOPORTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHERNAMEDataGridViewTextBoxColumn;
    }
}