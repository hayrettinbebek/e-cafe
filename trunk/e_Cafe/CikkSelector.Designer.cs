namespace e_Cafe
{
    partial class CikkSelector
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLAPRAKTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSSZETETTDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fKESZLETALLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKESZLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLCSOPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eRTEKESITESTIPUSADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(244, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(47, 19);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEGNEVEZESDataGridViewTextBoxColumn,
            this.aLAPRAKTARDataGridViewTextBoxColumn,
            this.oSSZETETTDataGridViewCheckBoxColumn,
            this.fKESZLETALLDataGridViewTextBoxColumn,
            this.cIKKIDDataGridViewTextBoxColumn,
            this.fKESZLETDataGridViewTextBoxColumn,
            this.aLCSOPORTDataGridViewTextBoxColumn,
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn,
            this.eRTEKESITESTIPUSADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cikkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // mEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGNEVEZES";
            this.mEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "Név";
            this.mEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGNEVEZESDataGridViewTextBoxColumn";
            // 
            // aLAPRAKTARDataGridViewTextBoxColumn
            // 
            this.aLAPRAKTARDataGridViewTextBoxColumn.DataPropertyName = "ALAP_RAKTAR";
            this.aLAPRAKTARDataGridViewTextBoxColumn.HeaderText = "Alap. raktár";
            this.aLAPRAKTARDataGridViewTextBoxColumn.Name = "aLAPRAKTARDataGridViewTextBoxColumn";
            // 
            // oSSZETETTDataGridViewCheckBoxColumn
            // 
            this.oSSZETETTDataGridViewCheckBoxColumn.DataPropertyName = "OSSZETETT";
            this.oSSZETETTDataGridViewCheckBoxColumn.HeaderText = "Összetett";
            this.oSSZETETTDataGridViewCheckBoxColumn.Name = "oSSZETETTDataGridViewCheckBoxColumn";
            this.oSSZETETTDataGridViewCheckBoxColumn.Visible = false;
            // 
            // fKESZLETALLDataGridViewTextBoxColumn
            // 
            this.fKESZLETALLDataGridViewTextBoxColumn.DataPropertyName = "fKESZLET_ALL";
            this.fKESZLETALLDataGridViewTextBoxColumn.HeaderText = "Össz. készlet";
            this.fKESZLETALLDataGridViewTextBoxColumn.Name = "fKESZLETALLDataGridViewTextBoxColumn";
            this.fKESZLETALLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIKKIDDataGridViewTextBoxColumn
            // 
            this.cIKKIDDataGridViewTextBoxColumn.DataPropertyName = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.HeaderText = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.Name = "cIKKIDDataGridViewTextBoxColumn";
            this.cIKKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKESZLETDataGridViewTextBoxColumn
            // 
            this.fKESZLETDataGridViewTextBoxColumn.DataPropertyName = "fKESZLET";
            this.fKESZLETDataGridViewTextBoxColumn.HeaderText = "fKESZLET";
            this.fKESZLETDataGridViewTextBoxColumn.Name = "fKESZLETDataGridViewTextBoxColumn";
            this.fKESZLETDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKESZLETDataGridViewTextBoxColumn.Visible = false;
            // 
            // aLCSOPORTDataGridViewTextBoxColumn
            // 
            this.aLCSOPORTDataGridViewTextBoxColumn.DataPropertyName = "ALCSOPORT";
            this.aLCSOPORTDataGridViewTextBoxColumn.HeaderText = "ALCSOPORT";
            this.aLCSOPORTDataGridViewTextBoxColumn.Name = "aLCSOPORTDataGridViewTextBoxColumn";
            this.aLCSOPORTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIKKCSOPORTIDDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.HeaderText = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Name = "cIKKCSOPORTIDDataGridViewTextBoxColumn";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eRTEKESITESTIPUSADataGridViewTextBoxColumn
            // 
            this.eRTEKESITESTIPUSADataGridViewTextBoxColumn.DataPropertyName = "ERTEKESITES_TIPUSA";
            this.eRTEKESITESTIPUSADataGridViewTextBoxColumn.HeaderText = "ERTEKESITES_TIPUSA";
            this.eRTEKESITESTIPUSADataGridViewTextBoxColumn.Name = "eRTEKESITESTIPUSADataGridViewTextBoxColumn";
            this.eRTEKESITESTIPUSADataGridViewTextBoxColumn.Visible = false;
            // 
            // cikkBindingSource
            // 
            this.cikkBindingSource.DataSource = typeof(BusinessLogic.Cikk);
            // 
            // CikkSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox1);
            this.Name = "CikkSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CikkSelector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cikkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLAPRAKTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oSSZETETTDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKESZLETALLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKESZLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLCSOPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKCSOPORTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eRTEKESITESTIPUSADataGridViewTextBoxColumn;
    }
}