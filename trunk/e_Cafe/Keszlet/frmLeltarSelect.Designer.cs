namespace e_Cafe.Keszlet
{
    partial class frmLeltarSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeltarSelect));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsLeltar = new e_Cafe.dsLeltar();
            this.chkLezartak = new GUI.ToolStripCheckedBox();
            this.lELTAR_FEJTableAdapter = new e_Cafe.dsLeltarTableAdapters.LELTAR_FEJTableAdapter();
            this.dsLeltarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lELTARFEJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAKTARKODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEZARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLeltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLeltarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lELTARFEJBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 186);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.chkLezartak,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton1.Text = "Folytatás...";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATUMDataGridViewTextBoxColumn,
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn,
            this.rAKTARKODDataGridViewTextBoxColumn,
            this.lEZARTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lELTARFEJBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsLeltar
            // 
            this.dsLeltar.DataSetName = "dsLeltar";
            this.dsLeltar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkLezartak
            // 
            // 
            // chkLezartak
            // 
            this.chkLezartak.MyCheckBox.AccessibleName = "chkLezartak";
            this.chkLezartak.MyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLezartak.MyCheckBox.Location = new System.Drawing.Point(91, 1);
            this.chkLezartak.MyCheckBox.Name = "chkLezartak";
            this.chkLezartak.MyCheckBox.Size = new System.Drawing.Size(77, 22);
            this.chkLezartak.MyCheckBox.TabIndex = 1;
            this.chkLezartak.MyCheckBox.Text = "Lezártak is";
            this.chkLezartak.Name = "chkLezartak";
            this.chkLezartak.Size = new System.Drawing.Size(77, 22);
            this.chkLezartak.Text = "Lezártak is";
            // 
            // lELTAR_FEJTableAdapter
            // 
            this.lELTAR_FEJTableAdapter.ClearBeforeFill = true;
            // 
            // dsLeltarBindingSource
            // 
            this.dsLeltarBindingSource.DataSource = this.dsLeltar;
            this.dsLeltarBindingSource.Position = 0;
            // 
            // lELTARFEJBindingSource
            // 
            this.lELTARFEJBindingSource.DataMember = "LELTAR_FEJ";
            this.lELTARFEJBindingSource.DataSource = this.dsLeltarBindingSource;
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            // 
            // cIKKCSOPORTNEVDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_NEV";
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.HeaderText = "Cikcsoport";
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.Name = "cIKKCSOPORTNEVDataGridViewTextBoxColumn";
            this.cIKKCSOPORTNEVDataGridViewTextBoxColumn.Width = 120;
            // 
            // rAKTARKODDataGridViewTextBoxColumn
            // 
            this.rAKTARKODDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_KOD";
            this.rAKTARKODDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.rAKTARKODDataGridViewTextBoxColumn.Name = "rAKTARKODDataGridViewTextBoxColumn";
            this.rAKTARKODDataGridViewTextBoxColumn.Width = 120;
            // 
            // lEZARTDataGridViewTextBoxColumn
            // 
            this.lEZARTDataGridViewTextBoxColumn.DataPropertyName = "LEZART";
            this.lEZARTDataGridViewTextBoxColumn.FalseValue = "0";
            this.lEZARTDataGridViewTextBoxColumn.HeaderText = "Lezárt";
            this.lEZARTDataGridViewTextBoxColumn.Name = "lEZARTDataGridViewTextBoxColumn";
            this.lEZARTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lEZARTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lEZARTDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(119, 22);
            this.toolStripButton2.Text = "leltárív nyomtatása";
            // 
            // frmLeltarSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLeltarSelect";
            this.Text = "frmLeltarSelect";
            this.Load += new System.EventHandler(this.frmLeltarSelect_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLeltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLeltarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lELTARFEJBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsLeltar dsLeltar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private GUI.ToolStripCheckedBox chkLezartak;
        private e_Cafe.dsLeltarTableAdapters.LELTAR_FEJTableAdapter lELTAR_FEJTableAdapter;
        private System.Windows.Forms.BindingSource dsLeltarBindingSource;
        private System.Windows.Forms.BindingSource lELTARFEJBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKCSOPORTNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAKTARKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lEZARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}