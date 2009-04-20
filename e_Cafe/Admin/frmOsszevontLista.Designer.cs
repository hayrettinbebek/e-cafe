namespace e_Cafe.Admin
{
    partial class frmOsszevontLista
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openDayComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEV = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtNAP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openDayComboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.openDayComboBindingSource;
            this.listBox1.DisplayMember = "DISPLAY_MEMBER";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(111, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 121);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "OD";
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // openDayComboBindingSource
            // 
            this.openDayComboBindingSource.DataSource = typeof(BusinessLogic.OpenDayCombo);
            // 
            // txtEV
            // 
            this.txtEV.Location = new System.Drawing.Point(39, 12);
            this.txtEV.Name = "txtEV";
            this.txtEV.Size = new System.Drawing.Size(66, 20);
            this.txtEV.TabIndex = 1;
            this.txtEV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHO
            // 
            this.txtHO.Location = new System.Drawing.Point(39, 38);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(66, 20);
            this.txtHO.TabIndex = 1;
            this.txtHO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNAP
            // 
            this.txtNAP.Location = new System.Drawing.Point(39, 64);
            this.txtNAP.Name = "txtNAP";
            this.txtNAP.Size = new System.Drawing.Size(66, 20);
            this.txtNAP.TabIndex = 1;
            this.txtNAP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nap";
            // 
            // frmOsszevontLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 141);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNAP);
            this.Controls.Add(this.txtHO);
            this.Controls.Add(this.txtEV);
            this.Controls.Add(this.listBox1);
            this.Name = "frmOsszevontLista";
            this.Text = "Összevont forgalmi lista";
            this.Load += new System.EventHandler(this.frmOsszevontLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openDayComboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtEV;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtNAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource openDayComboBindingSource;

    }
}