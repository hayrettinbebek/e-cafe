namespace e_Cafe.Admin
{
    partial class frmRights
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
            this.jOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsJOG = new e_Cafe.SQL.DataSets.dsJOG();
            this._JOGTableAdapter = new e_Cafe.SQL.DataSets.dsJOGTableAdapters._JOGTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJOG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJOG_NEV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // jOGBindingSource
            // 
            this.jOGBindingSource.DataMember = "_JOG";
            this.jOGBindingSource.DataSource = this.dsJOG;
            // 
            // dsJOG
            // 
            this.dsJOG.DataSetName = "dsJOG";
            this.dsJOG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _JOGTableAdapter
            // 
            this._JOGTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.jOGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(705, 268);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJOG_ID,
            this.colJOG_NEV});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colJOG_ID
            // 
            this.colJOG_ID.Caption = "Azonosító";
            this.colJOG_ID.FieldName = "JOG_ID";
            this.colJOG_ID.Name = "colJOG_ID";
            this.colJOG_ID.Visible = true;
            this.colJOG_ID.VisibleIndex = 0;
            // 
            // colJOG_NEV
            // 
            this.colJOG_NEV.Caption = "Megnevezés";
            this.colJOG_NEV.FieldName = "JOG_NEV";
            this.colJOG_NEV.Name = "colJOG_NEV";
            this.colJOG_NEV.Visible = true;
            this.colJOG_NEV.VisibleIndex = 1;
            // 
            // frmRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 268);
            this.Controls.Add(this.gridControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmRights";
            this.ShowInTaskbar = false;
            this.Text = "Jogok karbantartása";
            this.Load += new System.EventHandler(this.frmRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private e_Cafe.SQL.DataSets.dsJOG dsJOG;
        private System.Windows.Forms.BindingSource jOGBindingSource;
        private e_Cafe.SQL.DataSets.dsJOGTableAdapters._JOGTableAdapter _JOGTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colJOG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colJOG_NEV;
    }
}