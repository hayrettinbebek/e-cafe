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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.rbOsszesitett = new System.Windows.Forms.RadioButton();
            this.rbReszletek = new System.Windows.Forms.RadioButton();
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
            this.tblHitelek.Location = new System.Drawing.Point(12, 79);
            this.tblHitelek.MultiSelect = true;
            this.tblHitelek.Name = "tblHitelek";
            this.tblHitelek.NoItemsText = "Nincs kiválasztott cikk";
            this.tblHitelek.Scrollable = false;
            this.tblHitelek.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblHitelek.SelectionForeColor = System.Drawing.Color.Black;
            this.tblHitelek.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.tblHitelek.Size = new System.Drawing.Size(545, 256);
            this.tblHitelek.TabIndex = 8;
            this.tblHitelek.Text = "table1";
            this.tblHitelek.CellClick += new XPTable.Events.CellMouseEventHandler(this.tblHitelek_CellClick);
            this.tblHitelek.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.tblHitelek_SelectionChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(588, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 75);
            this.button3.TabIndex = 11;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(590, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fizetés";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(563, 43);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 57);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // rbOsszesitett
            // 
            this.rbOsszesitett.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOsszesitett.BackColor = System.Drawing.Color.Silver;
            this.rbOsszesitett.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rbOsszesitett.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbOsszesitett.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbOsszesitett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOsszesitett.Location = new System.Drawing.Point(175, 43);
            this.rbOsszesitett.Name = "rbOsszesitett";
            this.rbOsszesitett.Size = new System.Drawing.Size(130, 30);
            this.rbOsszesitett.TabIndex = 15;
            this.rbOsszesitett.Text = "Összesített";
            this.rbOsszesitett.UseVisualStyleBackColor = false;
            this.rbOsszesitett.CheckedChanged += new System.EventHandler(this.rbOsszesitett_CheckedChanged);
            // 
            // rbReszletek
            // 
            this.rbReszletek.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReszletek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbReszletek.Checked = true;
            this.rbReszletek.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbReszletek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbReszletek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbReszletek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReszletek.Location = new System.Drawing.Point(44, 43);
            this.rbReszletek.Name = "rbReszletek";
            this.rbReszletek.Size = new System.Drawing.Size(125, 30);
            this.rbReszletek.TabIndex = 15;
            this.rbReszletek.TabStop = true;
            this.rbReszletek.Text = "Részletek";
            this.rbReszletek.UseVisualStyleBackColor = false;
            this.rbReszletek.CheckedChanged += new System.EventHandler(this.rbReszletek_CheckedChanged);
            // 
            // frmHitelReszletezo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 375);
            this.ControlBox = false;
            this.Controls.Add(this.rbReszletek);
            this.Controls.Add(this.rbOsszesitett);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tblHitelek);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHitelReszletezo";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmHitelReszletezo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHitelek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private XPTable.Models.Table tblHitelek;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton rbOsszesitett;
        private System.Windows.Forms.RadioButton rbReszletek;
    }
}