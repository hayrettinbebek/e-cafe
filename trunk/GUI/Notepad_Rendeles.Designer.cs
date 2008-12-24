namespace GUI
{
    partial class Notepad_Rendeles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad_Rendeles));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRendelesSor = new System.Windows.Forms.ListBox();
            this.rtHeader = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rtSum = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "notepad_T.bmp");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.notepad_T;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbRendelesSor);
            this.panel1.Controls.Add(this.rtHeader);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(19, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 404);
            this.panel1.TabIndex = 2;
            // 
            // lbRendelesSor
            // 
            this.lbRendelesSor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRendelesSor.ColumnWidth = 20;
            this.lbRendelesSor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRendelesSor.FormattingEnabled = true;
            this.lbRendelesSor.Items.AddRange(new object[] {
            "elso",
            "második ",
            "harmadik",
            "",
            "kóla",
            "sültkrumpli"});
            this.lbRendelesSor.Location = new System.Drawing.Point(0, 40);
            this.lbRendelesSor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbRendelesSor.Name = "lbRendelesSor";
            this.lbRendelesSor.Size = new System.Drawing.Size(277, 325);
            this.lbRendelesSor.TabIndex = 3;
            // 
            // rtHeader
            // 
            this.rtHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtHeader.Location = new System.Drawing.Point(0, 0);
            this.rtHeader.Name = "rtHeader";
            this.rtHeader.Size = new System.Drawing.Size(277, 40);
            this.rtHeader.TabIndex = 2;
            this.rtHeader.Text = "Rendelések";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.rtSum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 27);
            this.panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(149, 27);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Összesen:";
            // 
            // rtSum
            // 
            this.rtSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtSum.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtSum.Location = new System.Drawing.Point(149, 0);
            this.rtSum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rtSum.Name = "rtSum";
            this.rtSum.Size = new System.Drawing.Size(128, 27);
            this.rtSum.TabIndex = 6;
            this.rtSum.Text = "32 123 Ft";
            // 
            // Notepad_Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Notepad_Rendeles";
            this.Size = new System.Drawing.Size(319, 512);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbRendelesSor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rtSum;
        public System.Windows.Forms.RichTextBox rtHeader;

    }
}
