namespace e_Cafe.Admin
{
    partial class frmUserJogok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserJogok));
            this.lbJogok = new System.Windows.Forms.ListBox();
            this.jOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJOG = new e_Cafe.SQL.DataSets.dsJOG();
            this._JOGTableAdapter = new e_Cafe.SQL.DataSets.dsJOGTableAdapters._JOGTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERJOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUserJog = new e_Cafe.SQL.DataSets.dsUserJog();
            this._USER_JOGTableAdapter = new e_Cafe.SQL.DataSets.dsUserJogTableAdapters._USER_JOGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJOG)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERJOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUserJog)).BeginInit();
            this.SuspendLayout();
            // 
            // lbJogok
            // 
            this.lbJogok.DataSource = this.jOGBindingSource;
            this.lbJogok.DisplayMember = "JOG_NEV";
            this.lbJogok.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbJogok.FormattingEnabled = true;
            this.lbJogok.Location = new System.Drawing.Point(0, 25);
            this.lbJogok.Name = "lbJogok";
            this.lbJogok.Size = new System.Drawing.Size(226, 238);
            this.lbJogok.TabIndex = 0;
            this.lbJogok.ValueMember = "JOG_ID";
            this.lbJogok.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // jOGBindingSource
            // 
            this.jOGBindingSource.DataMember = "_JOG";
            this.jOGBindingSource.DataSource = this.dsJOG;
            // 
            // dsJOG
            // 
            this.dsJOG.DataSetName = "dsJOG";
            this.dsJOG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _JOGTableAdapter
            // 
            this._JOGTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.jOGIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSERJOGBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(331, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(249, 243);
            this.dataGridView1.TabIndex = 4;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "_USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "_USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERIDDataGridViewTextBoxColumn.Visible = false;
            this.uSERIDDataGridViewTextBoxColumn.Width = 180;
            // 
            // jOGIDDataGridViewTextBoxColumn
            // 
            this.jOGIDDataGridViewTextBoxColumn.DataPropertyName = "_JOG_ID";
            this.jOGIDDataGridViewTextBoxColumn.HeaderText = "Hozzárendelt jogok";
            this.jOGIDDataGridViewTextBoxColumn.Name = "jOGIDDataGridViewTextBoxColumn";
            this.jOGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jOGIDDataGridViewTextBoxColumn.Width = 180;
            // 
            // uSERJOGBindingSource
            // 
            this.uSERJOGBindingSource.DataMember = "_USER_JOG";
            this.uSERJOGBindingSource.DataSource = this.dsUserJog;
            // 
            // dsUserJog
            // 
            this.dsUserJog.DataSetName = "dsUserJog";
            this.dsUserJog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _USER_JOGTableAdapter
            // 
            this._USER_JOGTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserJogok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbJogok);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmUserJogok";
            this.ShowInTaskbar = false;
            this.Text = "Felhasználó jogai";
            this.Load += new System.EventHandler(this.frmUserJogok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJOG)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERJOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUserJog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbJogok;
        private e_Cafe.SQL.DataSets.dsJOG dsJOG;
        private System.Windows.Forms.BindingSource jOGBindingSource;
        private e_Cafe.SQL.DataSets.dsJOGTableAdapters._JOGTableAdapter _JOGTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.DataSets.dsUserJog dsUserJog;
        private System.Windows.Forms.BindingSource uSERJOGBindingSource;
        private e_Cafe.SQL.DataSets.dsUserJogTableAdapters._USER_JOGTableAdapter _USER_JOGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOGIDDataGridViewTextBoxColumn;
    }
}