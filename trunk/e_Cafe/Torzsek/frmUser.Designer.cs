namespace e_Cafe.Torzsek
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGINNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lOCKEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lOCKEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKTIVDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Text = "Új felhasználó";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "Módosítás";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton3.Text = "Kilépés";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.lOGINNAMEDataGridViewTextBoxColumn,
            this.pWDataGridViewTextBoxColumn,
            this.sUPERDataGridViewTextBoxColumn,
            this.lOCKEDDataGridViewTextBoxColumn,
            this.lOCKEDDATEDataGridViewTextBoxColumn,
            this.aKTIVDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOGINNAMEDataGridViewTextBoxColumn
            // 
            this.lOGINNAMEDataGridViewTextBoxColumn.DataPropertyName = "LOGIN_NAME";
            this.lOGINNAMEDataGridViewTextBoxColumn.HeaderText = "Login név";
            this.lOGINNAMEDataGridViewTextBoxColumn.Name = "lOGINNAMEDataGridViewTextBoxColumn";
            this.lOGINNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pWDataGridViewTextBoxColumn
            // 
            this.pWDataGridViewTextBoxColumn.DataPropertyName = "PW";
            this.pWDataGridViewTextBoxColumn.HeaderText = "Jelszó";
            this.pWDataGridViewTextBoxColumn.Name = "pWDataGridViewTextBoxColumn";
            this.pWDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPERDataGridViewTextBoxColumn
            // 
            this.sUPERDataGridViewTextBoxColumn.DataPropertyName = "SUPER";
            this.sUPERDataGridViewTextBoxColumn.FalseValue = "0";
            this.sUPERDataGridViewTextBoxColumn.HeaderText = "Adminisztrátor";
            this.sUPERDataGridViewTextBoxColumn.Name = "sUPERDataGridViewTextBoxColumn";
            this.sUPERDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPERDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sUPERDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sUPERDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // lOCKEDDataGridViewTextBoxColumn
            // 
            this.lOCKEDDataGridViewTextBoxColumn.DataPropertyName = "LOCKED";
            this.lOCKEDDataGridViewTextBoxColumn.FalseValue = "N";
            this.lOCKEDDataGridViewTextBoxColumn.HeaderText = "LOCKED";
            this.lOCKEDDataGridViewTextBoxColumn.Name = "lOCKEDDataGridViewTextBoxColumn";
            this.lOCKEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCKEDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lOCKEDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lOCKEDDataGridViewTextBoxColumn.TrueValue = "I";
            // 
            // lOCKEDDATEDataGridViewTextBoxColumn
            // 
            this.lOCKEDDATEDataGridViewTextBoxColumn.DataPropertyName = "LOCKED_DATE";
            this.lOCKEDDATEDataGridViewTextBoxColumn.HeaderText = "LOCKED_DATE";
            this.lOCKEDDATEDataGridViewTextBoxColumn.Name = "lOCKEDDATEDataGridViewTextBoxColumn";
            this.lOCKEDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCKEDDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aKTIVDataGridViewCheckBoxColumn
            // 
            this.aKTIVDataGridViewCheckBoxColumn.DataPropertyName = "AKTIV";
            this.aKTIVDataGridViewCheckBoxColumn.FalseValue = "0";
            this.aKTIVDataGridViewCheckBoxColumn.HeaderText = "AKTIV";
            this.aKTIVDataGridViewCheckBoxColumn.Name = "aKTIVDataGridViewCheckBoxColumn";
            this.aKTIVDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aKTIVDataGridViewCheckBoxColumn.TrueValue = "1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BusinessLogic._User);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 273);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmUser";
            this.ShowInTaskbar = false;
            this.Text = "A rendszer felhasználói";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGINNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sUPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lOCKEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCKEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aKTIVDataGridViewCheckBoxColumn;
    }
}