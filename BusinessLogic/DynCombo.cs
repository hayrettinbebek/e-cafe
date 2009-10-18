using System;

namespace BusinessLogic
{
    public class DynCombo
    {

        #region DISPLAY_MEMBER
        private string _disp;
        public string DISPLAY_MEMBER
        {
            get { return (_disp); }
            set { _disp = value; }
        }
        #endregion

        #region VALUE_MEMBER
        private string _value;
        public string VALUE_MEMBER
        {
            get { return (_value); }
            set { _value = value; }
        }
        #endregion

        #region VALUE_MEMBER_INT
        private int _value_int;
        public int VALUE_MEMBER_INT
        {
            get { return (_value_int); }
            set { _value_int = value; }
        }
        #endregion
        public DynCombo(string pDisp, string pValue)
        {
            _disp = pDisp;
            _value = pValue;

        }


        public DynCombo(string pDisp, int pValue)
        {
            _disp = pDisp;
            _value_int = pValue;

        }

    }
}
