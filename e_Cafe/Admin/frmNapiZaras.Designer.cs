namespace e_Cafe.Admin
{
    partial class frmNapiZaras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNapiZaras));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNEV = new System.Windows.Forms.Label();
            this.lblHO = new System.Windows.Forms.Label();
            this.lblNAP = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlVanNyitottNap = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlNyitRendel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlNyitTartozas = new System.Windows.Forms.Panel();
            this.pnlNegRaktar = new System.Windows.Forms.Panel();
            this.pnlKonzisztencia = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.jOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOsszevontLista = new e_Cafe.SQL.dsOsszevontLista();
            this._JOGTableAdapter = new e_Cafe.SQL.dsOsszevontListaTableAdapters._JOGTableAdapter();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOsszevontLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktuális nyitott nap:";
            // 
            // lblNEV
            // 
            this.lblNEV.AutoSize = true;
            this.lblNEV.Location = new System.Drawing.Point(3, 0);
            this.lblNEV.Name = "lblNEV";
            this.lblNEV.Size = new System.Drawing.Size(0, 25);
            this.lblNEV.TabIndex = 1;
            // 
            // lblHO
            // 
            this.lblHO.AutoSize = true;
            this.lblHO.Location = new System.Drawing.Point(9, 0);
            this.lblHO.Name = "lblHO";
            this.lblHO.Size = new System.Drawing.Size(0, 25);
            this.lblHO.TabIndex = 1;
            // 
            // lblNAP
            // 
            this.lblNAP.AutoSize = true;
            this.lblNAP.Location = new System.Drawing.Point(15, 0);
            this.lblNAP.Name = "lblNAP";
            this.lblNAP.Size = new System.Drawing.Size(0, 25);
            this.lblNAP.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblNEV);
            this.flowLayoutPanel1.Controls.Add(this.lblHO);
            this.flowLayoutPanel1.Controls.Add(this.lblNAP);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(168, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlVanNyitottNap
            // 
            this.pnlVanNyitottNap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVanNyitottNap.Location = new System.Drawing.Point(332, 32);
            this.pnlVanNyitottNap.Name = "pnlVanNyitottNap";
            this.pnlVanNyitottNap.Size = new System.Drawing.Size(33, 29);
            this.pnlVanNyitottNap.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbStatus
            // 
            this.pbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbStatus.Location = new System.Drawing.Point(0, 0);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(506, 23);
            this.pbStatus.Step = 1;
            this.pbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(185, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ellenőrzések";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 38);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nyitott rendelések ellenőrzése";
            // 
            // pnlNyitRendel
            // 
            this.pnlNyitRendel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNyitRendel.Location = new System.Drawing.Point(302, 112);
            this.pnlNyitRendel.Name = "pnlNyitRendel";
            this.pnlNyitRendel.Size = new System.Drawing.Size(33, 29);
            this.pnlNyitRendel.TabIndex = 4;
            this.pnlNyitRendel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNyitRendel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(156, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nincs nyitott tartozás";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Negatív raktárkészletek ellenőrzése";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Adatbázis konzisztencia ellenőrzése";
            // 
            // pnlNyitTartozas
            // 
            this.pnlNyitTartozas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNyitTartozas.Location = new System.Drawing.Point(302, 244);
            this.pnlNyitTartozas.Name = "pnlNyitTartozas";
            this.pnlNyitTartozas.Size = new System.Drawing.Size(33, 29);
            this.pnlNyitTartozas.TabIndex = 4;
            this.pnlNyitTartozas.Visible = false;
            // 
            // pnlNegRaktar
            // 
            this.pnlNegRaktar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNegRaktar.Location = new System.Drawing.Point(302, 149);
            this.pnlNegRaktar.Name = "pnlNegRaktar";
            this.pnlNegRaktar.Size = new System.Drawing.Size(33, 29);
            this.pnlNegRaktar.TabIndex = 4;
            // 
            // pnlKonzisztencia
            // 
            this.pnlKonzisztencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlKonzisztencia.Location = new System.Drawing.Point(302, 184);
            this.pnlKonzisztencia.Name = "pnlKonzisztencia";
            this.pnlKonzisztencia.Size = new System.Drawing.Size(33, 29);
            this.pnlKonzisztencia.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lezár";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jOGBindingSource
            // 
            this.jOGBindingSource.DataMember = "_JOG";
            this.jOGBindingSource.DataSource = this.dsOsszevontLista;
            // 
            // dsOsszevontLista
            // 
            this.dsOsszevontLista.DataSetName = "dsOsszevontLista";
            this.dsOsszevontLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _JOGTableAdapter
            // 
            this._JOGTableAdapter.ClearBeforeFill = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(212, 317);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 8;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Visible = false;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(471, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button12_Click);
            // 
            // frmNapiZaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.pnlKonzisztencia);
            this.Controls.Add(this.pnlNegRaktar);
            this.Controls.Add(this.pnlNyitTartozas);
            this.Controls.Add(this.pnlNyitRendel);
            this.Controls.Add(this.pnlVanNyitottNap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "frmNapiZaras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Napi zárás";
            this.Load += new System.EventHandler(this.frmNapiZaras_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOsszevontLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNEV;
        private System.Windows.Forms.Label lblHO;
        private System.Windows.Forms.Label lblNAP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlVanNyitottNap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlNyitRendel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlNyitTartozas;
        private System.Windows.Forms.Panel pnlNegRaktar;
        private System.Windows.Forms.Panel pnlKonzisztencia;
        private System.Windows.Forms.Button button1;
        private e_Cafe.SQL.dsOsszevontLista dsOsszevontLista;
        private System.Windows.Forms.BindingSource jOGBindingSource;
        private e_Cafe.SQL.dsOsszevontListaTableAdapters._JOGTableAdapter _JOGTableAdapter;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnClose;
        
    }
}