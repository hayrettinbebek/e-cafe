namespace e_Cafe.Keszlet
{
    partial class frmSelejtez
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMenny = new System.Windows.Forms.TextBox();
            this.lblKeszlet = new System.Windows.Forms.Label();
            this.lblME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCikkNev = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rAKTARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetRAKTAR = new e_Cafe.SQL.ECAFEDataSetRAKTAR();
            this.rAKTARTableAdapter = new e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter();
            this.cikkKeszletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkKeszletBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kilépés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Selejt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMenny);
            this.groupBox1.Controls.Add(this.lblKeszlet);
            this.groupBox1.Controls.Add(this.lblME);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCikkNev);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(28, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Áthelyezés raktáról....";
            // 
            // txtMenny
            // 
            this.txtMenny.Location = new System.Drawing.Point(70, 122);
            this.txtMenny.Name = "txtMenny";
            this.txtMenny.Size = new System.Drawing.Size(83, 20);
            this.txtMenny.TabIndex = 4;
            // 
            // lblKeszlet
            // 
            this.lblKeszlet.AutoSize = true;
            this.lblKeszlet.Location = new System.Drawing.Point(144, 94);
            this.lblKeszlet.Name = "lblKeszlet";
            this.lblKeszlet.Size = new System.Drawing.Size(0, 13);
            this.lblKeszlet.TabIndex = 3;
            // 
            // lblME
            // 
            this.lblME.AutoSize = true;
            this.lblME.Location = new System.Drawing.Point(159, 125);
            this.lblME.Name = "lblME";
            this.lblME.Size = new System.Drawing.Size(0, 13);
            this.lblME.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mennyiség:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elérhető készletek";
            // 
            // lblCikkNev
            // 
            this.lblCikkNev.AutoSize = true;
            this.lblCikkNev.Location = new System.Drawing.Point(12, 45);
            this.lblCikkNev.Name = "lblCikkNev";
            this.lblCikkNev.Size = new System.Drawing.Size(55, 13);
            this.lblCikkNev.TabIndex = 2;
            this.lblCikkNev.Text = "Cikk neve";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cikk választás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cikkKeszletBindingSource;
            this.comboBox1.DisplayMember = "RAKTAR";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "RAKTAR_ID";
            // 
            // rAKTARBindingSource
            // 
            this.rAKTARBindingSource.DataMember = "RAKTAR";
            this.rAKTARBindingSource.DataSource = this.eCAFEDataSetRAKTAR;
            // 
            // eCAFEDataSetRAKTAR
            // 
            this.eCAFEDataSetRAKTAR.DataSetName = "ECAFEDataSetRAKTAR";
            this.eCAFEDataSetRAKTAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAKTARTableAdapter
            // 
            this.rAKTARTableAdapter.ClearBeforeFill = true;
            // 
            // cikkKeszletBindingSource
            // 
            this.cikkKeszletBindingSource.DataSource = typeof(BusinessLogic.CikkKeszlet);
            this.cikkKeszletBindingSource.CurrentChanged += new System.EventHandler(this.cikkKeszletBindingSource_CurrentChanged);
            // 
            // frmSelejtez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 281);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSelejtez";
            this.Text = "Selejtezés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkKeszletBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMenny;
        private System.Windows.Forms.Label lblKeszlet;
        private System.Windows.Forms.Label lblME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCikkNev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cikkKeszletBindingSource;
        private System.Windows.Forms.BindingSource rAKTARBindingSource;
        private e_Cafe.SQL.ECAFEDataSetRAKTAR eCAFEDataSetRAKTAR;
        private e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter rAKTARTableAdapter;
    }
}