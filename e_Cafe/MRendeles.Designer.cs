﻿namespace e_Cafe
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
            this.rbOsszetett = new System.Windows.Forms.RadioButton();
            this.rbReszletes = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblRendeles = new XPTable.Models.Table();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpCikkek = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOldalsav = new System.Windows.Forms.Panel();
            this.pnlOtherFilter = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxColumn1 = new XPTable.Models.CheckBoxColumn();
            this.numberColumn1 = new XPTable.Models.NumberColumn();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.numberColumn2 = new XPTable.Models.NumberColumn();
            this.dateTimeColumn1 = new XPTable.Models.DateTimeColumn();
            this.btmImgList = new System.Windows.Forms.ImageList(this.components);
            this.ilUpDown = new System.Windows.Forms.ImageList(this.components);
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPartnerek = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.pnlButtons.Size = new System.Drawing.Size(173, 630);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.Click += new System.EventHandler(this.pnlButtons_Click);
            // 
            // pnlButtonPlace
            // 
            this.pnlButtonPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonPlace.Location = new System.Drawing.Point(16, 60);
            this.pnlButtonPlace.Name = "pnlButtonPlace";
            this.pnlButtonPlace.Size = new System.Drawing.Size(157, 441);
            this.pnlButtonPlace.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 441);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 501);
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
            this.pnlRendeles.Controls.Add(this.button8);
            this.pnlRendeles.Controls.Add(this.rbOsszetett);
            this.pnlRendeles.Controls.Add(this.rbReszletes);
            this.pnlRendeles.Controls.Add(this.btnDelete);
            this.pnlRendeles.Controls.Add(this.btnUP);
            this.pnlRendeles.Controls.Add(this.btnDOWN);
            this.pnlRendeles.Controls.Add(this.tblRendeles);
            this.pnlRendeles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRendeles.Location = new System.Drawing.Point(703, 0);
            this.pnlRendeles.Name = "pnlRendeles";
            this.pnlRendeles.Size = new System.Drawing.Size(313, 630);
            this.pnlRendeles.TabIndex = 1;
            this.pnlRendeles.Click += new System.EventHandler(this.pnlRendeles_Click);
            // 
            // rbOsszetett
            // 
            this.rbOsszetett.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOsszetett.BackColor = System.Drawing.Color.Gray;
            this.rbOsszetett.FlatAppearance.BorderSize = 0;
            this.rbOsszetett.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbOsszetett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOsszetett.Location = new System.Drawing.Point(140, 113);
            this.rbOsszetett.Name = "rbOsszetett";
            this.rbOsszetett.Size = new System.Drawing.Size(121, 24);
            this.rbOsszetett.TabIndex = 6;
            this.rbOsszetett.Tag = "3";
            this.rbOsszetett.Text = "Összetett";
            this.rbOsszetett.UseVisualStyleBackColor = false;
            this.rbOsszetett.CheckedChanged += new System.EventHandler(this.rbOsszetett_CheckedChanged);
            // 
            // rbReszletes
            // 
            this.rbReszletes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReszletes.BackColor = System.Drawing.Color.Gray;
            this.rbReszletes.Checked = true;
            this.rbReszletes.FlatAppearance.BorderSize = 0;
            this.rbReszletes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbReszletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReszletes.Location = new System.Drawing.Point(20, 113);
            this.rbReszletes.Name = "rbReszletes";
            this.rbReszletes.Size = new System.Drawing.Size(121, 24);
            this.rbReszletes.TabIndex = 6;
            this.rbReszletes.TabStop = true;
            this.rbReszletes.Tag = "3";
            this.rbReszletes.Text = "Részletes";
            this.rbReszletes.UseVisualStyleBackColor = false;
            this.rbReszletes.CheckedChanged += new System.EventHandler(this.rbReszletes_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(151, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Töröl";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tblRendeles
            // 
            this.tblRendeles.AllowSelection = false;
            this.tblRendeles.FullRowSelect = true;
            this.tblRendeles.Location = new System.Drawing.Point(9, 135);
            this.tblRendeles.MultiSelect = true;
            this.tblRendeles.Name = "tblRendeles";
            this.tblRendeles.NoItemsText = "Nincs kiválasztott cikk";
            this.tblRendeles.Scrollable = false;
            this.tblRendeles.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblRendeles.SelectionForeColor = System.Drawing.Color.Black;
            this.tblRendeles.SelectionStyle = XPTable.Models.SelectionStyle.Grid;
            this.tblRendeles.Size = new System.Drawing.Size(293, 384);
            this.tblRendeles.TabIndex = 1;
            this.tblRendeles.Text = "table1";
            this.tblRendeles.CellClick += new XPTable.Events.CellMouseEventHandler(this.tblRendeles_CellClick);
            this.tblRendeles.SelectionChanged += new XPTable.Events.SelectionEventHandler(this.tblRendeles_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpCikkek);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlOtherFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(173, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 630);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // flpCikkek
            // 
            this.flpCikkek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCikkek.Location = new System.Drawing.Point(25, 50);
            this.flpCikkek.Name = "flpCikkek";
            this.flpCikkek.Size = new System.Drawing.Size(505, 580);
            this.flpCikkek.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlOldalsav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 580);
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
            this.pnlOldalsav.Visible = false;
            // 
            // pnlOtherFilter
            // 
            this.pnlOtherFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(148)))));
            this.pnlOtherFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOtherFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherFilter.Name = "pnlOtherFilter";
            this.pnlOtherFilter.Size = new System.Drawing.Size(530, 50);
            this.pnlOtherFilter.TabIndex = 0;
            this.pnlOtherFilter.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btmImgList
            // 
            this.btmImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btmImgList.ImageStream")));
            this.btmImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.btmImgList.Images.SetKeyName(0, "off.png");
            this.btmImgList.Images.SetKeyName(1, "aktiv.png");
            // 
            // ilUpDown
            // 
            this.ilUpDown.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilUpDown.ImageSize = new System.Drawing.Size(16, 16);
            this.ilUpDown.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.Color.Transparent;
            this.btnUP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUP.BackgroundImage")));
            this.btnUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUP.FlatAppearance.BorderSize = 0;
            this.btnUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUP.Location = new System.Drawing.Point(159, 521);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(145, 44);
            this.btnUP.TabIndex = 4;
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDOWN
            // 
            this.btnDOWN.BackColor = System.Drawing.Color.Transparent;
            this.btnDOWN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDOWN.BackgroundImage")));
            this.btnDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDOWN.FlatAppearance.BorderSize = 0;
            this.btnDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDOWN.Location = new System.Drawing.Point(10, 521);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(145, 44);
            this.btnDOWN.TabIndex = 3;
            this.btnDOWN.UseVisualStyleBackColor = false;
            this.btnDOWN.Click += new System.EventHandler(this.btnDOWN_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::e_Cafe.Properties.Resources.also;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnPartnerek);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 111);
            this.panel4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(159, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "vegyes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(231, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Utalvány";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(329, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vegyes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(403, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fizetés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(562, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Storno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(653, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Átvitel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(732, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hitel";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(153, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 75);
            this.button7.TabIndex = 10;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(229, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 75);
            this.button6.TabIndex = 10;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(320, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 75);
            this.button5.TabIndex = 10;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(396, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 75);
            this.button3.TabIndex = 10;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(555, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 75);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(642, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 75);
            this.button1.TabIndex = 10;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPartnerek
            // 
            this.btnPartnerek.BackColor = System.Drawing.Color.Transparent;
            this.btnPartnerek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPartnerek.BackgroundImage")));
            this.btnPartnerek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPartnerek.FlatAppearance.BorderSize = 0;
            this.btnPartnerek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartnerek.Location = new System.Drawing.Point(736, 6);
            this.btnPartnerek.Name = "btnPartnerek";
            this.btnPartnerek.Size = new System.Drawing.Size(70, 75);
            this.btnPartnerek.TabIndex = 10;
            this.btnPartnerek.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPartnerek.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "aktiv_T.bmp";
            this.button4.Location = new System.Drawing.Point(877, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 75);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(15, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 36);
            this.button8.TabIndex = 7;
            this.button8.Text = "mind";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.tblRendeles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlRendeles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlButtonPlace;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlOtherFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOldalsav;
        private System.Windows.Forms.FlowLayoutPanel flpCikkek;
        private XPTable.Models.CheckBoxColumn checkBoxColumn1;
        private XPTable.Models.NumberColumn numberColumn1;
        private XPTable.Models.TextColumn textColumn1;
        private XPTable.Models.NumberColumn numberColumn2;
        private XPTable.Models.DateTimeColumn dateTimeColumn1;
        private XPTable.Models.Table tblRendeles;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ImageList btmImgList;
        private System.Windows.Forms.RadioButton rbOsszetett;
        private System.Windows.Forms.RadioButton rbReszletes;
        private System.Windows.Forms.Button btnPartnerek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ilUpDown;
        private System.Windows.Forms.Button button8;
    }
}