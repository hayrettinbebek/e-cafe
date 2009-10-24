using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace e_Cafe.UserControls
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        public UserForm()
        {
            InitializeComponent();
        }
        internal bool _isEdit;
        internal bool _isModified;

        internal bool _InsertAndDelete;

        public bool _isEditForm
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }
        public bool _isInsertAndDelete
        {
            get { return _InsertAndDelete; }
            set { _InsertAndDelete = value; }
        }


        public bool Modified { get { return _isModified; } }

        public virtual void Save()
        {


        }

        public virtual void AddNew()
        {


        }

        public virtual void DeleteRow()
        {

        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((AdminTools)MdiParent).InitSpeedBar();
        }
    }
}