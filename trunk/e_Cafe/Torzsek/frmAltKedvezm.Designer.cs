namespace e_Cafe.Torzsek
{
    partial class frmAltKedvezm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltKedvezm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsALTALANOS_KEDVEZMENY = new e_Cafe.SQL.DataSets.dsALTALANOS_KEDVEZMENY();
            this.aLTALANOSKEDVEZMENYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLTALANOS_KEDVEZMENYTableAdapter = new e_Cafe.SQL.DataSets.dsALTALANOS_KEDVEZMENYTableAdapters.ALTALANOS_KEDVEZMENYTableAdapter();
            this.kEDEZMENYSZAZALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kEDEZMENYJOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsALTALANOS_KEDVEZMENY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTALANOSKEDVEZMENYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kEDEZMENYSZAZALDataGridViewTextBoxColumn,
            this.kEDEZMENYJOGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLTALANOSKEDVEZMENYBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 248);
            this.dataGridView1.TabIndex = 2;
            // 
            // dsALTALANOS_KEDVEZMENY
            // 
            this.dsALTALANOS_KEDVEZMENY.DataSetName = "dsALTALANOS_KEDVEZMENY";
            this.dsALTALANOS_KEDVEZMENY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLTALANOSKEDVEZMENYBindingSource
            // 
            this.aLTALANOSKEDVEZMENYBindingSource.DataMember = "ALTALANOS_KEDVEZMENY";
            this.aLTALANOSKEDVEZMENYBindingSource.DataSource = this.dsALTALANOS_KEDVEZMENY;
            // 
            // aLTALANOS_KEDVEZMENYTableAdapter
            // 
            this.aLTALANOS_KEDVEZMENYTableAdapter.ClearBeforeFill = true;
            // 
            // kEDEZMENYSZAZALDataGridViewTextBoxColumn
            // 
            this.kEDEZMENYSZAZALDataGridViewTextBoxColumn.DataPropertyName = "KEDEZMENY_SZAZAL";
            this.kEDEZMENYSZAZALDataGridViewTextBoxColumn.HeaderText = "Százalék";
            this.kEDEZMENYSZAZALDataGridViewTextBoxColumn.Name = "kEDEZMENYSZAZALDataGridViewTextBoxColumn";
            // 
            // kEDEZMENYJOGDataGridViewTextBoxColumn
            // 
            this.kEDEZMENYJOGDataGridViewTextBoxColumn.DataPropertyName = "KEDEZMENY_JOG";
            this.kEDEZMENYJOGDataGridViewTextBoxColumn.HeaderText = "Jog";
            this.kEDEZMENYJOGDataGridViewTextBoxColumn.Name = "kEDEZMENYJOGDataGridViewTextBoxColumn";
            this.kEDEZMENYJOGDataGridViewTextBoxColumn.Width = 130;
            // 
            // frmAltKedvezm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAltKedvezm";
            this.Text = "Általános kedvezmények";
            this.Load += new System.EventHandler(this.frmAltKedvezm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsALTALANOS_KEDVEZMENY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLTALANOSKEDVEZMENYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.DataSets.dsALTALANOS_KEDVEZMENY dsALTALANOS_KEDVEZMENY;
        private System.Windows.Forms.BindingSource aLTALANOSKEDVEZMENYBindingSource;
        private e_Cafe.SQL.DataSets.dsALTALANOS_KEDVEZMENYTableAdapters.ALTALANOS_KEDVEZMENYTableAdapter aLTALANOS_KEDVEZMENYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kEDEZMENYSZAZALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kEDEZMENYJOGDataGridViewTextBoxColumn;
    }
}