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
            this.hELYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hELYNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hELYVANDESIGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AKTIV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hELYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetHELY = new e_Cafe.SQL.ECAFEDataSetHELY();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.hELYTableAdapter = new e_Cafe.SQL.ECAFEDataSetHELYTableAdapters.HELYTableAdapter();
            this.chkInaktivak = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hELYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetHELY)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hELYIDDataGridViewTextBoxColumn,
            this.hELYNEVDataGridViewTextBoxColumn,
            this.hELYVANDESIGNDataGridViewTextBoxColumn,
            this.AKTIV});
            this.dataGridView1.DataSource = this.hELYBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 178);
            this.dataGridView1.TabIndex = 0;
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
            // AKTIV
            // 
            this.AKTIV.DataPropertyName = "AKTIV";
            this.AKTIV.FalseValue = "0";
            this.AKTIV.HeaderText = "Aktív";
            this.AKTIV.Name = "AKTIV";
            this.AKTIV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AKTIV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AKTIV.TrueValue = "1";
            // 
            // hELYBindingSource
            // 
            this.hELYBindingSource.DataMember = "HELY";
            this.hELYBindingSource.DataSource = this.eCAFEDataSetHELY;
            // 
            // eCAFEDataSetHELY
            // 
            this.eCAFEDataSetHELY.DataSetName = "ECAFEDataSetHELY";
            this.eCAFEDataSetHELY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hELYBindingSource, "HELY_NEV", true));
            this.textBox1.Location = new System.Drawing.Point(12, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(438, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::e_Cafe.Properties.Resources.floppy_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Mentés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // hELYTableAdapter
            // 
            this.hELYTableAdapter.ClearBeforeFill = true;
            // 
            // chkInaktivak
            // 
            this.chkInaktivak.AutoSize = true;
            this.chkInaktivak.BackColor = System.Drawing.Color.Transparent;
            this.chkInaktivak.Location = new System.Drawing.Point(346, 2);
            this.chkInaktivak.Name = "chkInaktivak";
            this.chkInaktivak.Size = new System.Drawing.Size(82, 17);
            this.chkInaktivak.TabIndex = 3;
            this.chkInaktivak.Text = "Inaktívak is";
            this.chkInaktivak.UseVisualStyleBackColor = false;
            this.chkInaktivak.CheckedChanged += new System.EventHandler(this.chkInaktivak_CheckedChanged);
            // 
            // frmHelyek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 203);
            this.Controls.Add(this.chkInaktivak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHelyek";
            this.Text = "frmHelyek";
            this.Load += new System.EventHandler(this.frmHelyek_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelyek_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hELYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetHELY)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.ECAFEDataSetHELY eCAFEDataSetHELY;
        private System.Windows.Forms.BindingSource hELYBindingSource;
        private e_Cafe.SQL.ECAFEDataSetHELYTableAdapters.HELYTableAdapter hELYTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hELYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hELYNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hELYVANDESIGNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AKTIV;
        private System.Windows.Forms.CheckBox chkInaktivak;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}