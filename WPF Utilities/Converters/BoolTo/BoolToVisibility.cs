using System;
using System.Windows;
using System.Windows.Data;

namespace WPF_Utilities.Converters.BoolTo
{
    public class BoolToVisibility : IValueConverter
    {
        public Visibility TrueVisibility { get; set; } = Visibility.Visible;
        public Visibility FalseVisibility { get; set; } = Visibility.Collapsed;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value is bool boolean && boolean) ? TrueVisibility : FalseVisibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value is Visibility visibility && visibility == TrueVisibility;
        }
    }
}
