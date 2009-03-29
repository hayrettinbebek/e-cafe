namespace e_Cafe.FrontOffice
{
    partial class frmHitelReszletezo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHitelReszletezo));
            this.button12 = new System.Windows.Forms.Button();
            this.tblHitelek = new XPTable.Models.Table();
            ((System.ComponentModel.ISupportInitialize)(this.tblHitelek)).BeginInit();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(671, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 32);
            this.button12.TabIndex = 7;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tblHitelek
            // 
            this.tblHitelek.AllowSelection = false;
            this.tblHitelek.FullRowSelect = true;
            this.tblHitelek.Location = new System.Drawing.Point(12, 43);
            this.tblHitelek.MultiSelect = true;
            this.tblHitelek.Name = "tblHitelek";
            this.tblHitelek.NoItemsText = "Nincs kiválasztott cikk";
            this.tblHitelek.Scrollable = false;
            this.tblHitelek.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblHitelek.SelectionForeColor = System.Drawing.Color.Black;
            this.tblHitelek.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.tblHitelek.Size = new System.Drawing.Size(545, 292);
            this.tblHitelek.TabIndex = 8;
            this.tblHitelek.Text = "table1";
            // 
            // frmHitelReszletezo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 375);
            this.ControlBox = false;
            this.Controls.Add(this.tblHitelek);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHitelReszletezo";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmHitelReszletezo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHitelek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private XPTable.Models.Table tblHitelek;
    }
}