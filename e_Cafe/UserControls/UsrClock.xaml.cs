using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GUI;


namespace e_Cafe
{
    /// <summary>
    /// Interaction logic for UsrClock.xaml
    /// </summary>
    public partial class UsrClock : UserControl
    {
        public UsrClock()
        {
            InitializeComponent();
            
        }
    }

        [ValueConversion(typeof(DateTime), typeof(int))]
        public class SecondsConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                DateTime date = (DateTime)value;
                return date.Second * 6;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null;
            }
        }

        [ValueConversion(typeof(DateTime), typeof(int))]
        public class MinutesConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                DateTime date = (DateTime)value;
                return date.Minute * 6;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null;
            }
        }

        [ValueConversion(typeof(DateTime), typeof(int))]
        public class HoursConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                DateTime date = (DateTime)value;
                return (date.Hour * 30) + (date.Minute / 2);
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null;
            }
        }

        [ValueConversion(typeof(DateTime), typeof(string))]
        public class WeekdayConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                DateTime date = (DateTime)value;
                return date.DayOfWeek.ToString();
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return null;
            }
        }
   
}
