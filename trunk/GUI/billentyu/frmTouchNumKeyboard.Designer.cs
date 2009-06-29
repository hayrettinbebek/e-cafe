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
            this.SuspendLayout();
            // 
            // numericKeyboar1
            // 
            this.numericKeyboar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numericKeyboar1.BackgroundImage")));
            this.numericKeyboar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numericKeyboar1.Location = new System.Drawing.Point(1, 2);
            this.numericKeyboar1.Name = "numericKeyboar1";
            this.numericKeyboar1.Size = new System.Drawing.Size(204, 250);
            this.numericKeyboar1.TabIndex = 0;
            // 
            // frmTouchNumKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 250);
            this.ControlBox = false;
            this.Controls.Add(this.numericKeyboar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTouchNumKeyboard";
            this.ResumeLayout(false);

        }

        #endregion

        private numericKeyboar numericKeyboar1;
    }
}