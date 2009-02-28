

namespace e_Cafe
{
    partial class frmCikkcsoport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCikkcsoport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIKKCSOPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSet = new e_Cafe.SQL.ECAFEDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cIKKCSOPORTTableAdapter = new e_Cafe.SQL.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter();
            this.eCAFEDataSetAFA = new e_Cafe.SQL.ECAFEDataSetAFA();
            this.eCAFEDataSetAFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aFATableAdapter = new e_Cafe.SQL.ECAFEDataSetAFATableAdapters.AFATableAdapter();
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFAKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn,
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn,
            this.aFAKODDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cIKKCSOPORTBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // cIKKCSOPORTBindingSource
            // 
            this.cIKKCSOPORTBindingSource.DataMember = "CIKKCSOPORT";
            this.cIKKCSOPORTBindingSource.DataSource = this.eCAFEDataSet;
            // 
            // eCAFEDataSet
            // 
            this.eCAFEDataSet.DataSetName = "ECAFEDataSet";
            this.eCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(574, 25);
            this.toolStrip1.TabIndex = 1;
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
            // cIKKCSOPORTTableAdapter
            // 
            this.cIKKCSOPORTTableAdapter.ClearBeforeFill = true;
            // 
            // eCAFEDataSetAFA
            // 
            this.eCAFEDataSetAFA.DataSetName = "ECAFEDataSetAFA";
            this.eCAFEDataSetAFA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eCAFEDataSetAFABindingSource
            // 
            this.eCAFEDataSetAFABindingSource.DataSource = this.eCAFEDataSetAFA;
            this.eCAFEDataSetAFABindingSource.Position = 0;
            // 
            // aFABindingSource
            // 
            this.aFABindingSource.DataMember = "AFA";
            this.aFABindingSource.DataSource = this.eCAFEDataSetAFA;
            // 
            // aFATableAdapter
            // 
            this.aFATableAdapter.ClearBeforeFill = true;
            // 
            // cIKKCSOPORTIDDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Name = "cIKKCSOPORTIDDataGridViewTextBoxColumn";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIKKCSOPORTNEVDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_NEV";
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.Name = "cIKKCSOPORTNEVDataGridViewTextBoxColumn";
            // 
            // aFAKODDataGridViewTextBoxColumn
            // 
            this.aFAKODDataGridViewTextBoxColumn.DataPropertyName = "AFA_KOD";
            this.aFAKODDataGridViewTextBoxColumn.DataSource = this.aFABindingSource;
            this.aFAKODDataGridViewTextBoxColumn.DisplayMember = "AFA_NEV";
            this.aFAKODDataGridViewTextBoxColumn.HeaderText = "Áfa kód";
            this.aFAKODDataGridViewTextBoxColumn.Name = "aFAKODDataGridViewTextBoxColumn";
            this.aFAKODDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aFAKODDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aFAKODDataGridViewTextBoxColumn.ValueMember = "AFA_KOD";
            // 
            // frmCikkcsoport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 263);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCikkcsoport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cikkcsoportok";
            this.Load += new System.EventHandler(this.frmCikkcsoport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.ECAFEDataSet eCAFEDataSet;
        private System.Windows.Forms.BindingSource cIKKCSOPORTBindingSource;
        private e_Cafe.SQL.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter cIKKCSOPORTTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private e_Cafe.SQL.ECAFEDataSetAFA eCAFEDataSetAFA;
        private System.Windows.Forms.BindingSource eCAFEDataSetAFABindingSource;
        private System.Windows.Forms.BindingSource aFABindingSource;
        private e_Cafe.SQL.ECAFEDataSetAFATableAdapters.AFATableAdapter aFATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKCSOPORTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKCSOPORTNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aFAKODDataGridViewTextBoxColumn;
    }
}