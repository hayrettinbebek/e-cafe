namespace e_Cafe.Admin
{
    partial class frmNegkeszletInfo
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
            this.cikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cIKKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOVIDNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKESZLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKESZLETALLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSSZETETTDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIKKIDDataGridViewTextBoxColumn,
            this.mEGNEVEZESDataGridViewTextBoxColumn,
            this.rOVIDNEVDataGridViewTextBoxColumn,
            this.fKESZLETDataGridViewTextBoxColumn,
            this.fKESZLETALLDataGridViewTextBoxColumn,
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn,
            this.oSSZETETTDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.cikkBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // cikkBindingSource
            // 
            this.cikkBindingSource.AllowNew = false;
            this.cikkBindingSource.DataSource = typeof(BusinessLogic.Cikk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cIKKIDDataGridViewTextBoxColumn
            // 
            this.cIKKIDDataGridViewTextBoxColumn.DataPropertyName = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.HeaderText = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.Name = "cIKKIDDataGridViewTextBoxColumn";
            this.cIKKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGNEVEZES";
            this.mEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "Cikk neve";
            this.mEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGNEVEZESDataGridViewTextBoxColumn";
            this.mEGNEVEZESDataGridViewTextBoxColumn.ReadOnly = true;
            this.mEGNEVEZESDataGridViewTextBoxColumn.Width = 140;
            // 
            // rOVIDNEVDataGridViewTextBoxColumn
            // 
            this.rOVIDNEVDataGridViewTextBoxColumn.DataPropertyName = "ROVID_NEV";
            this.rOVIDNEVDataGridViewTextBoxColumn.HeaderText = "Rövid név";
            this.rOVIDNEVDataGridViewTextBoxColumn.Name = "rOVIDNEVDataGridViewTextBoxColumn";
            this.rOVIDNEVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKESZLETDataGridViewTextBoxColumn
            // 
            this.fKESZLETDataGridViewTextBoxColumn.DataPropertyName = "fKESZLET";
            this.fKESZLETDataGridViewTextBoxColumn.HeaderText = "Készlet";
            this.fKESZLETDataGridViewTextBoxColumn.Name = "fKESZLETDataGridViewTextBoxColumn";
            this.fKESZLETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKESZLETALLDataGridViewTextBoxColumn
            // 
            this.fKESZLETALLDataGridViewTextBoxColumn.DataPropertyName = "fKESZLET_ALL";
            this.fKESZLETALLDataGridViewTextBoxColumn.HeaderText = "Összes készlet";
            this.fKESZLETALLDataGridViewTextBoxColumn.Name = "fKESZLETALLDataGridViewTextBoxColumn";
            this.fKESZLETALLDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKESZLETALLDataGridViewTextBoxColumn.Width = 120;
            // 
            // mEGYSMEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGYS_MEGNEVEZES";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "Kiszerelés";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGYSMEGNEVEZESDataGridViewTextBoxColumn";
            this.mEGYSMEGNEVEZESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oSSZETETTDataGridViewCheckBoxColumn
            // 
            this.oSSZETETTDataGridViewCheckBoxColumn.DataPropertyName = "OSSZETETT";
            this.oSSZETETTDataGridViewCheckBoxColumn.FalseValue = "0";
            this.oSSZETETTDataGridViewCheckBoxColumn.HeaderText = "Összetett cikk";
            this.oSSZETETTDataGridViewCheckBoxColumn.Name = "oSSZETETTDataGridViewCheckBoxColumn";
            this.oSSZETETTDataGridViewCheckBoxColumn.ReadOnly = true;
            this.oSSZETETTDataGridViewCheckBoxColumn.TrueValue = "1";
            // 
            // frmNegkeszletInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 304);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNegkeszletInfo";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cikkBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOVIDNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKESZLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKESZLETALLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGYSMEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oSSZETETTDataGridViewCheckBoxColumn;
    }
}