using System.Windows.Data;
using System.Windows;
using System;

namespace WPFUtilities.Converters.NullTo
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public Visibility NotNullVisibility { get; set; } = Visibility.Visible;
        public Visibility NullVisibility { get; set; } = Visibility.Collapsed;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value is not null) ? NotNullVisibility : NullVisibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
