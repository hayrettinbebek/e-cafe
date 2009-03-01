namespace GUI
{
    partial class ucMemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMemo));
            this.button1 = new System.Windows.Forms.Button();
            this.transparentRichTextBox1 = new GUI.TransparentRichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(176, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // transparentRichTextBox1
            // 
            this.transparentRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transparentRichTextBox1.Location = new System.Drawing.Point(39, 46);
            this.transparentRichTextBox1.Name = "transparentRichTextBox1";
            this.transparentRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.transparentRichTextBox1.Size = new System.Drawing.Size(169, 181);
            this.transparentRichTextBox1.TabIndex = 3;
            this.transparentRichTextBox1.Text = "Vidd le a szemetet";
            // 
            // ucMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.transparentRichTextBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "ucMemo";
            this.Size = new System.Drawing.Size(227, 259);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TransparentRichTextBox transparentRichTextBox1;
    }
}
