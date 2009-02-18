namespace e_Cafe
{
    partial class PartnerSelector
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
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTIPUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEV2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNEV3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pARTNERIDDataGridViewTextBoxColumn,
            this.pTIPUSDataGridViewTextBoxColumn,
            this.pNEVDataGridViewTextBoxColumn,
            this.pNEV2DataGridViewTextBoxColumn,
            this.pNEV3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partnerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataSource = typeof(BusinessLogic.Partner);
            // 
            // pARTNERIDDataGridViewTextBoxColumn
            // 
            this.pARTNERIDDataGridViewTextBoxColumn.DataPropertyName = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.HeaderText = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.Name = "pARTNERIDDataGridViewTextBoxColumn";
            this.pARTNERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pTIPUSDataGridViewTextBoxColumn
            // 
            this.pTIPUSDataGridViewTextBoxColumn.DataPropertyName = "P_TIPUS";
            this.pTIPUSDataGridViewTextBoxColumn.HeaderText = "P_TIPUS";
            this.pTIPUSDataGridViewTextBoxColumn.Name = "pTIPUSDataGridViewTextBoxColumn";
            this.pTIPUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // pNEVDataGridViewTextBoxColumn
            // 
            this.pNEVDataGridViewTextBoxColumn.DataPropertyName = "P_NEV";
            this.pNEVDataGridViewTextBoxColumn.HeaderText = "P_NEV";
            this.pNEVDataGridViewTextBoxColumn.Name = "pNEVDataGridViewTextBoxColumn";
            // 
            // pNEV2DataGridViewTextBoxColumn
            // 
            this.pNEV2DataGridViewTextBoxColumn.DataPropertyName = "P_NEV2";
            this.pNEV2DataGridViewTextBoxColumn.HeaderText = "P_NEV2";
            this.pNEV2DataGridViewTextBoxColumn.Name = "pNEV2DataGridViewTextBoxColumn";
            // 
            // pNEV3DataGridViewTextBoxColumn
            // 
            this.pNEV3DataGridViewTextBoxColumn.DataPropertyName = "P_NEV3";
            this.pNEV3DataGridViewTextBoxColumn.HeaderText = "P_NEV3";
            this.pNEV3DataGridViewTextBoxColumn.Name = "pNEV3DataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 2;
            // 
            // PartnerSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 281);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartnerSelector";
            this.Text = "PartnerSelector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTNERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTIPUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEV2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNEV3DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}