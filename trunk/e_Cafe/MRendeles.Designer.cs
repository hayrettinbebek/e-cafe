namespace e_Cafe
{
    partial class MRendeles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRendeles));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtonPlace = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlRendeles = new System.Windows.Forms.Panel();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblRendeles = new XPTable.Models.Table();
            this.label1 = new System.Windows.Forms.Label();
            this.btmImgList = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpCikkek = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOldalsav = new System.Windows.Forms.Panel();
            this.pnlOtherFilter = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxColumn1 = new XPTable.Models.CheckBoxColumn();
            this.numberColumn1 = new XPTable.Models.NumberColumn();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.numberColumn2 = new XPTable.Models.NumberColumn();
            this.dateTimeColumn1 = new XPTable.Models.DateTimeColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.pnlRendeles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRendeles)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Gray;
            this.pnlButtons.Controls.Add(this.pnlButtonPlace);
            this.pnlButtons.Controls.Add(this.panel5);
            this.pnlButtons.Controls.Add(this.panel6);
            this.pnlButtons.Controls.Add(this.panel2);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(173, 624);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.Click += new System.EventHandler(this.pnlButtons_Click);
            // 
            // pnlButtonPlace
            // 
            this.pnlButtonPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonPlace.Location = new System.Drawing.Point(16, 60);
            this.pnlButtonPlace.Name = "pnlButtonPlace";
            this.pnlButtonPlace.Size = new System.Drawing.Size(157, 435);
            this.pnlButtonPlace.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 435);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 495);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 129);
            this.panel6.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 60);
            this.panel2.TabIndex = 7;
            // 
            // pnlRendeles
            // 
            this.pnlRendeles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlRendeles.Controls.Add(this.btnDelete);
            this.pnlRendeles.Controls.Add(this.btnUP);
            this.pnlRendeles.Controls.Add(this.btnDOWN);
            this.pnlRendeles.Controls.Add(this.btnSave);
            this.pnlRendeles.Controls.Add(this.tblRendeles);
            this.pnlRendeles.Controls.Add(this.label1);
            this.pnlRendeles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRendeles.Location = new System.Drawing.Point(703, 0);
            this.pnlRendeles.Name = "pnlRendeles";
            this.pnlRendeles.Size = new System.Drawing.Size(313, 624);
            this.pnlRendeles.TabIndex = 1;
            this.pnlRendeles.Click += new System.EventHandler(this.pnlRendeles_Click);
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUP.Location = new System.Drawing.Point(161, 525);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(93, 31);
            this.btnUP.TabIndex = 4;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDOWN
            // 
            this.btnDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDOWN.Location = new System.Drawing.Point(48, 525);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(93, 31);
            this.btnDOWN.TabIndex = 3;
            this.btnDOWN.Text = "DOWN";
            this.btnDOWN.UseVisualStyleBackColor = false;
            this.btnDOWN.Click += new System.EventHandler(this.btnDOWN_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Ment";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblRendeles
            // 
            this.tblRendeles.AllowSelection = false;
            this.tblRendeles.FullRowSelect = true;
            this.tblRendeles.Location = new System.Drawing.Point(10, 117);
            this.tblRendeles.MultiSelect = true;
            this.tblRendeles.Name = "tblRendeles";
            this.tblRendeles.NoItemsText = "Nincs kiválasztott cikk";
            this.tblRendeles.Scrollable = false;
            this.tblRendeles.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblRendeles.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.tblRendeles.Size = new System.Drawing.Size(292, 402);
            this.tblRendeles.TabIndex = 1;
            this.tblRendeles.Text = "table1";
            this.tblRendeles.CellClick += new XPTable.Events.CellMouseEventHandler(this.tblRendeles_CellClick);
            this.tblRendeles.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.tblRendeles_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btmImgList
            // 
            this.btmImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btmImgList.ImageStream")));
            this.btmImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.btmImgList.Images.SetKeyName(0, "off_T.bmp");
            this.btmImgList.Images.SetKeyName(1, "aktiv_T.bmp");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpCikkek);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlOtherFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(173, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 624);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // flpCikkek
            // 
            this.flpCikkek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCikkek.Location = new System.Drawing.Point(25, 50);
            this.flpCikkek.Name = "flpCikkek";
            this.flpCikkek.Size = new System.Drawing.Size(505, 574);
            this.flpCikkek.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlOldalsav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 574);
            this.panel1.TabIndex = 1;
            // 
            // pnlOldalsav
            // 
            this.pnlOldalsav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(148)))));
            this.pnlOldalsav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOldalsav.Location = new System.Drawing.Point(0, 0);
            this.pnlOldalsav.Name = "pnlOldalsav";
            this.pnlOldalsav.Size = new System.Drawing.Size(25, 36);
            this.pnlOldalsav.TabIndex = 0;
            // 
            // pnlOtherFilter
            // 
            this.pnlOtherFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(148)))));
            this.pnlOtherFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOtherFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherFilter.Name = "pnlOtherFilter";
            this.pnlOtherFilter.Size = new System.Drawing.Size(530, 50);
            this.pnlOtherFilter.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 624);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 117);
            this.panel4.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "aktiv_T.bmp";
            this.button4.ImageList = this.btmImgList;
            this.button4.Location = new System.Drawing.Point(130, 27);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 65);
            this.button4.TabIndex = 0;
            this.button4.Text = "exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(160, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Töröl";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlRendeles);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel4);
            this.Name = "MRendeles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlButtons.ResumeLayout(false);
            this.pnlRendeles.ResumeLayout(false);
            this.pnlRendeles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRendeles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlRendeles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlButtonPlace;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlOtherFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOldalsav;
        private System.Windows.Forms.ImageList btmImgList;
        private System.Windows.Forms.FlowLayoutPanel flpCikkek;
        private XPTable.Models.CheckBoxColumn checkBoxColumn1;
        private XPTable.Models.NumberColumn numberColumn1;
        private XPTable.Models.TextColumn textColumn1;
        private XPTable.Models.NumberColumn numberColumn2;
        private XPTable.Models.DateTimeColumn dateTimeColumn1;
        private XPTable.Models.Table tblRendeles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDelete;
    }
}