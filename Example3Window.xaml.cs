using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBindingExample
{
    public class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "yes": case "да": return true;
                case "no": case "нет": return false;
            }
            return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                return ((bool)value) ? "да" : "нет";
            }
            return "no";
        }
    }
    
    public class BoldToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "Bold")
            {
                return true;
            }
            return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                return ((bool)value) ? "Bold" : "Regular";
            }
            return "no";
        }
    }
    public class RainbowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string colorName = value.ToString().ToLower();
            if (colorName.Contains("красный"))
                return Colors.Red;
            if (colorName.Contains("оранжевый"))
                return Colors.Orange;
            if (colorName.Contains("желтый"))
                return Colors.Yellow;
            if (colorName.Contains("зеленый"))
                return Colors.Green;
            if (colorName.Contains("голубой"))
                return Colors.Aqua;
            if (colorName.Contains("синий"))
                return Colors.Blue;
            if (colorName.Contains("фиолетовый"))
                return Colors.Violet;
            return Colors.Transparent;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    /// <summary>
    /// Логика взаимодействия для Example3Window.xaml
    /// </summary>
    public partial class Example3Window : Window
    {
        public Example3Window()
        {
            InitializeComponent();
        }


    }
}
