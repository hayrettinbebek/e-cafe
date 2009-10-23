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
        internal bool _isEdit = false;
        internal bool _isModified = false;

        public bool isEditForm { get { return _isEdit; } }


        public bool Modified { get { return _isModified; } }

        public virtual void Save()
        {


        }
    }
}