namespace e_Cafe.Admin
{
    partial class frmSyspar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSyspar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pARAMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARAMVALUESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARAMVALUEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARAMVALUEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARAM_VALUE_IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.sYSPARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSYSPAR = new e_Cafe.SQL.dsSYSPAR();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.sYSPARTableAdapter = new e_Cafe.SQL.dsSYSPARTableAdapters.SYSPARTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSPARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSYSPAR)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pARAMNAMEDataGridViewTextBoxColumn,
            this.pARAMVALUESDataGridViewTextBoxColumn,
            this.pARAMVALUEIDataGridViewTextBoxColumn,
            this.pARAMVALUEFDataGridViewTextBoxColumn,
            this.PARAM_VALUE_IMAGE});
            this.dataGridView1.DataSource = this.sYSPARBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // pARAMNAMEDataGridViewTextBoxColumn
            // 
            this.pARAMNAMEDataGridViewTextBoxColumn.DataPropertyName = "PARAM_NAME";
            this.pARAMNAMEDataGridViewTextBoxColumn.HeaderText = "Paraméter neve";
            this.pARAMNAMEDataGridViewTextBoxColumn.Name = "pARAMNAMEDataGridViewTextBoxColumn";
            this.pARAMNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pARAMVALUESDataGridViewTextBoxColumn
            // 
            this.pARAMVALUESDataGridViewTextBoxColumn.DataPropertyName = "PARAM_VALUE_S";
            this.pARAMVALUESDataGridViewTextBoxColumn.HeaderText = "Szöveges érték";
            this.pARAMVALUESDataGridViewTextBoxColumn.Name = "pARAMVALUESDataGridViewTextBoxColumn";
            this.pARAMVALUESDataGridViewTextBoxColumn.Width = 150;
            // 
            // pARAMVALUEIDataGridViewTextBoxColumn
            // 
            this.pARAMVALUEIDataGridViewTextBoxColumn.DataPropertyName = "PARAM_VALUE_I";
            this.pARAMVALUEIDataGridViewTextBoxColumn.HeaderText = "Egész érték";
            this.pARAMVALUEIDataGridViewTextBoxColumn.Name = "pARAMVALUEIDataGridViewTextBoxColumn";
            // 
            // pARAMVALUEFDataGridViewTextBoxColumn
            // 
            this.pARAMVALUEFDataGridViewTextBoxColumn.DataPropertyName = "PARAM_VALUE_F";
            this.pARAMVALUEFDataGridViewTextBoxColumn.HeaderText = "Tizedes érték";
            this.pARAMVALUEFDataGridViewTextBoxColumn.Name = "pARAMVALUEFDataGridViewTextBoxColumn";
            // 
            // PARAM_VALUE_IMAGE
            // 
            this.PARAM_VALUE_IMAGE.DataPropertyName = "PARAM_VALUE_IMAGE";
            this.PARAM_VALUE_IMAGE.HeaderText = "PARAM_VALUE_IMAGE";
            this.PARAM_VALUE_IMAGE.Name = "PARAM_VALUE_IMAGE";
            this.PARAM_VALUE_IMAGE.Visible = false;
            // 
            // sYSPARBindingSource
            // 
            this.sYSPARBindingSource.DataMember = "SYSPAR";
            this.sYSPARBindingSource.DataSource = this.dsSYSPAR;
            // 
            // dsSYSPAR
            // 
            this.dsSYSPAR.DataSetName = "dsSYSPAR";
            this.dsSYSPAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton1.Text = "Kilépés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::e_Cafe.Properties.Resources.floppy_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton2.Text = "Mentés";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pbPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(595, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 301);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.sYSPARBindingSource, "PARAM_VALUE_IMAGE", true));
            this.pbPreview.Location = new System.Drawing.Point(6, 3);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(153, 186);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // sYSPARTableAdapter
            // 
            this.sYSPARTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSyspar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 326);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSyspar";
            this.ShowInTaskbar = false;
            this.Text = "Rendszerparaméterek";
            this.Load += new System.EventHandler(this.frmSyspar_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSyspar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSPARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSYSPAR)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.dsSYSPAR dsSYSPAR;
        private System.Windows.Forms.BindingSource sYSPARBindingSource;
        private e_Cafe.SQL.dsSYSPARTableAdapters.SYSPARTableAdapter sYSPARTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARAMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARAMVALUESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARAMVALUEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARAMVALUEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn PARAM_VALUE_IMAGE;
    }
}