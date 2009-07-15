namespace GUI.billentyu
{
    partial class frmTouchNumKeyboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTouchNumKeyboard));
            this.numericKeyboar1 = new GUI.billentyu.numericKeyboar();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numericKeyboar1
            // 
            this.numericKeyboar1.BackColor = System.Drawing.Color.Black;
            this.numericKeyboar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numericKeyboar1.BackgroundImage")));
            this.numericKeyboar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numericKeyboar1.Location = new System.Drawing.Point(1, 2);
            this.numericKeyboar1.Name = "numericKeyboar1";
            this.numericKeyboar1.Size = new System.Drawing.Size(204, 250);
            this.numericKeyboar1.TabIndex = 0;
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
            this.button12.Location = new System.Drawing.Point(166, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 45);
            this.button12.TabIndex = 3;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // frmTouchNumKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 250);
            this.ControlBox = false;
            this.Controls.Add(this.button12);
            this.Controls.Add(this.numericKeyboar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTouchNumKeyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private numericKeyboar numericKeyboar1;
        private System.Windows.Forms.Button button12;
    }
}