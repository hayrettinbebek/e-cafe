namespace e_Cafe.FrontOffice
{
    partial class frmAsztalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsztalInfo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAsztalSzam = new System.Windows.Forms.Label();
            this.tblRendelesek = new XPTable.Models.Table();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRendelesek)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tblRendelesek);
            this.panel1.Controls.Add(this.lblAsztalSzam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 109);
            this.panel1.TabIndex = 0;
            // 
            // lblAsztalSzam
            // 
            this.lblAsztalSzam.BackColor = System.Drawing.Color.Transparent;
            this.lblAsztalSzam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAsztalSzam.ForeColor = System.Drawing.Color.White;
            this.lblAsztalSzam.Location = new System.Drawing.Point(3, 10);
            this.lblAsztalSzam.Name = "lblAsztalSzam";
            this.lblAsztalSzam.Size = new System.Drawing.Size(256, 23);
            this.lblAsztalSzam.TabIndex = 1;
            this.lblAsztalSzam.Text = "label1";
            // 
            // tblRendelesek
            // 
            this.tblRendelesek.AllowSelection = false;
            this.tblRendelesek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRendelesek.FullRowSelect = true;
            this.tblRendelesek.Location = new System.Drawing.Point(3, 36);
            this.tblRendelesek.MultiSelect = true;
            this.tblRendelesek.Name = "tblRendelesek";
            this.tblRendelesek.NoItemsText = "Nincs kiválasztott cikk";
            this.tblRendelesek.Scrollable = false;
            this.tblRendelesek.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblRendelesek.SelectionForeColor = System.Drawing.Color.Black;
            this.tblRendelesek.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.tblRendelesek.Size = new System.Drawing.Size(232, 48);
            this.tblRendelesek.TabIndex = 2;
            this.tblRendelesek.Text = "table1";
            // 
            // frmAsztalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(238, 148);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsztalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAsztalInfo";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRendelesek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAsztalSzam;
        private XPTable.Models.Table tblRendelesek;

    }
}