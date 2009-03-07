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
            this.dsReceptText = new e_Cafe.SQL.dsReceptText();
            this.cIKKTableAdapter = new e_Cafe.SQL.dsReceptTextTableAdapters.CIKKTableAdapter();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptText)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIKKBindingSource, "RECEPT_TEXT", true));
            this.richTextBox1.Location = new System.Drawing.Point(133, 351);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 118);
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
            // cIKKTableAdapter
            // 
            this.cIKKTableAdapter.ClearBeforeFill = true;
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
            this.lineShape1.Y1 = 177;
            this.lineShape1.Y2 = 468;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elkészítés";
            // 
            // frmOsszCikkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.Name = "frmOsszCikkView";
            this.Text = "frmOsszCikkView";
            ((System.ComponentModel.ISupportInitialize)(this.cIKKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceptText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource cIKKBindingSource;
        private e_Cafe.SQL.dsReceptText dsReceptText;
        private e_Cafe.SQL.dsReceptTextTableAdapters.CIKKTableAdapter cIKKTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
    }
}