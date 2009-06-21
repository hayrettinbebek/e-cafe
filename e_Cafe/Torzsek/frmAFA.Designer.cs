

namespace e_Cafe.Torzsek
{
    partial class frmAFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAFA));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aFAKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFANEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFAERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetAFA = new e_Cafe.SQL.DataSets.ECAFEDataSetAFA();
            this.aFATableAdapter = new e_Cafe.SQL.DataSets.ECAFEDataSetAFATableAdapters.AFATableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 25);
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
            this.aFAKODDataGridViewTextBoxColumn,
            this.aFANEVDataGridViewTextBoxColumn,
            this.aFAERTEKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aFABindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 249);
            this.dataGridView1.TabIndex = 1;
            // 
            // aFAKODDataGridViewTextBoxColumn
            // 
            this.aFAKODDataGridViewTextBoxColumn.DataPropertyName = "AFA_KOD";
            this.aFAKODDataGridViewTextBoxColumn.HeaderText = "AFA_KOD";
            this.aFAKODDataGridViewTextBoxColumn.Name = "aFAKODDataGridViewTextBoxColumn";
            // 
            // aFANEVDataGridViewTextBoxColumn
            // 
            this.aFANEVDataGridViewTextBoxColumn.DataPropertyName = "AFA_NEV";
            this.aFANEVDataGridViewTextBoxColumn.HeaderText = "AFA_NEV";
            this.aFANEVDataGridViewTextBoxColumn.Name = "aFANEVDataGridViewTextBoxColumn";
            // 
            // aFAERTEKDataGridViewTextBoxColumn
            // 
            this.aFAERTEKDataGridViewTextBoxColumn.DataPropertyName = "AFA_ERTEK";
            this.aFAERTEKDataGridViewTextBoxColumn.HeaderText = "AFA_ERTEK";
            this.aFAERTEKDataGridViewTextBoxColumn.Name = "aFAERTEKDataGridViewTextBoxColumn";
            // 
            // aFABindingSource
            // 
            this.aFABindingSource.DataMember = "AFA";
            this.aFABindingSource.DataSource = this.eCAFEDataSetAFA;
            // 
            // eCAFEDataSetAFA
            // 
            this.eCAFEDataSetAFA.DataSetName = "ECAFEDataSetAFA";
            this.eCAFEDataSetAFA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aFATableAdapter
            // 
            this.aFATableAdapter.ClearBeforeFill = true;
            // 
            // frmAFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 274);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAFA";
            this.Text = "frmAFA";
            this.Load += new System.EventHandler(this.frmAFA_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetAFA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.DataSets.ECAFEDataSetAFA eCAFEDataSetAFA;
        private System.Windows.Forms.BindingSource aFABindingSource;
        private e_Cafe.SQL.DataSets.ECAFEDataSetAFATableAdapters.AFATableAdapter aFATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFAKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFANEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFAERTEKDataGridViewTextBoxColumn;
    }
}