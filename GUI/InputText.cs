using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using GUI.billentyu;


namespace GUI
{
    public enum InputType
    {
        Number,
        String
    }
    public abstract class InputText
    {
        public static string getString(bool req)
        {
            // Paramtéer TRUE = Kötelezően nem lehet 0 hosszú
            string tmpStr = "";
            frmTouchKeyboard ft = new frmTouchKeyboard(InputType.String);

            if (req)
            {
                while (tmpStr.Length == 0)
                {
                    ft.ShowDialog();
                    if (ft.DialogResult == DialogResult.OK)
                    {
                        tmpStr = ft.ResultString;

                    }
                }
            }
            else
            {
                ft.ShowDialog();
                if (ft.DialogResult == DialogResult.OK)
                {
                    tmpStr = ft.ResultString;

                }
            }

            return (tmpStr);

        }

        public static int getInt(bool req)
        {
            // Paramtéer TRUE = Kötelezően nem lehet 0 hosszú
            int tmpInt = 0;
            frmTouchKeyboard ft = new frmTouchKeyboard(InputType.Number);
            
            if (req)
            {
                while (tmpInt == 0)
                {
                    ft.ShowDialog();
                    if (ft.DialogResult == DialogResult.OK)
                    {
                        tmpInt = Convert.ToInt16(ft.ResultString);

                    }
                }
            }
            else
            {
                ft.ShowDialog();
                if (ft.DialogResult == DialogResult.OK)
                {
                    tmpInt = Convert.ToInt16(ft.ResultString);

                }
            }

            return (tmpInt);

        }

        public static int getInt2(bool req)
        {
            // Paramtéer TRUE = Kötelezően nem lehet 0 hosszú
            int tmpInt = 0;
            frmTouchNumKeyboard ft = new frmTouchNumKeyboard(InputType.Number);

            if (req)
            {
                while (tmpInt == 0)
                {
                    ft.ShowDialog();
                    if (ft.DialogResult == DialogResult.OK)
                    {
                        tmpInt = Convert.ToInt16(ft.ResultString);

                    }
                }
            }
            else
            {
                ft.ShowDialog();
                if (ft.DialogResult == DialogResult.OK)
                {
                    tmpInt = Convert.ToInt16(ft.ResultString);

                }
            }

            return (tmpInt);

        }
        /*
        public static int getInt3(bool req)
        {
            // Paramtéer TRUE = Kötelezően nem lehet 0 hosszú
            int tmpInt = 0;
            frmTouchNumKeyboard ft = new frmTouchNumKeyboard(InputType.Number);

            if (req)
            {
                while (tmpInt == 0)
                {
                    ft.ShowDialog();
                    if (ft.DialogResult == DialogResult.OK)
                    {
                        tmpInt = Convert.ToInt16(ft.ResultString);

                    }
                }
            }
            else
            {
                ft.ShowDialog();
                if (ft.DialogResult == DialogResult.OK)
                {
                    tmpInt = Convert.ToInt16(ft.ResultString);

                }
            }

            return (tmpInt);

        }

        private static bool getInt2(bool req, out int szam )
        {
            // Paramtéer TRUE = Kötelezően nem lehet 0 hosszú
            int tmpInt = 0;
            frmTouchNumKeyboard ft = new frmTouchNumKeyboard(InputType.Number);

            if (req)
            {
                while (tmpInt == 0)
                {
                    ft.ShowDialog();
                    if (ft.DialogResult == DialogResult.OK)
                    {
                        szam = Convert.ToInt16(ft.ResultString);

                    }
                    if (ft.DialogResult == DialogResult.Cancel)
                    {
                        szam = 0;
                        break;

                    }

                }
            }
            else
            {
                ft.ShowDialog();
                if (ft.DialogResult == DialogResult.OK)
                {
                    szam = Convert.ToInt16(ft.ResultString);

                }
            }

            return (tmpInt);

        }

        */

    }
}
