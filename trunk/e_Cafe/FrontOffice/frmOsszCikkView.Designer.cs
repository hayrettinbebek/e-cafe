namespace e_Cafe.FrontOffice
{
    partial class frmOsszCikkView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOsszCikkView));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cIKKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReceptText = new e_Cafe.SQL.DataSets.dsReceptText();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cIKKTableAdapter = new e_Cafe.SQL.DataSets.dsReceptTextTableAdapters.CIKKTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCikkNeve = new System.Windows.Forms.Label();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.rECEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReceptCikkek = new e_Cafe.SQL.DataSets.dsReceptCikkek();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rECEPTTableAdapter = new e_Cafe.SQL.DataSets.dsReceptCikkekTableAdapters.RECEPTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rECEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptCikkek)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIKKBindingSource, "RECEPT_TEXT", true));
            this.richTextBox1.Location = new System.Drawing.Point(110, 292);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 177);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cIKKBindingSource
            // 
            this.cIKKBindingSource.AllowNew = false;
            this.cIKKBindingSource.DataMember = "CIKK";
            this.cIKKBindingSource.DataSource = this.dsReceptText;
            // 
            // dsReceptText
            // 
            this.dsReceptText.DataSetName = "dsReceptText";
            this.dsReceptText.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(612, 555);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 123;
            this.lineShape1.X2 = 123;
            this.lineShape1.Y1 = 187;
            this.lineShape1.Y2 = 468;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elkészítés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Módszer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(55, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pohár";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIKKBindingSource, "RECEPT_POHAR", true));
            this.textBox1.Location = new System.Drawing.Point(110, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alkohol tartalom";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIKKBindingSource, "RECEPT_MODSZER", true));
            this.textBox2.Location = new System.Drawing.Point(110, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIKKBindingSource, "RECEPT_ALK_TART", true));
            this.textBox3.Location = new System.Drawing.Point(110, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 3;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(662, 555);
            this.shapeContainer2.TabIndex = 4;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Gray;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 415;
            this.lineShape3.X2 = 415;
            this.lineShape3.Y1 = 178;
            this.lineShape3.Y2 = 488;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gray;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 100;
            this.lineShape2.X2 = 100;
            this.lineShape2.Y1 = 175;
            this.lineShape2.Y2 = 485;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(561, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 45);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 106);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cIKKTableAdapter
            // 
            this.cIKKTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(344, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hozzávalók";
            // 
            // lblCikkNeve
            // 
            this.lblCikkNeve.BackColor = System.Drawing.Color.Transparent;
            this.lblCikkNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCikkNeve.Location = new System.Drawing.Point(205, 84);
            this.lblCikkNeve.Name = "lblCikkNeve";
            this.lblCikkNeve.Size = new System.Drawing.Size(395, 68);
            this.lblCikkNeve.TabIndex = 7;
            this.lblCikkNeve.Text = "label6";
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.AllowUserToAddItems = false;
            this.dataRepeater1.AllowUserToDeleteItems = false;
            this.dataRepeater1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dataRepeater1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataRepeater1.Enabled = false;
            this.dataRepeater1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataRepeater1.ItemHeaderVisible = false;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.flowLayoutPanel1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(213, 33);
            this.dataRepeater1.Location = new System.Drawing.Point(429, 178);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.SelectionColor = System.Drawing.Color.Transparent;
            this.dataRepeater1.Size = new System.Drawing.Size(221, 308);
            this.dataRepeater1.TabIndex = 8;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEPTBindingSource, "TARTOZEK_MENNY", true));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEPTBindingSource, "MEGYS_MEGNEVEZES", true));
            this.label7.Location = new System.Drawing.Point(44, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEPTBindingSource, "MEGNEVEZES", true));
            this.label8.Location = new System.Drawing.Point(85, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // rECEPTTableAdapter
            // 
            this.rECEPTTableAdapter.ClearBeforeFill = true;
            // 
            // frmOsszCikkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 555);
            this.ControlBox = false;
            this.Controls.Add(this.dataRepeater1);
            this.Controls.Add(this.lblCikkNeve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.shapeContainer2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOsszCikkView";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.cIKKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rECEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptCikkek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource cIKKBindingSource;
        private e_Cafe.SQL.DataSets.dsReceptText dsReceptText;
        private e_Cafe.SQL.DataSets.dsReceptTextTableAdapters.CIKKTableAdapter cIKKTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCikkNeve;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource rECEPTBindingSource;
        private e_Cafe.SQL.DataSets.dsReceptCikkek dsReceptCikkek;
        private e_Cafe.SQL.DataSets.dsReceptCikkekTableAdapters.RECEPTTableAdapter rECEPTTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
    }
}