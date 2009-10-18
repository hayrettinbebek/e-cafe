using System;

namespace BusinessLogic
{
    public class OpenDayCombo
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


        public OpenDay _OD;
        public OpenDay OD
        {
            get { return (_OD); }
            set { _OD = value; }
        }


        public OpenDayCombo(string pDisp, string pValue, OpenDay pOd)
        {
            _disp = pDisp;
            _value = pValue;
            _OD = pOd;

        }

    }
}
