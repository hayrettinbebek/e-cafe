namespace e_Cafe.FrontOffice
{
    partial class frmReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dsSZAMLAZAS = new e_Cafe.dsSZAMLAZAS();
            this.sZAMLAFEJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sZAMLA_FEJTableAdapter = new e_Cafe.dsSZAMLAZASTableAdapters.SZAMLA_FEJTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.sZAMLATETELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sZAMLA_TETELTableAdapter = new e_Cafe.dsSZAMLAZASTableAdapters.SZAMLA_TETELTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Blokk1 = new e_Cafe.Reports.Blokk();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSZAMLAZAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sZAMLAFEJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sZAMLATETELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A nyomtatás hogyan legyen?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "itt képernyőkép a nyomtatásról és lehet nyomtatni.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adminból utólag is lehet másolatot.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 529);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sZAMLATETELBindingSource, "TETEL_ID", true));
            this.textBox1.Location = new System.Drawing.Point(250, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "A BLOKK:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(475, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsSZAMLAZAS
            // 
            this.dsSZAMLAZAS.DataSetName = "dsSZAMLAZAS";
            this.dsSZAMLAZAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sZAMLAFEJBindingSource
            // 
            this.sZAMLAFEJBindingSource.DataMember = "SZAMLA_FEJ";
            this.sZAMLAFEJBindingSource.DataSource = this.dsSZAMLAZAS;
            // 
            // sZAMLA_FEJTableAdapter
            // 
            this.sZAMLA_FEJTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sZAMLATETELBindingSource
            // 
            this.sZAMLATETELBindingSource.DataMember = "SZAMLA_TETEL";
            this.sZAMLATETELBindingSource.DataSource = this.dsSZAMLAZAS;
            // 
            // sZAMLA_TETELTableAdapter
            // 
            this.sZAMLA_TETELTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(27, 43);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Blokk1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(390, 443);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // Blokk1
            // 
            this.Blokk1.InitReport += new System.EventHandler(this.Blokk1_InitReport);
            // 
            // frmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 613);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReporting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSZAMLAZAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sZAMLAFEJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sZAMLATETELBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Reports.Blokk Blokk1;
        private System.Windows.Forms.TextBox textBox1;
        private dsSZAMLAZAS dsSZAMLAZAS;
        private System.Windows.Forms.BindingSource sZAMLAFEJBindingSource;
        private e_Cafe.dsSZAMLAZASTableAdapters.SZAMLA_FEJTableAdapter sZAMLA_FEJTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sZAMLATETELBindingSource;
        private e_Cafe.dsSZAMLAZASTableAdapters.SZAMLA_TETELTableAdapter sZAMLA_TETELTableAdapter;
    }
}