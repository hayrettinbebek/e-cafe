using GUI;

namespace e_Cafe
{
    partial class Asztalok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asztalok));
            this.AsztalType1List = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.asztalInfo1 = new e_Cafe.AsztalInfo();
            this.asztal_Button1 = new GUI.Asztal_Button();
            this.SuspendLayout();
            // 
            // AsztalType1List
            // 
            this.AsztalType1List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AsztalType1List.ImageStream")));
            this.AsztalType1List.TransparentColor = System.Drawing.Color.Transparent;
            this.AsztalType1List.Images.SetKeyName(0, "asztal_zold_T.bmp");
            this.AsztalType1List.Images.SetKeyName(1, "asztal_normal_T.bmp");
            this.AsztalType1List.Images.SetKeyName(2, "asztal_piros_T.bmp");
            this.AsztalType1List.Images.SetKeyName(3, "asztal_sarga_T.bmp");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::e_Cafe.Properties.Resources.off_T;
            this.button1.Location = new System.Drawing.Point(336, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // asztalInfo1
            // 
            this.asztalInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.asztalInfo1.Location = new System.Drawing.Point(78, 170);
            this.asztalInfo1.Name = "asztalInfo1";
            this.asztalInfo1.Size = new System.Drawing.Size(212, 90);
            this.asztalInfo1.TabIndex = 3;
            // 
            // asztal_Button1
            // 
            this.asztal_Button1.Asztal_id = -1;
            this.asztal_Button1.Asztal_type = 0;
            this.asztal_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.asztal_Button1.FlatAppearance.BorderSize = 0;
            this.asztal_Button1.ImageIndex = 0;
            this.asztal_Button1.Location = new System.Drawing.Point(326, 243);
            this.asztal_Button1.Name = "asztal_Button1";
            this.asztal_Button1.Size = new System.Drawing.Size(308, 99);
            this.asztal_Button1.TabIndex = 1;
            this.asztal_Button1.Text = "asztal_Button1";
            this.asztal_Button1.UseVisualStyleBackColor = false;
            this.asztal_Button1.vSelected = false;
            // 
            // Asztalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.asztalInfo1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.asztal_Button1);
            this.Controls.Add(this.label1);
            this.Name = "Asztalok";
            this.Size = new System.Drawing.Size(743, 418);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Asztalok_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList AsztalType1List;
        private System.Windows.Forms.Label label1;
        private Asztal_Button asztal_Button1;
        private System.Windows.Forms.Button button1;
        private e_Cafe.AsztalInfo asztalInfo1;
    }
}
