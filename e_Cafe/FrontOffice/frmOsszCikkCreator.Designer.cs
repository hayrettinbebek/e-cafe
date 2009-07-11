namespace e_Cafe.FrontOffice
{
    partial class frmOsszCikkCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOsszCikkCreator));
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpCikkek = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOtherFilter = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAlcsopNext = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAlcsopPrev = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnNextCikk = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnPrevCikk = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtonPlace = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAlsoGombok = new System.Windows.Forms.Panel();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.btnReceptek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKilep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCikkcsopSelectInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCikkNev = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.rECEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReceptCikkek = new e_Cafe.SQL.DataSets.dsReceptCikkek();
            this.rECEPTTableAdapter = new e_Cafe.SQL.DataSets.dsReceptCikkekTableAdapters.RECEPTTableAdapter();
            this.receptMentes = new e_Cafe.SQL.DataSets.ReceptMentes();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.receptTableAdapter1 = new e_Cafe.SQL.DataSets.ReceptMentesTableAdapters.RECEPTTableAdapter();
            this.panel3.SuspendLayout();
            this.pnlOtherFilter.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlButtonPlace.SuspendLayout();
            this.pnlAlsoGombok.SuspendLayout();
            this.pnlFunctions.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rECEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptCikkek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptMentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.flpCikkek);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlOtherFilter);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(173, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 527);
            this.panel3.TabIndex = 2;
            // 
            // flpCikkek
            // 
            this.flpCikkek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCikkek.Location = new System.Drawing.Point(25, 60);
            this.flpCikkek.Name = "flpCikkek";
            this.flpCikkek.Size = new System.Drawing.Size(562, 406);
            this.flpCikkek.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 406);
            this.panel1.TabIndex = 1;
            // 
            // pnlOtherFilter
            // 
            this.pnlOtherFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOtherFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOtherFilter.Controls.Add(this.panel6);
            this.pnlOtherFilter.Controls.Add(this.panel8);
            this.pnlOtherFilter.Controls.Add(this.panel7);
            this.pnlOtherFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOtherFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherFilter.Name = "pnlOtherFilter";
            this.pnlOtherFilter.Size = new System.Drawing.Size(587, 60);
            this.pnlOtherFilter.TabIndex = 0;
            this.pnlOtherFilter.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(25, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(532, 60);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.btnAlcsopNext);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(557, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 60);
            this.panel8.TabIndex = 1;
            // 
            // btnAlcsopNext
            // 
            this.btnAlcsopNext.BackColor = System.Drawing.Color.Transparent;
            this.btnAlcsopNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlcsopNext.BackgroundImage")));
            this.btnAlcsopNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlcsopNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlcsopNext.FlatAppearance.BorderSize = 0;
            this.btnAlcsopNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlcsopNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlcsopNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlcsopNext.Location = new System.Drawing.Point(0, 0);
            this.btnAlcsopNext.Name = "btnAlcsopNext";
            this.btnAlcsopNext.Size = new System.Drawing.Size(30, 60);
            this.btnAlcsopNext.TabIndex = 5;
            this.btnAlcsopNext.UseVisualStyleBackColor = false;
            this.btnAlcsopNext.Click += new System.EventHandler(this.btnAlcsopNext_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.btnAlcsopPrev);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(25, 60);
            this.panel7.TabIndex = 0;
            // 
            // btnAlcsopPrev
            // 
            this.btnAlcsopPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnAlcsopPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlcsopPrev.BackgroundImage")));
            this.btnAlcsopPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlcsopPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlcsopPrev.FlatAppearance.BorderSize = 0;
            this.btnAlcsopPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlcsopPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlcsopPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlcsopPrev.Location = new System.Drawing.Point(0, 0);
            this.btnAlcsopPrev.Name = "btnAlcsopPrev";
            this.btnAlcsopPrev.Size = new System.Drawing.Size(25, 60);
            this.btnAlcsopPrev.TabIndex = 4;
            this.btnAlcsopPrev.UseVisualStyleBackColor = false;
            this.btnAlcsopPrev.Click += new System.EventHandler(this.btnAlcsopPrev_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 466);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(587, 61);
            this.panel9.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.textBox3);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(25, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(532, 61);
            this.panel12.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.btnNextCikk);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(557, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 61);
            this.panel10.TabIndex = 1;
            // 
            // btnNextCikk
            // 
            this.btnNextCikk.BackColor = System.Drawing.Color.Transparent;
            this.btnNextCikk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextCikk.BackgroundImage")));
            this.btnNextCikk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextCikk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextCikk.FlatAppearance.BorderSize = 0;
            this.btnNextCikk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextCikk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextCikk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCikk.Location = new System.Drawing.Point(0, 0);
            this.btnNextCikk.Name = "btnNextCikk";
            this.btnNextCikk.Size = new System.Drawing.Size(30, 61);
            this.btnNextCikk.TabIndex = 5;
            this.btnNextCikk.UseVisualStyleBackColor = false;
            this.btnNextCikk.Click += new System.EventHandler(this.btnNextCikk_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.btnPrevCikk);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(25, 61);
            this.panel11.TabIndex = 0;
            // 
            // btnPrevCikk
            // 
            this.btnPrevCikk.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevCikk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevCikk.BackgroundImage")));
            this.btnPrevCikk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevCikk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevCikk.FlatAppearance.BorderSize = 0;
            this.btnPrevCikk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevCikk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevCikk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevCikk.Location = new System.Drawing.Point(0, 0);
            this.btnPrevCikk.Name = "btnPrevCikk";
            this.btnPrevCikk.Size = new System.Drawing.Size(25, 61);
            this.btnPrevCikk.TabIndex = 4;
            this.btnPrevCikk.UseVisualStyleBackColor = false;
            this.btnPrevCikk.Click += new System.EventHandler(this.btnPrevCikk_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Gray;
            this.pnlButtons.BackgroundImage = global::e_Cafe.Properties.Resources.oldal1;
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButtons.Controls.Add(this.pnlButtonPlace);
            this.pnlButtons.Controls.Add(this.panel5);
            this.pnlButtons.Controls.Add(this.panel2);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(173, 527);
            this.pnlButtons.TabIndex = 3;
            // 
            // pnlButtonPlace
            // 
            this.pnlButtonPlace.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonPlace.Controls.Add(this.button12);
            this.pnlButtonPlace.Controls.Add(this.button11);
            this.pnlButtonPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonPlace.Location = new System.Drawing.Point(16, 60);
            this.pnlButtonPlace.Name = "pnlButtonPlace";
            this.pnlButtonPlace.Size = new System.Drawing.Size(157, 467);
            this.pnlButtonPlace.TabIndex = 6;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(157, 44);
            this.button12.TabIndex = 8;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 423);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 44);
            this.button11.TabIndex = 8;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 467);
            this.panel5.TabIndex = 7;
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
            // pnlAlsoGombok
            // 
            this.pnlAlsoGombok.BackgroundImage = global::e_Cafe.Properties.Resources.also;
            this.pnlAlsoGombok.Controls.Add(this.pnlFunctions);
            this.pnlAlsoGombok.Controls.Add(this.panel4);
            this.pnlAlsoGombok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlsoGombok.Location = new System.Drawing.Point(0, 527);
            this.pnlAlsoGombok.Name = "pnlAlsoGombok";
            this.pnlAlsoGombok.Size = new System.Drawing.Size(988, 111);
            this.pnlAlsoGombok.TabIndex = 4;
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.BackColor = System.Drawing.Color.Transparent;
            this.pnlFunctions.Controls.Add(this.btnReceptek);
            this.pnlFunctions.Controls.Add(this.label2);
            this.pnlFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunctions.Location = new System.Drawing.Point(0, 0);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(718, 111);
            this.pnlFunctions.TabIndex = 13;
            // 
            // btnReceptek
            // 
            this.btnReceptek.BackColor = System.Drawing.Color.Transparent;
            this.btnReceptek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReceptek.BackgroundImage")));
            this.btnReceptek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceptek.FlatAppearance.BorderSize = 0;
            this.btnReceptek.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReceptek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReceptek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReceptek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceptek.Location = new System.Drawing.Point(308, 3);
            this.btnReceptek.Name = "btnReceptek";
            this.btnReceptek.Size = new System.Drawing.Size(70, 75);
            this.btnReceptek.TabIndex = 8;
            this.btnReceptek.UseVisualStyleBackColor = false;
            this.btnReceptek.Click += new System.EventHandler(this.btnReceptek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(304, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Elfogadás";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnKilep);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(718, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 111);
            this.panel4.TabIndex = 12;
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.Color.Transparent;
            this.btnKilep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKilep.BackgroundImage")));
            this.btnKilep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKilep.FlatAppearance.BorderSize = 0;
            this.btnKilep.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnKilep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKilep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilep.Location = new System.Drawing.Point(95, 3);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(70, 75);
            this.btnKilep.TabIndex = 12;
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Visszalépés mentés nélkül";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.checkBox1);
            this.panel13.Controls.Add(this.dataRepeater1);
            this.panel13.Controls.Add(this.lblCikkcsopSelectInfo);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.lblCikkNev);
            this.panel13.Controls.Add(this.textBox2);
            this.panel13.Controls.Add(this.textBox1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(760, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(228, 527);
            this.panel13.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(123, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 37);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.DataSource = this.rECEPTBindingSource;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.button1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelControl1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label3);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(211, 45);
            this.dataRepeater1.Location = new System.Drawing.Point(6, 153);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(219, 368);
            this.dataRepeater1.TabIndex = 2;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEPTBindingSource, "MEGNEVEZES", true));
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // lblCikkcsopSelectInfo
            // 
            this.lblCikkcsopSelectInfo.AutoSize = true;
            this.lblCikkcsopSelectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCikkcsopSelectInfo.ForeColor = System.Drawing.Color.Red;
            this.lblCikkcsopSelectInfo.Location = new System.Drawing.Point(20, 130);
            this.lblCikkcsopSelectInfo.Name = "lblCikkcsopSelectInfo";
            this.lblCikkcsopSelectInfo.Size = new System.Drawing.Size(193, 13);
            this.lblCikkcsopSelectInfo.TabIndex = 1;
            this.lblCikkcsopSelectInfo.Text = "Válasszon a cikkcsoportok közül";
            this.lblCikkcsopSelectInfo.Visible = false;
            this.lblCikkcsopSelectInfo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cikkcsoportja";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ára";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCikkNev
            // 
            this.lblCikkNev.AutoSize = true;
            this.lblCikkNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCikkNev.Location = new System.Drawing.Point(3, 9);
            this.lblCikkNev.Name = "lblCikkNev";
            this.lblCikkNev.Size = new System.Drawing.Size(91, 20);
            this.lblCikkNev.TabIndex = 1;
            this.lblCikkNev.Text = "Cikk neve:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(46, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(81, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 32);
            this.textBox3.TabIndex = 0;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Keresés:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEPTBindingSource, "TARTOZEK_MENNY", true));
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "DB módosít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rECEPTBindingSource
            // 
            this.rECEPTBindingSource.DataMember = "RECEPT";
            this.rECEPTBindingSource.DataSource = this.dsReceptCikkek;
            // 
            // dsReceptCikkek
            // 
            this.dsReceptCikkek.DataSetName = "dsReceptCikkek";
            this.dsReceptCikkek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECEPTTableAdapter
            // 
            this.rECEPTTableAdapter.ClearBeforeFill = true;
            // 
            // receptMentes
            // 
            this.receptMentes.DataSetName = "ReceptMentes";
            this.receptMentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "RECEPT";
            this.bindingSource1.DataSource = this.receptMentes;
            // 
            // receptTableAdapter1
            // 
            this.receptTableAdapter1.ClearBeforeFill = true;
            // 
            // frmOsszCikkCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 638);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlAlsoGombok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOsszCikkCreator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOsszCikkCreator_Load);
            this.panel3.ResumeLayout(false);
            this.pnlOtherFilter.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtonPlace.ResumeLayout(false);
            this.pnlAlsoGombok.ResumeLayout(false);
            this.pnlFunctions.ResumeLayout(false);
            this.pnlFunctions.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rECEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptCikkek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptMentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpCikkek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOtherFilter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAlcsopNext;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAlcsopPrev;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnNextCikk;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnPrevCikk;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlButtonPlace;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAlsoGombok;
        private System.Windows.Forms.Panel pnlFunctions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnReceptek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblCikkNev;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.BindingSource rECEPTBindingSource;
        private e_Cafe.SQL.DataSets.dsReceptCikkek dsReceptCikkek;
        private e_Cafe.SQL.DataSets.dsReceptCikkekTableAdapters.RECEPTTableAdapter rECEPTTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblCikkcsopSelectInfo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button button1;
        private e_Cafe.SQL.DataSets.ReceptMentes receptMentes;
        private System.Windows.Forms.BindingSource bindingSource1;
        public e_Cafe.SQL.DataSets.ReceptMentesTableAdapters.RECEPTTableAdapter receptTableAdapter1;
    }
}