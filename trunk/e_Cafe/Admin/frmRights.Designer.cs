namespace e_Cafe.Admin
{
    partial class frmRights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRights));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsJOG = new e_Cafe.dsJOG();
            this.jOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._JOGTableAdapter = new e_Cafe.dsJOGTableAdapters._JOGTableAdapter();
            this.jOGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOGNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Kilépés";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton2.Text = "Mentés";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOGIDDataGridViewTextBoxColumn,
            this.jOGNEVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jOGBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 232);
            this.dataGridView1.TabIndex = 3;
            // 
            // dsJOG
            // 
            this.dsJOG.DataSetName = "dsJOG";
            this.dsJOG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOGBindingSource
            // 
            this.jOGBindingSource.DataMember = "_JOG";
            this.jOGBindingSource.DataSource = this.dsJOG;
            // 
            // _JOGTableAdapter
            // 
            this._JOGTableAdapter.ClearBeforeFill = true;
            // 
            // jOGIDDataGridViewTextBoxColumn
            // 
            this.jOGIDDataGridViewTextBoxColumn.DataPropertyName = "JOG_ID";
            this.jOGIDDataGridViewTextBoxColumn.HeaderText = "Kód";
            this.jOGIDDataGridViewTextBoxColumn.Name = "jOGIDDataGridViewTextBoxColumn";
            // 
            // jOGNEVDataGridViewTextBoxColumn
            // 
            this.jOGNEVDataGridViewTextBoxColumn.DataPropertyName = "JOG_NEV";
            this.jOGNEVDataGridViewTextBoxColumn.HeaderText = "Leírás";
            this.jOGNEVDataGridViewTextBoxColumn.Name = "jOGNEVDataGridViewTextBoxColumn";
            this.jOGNEVDataGridViewTextBoxColumn.Width = 300;
            // 
            // frmRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 257);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRights";
            this.ShowInTaskbar = false;
            this.Text = "Jogok karbantartása";
            this.Load += new System.EventHandler(this.frmRights_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsJOG dsJOG;
        private System.Windows.Forms.BindingSource jOGBindingSource;
        private e_Cafe.dsJOGTableAdapters._JOGTableAdapter _JOGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOGNEVDataGridViewTextBoxColumn;
    }
}